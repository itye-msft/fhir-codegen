// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// An example value set of Codified order entry details concepts.  These concepts only make sense in the context of what is being ordered.  This example is for a patient ventilation order
  /// </summary>
  public static class ServicerequestOrderdetailCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientTriggeredInspiratoryAssistanceProcedure = new Coding
    {
      Code = "243144002",
      Display = "Patient triggered inspiratory assistance (procedure)",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AssistedControlledMandatoryVentilationProcedure = new Coding
    {
      Code = "243150007",
      Display = "Assisted controlled mandatory ventilation (procedure)",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PressureControlledVentilationProcedure = new Coding
    {
      Code = "286812008",
      Display = "Pressure controlled ventilation (procedure)",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ContinuousPositiveAirwayPressureVentilationTreatmentRegimeTherapy = new Coding
    {
      Code = "47545007",
      Display = "Continuous positive airway pressure ventilation treatment (regime/therapy)",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SynchronizedIntermittentMandatoryVentilationProcedure = new Coding
    {
      Code = "59427005",
      Display = "Synchronized intermittent mandatory ventilation (procedure)",
      System = "http://snomed.info/sct"
    };
  };
}