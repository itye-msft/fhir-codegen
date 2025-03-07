// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Codes identifying the lifecycle stage of a request.
  /// </summary>
  public static class RequestStatusCodes
  {
    /// <summary>
    /// The request is in force and ready to be acted upon.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/request-status"
    };
    /// <summary>
    /// The activity described by the request has been fully performed.  No further activity will occur.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/request-status"
    };
    /// <summary>
    /// The request has been created but is not yet complete or ready for action.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "Draft",
      System = "http://hl7.org/fhir/request-status"
    };
    /// <summary>
    /// This request should never have existed and should be considered 'void'.  (It is possible that real-world decisions were based on it.  If real-world activity has occurred, the status should be "revoked" rather than "entered-in-error".).
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/request-status"
    };
    /// <summary>
    /// The request (and any implicit authorization to act) has been temporarily withdrawn but is expected to resume in the future.
    /// </summary>
    public static readonly Coding OnHold = new Coding
    {
      Code = "on-hold",
      Display = "On Hold",
      System = "http://hl7.org/fhir/request-status"
    };
    /// <summary>
    /// The request (and any implicit authorization to act) has been terminated prior to the known full completion of the intended actions.  No further activity should occur.
    /// </summary>
    public static readonly Coding Revoked = new Coding
    {
      Code = "revoked",
      Display = "Revoked",
      System = "http://hl7.org/fhir/request-status"
    };
    /// <summary>
    /// The authoring/source system does not know which of the status values currently applies for this request.  Note: This concept is not to be used for "other" - one of the listed statuses is presumed to apply,  but the authoring/source system does not know which.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/request-status"
    };
  };
}
