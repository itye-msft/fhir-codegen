// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The clinical priority of a diagnostic order.
  /// </summary>
  public static class RequestPriorityCodes
  {
    /// <summary>
    /// The request should be actioned as soon as possible - higher priority than urgent.
    /// </summary>
    public static readonly Coding ASAP = new Coding
    {
      Code = "asap",
      Display = "ASAP",
      System = "http://hl7.org/fhir/request-priority"
    };
    /// <summary>
    /// The request has normal priority.
    /// </summary>
    public static readonly Coding Routine = new Coding
    {
      Code = "routine",
      Display = "Routine",
      System = "http://hl7.org/fhir/request-priority"
    };
    /// <summary>
    /// The request should be actioned immediately - highest possible priority.  E.g. an emergency.
    /// </summary>
    public static readonly Coding STAT = new Coding
    {
      Code = "stat",
      Display = "STAT",
      System = "http://hl7.org/fhir/request-priority"
    };
    /// <summary>
    /// The request should be actioned promptly - higher priority than routine.
    /// </summary>
    public static readonly Coding Urgent = new Coding
    {
      Code = "urgent",
      Display = "Urgent",
      System = "http://hl7.org/fhir/request-priority"
    };
  };
}
