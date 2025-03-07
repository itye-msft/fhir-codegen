// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The kind of dose or rate specified.
  /// </summary>
  public static class DoseRateTypeCodes
  {
    /// <summary>
    /// The dose specified is calculated by the prescriber or the system.
    /// </summary>
    public static readonly Coding Calculated = new Coding
    {
      Code = "calculated",
      Display = "Calculated",
      System = "http://terminology.hl7.org/CodeSystem/dose-rate-type"
    };
    /// <summary>
    /// The dose specified is as ordered by the prescriber.
    /// </summary>
    public static readonly Coding Ordered = new Coding
    {
      Code = "ordered",
      Display = "Ordered",
      System = "http://terminology.hl7.org/CodeSystem/dose-rate-type"
    };
  };
}
