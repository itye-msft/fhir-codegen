// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Biologically Derived Product Status.
  /// </summary>
  public static class BiologicalProductStatusCodes
  {
    /// <summary>
    /// Product is currently available for use.
    /// </summary>
    public static readonly Coding Available = new Coding
    {
      Code = "available",
      Display = "Available",
      System = "http://hl7.org/fhir/biological-product-status"
    };
    /// <summary>
    /// Product is not currently available for use.
    /// </summary>
    public static readonly Coding Unavailable = new Coding
    {
      Code = "unavailable",
      Display = "Unavailable",
      System = "http://hl7.org/fhir/biological-product-status"
    };
  };
}
