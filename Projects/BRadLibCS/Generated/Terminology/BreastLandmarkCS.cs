using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class %ClassName%
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/BreastLandmarkCS";

		public static Coding Code_Nipple = new Coding(System, "Nipple", "Nipple");                                                                // CSItemCodeSystem.cs:59
		public static Coding Code_ChestWall = new Coding(System, "ChestWall", "Chest Wall");                                                      // CSItemCodeSystem.cs:59
		public static Coding Code_Skin = new Coding(System, "Skin", "Skin");                                                                      // CSItemCodeSystem.cs:59

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemCodeSystem.cs:51
		{                                                                                                                                         // CSItemCodeSystem.cs:52
		    yield return Code_Nipple;                                                                                                             // CSItemCodeSystem.cs:62
		    yield return Code_ChestWall;                                                                                                          // CSItemCodeSystem.cs:62
		    yield return Code_Skin;                                                                                                               // CSItemCodeSystem.cs:62
		}                                                                                                                                         // CSItemCodeSystem.cs:67
	}
}