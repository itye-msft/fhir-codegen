// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Use of contact point.
  /// </summary>
  public static class ContactPointUseCodes
  {
    /// <summary>
    /// A communication contact point at a home; attempted contacts for business purposes might intrude privacy and chances are one will contact family or other household members instead of the person one wishes to call. Typically used with urgent cases, or if no other contacts are available.
    /// </summary>
    public static readonly Coding Home = new Coding
    {
      Code = "home",
      Display = "Home",
      System = "http://hl7.org/fhir/contact-point-use"
    };
    /// <summary>
    /// A telecommunication device that moves and stays with its owner. May have characteristics of all other use codes, suitable for urgent matters, not the first choice for routine business.
    /// </summary>
    public static readonly Coding Mobile = new Coding
    {
      Code = "mobile",
      Display = "Mobile",
      System = "http://hl7.org/fhir/contact-point-use"
    };
    /// <summary>
    /// This contact point is no longer in use (or was never correct, but retained for records).
    /// </summary>
    public static readonly Coding Old = new Coding
    {
      Code = "old",
      Display = "Old",
      System = "http://hl7.org/fhir/contact-point-use"
    };
    /// <summary>
    /// A temporary contact point. The period can provide more detailed information.
    /// </summary>
    public static readonly Coding Temp = new Coding
    {
      Code = "temp",
      Display = "Temp",
      System = "http://hl7.org/fhir/contact-point-use"
    };
    /// <summary>
    /// An office contact point. First choice for business related contacts during business hours.
    /// </summary>
    public static readonly Coding Work = new Coding
    {
      Code = "work",
      Display = "Work",
      System = "http://hl7.org/fhir/contact-point-use"
    };
  };
}
