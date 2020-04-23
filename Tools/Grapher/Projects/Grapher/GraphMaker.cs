﻿using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Eir.DevTools;
using System.Globalization;
using System.Linq;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Serialization;

namespace Grapher
{
    public class GraphMaker : ConverterBase
    {
        Dictionary<String, StructureDefinition> structDefDict = new Dictionary<string, StructureDefinition>();

        public String GraphicsOutputDir { get; set; } = ".";
        public String Graph { get; set; } = "focus";

        public void AddResource(Resource resource)
        {
            switch (resource)
            {
                case StructureDefinition sDef:
                    this.structDefDict.Add(sDef.Url, sDef);
                    break;
                default:
                    break;
            }
        }

        DomainResource LoadResourceInFile(String path)
        {
            const String fcn = "LoadResourceInFile";

            this.ConversionInfo(this.GetType().Name,
                fcn,
                $"Adding FHIR file {path}");

            switch (Path.GetExtension(path).ToUpper(CultureInfo.InvariantCulture))
            {
                case ".XML":
                    {
                        FhirXmlParser parser = new FhirXmlParser();
                        return parser.Parse<DomainResource>(File.ReadAllText(path));
                    }

                case ".JSON":
                    {
                        FhirJsonParser parser = new FhirJsonParser();
                        return parser.Parse<DomainResource>(File.ReadAllText(path));
                    }

                default:
                    throw new Exception($"Unknown extension for serialized fhir resource '{path}'");
            }
        }

        void AddResourceInFile(String path)
        {
            DomainResource dr = this.LoadResourceInFile(path);
            AddResource(dr);
        }


        void AddResourcesInDir(String dirPath)
        {
            const String fcn = "AddResourcesInDir";

            this.ConversionInfo(this.GetType().Name,
                fcn,
                $"Adding FHIR files in directory {dirPath}");

            foreach (String subDir in Directory.GetDirectories(dirPath))
                AddResourcesInDir(subDir);
            foreach (String file in Directory.GetFiles(dirPath, "*.json"))
                AddResourceInFile(file);
            foreach (String file in Directory.GetFiles(dirPath, "*.xml"))
                AddResourceInFile(file);
        }

        String ProcessPath(String path)
        {
            if (path.StartsWith("^"))
            {
                String[] pathParts = path.Split('\\');
                String parentPath = pathParts[0].Substring(1);
                parentPath = DirHelper.FindParentDir(parentPath);
                pathParts[0] = parentPath;
                path = Path.Combine(pathParts);
            }

            return path;
        }

        public void AddResources(String path)
        {
            path = this.ProcessPath(path);
            if (Directory.Exists(path) == true)
                AddResourcesInDir(path);
            else
                AddResourceInFile(path);
        }

        public Int32 Process()
        {
            const String fcn = "Process";

            try
            {
                this.GraphicsOutputDir = this.ProcessPath(this.GraphicsOutputDir);
                LoadGraphicData();
                return 0;
            }
            catch (Exception e)
            {
                this.ConversionInfo(this.GetType().Name,
                    fcn,
                    $"error {e.Message}");

                return -1;
            }
        }

        void LoadGraphicData(StructureDefinition sDef)
        {
            const String fcn = "LoadGraphicData";

            sDef.Snapshot = null;
            SnapshotCreator.Create(sDef);
            foreach (ElementDefinition item in sDef.Snapshot.Element.ExtensionSlices())
            {
                String profile = item.Type[0].Profile.FirstOrDefault();
                switch (profile.LastUriPart())
                {
                    case "GraphNode":
                        this.ConversionInfo(this.GetType().Name,
                            fcn,
                            $"Processing {item.ElementId}");
                        break;
                    case "GraphLinkByName":
                        this.ConversionInfo(this.GetType().Name,
                            fcn,
                            $"Processing {item.ElementId}");
                        break;
                }
            }
        }

        void LoadGraphicData()
        {
            foreach (StructureDefinition sDef in this.structDefDict.Values)
                this.LoadGraphicData(sDef);
        }
    }
}
