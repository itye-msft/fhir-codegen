// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The availability status reason of the device.
  /// </summary>
  public static class DeviceStatusReasonCodes
  {
    /// <summary>
    /// The device hardware is disconnected.
    /// </summary>
    public static readonly Coding HardwareDisconnected = new Coding
    {
      Code = "hw-discon",
      Display = "Hardware Disconnected",
      System = "http://terminology.hl7.org/CodeSystem/device-status-reason"
    };
    /// <summary>
    /// The device is not ready.
    /// </summary>
    public static readonly Coding NotReady = new Coding
    {
      Code = "not-ready",
      Display = "Not Ready",
      System = "http://terminology.hl7.org/CodeSystem/device-status-reason"
    };
    /// <summary>
    /// The device is off.
    /// </summary>
    public static readonly Coding Off = new Coding
    {
      Code = "off",
      Display = "Off",
      System = "http://terminology.hl7.org/CodeSystem/device-status-reason"
    };
    /// <summary>
    /// The device is offline.
    /// </summary>
    public static readonly Coding Offline = new Coding
    {
      Code = "offline",
      Display = "Offline",
      System = "http://terminology.hl7.org/CodeSystem/device-status-reason"
    };
    /// <summary>
    /// The device is off.
    /// </summary>
    public static readonly Coding Online = new Coding
    {
      Code = "online",
      Display = "Online",
      System = "http://terminology.hl7.org/CodeSystem/device-status-reason"
    };
    /// <summary>
    /// The device is paused.
    /// </summary>
    public static readonly Coding Paused = new Coding
    {
      Code = "paused",
      Display = "Paused",
      System = "http://terminology.hl7.org/CodeSystem/device-status-reason"
    };
    /// <summary>
    /// The device is ready but not actively operating.
    /// </summary>
    public static readonly Coding Standby = new Coding
    {
      Code = "standby",
      Display = "Standby",
      System = "http://terminology.hl7.org/CodeSystem/device-status-reason"
    };
    /// <summary>
    /// The device transducer is disconnected.
    /// </summary>
    public static readonly Coding TransducerDisconnected = new Coding
    {
      Code = "transduc-discon",
      Display = "Transducer Disconnected",
      System = "http://terminology.hl7.org/CodeSystem/device-status-reason"
    };
  };
}
