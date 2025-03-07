// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The kind of operation to perform as a part of a property based filter.
  /// </summary>
  public static class FilterOperatorCodes
  {
    /// <summary>
    /// The specified property of the code equals the provided value.
    /// </summary>
    public static readonly new Coding Equals = new Coding
    {
      Code = "=",
      Display = "Equals",
      System = "http://hl7.org/fhir/filter-operator"
    };
    /// <summary>
    /// Only concepts with a direct hierarchical relationship to the index code and no other concepts. This does not include the index code in the output.
    /// </summary>
    public static readonly Coding ChildOf = new Coding
    {
      Code = "child-of",
      Display = "Child Of",
      System = "http://hl7.org/fhir/filter-operator"
    };
    /// <summary>
    /// Includes concept ids that have a transitive is-a relationship with the concept Id provided as the value, but which do not have any concept ids with transitive is-a relationships with themselves.
    /// </summary>
    public static readonly Coding DescendentLeaf = new Coding
    {
      Code = "descendent-leaf",
      Display = "Descendent Leaf",
      System = "http://hl7.org/fhir/filter-operator"
    };
    /// <summary>
    /// Includes all concept ids that have a transitive is-a relationship with the concept Id provided as the value, excluding the provided concept itself i.e. include descendant codes only).
    /// </summary>
    public static readonly Coding DescendentOfBySubsumption = new Coding
    {
      Code = "descendent-of",
      Display = "Descendent Of (by subsumption)",
      System = "http://hl7.org/fhir/filter-operator"
    };
    /// <summary>
    /// The specified property of the code has at least one value (if the specified value is true; if the specified value is false, then matches when the specified property of the code has no values).
    /// </summary>
    public static readonly Coding Exists = new Coding
    {
      Code = "exists",
      Display = "Exists",
      System = "http://hl7.org/fhir/filter-operator"
    };
    /// <summary>
    /// Includes all concept ids that have a transitive is-a relationship from the concept Id provided as the value, including the provided concept itself (i.e. include ancestor codes and self).
    /// </summary>
    public static readonly Coding GeneralizesBySubsumption = new Coding
    {
      Code = "generalizes",
      Display = "Generalizes (by Subsumption)",
      System = "http://hl7.org/fhir/filter-operator"
    };
    /// <summary>
    /// The specified property of the code is in the set of codes or concepts specified in the provided value (comma separated list).
    /// </summary>
    public static readonly Coding InSet = new Coding
    {
      Code = "in",
      Display = "In Set",
      System = "http://hl7.org/fhir/filter-operator"
    };
    /// <summary>
    /// Includes all concept ids that have a transitive is-a relationship with the concept Id provided as the value, including the provided concept itself (include descendant codes and self).
    /// </summary>
    public static readonly Coding IsABySubsumption = new Coding
    {
      Code = "is-a",
      Display = "Is A (by subsumption)",
      System = "http://hl7.org/fhir/filter-operator"
    };
    /// <summary>
    /// The specified property of the code does not have an is-a relationship with the provided value.
    /// </summary>
    public static readonly Coding NotIsABySubsumption = new Coding
    {
      Code = "is-not-a",
      Display = "Not (Is A) (by subsumption)",
      System = "http://hl7.org/fhir/filter-operator"
    };
    /// <summary>
    /// The specified property of the code is not in the set of codes or concepts specified in the provided value (comma separated list).
    /// </summary>
    public static readonly Coding NotInSet = new Coding
    {
      Code = "not-in",
      Display = "Not in Set",
      System = "http://hl7.org/fhir/filter-operator"
    };
    /// <summary>
    /// The specified property of the code  matches the regex specified in the provided value.
    /// </summary>
    public static readonly Coding RegularExpression = new Coding
    {
      Code = "regex",
      Display = "Regular Expression",
      System = "http://hl7.org/fhir/filter-operator"
    };
  };
}
