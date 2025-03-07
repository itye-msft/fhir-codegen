// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR5.Serialization;

namespace fhirCsR5.Models
{
  /// <summary>
  /// A slot of time on a schedule that may be available for booking appointments.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<Slot>))]
  public class Slot : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "Slot";
    /// <summary>
    /// The style of appointment or patient that may be booked in the slot (not service type).
    /// </summary>
    public CodeableConcept AppointmentType { get; set; }
    /// <summary>
    /// Comments on the slot to describe any extended information. Such as custom constraints on the slot.
    /// </summary>
    public string Comment { get; set; }
    /// <summary>
    /// Extension container element for Comment
    /// </summary>
    public Element _Comment { get; set; }
    /// <summary>
    /// Date/Time that the slot is to conclude.
    /// </summary>
    public string End { get; set; }
    /// <summary>
    /// Extension container element for End
    /// </summary>
    public Element _End { get; set; }
    /// <summary>
    /// External Ids for this item.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// This slot has already been overbooked, appointments are unlikely to be accepted for this time.
    /// </summary>
    public bool? Overbooked { get; set; }
    /// <summary>
    /// The schedule resource that this slot defines an interval of status information.
    /// </summary>
    public Reference Schedule { get; set; }
    /// <summary>
    /// A broad categorization of the service that is to be performed during this appointment.
    /// </summary>
    public List<CodeableConcept> ServiceCategory { get; set; }
    /// <summary>
    /// The type of appointments that can be booked into this slot (ideally this would be an identifiable service - which is at a location, rather than the location itself). If provided then this overrides the value provided on the availability resource.
    /// </summary>
    public List<CodeableConcept> ServiceType { get; set; }
    /// <summary>
    /// The specialty of a practitioner that would be required to perform the service requested in this appointment.
    /// </summary>
    public List<CodeableConcept> Specialty { get; set; }
    /// <summary>
    /// Date/Time that the slot is to begin.
    /// </summary>
    public string Start { get; set; }
    /// <summary>
    /// Extension container element for Start
    /// </summary>
    public Element _Start { get; set; }
    /// <summary>
    /// busy | free | busy-unavailable | busy-tentative | entered-in-error.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR5.Models.DomainResource)this).SerializeJson(writer, options, false);

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ServiceCategory != null) && (ServiceCategory.Count != 0))
      {
        writer.WritePropertyName("serviceCategory");
        writer.WriteStartArray();

        foreach (CodeableConcept valServiceCategory in ServiceCategory)
        {
          valServiceCategory.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ServiceType != null) && (ServiceType.Count != 0))
      {
        writer.WritePropertyName("serviceType");
        writer.WriteStartArray();

        foreach (CodeableConcept valServiceType in ServiceType)
        {
          valServiceType.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Specialty != null) && (Specialty.Count != 0))
      {
        writer.WritePropertyName("specialty");
        writer.WriteStartArray();

        foreach (CodeableConcept valSpecialty in Specialty)
        {
          valSpecialty.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (AppointmentType != null)
      {
        writer.WritePropertyName("appointmentType");
        AppointmentType.SerializeJson(writer, options);
      }

      if (Schedule != null)
      {
        writer.WritePropertyName("schedule");
        Schedule.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Start))
      {
        writer.WriteString("start", (string)Start!);
      }

      if (_Start != null)
      {
        writer.WritePropertyName("_start");
        _Start.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(End))
      {
        writer.WriteString("end", (string)End!);
      }

      if (_End != null)
      {
        writer.WritePropertyName("_end");
        _End.SerializeJson(writer, options);
      }

      if (Overbooked != null)
      {
        writer.WriteBoolean("overbooked", (bool)Overbooked!);
      }

      if (!string.IsNullOrEmpty(Comment))
      {
        writer.WriteString("comment", (string)Comment!);
      }

      if (_Comment != null)
      {
        writer.WritePropertyName("_comment");
        _Comment.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "appointmentType":
          AppointmentType = new fhirCsR5.Models.CodeableConcept();
          AppointmentType.DeserializeJson(ref reader, options);
          break;

        case "comment":
          Comment = reader.GetString();
          break;

        case "_comment":
          _Comment = new fhirCsR5.Models.Element();
          _Comment.DeserializeJson(ref reader, options);
          break;

        case "end":
          End = reader.GetString();
          break;

        case "_end":
          _End = new fhirCsR5.Models.Element();
          _End.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Identifier objIdentifier = new fhirCsR5.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "overbooked":
          Overbooked = reader.GetBoolean();
          break;

        case "schedule":
          Schedule = new fhirCsR5.Models.Reference();
          Schedule.DeserializeJson(ref reader, options);
          break;

        case "serviceCategory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ServiceCategory = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objServiceCategory = new fhirCsR5.Models.CodeableConcept();
            objServiceCategory.DeserializeJson(ref reader, options);
            ServiceCategory.Add(objServiceCategory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ServiceCategory.Count == 0)
          {
            ServiceCategory = null;
          }

          break;

        case "serviceType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ServiceType = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objServiceType = new fhirCsR5.Models.CodeableConcept();
            objServiceType.DeserializeJson(ref reader, options);
            ServiceType.Add(objServiceType);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ServiceType.Count == 0)
          {
            ServiceType = null;
          }

          break;

        case "specialty":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Specialty = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objSpecialty = new fhirCsR5.Models.CodeableConcept();
            objSpecialty.DeserializeJson(ref reader, options);
            Specialty.Add(objSpecialty);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Specialty.Count == 0)
          {
            Specialty = null;
          }

          break;

        case "start":
          Start = reader.GetString();
          break;

        case "_start":
          _Start = new fhirCsR5.Models.Element();
          _Start.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR5.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Code Values for the Slot.status field
  /// </summary>
  public static class SlotStatusCodes {
    public const string BUSY = "busy";
    public const string FREE = "free";
    public const string BUSY_UNAVAILABLE = "busy-unavailable";
    public const string BUSY_TENTATIVE = "busy-tentative";
    public const string ENTERED_IN_ERROR = "entered-in-error";
  }
}
