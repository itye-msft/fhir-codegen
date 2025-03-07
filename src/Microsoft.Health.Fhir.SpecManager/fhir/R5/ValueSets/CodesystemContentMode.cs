// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The extent of the content of the code system (the concepts and codes it defines) are represented in a code system resource.
  /// </summary>
  public static class CodesystemContentModeCodes
  {
    /// <summary>
    /// All the concepts defined by the code system are included in the code system resource.
    /// </summary>
    public static readonly Coding Complete = new Coding
    {
      Code = "complete",
      Display = "Complete",
      System = "http://hl7.org/fhir/codesystem-content-mode"
    };
    /// <summary>
    /// A few representative concepts are included in the code system resource. There is no useful intent in the subset choice and there's no process to make it workable: it's not intended to be workable.
    /// </summary>
    public static readonly Coding Example = new Coding
    {
      Code = "example",
      Display = "Example",
      System = "http://hl7.org/fhir/codesystem-content-mode"
    };
    /// <summary>
    /// A subset of the code system concepts are included in the code system resource. This is a curated subset released for a specific purpose under the governance of the code system steward, and that the intent, bounds and consequences of the fragmentation are clearly defined in the fragment or the code system documentation. Fragments are also known as partitions.
    /// </summary>
    public static readonly Coding Fragment = new Coding
    {
      Code = "fragment",
      Display = "Fragment",
      System = "http://hl7.org/fhir/codesystem-content-mode"
    };
    /// <summary>
    /// None of the concepts defined by the code system are included in the code system resource.
    /// </summary>
    public static readonly Coding NotPresent = new Coding
    {
      Code = "not-present",
      Display = "Not Present",
      System = "http://hl7.org/fhir/codesystem-content-mode"
    };
    /// <summary>
    /// The resource doesn't define any new concepts; it just provides additional designations and properties to another code system.
    /// </summary>
    public static readonly Coding Supplement = new Coding
    {
      Code = "supplement",
      Display = "Supplement",
      System = "http://hl7.org/fhir/codesystem-content-mode"
    };
  };
}
