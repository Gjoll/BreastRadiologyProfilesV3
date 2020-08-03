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
	/// Interface IConsistentWithFragment.
	/// </summary>
	public interface IConsistentWithFragment 
	{
		ObservationHasMemberCollection<ConsistentWithProfile> ConsistentWith { get; set; }                                                        // CSHasMemberSlice.cs:90
	}


	/// <summary>
	/// Interface IConsistentWithFragment.
	/// </summary>
	public static class ConsistentWithFragmentExtensions
	{

		public static void Init(this IConsistentWithFragment fragment)
		{
		fragment.ConsistentWith = new ObservationHasMemberCollection<ConsistentWithProfile>();                                                    // CSHasMemberSlice.cs:128
		}

		public static void Read<T>(this IConsistentWithFragment fragment,
								BreastRadiologyDocument doc,
								T resource)
		    where T : DomainResource
		{
		}

		public static void Write(this IConsistentWithFragment fragment,
								BreastRadiologyDocument doc)
		{
		}

		public static void Validate(this IConsistentWithFragment fragment,
								StringBuilder sb)
		{
		}
	}
}

