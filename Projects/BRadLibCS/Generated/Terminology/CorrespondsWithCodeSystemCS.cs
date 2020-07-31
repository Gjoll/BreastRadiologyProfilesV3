using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class CorrespondsWithCodeSystemCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CorrespondsWithCodeSystemCS";

		public static Coding Code_Aspiration = new Coding(System, "Aspiration", "Aspiration");                                                    // CSItemCodeSystem.cs:62
		public static Coding Code_Biopsy = new Coding(System, "Biopsy", "Biopsy");                                                                // CSItemCodeSystem.cs:62
		public static Coding Code_Cprofilern = new Coding(System, "Cprofilern", "Cprofilern");                                                    // CSItemCodeSystem.cs:62
		public static Coding Code_Ductogram = new Coding(System, "Ductogram", "Ductogram");                                                       // CSItemCodeSystem.cs:62
		public static Coding Code_IncidentalFinding = new Coding(System, "IncidentalFinding", "Incidental finding");                              // CSItemCodeSystem.cs:62
		public static Coding Code_Mammo = new Coding(System, "Mammo", "Mammo");                                                                   // CSItemCodeSystem.cs:62
		public static Coding Code_MRI = new Coding(System, "MRI", "MRI");                                                                         // CSItemCodeSystem.cs:62
		public static Coding Code_NippleDischarge = new Coding(System, "NippleDischarge", "Nipple discharge");                                    // CSItemCodeSystem.cs:62
		public static Coding Code_OutsideExam = new Coding(System, "OutsideExam", "Outside exam");                                                // CSItemCodeSystem.cs:62
		public static Coding Code_Pain = new Coding(System, "Pain", "Pain");                                                                      // CSItemCodeSystem.cs:62
		public static Coding Code_Palpated = new Coding(System, "Palpated", "Palpated");                                                          // CSItemCodeSystem.cs:62
		public static Coding Code_PostOperative = new Coding(System, "PostOperative", "Post operative");                                          // CSItemCodeSystem.cs:62
		public static Coding Code_PreviousBiopsy = new Coding(System, "PreviousBiopsy", "Previous biopsy");                                       // CSItemCodeSystem.cs:62
		public static Coding Code_PriorExam = new Coding(System, "PriorExam", "Prior exam");                                                      // CSItemCodeSystem.cs:62
		public static Coding Code_Redness = new Coding(System, "Redness", "Redness");                                                             // CSItemCodeSystem.cs:62
		public static Coding Code_Scinti = new Coding(System, "Scinti", "Scinti");                                                                // CSItemCodeSystem.cs:62
		public static Coding Code_SizeLessThanMammo = new Coding(System, "Size<Mammo", "Size < mammo");                                           // CSItemCodeSystem.cs:62
		public static Coding Code_SizeLessThanMRI = new Coding(System, "Size<MRI", "Size < MRI");                                                 // CSItemCodeSystem.cs:62
		public static Coding Code_SizeLessThanPalp = new Coding(System, "Size<Palp", "Size < palp");                                              // CSItemCodeSystem.cs:62
		public static Coding Code_SizeLessThanUS = new Coding(System, "Size<US", "Size < US");                                                    // CSItemCodeSystem.cs:62
		public static Coding Code_SizeGreaterThanMammo = new Coding(System, "Size>Mammo", "Size > mammo");                                        // CSItemCodeSystem.cs:62
		public static Coding Code_SizeGreaterThanMRI = new Coding(System, "Size>MRI", "Size > MRI");                                              // CSItemCodeSystem.cs:62
		public static Coding Code_SizeGreaterThanPalp = new Coding(System, "Size>Palp", "Size > palp");                                           // CSItemCodeSystem.cs:62
		public static Coding Code_SkinMarker = new Coding(System, "SkinMarker", "Skin marker");                                                   // CSItemCodeSystem.cs:62
		public static Coding Code_Surgery = new Coding(System, "Surgery", "Surgery");                                                             // CSItemCodeSystem.cs:62
		public static Coding Code_SurgicalSite = new Coding(System, "SurgicalSite", "Surgical site");                                             // CSItemCodeSystem.cs:62
		public static Coding Code_Tenderness = new Coding(System, "Tenderness", "Tenderness");                                                    // CSItemCodeSystem.cs:62
		public static Coding Code_TriggerPoint = new Coding(System, "TriggerPoint", "Trigger point");                                             // CSItemCodeSystem.cs:62
		public static Coding Code_US = new Coding(System, "US", "US");                                                                            // CSItemCodeSystem.cs:62

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:54
		{                                                                                                                                         // CSItemCodeSystem.cs:55
		    yield return Code_Aspiration;                                                                                                         // CSItemCodeSystem.cs:65
		    yield return Code_Biopsy;                                                                                                             // CSItemCodeSystem.cs:65
		    yield return Code_Cprofilern;                                                                                                         // CSItemCodeSystem.cs:65
		    yield return Code_Ductogram;                                                                                                          // CSItemCodeSystem.cs:65
		    yield return Code_IncidentalFinding;                                                                                                  // CSItemCodeSystem.cs:65
		    yield return Code_Mammo;                                                                                                              // CSItemCodeSystem.cs:65
		    yield return Code_MRI;                                                                                                                // CSItemCodeSystem.cs:65
		    yield return Code_NippleDischarge;                                                                                                    // CSItemCodeSystem.cs:65
		    yield return Code_OutsideExam;                                                                                                        // CSItemCodeSystem.cs:65
		    yield return Code_Pain;                                                                                                               // CSItemCodeSystem.cs:65
		    yield return Code_Palpated;                                                                                                           // CSItemCodeSystem.cs:65
		    yield return Code_PostOperative;                                                                                                      // CSItemCodeSystem.cs:65
		    yield return Code_PreviousBiopsy;                                                                                                     // CSItemCodeSystem.cs:65
		    yield return Code_PriorExam;                                                                                                          // CSItemCodeSystem.cs:65
		    yield return Code_Redness;                                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_Scinti;                                                                                                             // CSItemCodeSystem.cs:65
		    yield return Code_SizeLessThanMammo;                                                                                                  // CSItemCodeSystem.cs:65
		    yield return Code_SizeLessThanMRI;                                                                                                    // CSItemCodeSystem.cs:65
		    yield return Code_SizeLessThanPalp;                                                                                                   // CSItemCodeSystem.cs:65
		    yield return Code_SizeLessThanUS;                                                                                                     // CSItemCodeSystem.cs:65
		    yield return Code_SizeGreaterThanMammo;                                                                                               // CSItemCodeSystem.cs:65
		    yield return Code_SizeGreaterThanMRI;                                                                                                 // CSItemCodeSystem.cs:65
		    yield return Code_SizeGreaterThanPalp;                                                                                                // CSItemCodeSystem.cs:65
		    yield return Code_SkinMarker;                                                                                                         // CSItemCodeSystem.cs:65
		    yield return Code_Surgery;                                                                                                            // CSItemCodeSystem.cs:65
		    yield return Code_SurgicalSite;                                                                                                       // CSItemCodeSystem.cs:65
		    yield return Code_Tenderness;                                                                                                         // CSItemCodeSystem.cs:65
		    yield return Code_TriggerPoint;                                                                                                       // CSItemCodeSystem.cs:65
		    yield return Code_US;                                                                                                                 // CSItemCodeSystem.cs:65
		}                                                                                                                                         // CSItemCodeSystem.cs:70
	}
}