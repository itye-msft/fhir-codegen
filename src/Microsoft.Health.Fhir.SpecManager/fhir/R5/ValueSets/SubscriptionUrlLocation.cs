// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The location, in Bundle.entry, where URLs for resources should be located.
  /// </summary>
  public static class SubscriptionUrlLocationCodes
  {
    /// <summary>
    /// URLS should be filled out in all available locations.
    /// </summary>
    public static readonly Coding All = new Coding
    {
      Code = "all",
      Display = "all",
      System = "http://hl7.org/fhir/subscription-url-location"
    };
    /// <summary>
    /// URLs should be placed in Bundle.entry.fullUrl.
    /// </summary>
    public static readonly Coding FullUrl = new Coding
    {
      Code = "full-url",
      Display = "full-url",
      System = "http://hl7.org/fhir/subscription-url-location"
    };
    /// <summary>
    /// URLs should NOT be included in notifications.
    /// </summary>
    public static readonly Coding None = new Coding
    {
      Code = "none",
      Display = "none",
      System = "http://hl7.org/fhir/subscription-url-location"
    };
    /// <summary>
    /// URLs should be placed in Bundle.entry.request and/or Bundle.entry.response.
    /// </summary>
    public static readonly Coding RequestResponse = new Coding
    {
      Code = "request-response",
      Display = "request-response",
      System = "http://hl7.org/fhir/subscription-url-location"
    };
  };
}
