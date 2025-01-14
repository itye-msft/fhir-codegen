// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Whether an operation parameter is an input or an output parameter.
  /// </summary>
  public static class OperationParameterUseCodes
  {
    /// <summary>
    /// This is an input parameter.
    /// </summary>
    public static readonly Coding In = new Coding
    {
      Code = "in",
      Display = "In",
      System = "http://hl7.org/fhir/operation-parameter-use"
    };
    /// <summary>
    /// This is an output parameter.
    /// </summary>
    public static readonly Coding Out = new Coding
    {
      Code = "out",
      Display = "Out",
      System = "http://hl7.org/fhir/operation-parameter-use"
    };
  };
}
