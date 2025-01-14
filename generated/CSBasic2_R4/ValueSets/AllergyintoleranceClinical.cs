// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Preferred value set for AllergyIntolerance Clinical Status.
  /// </summary>
  public static class AllergyintoleranceClinicalCodes
  {
    /// <summary>
    /// The subject is currently experiencing, or is at risk of, a reaction to the identified substance.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical"
    };
    /// <summary>
    /// The subject is no longer at risk of a reaction to the identified substance.
    /// </summary>
    public static readonly Coding Inactive = new Coding
    {
      Code = "inactive",
      Display = "Inactive",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical"
    };
    /// <summary>
    /// A reaction to the identified substance has been clinically reassessed by testing or re-exposure and is considered no longer to be present. Re-exposure could be accidental, unplanned, or outside of any clinical setting.
    /// </summary>
    public static readonly Coding Resolved = new Coding
    {
      Code = "resolved",
      Display = "Resolved",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical"
    };
  };
}
