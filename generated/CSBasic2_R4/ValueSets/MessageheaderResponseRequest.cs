// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// HL7-defined table of codes which identify conditions under which acknowledgments are required to be returned in response to a message.
  /// </summary>
  public static class MessageheaderResponseRequestCodes
  {
    /// <summary>
    /// initiator expects a response for this message.
    /// </summary>
    public static readonly Coding Always = new Coding
    {
      Code = "always",
      Display = "Always",
      System = "http://hl7.org/fhir/messageheader-response-request"
    };
    /// <summary>
    /// initiator does not expect a response.
    /// </summary>
    public static readonly Coding Never = new Coding
    {
      Code = "never",
      Display = "Never",
      System = "http://hl7.org/fhir/messageheader-response-request"
    };
    /// <summary>
    /// initiator expects a response only if in error.
    /// </summary>
    public static readonly Coding ErrorRejectConditionsOnly = new Coding
    {
      Code = "on-error",
      Display = "Error/reject conditions only",
      System = "http://hl7.org/fhir/messageheader-response-request"
    };
    /// <summary>
    /// initiator expects a response only if successful.
    /// </summary>
    public static readonly Coding SuccessfulCompletionOnly = new Coding
    {
      Code = "on-success",
      Display = "Successful completion only",
      System = "http://hl7.org/fhir/messageheader-response-request"
    };
  };
}
