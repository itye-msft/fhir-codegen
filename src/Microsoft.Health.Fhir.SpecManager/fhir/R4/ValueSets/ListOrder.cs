// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Base values for the order of the items in a list resource.
  /// </summary>
  public static class ListOrderCodes
  {
    /// <summary>
    /// The list is sorted alphabetically by an unspecified property of the items in the list.
    /// </summary>
    public static readonly Coding SortedAlphabetically = new Coding
    {
      Code = "alphabetic",
      Display = "Sorted Alphabetically",
      System = "http://terminology.hl7.org/CodeSystem/list-order"
    };
    /// <summary>
    /// The list is sorted categorically by an unspecified property of the items in the list.
    /// </summary>
    public static readonly Coding SortedByCategory = new Coding
    {
      Code = "category",
      Display = "Sorted by Category",
      System = "http://terminology.hl7.org/CodeSystem/list-order"
    };
    /// <summary>
    /// The list is sorted by the date the item was added to the list. Note that the date added to the list is not explicit in the list itself.
    /// </summary>
    public static readonly Coding SortedByItemDate = new Coding
    {
      Code = "entry-date",
      Display = "Sorted by Item Date",
      System = "http://terminology.hl7.org/CodeSystem/list-order"
    };
    /// <summary>
    /// The list is sorted by the data of the event. This can be used when the list has items which are dates with past or future events.
    /// </summary>
    public static readonly Coding SortedByEventDate = new Coding
    {
      Code = "event-date",
      Display = "Sorted by Event Date",
      System = "http://terminology.hl7.org/CodeSystem/list-order"
    };
    /// <summary>
    /// The list is sorted by patient, with items for each patient grouped together.
    /// </summary>
    public static readonly Coding SortedByPatient = new Coding
    {
      Code = "patient",
      Display = "Sorted by Patient",
      System = "http://terminology.hl7.org/CodeSystem/list-order"
    };
    /// <summary>
    /// The list is sorted by priority. The exact method in which priority has been determined is not specified.
    /// </summary>
    public static readonly Coding SortedByPriority = new Coding
    {
      Code = "priority",
      Display = "Sorted by Priority",
      System = "http://terminology.hl7.org/CodeSystem/list-order"
    };
    /// <summary>
    /// The list was sorted by the system. The criteria the user used are not specified; define additional codes to specify a particular order (or use other defined codes).
    /// </summary>
    public static readonly Coding SortedBySystem = new Coding
    {
      Code = "system",
      Display = "Sorted by System",
      System = "http://terminology.hl7.org/CodeSystem/list-order"
    };
    /// <summary>
    /// The list was sorted by a user. The criteria the user used are not specified.
    /// </summary>
    public static readonly Coding SortedByUser = new Coding
    {
      Code = "user",
      Display = "Sorted by User",
      System = "http://terminology.hl7.org/CodeSystem/list-order"
    };
  };
}
