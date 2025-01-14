// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// MedicationAdministration Status Codes
  /// </summary>
  public static class MedicationAdminStatusCodes
  {
    /// <summary>
    /// All actions that are implied by the administration have occurred.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://terminology.hl7.org/CodeSystem/medication-admin-status"
    };
    /// <summary>
    /// The administration was entered in error and therefore nullified.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://terminology.hl7.org/CodeSystem/medication-admin-status"
    };
    /// <summary>
    /// The administration has started but has not yet completed.
    /// </summary>
    public static readonly Coding InProgress = new Coding
    {
      Code = "in-progress",
      Display = "In Progress",
      System = "http://terminology.hl7.org/CodeSystem/medication-admin-status"
    };
    /// <summary>
    /// The administration was terminated prior to any impact on the subject (though preparatory actions may have been taken)
    /// </summary>
    public static readonly Coding NotDone = new Coding
    {
      Code = "not-done",
      Display = "Not Done",
      System = "http://terminology.hl7.org/CodeSystem/medication-admin-status"
    };
    /// <summary>
    /// Actions implied by the administration have been temporarily halted, but are expected to continue later. May also be called 'suspended'.
    /// </summary>
    public static readonly Coding OnHold = new Coding
    {
      Code = "on-hold",
      Display = "On Hold",
      System = "http://terminology.hl7.org/CodeSystem/medication-admin-status"
    };
    /// <summary>
    /// Actions implied by the administration have been permanently halted, before all of them occurred.
    /// </summary>
    public static readonly Coding Stopped = new Coding
    {
      Code = "stopped",
      Display = "Stopped",
      System = "http://terminology.hl7.org/CodeSystem/medication-admin-status"
    };
    /// <summary>
    /// The authoring system does not know which of the status values currently applies for this request. Note: This concept is not to be used for 'other' - one of the listed statuses is presumed to apply, it's just not known which one.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://terminology.hl7.org/CodeSystem/medication-admin-status"
    };
  };
}
