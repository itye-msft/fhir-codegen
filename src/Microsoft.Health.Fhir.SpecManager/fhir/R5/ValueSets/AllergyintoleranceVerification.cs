// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The verification status to support or decline the clinical status of the allergy or intolerance.
  /// </summary>
  public static class AllergyintoleranceVerificationCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Confirmed = new Coding
    {
      Code = "confirmed",
      Display = "Confirmed",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Presumed = new Coding
    {
      Code = "presumed",
      Display = "Presumed",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Refuted = new Coding
    {
      Code = "refuted",
      Display = "Refuted",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Unconfirmed = new Coding
    {
      Code = "unconfirmed",
      Display = "Unconfirmed",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
  };
}
