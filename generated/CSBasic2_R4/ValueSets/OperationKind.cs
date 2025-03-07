// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Whether an operation is a normal operation or a query.
  /// </summary>
  public static class OperationKindCodes
  {
    /// <summary>
    /// This operation is invoked as an operation.
    /// </summary>
    public static readonly Coding Operation = new Coding
    {
      Code = "operation",
      Display = "Operation",
      System = "http://hl7.org/fhir/operation-kind"
    };
    /// <summary>
    /// This operation is a named query, invoked using the search mechanism.
    /// </summary>
    public static readonly Coding Query = new Coding
    {
      Code = "query",
      Display = "Query",
      System = "http://hl7.org/fhir/operation-kind"
    };
  };
}
