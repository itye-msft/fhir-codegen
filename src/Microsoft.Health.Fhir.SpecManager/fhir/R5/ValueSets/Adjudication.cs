// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes a smattering of Adjudication Value codes which includes codes to indicate the amounts eligible under the plan, the amount of benefit, copays etc.
  /// </summary>
  public static class AdjudicationCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding BenefitAmount = new Coding
    {
      Code = "benefit",
      Display = "Benefit Amount",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CoPay = new Coding
    {
      Code = "copay",
      Display = "CoPay",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Deductible = new Coding
    {
      Code = "deductible",
      Display = "Deductible",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EligibleAmount = new Coding
    {
      Code = "eligible",
      Display = "Eligible Amount",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EligiblePercent = new Coding
    {
      Code = "eligpercent",
      Display = "Eligible %",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SubmittedAmount = new Coding
    {
      Code = "submitted",
      Display = "Submitted Amount",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Tax = new Coding
    {
      Code = "tax",
      Display = "Tax",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding UnallocatedDeductible = new Coding
    {
      Code = "unallocdeduct",
      Display = "Unallocated Deductible",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
  };
}
