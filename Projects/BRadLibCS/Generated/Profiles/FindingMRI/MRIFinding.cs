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
	/// Interface IMRIFinding.
	/// </summary>
	public interface IMRIFinding 
	{

	}

	/// <summary>
	/// class CMRIFindingProfile.
	/// </summary>
	public partial class MRIFindingProfile :  ObservationBase, IMRIFinding
	{

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public MRIFindingProfile() : base()
		{
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public override void Init()
		{
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
			return retVal;
		}

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write(BreastRadiologyDocument doc)
		{
			base.Write(doc);
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read<Observation>(BreastRadiologyDocument doc,
							      Observation resource)
		{
			base.Read(doc, resource);
		}

	}
}

