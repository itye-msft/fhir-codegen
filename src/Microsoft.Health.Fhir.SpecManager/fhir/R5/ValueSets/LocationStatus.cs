// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Indicates whether the location is still in use.
  /// </summary>
  public static class LocationStatusCodes
  {
    /// <summary>
    /// The location is operational.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/location-status"
    };
    /// <summary>
    /// The location is no longer used.
    /// </summary>
    public static readonly Coding Inactive = new Coding
    {
      Code = "inactive",
      Display = "Inactive",
      System = "http://hl7.org/fhir/location-status"
    };
    /// <summary>
    /// The location is temporarily closed.
    /// </summary>
    public static readonly Coding Suspended = new Coding
    {
      Code = "suspended",
      Display = "Suspended",
      System = "http://hl7.org/fhir/location-status"
    };
  };
}
