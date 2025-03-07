// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Codes identifying the lifecycle stage of an Invoice.
  /// </summary>
  public static class InvoiceStatusCodes
  {
    /// <summary>
    /// the invoice has been balaced / completely paid.
    /// </summary>
    public static readonly Coding Balanced = new Coding
    {
      Code = "balanced",
      Display = "balanced",
      System = "http://hl7.org/fhir/invoice-status"
    };
    /// <summary>
    /// the invoice was cancelled.
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "cancelled",
      Display = "cancelled",
      System = "http://hl7.org/fhir/invoice-status"
    };
    /// <summary>
    /// the invoice has been prepared but not yet finalized.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "draft",
      System = "http://hl7.org/fhir/invoice-status"
    };
    /// <summary>
    /// the invoice was determined as entered in error before it was issued.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "entered in error",
      System = "http://hl7.org/fhir/invoice-status"
    };
    /// <summary>
    /// the invoice has been finalized and sent to the recipient.
    /// </summary>
    public static readonly Coding Issued = new Coding
    {
      Code = "issued",
      Display = "issued",
      System = "http://hl7.org/fhir/invoice-status"
    };
  };
}
