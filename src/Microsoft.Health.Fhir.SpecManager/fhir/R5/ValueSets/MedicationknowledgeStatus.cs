// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// MedicationKnowledge Status Codes
  /// </summary>
  public static class MedicationknowledgeStatusCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://terminology.hl7.org/CodeSystem/medicationknowledge-status"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://terminology.hl7.org/CodeSystem/medicationknowledge-status"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Inactive = new Coding
    {
      Code = "inactive",
      Display = "Inactive",
      System = "http://terminology.hl7.org/CodeSystem/medicationknowledge-status"
    };
  };
}
