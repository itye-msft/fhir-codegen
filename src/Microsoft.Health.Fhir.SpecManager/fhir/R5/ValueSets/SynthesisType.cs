// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Types of combining results from a body of evidence (eg. summary data meta-analysis).
  /// </summary>
  public static class SynthesisTypeCodes
  {
    /// <summary>
    /// An approach describing a body of evidence by categorically classifying individual studies (eg 3 studies showed beneft and 2 studied found no effect).
    /// </summary>
    public static readonly Coding ClassifcationOfResults = new Coding
    {
      Code = "classification",
      Display = "classifcation of results",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };
    /// <summary>
    /// An composite meta-analysis derived from direct comparisons and indirect comparisons in a network meta-analysis.
    /// </summary>
    public static readonly Coding CombinedDirectPlusIndirectNetworkMetaAnalysis = new Coding
    {
      Code = "combined-NMA",
      Display = "combined direct plus indirect network meta-analysis",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };
    /// <summary>
    /// An indirect meta-analysis derived from 2 or more direct comparisons in a network meta-analysis.
    /// </summary>
    public static readonly Coding IndirectNetworkMetaAnalysis = new Coding
    {
      Code = "indirect-NMA",
      Display = "indirect network meta-analysis",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };
    /// <summary>
    /// A meta-analysis of the individual participant data from individual studies or data sets.
    /// </summary>
    public static readonly Coding IndividualPatientDataMetaAnalysis = new Coding
    {
      Code = "IPD-MA",
      Display = "individual patient data meta-analysis",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };
    /// <summary>
    /// Not applicable because the evidence is not from a synthesis but from a single study. Used fo explicitly state that it's not a synthesis.
    /// </summary>
    public static readonly Coding NotApplicable = new Coding
    {
      Code = "NotApplicable",
      Display = "not applicable",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };
    /// <summary>
    /// A range of results across a body of evidence.
    /// </summary>
    public static readonly Coding RangeOfResults = new Coding
    {
      Code = "range",
      Display = "range of results",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };
    /// <summary>
    /// A meta-analysis of the summary data of estimates from individual studies or data sets.
    /// </summary>
    public static readonly Coding SummaryDataMetaAnalysis = new Coding
    {
      Code = "std-MA",
      Display = "summary data meta-analysis",
      System = "http://terminology.hl7.org/CodeSystem/synthesis-type"
    };
  };
}
