// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Example use codes for the List resource - typical kinds of use.
  /// </summary>
  public static class ListExampleCodesCodes
  {
    /// <summary>
    /// A list of part adverse reactions.
    /// </summary>
    public static readonly Coding AdverseReactions = new Coding
    {
      Code = "adverserxns",
      Display = "Adverse Reactions",
      System = "http://terminology.hl7.org/CodeSystem/list-example-use-codes"
    };
    /// <summary>
    /// A list of alerts for the patient.
    /// </summary>
    public static readonly Coding Alerts = new Coding
    {
      Code = "alerts",
      Display = "Alerts",
      System = "http://terminology.hl7.org/CodeSystem/list-example-use-codes"
    };
    /// <summary>
    /// A list of Allergies for the patient.
    /// </summary>
    public static readonly Coding Allergies = new Coding
    {
      Code = "allergies",
      Display = "Allergies",
      System = "http://terminology.hl7.org/CodeSystem/list-example-use-codes"
    };
    /// <summary>
    /// A list of medication statements for the patient.
    /// </summary>
    public static readonly Coding MedicationList = new Coding
    {
      Code = "medications",
      Display = "Medication List",
      System = "http://terminology.hl7.org/CodeSystem/list-example-use-codes"
    };
    /// <summary>
    /// A set of care plans that apply in a particular context of care.
    /// </summary>
    public static readonly Coding CarePlans = new Coding
    {
      Code = "plans",
      Display = "Care Plans",
      System = "http://terminology.hl7.org/CodeSystem/list-example-use-codes"
    };
    /// <summary>
    /// A list of problems that the patient is known of have (or have had in the past).
    /// </summary>
    public static readonly Coding ProblemList = new Coding
    {
      Code = "problems",
      Display = "Problem List",
      System = "http://terminology.hl7.org/CodeSystem/list-example-use-codes"
    };
    /// <summary>
    /// A set of protocols to be followed.
    /// </summary>
    public static readonly Coding Protocols = new Coding
    {
      Code = "protocols",
      Display = "Protocols",
      System = "http://terminology.hl7.org/CodeSystem/list-example-use-codes"
    };
    /// <summary>
    /// A list of items waiting for an event (perhaps a surgical patient waiting list).
    /// </summary>
    public static readonly Coding WaitingList = new Coding
    {
      Code = "waiting",
      Display = "Waiting List",
      System = "http://terminology.hl7.org/CodeSystem/list-example-use-codes"
    };
    /// <summary>
    /// A list of items that constitute a set of work to be performed (typically this code would be specialized for more specific uses, such as a ward round list).
    /// </summary>
    public static readonly Coding Worklist = new Coding
    {
      Code = "worklist",
      Display = "Worklist",
      System = "http://terminology.hl7.org/CodeSystem/list-example-use-codes"
    };
  };
}
