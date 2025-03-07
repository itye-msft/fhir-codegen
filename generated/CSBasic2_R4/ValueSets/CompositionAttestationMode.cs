// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The way in which a person authenticated a composition.
  /// </summary>
  public static class CompositionAttestationModeCodes
  {
    /// <summary>
    /// The person authenticated the content and accepted legal responsibility for its content.
    /// </summary>
    public static readonly Coding Legal = new Coding
    {
      Code = "legal",
      Display = "Legal",
      System = "http://hl7.org/fhir/composition-attestation-mode"
    };
    /// <summary>
    /// The organization authenticated the content as consistent with their policies and procedures.
    /// </summary>
    public static readonly Coding Official = new Coding
    {
      Code = "official",
      Display = "Official",
      System = "http://hl7.org/fhir/composition-attestation-mode"
    };
    /// <summary>
    /// The person authenticated the content in their personal capacity.
    /// </summary>
    public static readonly Coding Personal = new Coding
    {
      Code = "personal",
      Display = "Personal",
      System = "http://hl7.org/fhir/composition-attestation-mode"
    };
    /// <summary>
    /// The person authenticated the content in their professional capacity.
    /// </summary>
    public static readonly Coding Professional = new Coding
    {
      Code = "professional",
      Display = "Professional",
      System = "http://hl7.org/fhir/composition-attestation-mode"
    };
  };
}
