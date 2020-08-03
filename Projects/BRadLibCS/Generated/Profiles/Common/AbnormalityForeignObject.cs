using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
    /*
	 All code in this class is automatically generated.
	 */

	/// <summary>
	/// Interface IAbnormalityForeignObject.
	/// </summary>
	public interface IAbnormalityForeignObject  : IBreastBodyLocationRequiredFragment,
        IObservedChangesFragment,
        IBiRadFragment,
        INotPreviouslySeenFragment,
        ICorrespondsWithFragment,
        IPreviouslyDemonstratedByFragment,
        IAssociatedFeatureFragment,
        IConsistentWithFragment
	{
		ObservationComponentItem<CodeableConcept> AbnormalityForeignObjectType { get; set; }                                                      // CSComponentSlice.cs:105

	}

	/// <summary>
	/// class CAbnormalityForeignObjectProfile.
	/// </summary>
	public partial class AbnormalityForeignObjectProfile :  ObservationBase, IAbnormalityForeignObject
	{
		public ObservationHasMemberCollection<AssociatedFeatureProfile> AssociatedFeature { get; set; }                                           // CSHasMemberSlice.cs:90
		public ObservationHasMemberCollection<ConsistentWithProfile> ConsistentWith { get; set; }                                                 // CSHasMemberSlice.cs:90
		public ObservationComponentItem<CodeableConcept> AbnormalityForeignObjectType { get; set; }                                               // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> ObsChanges { get; set; }                                                                 // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> BiRadsAssessmentCategory { get; set; }                                                   // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> NotPreviouslySeen { get; set; }                                                          // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> CorrespondsWith { get; set; }                                                            // CSComponentSlice.cs:105
		public ObservationComponentItem<CodeableConcept> PrevDemBy { get; set; }                                                                  // CSComponentSlice.cs:105

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AbnormalityForeignObjectProfile() : base()
		{
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public override void Init()
		{
			((IBreastBodyLocationRequiredFragment)this).Init();                                                                                      // CSItemClass.cs:75
			((IObservedChangesFragment)this).Init();                                                                                                 // CSItemClass.cs:75
			((IBiRadFragment)this).Init();                                                                                                           // CSItemClass.cs:75
			((INotPreviouslySeenFragment)this).Init();                                                                                               // CSItemClass.cs:75
			((ICorrespondsWithFragment)this).Init();                                                                                                 // CSItemClass.cs:75
			((IPreviouslyDemonstratedByFragment)this).Init();                                                                                        // CSItemClass.cs:75
			((IAssociatedFeatureFragment)this).Init();                                                                                               // CSItemClass.cs:75
			((IConsistentWithFragment)this).Init();                                                                                                  // CSItemClass.cs:75
			{                                                                                                                                        // CSComponentSlice.cs:136
			     CodeableConcept ObservationCode()                                                                                                   // FhirConstruct.cs:760
			    {                                                                                                                                    // FhirConstruct.cs:761
			        CodeableConcept retVal = new CodeableConcept();                                                                                  // FhirConstruct.cs:762
			        retVal.Coding = new List<Coding>();                                                                                              // FhirConstruct.cs:768
			        {                                                                                                                                // FhirConstruct.cs:771
			            var temp4 = new Coding();                                                                                                    // FhirConstruct.cs:772
			            temp4.SystemElement = new FhirUri();                                                                                         // FhirConstruct.cs:775
			            temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodesCS";           // FhirConstruct.cs:777
			            temp4.CodeElement = new Code();                                                                                              // FhirConstruct.cs:791
			            temp4.CodeElement.Value = "abnormalityForeignObjectType";                                                                    // FhirConstruct.cs:793
			            retVal.Coding.Add(temp4);                                                                                                    // FhirConstruct.cs:820
			        }                                                                                                                                // FhirConstruct.cs:821
			        return retVal;                                                                                                                   // FhirConstruct.cs:836
			    }                                                                                                                                    // FhirConstruct.cs:837
			    this.AbnormalityForeignObjectType = new ObservationComponentItem<CodeableConcept>(ObservationCode());                                // CSComponentSlice.cs:145
			}                                                                                                                                        // CSComponentSlice.cs:153
		}

		/// <summary>
		/// Validate object. Will return false if an error is detected. sb will contains text of error found.
		/// User must not call Init().
		/// </summary>
		public override bool Validate(StringBuilder sb)
		{
			bool retVal = true;
			if (base.Validate(sb) == false)
				retVal = false;
			((IBreastBodyLocationRequiredFragment)this).Validate(sb);                                                                                // CSItemClass.cs:84
			((IObservedChangesFragment)this).Validate(sb);                                                                                           // CSItemClass.cs:84
			((IBiRadFragment)this).Validate(sb);                                                                                                     // CSItemClass.cs:84
			((INotPreviouslySeenFragment)this).Validate(sb);                                                                                         // CSItemClass.cs:84
			((ICorrespondsWithFragment)this).Validate(sb);                                                                                           // CSItemClass.cs:84
			((IPreviouslyDemonstratedByFragment)this).Validate(sb);                                                                                  // CSItemClass.cs:84
			((IAssociatedFeatureFragment)this).Validate(sb);                                                                                         // CSItemClass.cs:84
			((IConsistentWithFragment)this).Validate(sb);                                                                                            // CSItemClass.cs:84
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write(BreastRadiologyDocument doc)
		{
			base.Write(doc);
			((IBreastBodyLocationRequiredFragment)this).Write(doc);                                                                                  // CSItemClass.cs:81
			((IObservedChangesFragment)this).Write(doc);                                                                                             // CSItemClass.cs:81
			((IBiRadFragment)this).Write(doc);                                                                                                       // CSItemClass.cs:81
			((INotPreviouslySeenFragment)this).Write(doc);                                                                                           // CSItemClass.cs:81
			((ICorrespondsWithFragment)this).Write(doc);                                                                                             // CSItemClass.cs:81
			((IPreviouslyDemonstratedByFragment)this).Write(doc);                                                                                    // CSItemClass.cs:81
			((IAssociatedFeatureFragment)this).Write(doc);                                                                                           // CSItemClass.cs:81
			((IConsistentWithFragment)this).Write(doc);                                                                                              // CSItemClass.cs:81
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read<Observation>(BreastRadiologyDocument doc,
							      Observation resource)
		{
			base.Read(doc, resource);
			((IBreastBodyLocationRequiredFragment)this).Read(doc, resource);                                                                         // CSItemClass.cs:78
			((IObservedChangesFragment)this).Read(doc, resource);                                                                                    // CSItemClass.cs:78
			((IBiRadFragment)this).Read(doc, resource);                                                                                              // CSItemClass.cs:78
			((INotPreviouslySeenFragment)this).Read(doc, resource);                                                                                  // CSItemClass.cs:78
			((ICorrespondsWithFragment)this).Read(doc, resource);                                                                                    // CSItemClass.cs:78
			((IPreviouslyDemonstratedByFragment)this).Read(doc, resource);                                                                           // CSItemClass.cs:78
			((IAssociatedFeatureFragment)this).Read(doc, resource);                                                                                  // CSItemClass.cs:78
			((IConsistentWithFragment)this).Read(doc, resource);                                                                                     // CSItemClass.cs:78
		}

	}
}

