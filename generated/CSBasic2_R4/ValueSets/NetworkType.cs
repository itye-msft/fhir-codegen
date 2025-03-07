// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The type of network access point of this agent in the audit event.
  /// </summary>
  public static class NetworkTypeCodes
  {
    /// <summary>
    /// The machine name, including DNS name.
    /// </summary>
    public static readonly Coding MachineName = new Coding
    {
      Code = "1",
      Display = "Machine Name",
      System = "http://hl7.org/fhir/network-type"
    };
    /// <summary>
    /// The assigned Internet Protocol (IP) address.
    /// </summary>
    public static readonly Coding IPAddress = new Coding
    {
      Code = "2",
      Display = "IP Address",
      System = "http://hl7.org/fhir/network-type"
    };
    /// <summary>
    /// The assigned telephone number.
    /// </summary>
    public static readonly Coding TelephoneNumber = new Coding
    {
      Code = "3",
      Display = "Telephone Number",
      System = "http://hl7.org/fhir/network-type"
    };
    /// <summary>
    /// The assigned email address.
    /// </summary>
    public static readonly Coding EmailAddress = new Coding
    {
      Code = "4",
      Display = "Email address",
      System = "http://hl7.org/fhir/network-type"
    };
    /// <summary>
    /// URI (User directory, HTTP-PUT, ftp, etc.).
    /// </summary>
    public static readonly Coding URI = new Coding
    {
      Code = "5",
      Display = "URI",
      System = "http://hl7.org/fhir/network-type"
    };
  };
}
