using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ShapeVS
	{
		/// <summary>
		/// This class creates a type for codings of this class, that implicitly converts to Coding
		/// Allows type checking for these codes.
		/// </summary>
		public class TCoding
		{
		    public Coding Value {get;}
			public static implicit operator Coding(TCoding tCode) => tCode.Value;
			public static implicit operator CodeableConcept(TCoding tCode) => new CodeableConcept(tCode.Value.System, tCode.Value.Code, tCode.Value.Display);

			public TCoding(Coding value)
		    {
		        this.Value= value;
		    }
		}

		/// <summary>
		/// Url of this value set.
		/// </summary>
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/ShapeVS";

		public static TCoding Code_IrregularInShape = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ShapeCS", "IrregularInShape"));// CSItemValueSet.cs:67
		public static TCoding Code_LobulatedInShape = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ShapeCS", "LobulatedInShape"));// CSItemValueSet.cs:67
		public static TCoding Code_OvalInShape = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ShapeCS", "OvalInShape"));// CSItemValueSet.cs:67
		public static TCoding Code_Reniform = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ShapeCS", "Reniform"));  // CSItemValueSet.cs:67
		public static TCoding Code_RoundInShape = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ShapeCS", "RoundInShape"));// CSItemValueSet.cs:67

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:58
		{                                                                                                                                         // CSItemValueSet.cs:59
		    yield return Code_IrregularInShape;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_LobulatedInShape;                                                                                                   // CSItemValueSet.cs:70
		    yield return Code_OvalInShape;                                                                                                        // CSItemValueSet.cs:70
		    yield return Code_Reniform;                                                                                                           // CSItemValueSet.cs:70
		    yield return Code_RoundInShape;                                                                                                       // CSItemValueSet.cs:70
		}                                                                                                                                         // CSItemValueSet.cs:93
	}
}