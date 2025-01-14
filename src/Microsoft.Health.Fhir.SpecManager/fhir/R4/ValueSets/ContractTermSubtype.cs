// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes sample Contract Term SubType codes.
  /// </summary>
  public static class ContractTermSubtypeCodes
  {
    /// <summary>
    /// Terms that go to the very root of a contract.
    /// </summary>
    public static readonly Coding Condition = new Coding
    {
      Code = "condition",
      Display = "Condition",
      System = "http://terminology.hl7.org/CodeSystem/contracttermsubtypecodes"
    };
    /// <summary>
    /// Breach of which might or might not go to the root of the contract depending upon the nature of the breach
    /// </summary>
    public static readonly Coding Innominate = new Coding
    {
      Code = "innominate",
      Display = "Innominate",
      System = "http://terminology.hl7.org/CodeSystem/contracttermsubtypecodes"
    };
    /// <summary>
    /// Less imperative than a condition, so the contract will survive a breach
    /// </summary>
    public static readonly Coding Warranty = new Coding
    {
      Code = "warranty",
      Display = "Warranty",
      System = "http://terminology.hl7.org/CodeSystem/contracttermsubtypecodes"
    };
  };
}
