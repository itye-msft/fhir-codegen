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
  /// Indicates who or what performed the medication administration and how they were involved.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<MedicationAdministrationPerformer>))]
  public class MedicationAdministrationPerformer : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Indicates who or what performed the medication administration.
    /// </summary>
    public Reference Actor { get; set; }
    /// <summary>
    /// Distinguishes the type of involvement of the performer in the medication administration.
    /// </summary>
    public CodeableConcept Function { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Function != null)
      {
        writer.WritePropertyName("function");
        Function.SerializeJson(writer, options);
      }

      if (Actor != null)
      {
        writer.WritePropertyName("actor");
        Actor.SerializeJson(writer, options);
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
        case "actor":
          Actor = new fhirCsR5.Models.Reference();
          Actor.DeserializeJson(ref reader, options);
          break;

        case "function":
          Function = new fhirCsR5.Models.CodeableConcept();
          Function.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Describes the medication dosage information details e.g. dose, rate, site, route, etc.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<MedicationAdministrationDosage>))]
  public class MedicationAdministrationDosage : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// If the administration is not instantaneous (rate is present), this can be specified to convey the total amount administered over period of time of a single administration.
    /// </summary>
    public Quantity Dose { get; set; }
    /// <summary>
    /// One of the reasons this attribute is not used often, is that the method is often pre-coordinated with the route and/or form of administration.  This means the codes used in route or form may pre-coordinate the method in the route code or the form code.  The implementation decision about what coding system to use for route or form code will determine how frequently the method code will be populated e.g. if route or form code pre-coordinate method code, then this attribute will not be populated often; if there is no pre-coordination then method code may  be used frequently.
    /// </summary>
    public CodeableConcept Method { get; set; }
    /// <summary>
    /// If the rate changes over time, and you want to capture this in MedicationAdministration, then each change should be captured as a distinct MedicationAdministration, with a specific MedicationAdministration.dosage.rate, and the date time when the rate change occurred. Typically, the MedicationAdministration.dosage.rate element is not used to convey an average rate.
    /// </summary>
    public Ratio RateRatio { get; set; }
    /// <summary>
    /// If the rate changes over time, and you want to capture this in MedicationAdministration, then each change should be captured as a distinct MedicationAdministration, with a specific MedicationAdministration.dosage.rate, and the date time when the rate change occurred. Typically, the MedicationAdministration.dosage.rate element is not used to convey an average rate.
    /// </summary>
    public Quantity RateQuantity { get; set; }
    /// <summary>
    /// A code specifying the route or physiological path of administration of a therapeutic agent into or onto the patient.  For example, topical, intravenous, etc.
    /// </summary>
    public CodeableConcept Route { get; set; }
    /// <summary>
    /// If the use case requires attributes from the BodySite resource (e.g. to identify and track separately) then use the standard extension [bodySite](extension-bodysite.html).  May be a summary code, or a reference to a very precise definition of the location, or both.
    /// </summary>
    public CodeableConcept Site { get; set; }
    /// <summary>
    /// Free text dosage can be used for cases where the dosage administered is too complex to code. When coded dosage is present, the free text dosage may still be present for display to humans.
    /// The dosage instructions should reflect the dosage of the medication that was administered.
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Extension container element for Text
    /// </summary>
    public Element _Text { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Text))
      {
        writer.WriteString("text", (string)Text!);
      }

      if (_Text != null)
      {
        writer.WritePropertyName("_text");
        _Text.SerializeJson(writer, options);
      }

      if (Site != null)
      {
        writer.WritePropertyName("site");
        Site.SerializeJson(writer, options);
      }

      if (Route != null)
      {
        writer.WritePropertyName("route");
        Route.SerializeJson(writer, options);
      }

      if (Method != null)
      {
        writer.WritePropertyName("method");
        Method.SerializeJson(writer, options);
      }

      if (Dose != null)
      {
        writer.WritePropertyName("dose");
        Dose.SerializeJson(writer, options);
      }

      if (RateRatio != null)
      {
        writer.WritePropertyName("rateRatio");
        RateRatio.SerializeJson(writer, options);
      }

      if (RateQuantity != null)
      {
        writer.WritePropertyName("rateQuantity");
        RateQuantity.SerializeJson(writer, options);
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
        case "dose":
          Dose = new fhirCsR5.Models.Quantity();
          Dose.DeserializeJson(ref reader, options);
          break;

        case "method":
          Method = new fhirCsR5.Models.CodeableConcept();
          Method.DeserializeJson(ref reader, options);
          break;

        case "rateRatio":
          RateRatio = new fhirCsR5.Models.Ratio();
          RateRatio.DeserializeJson(ref reader, options);
          break;

        case "rateQuantity":
          RateQuantity = new fhirCsR5.Models.Quantity();
          RateQuantity.DeserializeJson(ref reader, options);
          break;

        case "route":
          Route = new fhirCsR5.Models.CodeableConcept();
          Route.DeserializeJson(ref reader, options);
          break;

        case "site":
          Site = new fhirCsR5.Models.CodeableConcept();
          Site.DeserializeJson(ref reader, options);
          break;

        case "text":
          Text = reader.GetString();
          break;

        case "_text":
          _Text = new fhirCsR5.Models.Element();
          _Text.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Describes the event of a patient consuming or otherwise being administered a medication.  This may be as simple as swallowing a tablet or it may be a long running infusion.  Related resources tie this event to the authorizing prescription, and the specific encounter between patient and health care practitioner.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<MedicationAdministration>))]
  public class MedicationAdministration : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "MedicationAdministration";
    /// <summary>
    /// A plan that is fulfilled in whole or in part by this MedicationAdministration.
    /// </summary>
    public List<Reference> BasedOn { get; set; }
    /// <summary>
    /// The type of medication administration (for example, drug classification like ATC, where meds would be administered, legal category of the medication).
    /// </summary>
    public List<CodeableConcept> Category { get; set; }
    /// <summary>
    /// The device used in administering the medication to the patient.  For example, a particular infusion pump.
    /// </summary>
    public List<Reference> Device { get; set; }
    /// <summary>
    /// Describes the medication dosage information details e.g. dose, rate, site, route, etc.
    /// </summary>
    public MedicationAdministrationDosage Dosage { get; set; }
    /// <summary>
    /// The visit, admission, or other contact between patient and health care provider during which the medication administration was performed.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// This might not include provenances for all versions of the request – only those deemed “relevant” or important. This SHALL NOT include the Provenance associated with this current version of the resource. (If that provenance is deemed to be a “relevant” change, it will need to be added as part of a later update. Until then, it can be queried directly as the Provenance that points to this version using _revinclude All Provenances should have some historical version of this Request as their subject.
    /// </summary>
    public List<Reference> EventHistory { get; set; }
    /// <summary>
    /// This is a business identifier, not a resource identifier.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// A protocol, guideline, orderset, or other definition that was adhered to in whole or in part by this event.
    /// </summary>
    public List<string> InstantiatesCanonical { get; set; }
    /// <summary>
    /// Extension container element for InstantiatesCanonical
    /// </summary>
    public List<Element> _InstantiatesCanonical { get; set; }
    /// <summary>
    /// The URL pointing to an externally maintained protocol, guideline, orderset or other definition that is adhered to in whole or in part by this MedicationAdministration.
    /// </summary>
    public List<string> InstantiatesUri { get; set; }
    /// <summary>
    /// Extension container element for InstantiatesUri
    /// </summary>
    public List<Element> _InstantiatesUri { get; set; }
    /// <summary>
    /// If only a code is specified, then it needs to be a code for a specific product. If more information is required, then the use of the medication resource is recommended.  For example, if you require form or lot number, then you must reference the Medication resource.
    /// </summary>
    public CodeableReference Medication { get; set; }
    /// <summary>
    /// Extra information about the medication administration that is not conveyed by the other attributes.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// A specific date/time or interval of time during which the administration took place (or did not take place). For many administrations, such as swallowing a tablet the use of dateTime is more appropriate.
    /// </summary>
    public string OccurenceDateTime { get; set; }
    /// <summary>
    /// Extension container element for OccurenceDateTime
    /// </summary>
    public Element _OccurenceDateTime { get; set; }
    /// <summary>
    /// A specific date/time or interval of time during which the administration took place (or did not take place). For many administrations, such as swallowing a tablet the use of dateTime is more appropriate.
    /// </summary>
    public Period OccurencePeriod { get; set; }
    /// <summary>
    /// A larger event of which this particular event is a component or step.
    /// </summary>
    public List<Reference> PartOf { get; set; }
    /// <summary>
    /// Indicates who or what performed the medication administration and how they were involved.
    /// </summary>
    public List<MedicationAdministrationPerformer> Performer { get; set; }
    /// <summary>
    /// A code, Condition or observation that supports why the medication was administered.
    /// </summary>
    public List<CodeableReference> Reason { get; set; }
    /// <summary>
    /// The date the occurrence of the  MedicationAdministration was first captured in the record - potentially significantly after the occurrence of the event.
    /// </summary>
    public string Recorded { get; set; }
    /// <summary>
    /// Extension container element for Recorded
    /// </summary>
    public Element _Recorded { get; set; }
    /// <summary>
    /// This is a reference to the MedicationRequest  where the intent is either order or instance-order.  It should not reference MedicationRequests where the intent is any other value.
    /// </summary>
    public Reference Request { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// A code indicating why the administration was not performed.
    /// </summary>
    public List<CodeableConcept> StatusReason { get; set; }
    /// <summary>
    /// The person or animal or group receiving the medication.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// Additional information (for example, patient height and weight) that supports the administration of the medication.  This attribute can be used to provide documentation of specific characteristics of the patient present at the time of administration.  For example, if the dose says "give "x" if the heartrate exceeds "y"", then the heart rate can be included using this attribute.
    /// </summary>
    public List<Reference> SupportingInformation { get; set; }
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

      if ((InstantiatesCanonical != null) && (InstantiatesCanonical.Count != 0))
      {
        writer.WritePropertyName("instantiatesCanonical");
        writer.WriteStartArray();

        foreach (string valInstantiatesCanonical in InstantiatesCanonical)
        {
          writer.WriteStringValue(valInstantiatesCanonical);
        }

        writer.WriteEndArray();
      }

      if ((_InstantiatesCanonical != null) && (_InstantiatesCanonical.Count != 0))
      {
        writer.WritePropertyName("_instantiatesCanonical");
        writer.WriteStartArray();

        foreach (Element val_InstantiatesCanonical in _InstantiatesCanonical)
        {
          val_InstantiatesCanonical.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((InstantiatesUri != null) && (InstantiatesUri.Count != 0))
      {
        writer.WritePropertyName("instantiatesUri");
        writer.WriteStartArray();

        foreach (string valInstantiatesUri in InstantiatesUri)
        {
          writer.WriteStringValue(valInstantiatesUri);
        }

        writer.WriteEndArray();
      }

      if ((_InstantiatesUri != null) && (_InstantiatesUri.Count != 0))
      {
        writer.WritePropertyName("_instantiatesUri");
        writer.WriteStartArray();

        foreach (Element val_InstantiatesUri in _InstantiatesUri)
        {
          val_InstantiatesUri.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((BasedOn != null) && (BasedOn.Count != 0))
      {
        writer.WritePropertyName("basedOn");
        writer.WriteStartArray();

        foreach (Reference valBasedOn in BasedOn)
        {
          valBasedOn.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((PartOf != null) && (PartOf.Count != 0))
      {
        writer.WritePropertyName("partOf");
        writer.WriteStartArray();

        foreach (Reference valPartOf in PartOf)
        {
          valPartOf.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
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

      if ((StatusReason != null) && (StatusReason.Count != 0))
      {
        writer.WritePropertyName("statusReason");
        writer.WriteStartArray();

        foreach (CodeableConcept valStatusReason in StatusReason)
        {
          valStatusReason.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Category != null) && (Category.Count != 0))
      {
        writer.WritePropertyName("category");
        writer.WriteStartArray();

        foreach (CodeableConcept valCategory in Category)
        {
          valCategory.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Medication != null)
      {
        writer.WritePropertyName("medication");
        Medication.SerializeJson(writer, options);
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(writer, options);
      }

      if ((SupportingInformation != null) && (SupportingInformation.Count != 0))
      {
        writer.WritePropertyName("supportingInformation");
        writer.WriteStartArray();

        foreach (Reference valSupportingInformation in SupportingInformation)
        {
          valSupportingInformation.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(OccurenceDateTime))
      {
        writer.WriteString("occurenceDateTime", (string)OccurenceDateTime!);
      }

      if (_OccurenceDateTime != null)
      {
        writer.WritePropertyName("_occurenceDateTime");
        _OccurenceDateTime.SerializeJson(writer, options);
      }

      if (OccurencePeriod != null)
      {
        writer.WritePropertyName("occurencePeriod");
        OccurencePeriod.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Recorded))
      {
        writer.WriteString("recorded", (string)Recorded!);
      }

      if (_Recorded != null)
      {
        writer.WritePropertyName("_recorded");
        _Recorded.SerializeJson(writer, options);
      }

      if ((Performer != null) && (Performer.Count != 0))
      {
        writer.WritePropertyName("performer");
        writer.WriteStartArray();

        foreach (MedicationAdministrationPerformer valPerformer in Performer)
        {
          valPerformer.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Reason != null) && (Reason.Count != 0))
      {
        writer.WritePropertyName("reason");
        writer.WriteStartArray();

        foreach (CodeableReference valReason in Reason)
        {
          valReason.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Request != null)
      {
        writer.WritePropertyName("request");
        Request.SerializeJson(writer, options);
      }

      if ((Device != null) && (Device.Count != 0))
      {
        writer.WritePropertyName("device");
        writer.WriteStartArray();

        foreach (Reference valDevice in Device)
        {
          valDevice.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Note != null) && (Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();

        foreach (Annotation valNote in Note)
        {
          valNote.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Dosage != null)
      {
        writer.WritePropertyName("dosage");
        Dosage.SerializeJson(writer, options);
      }

      if ((EventHistory != null) && (EventHistory.Count != 0))
      {
        writer.WritePropertyName("eventHistory");
        writer.WriteStartArray();

        foreach (Reference valEventHistory in EventHistory)
        {
          valEventHistory.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
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
        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          BasedOn = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objBasedOn = new fhirCsR5.Models.Reference();
            objBasedOn.DeserializeJson(ref reader, options);
            BasedOn.Add(objBasedOn);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (BasedOn.Count == 0)
          {
            BasedOn = null;
          }

          break;

        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objCategory = new fhirCsR5.Models.CodeableConcept();
            objCategory.DeserializeJson(ref reader, options);
            Category.Add(objCategory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Category.Count == 0)
          {
            Category = null;
          }

          break;

        case "device":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Device = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objDevice = new fhirCsR5.Models.Reference();
            objDevice.DeserializeJson(ref reader, options);
            Device.Add(objDevice);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Device.Count == 0)
          {
            Device = null;
          }

          break;

        case "dosage":
          Dosage = new fhirCsR5.Models.MedicationAdministrationDosage();
          Dosage.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          Encounter = new fhirCsR5.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
          break;

        case "eventHistory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          EventHistory = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objEventHistory = new fhirCsR5.Models.Reference();
            objEventHistory.DeserializeJson(ref reader, options);
            EventHistory.Add(objEventHistory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (EventHistory.Count == 0)
          {
            EventHistory = null;
          }

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

        case "instantiatesCanonical":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          InstantiatesCanonical = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            InstantiatesCanonical.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (InstantiatesCanonical.Count == 0)
          {
            InstantiatesCanonical = null;
          }

          break;

        case "_instantiatesCanonical":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _InstantiatesCanonical = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_InstantiatesCanonical = new fhirCsR5.Models.Element();
            obj_InstantiatesCanonical.DeserializeJson(ref reader, options);
            _InstantiatesCanonical.Add(obj_InstantiatesCanonical);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_InstantiatesCanonical.Count == 0)
          {
            _InstantiatesCanonical = null;
          }

          break;

        case "instantiatesUri":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          InstantiatesUri = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            InstantiatesUri.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (InstantiatesUri.Count == 0)
          {
            InstantiatesUri = null;
          }

          break;

        case "_instantiatesUri":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _InstantiatesUri = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_InstantiatesUri = new fhirCsR5.Models.Element();
            obj_InstantiatesUri.DeserializeJson(ref reader, options);
            _InstantiatesUri.Add(obj_InstantiatesUri);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_InstantiatesUri.Count == 0)
          {
            _InstantiatesUri = null;
          }

          break;

        case "medication":
          Medication = new fhirCsR5.Models.CodeableReference();
          Medication.DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Annotation objNote = new fhirCsR5.Models.Annotation();
            objNote.DeserializeJson(ref reader, options);
            Note.Add(objNote);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Note.Count == 0)
          {
            Note = null;
          }

          break;

        case "occurenceDateTime":
          OccurenceDateTime = reader.GetString();
          break;

        case "_occurenceDateTime":
          _OccurenceDateTime = new fhirCsR5.Models.Element();
          _OccurenceDateTime.DeserializeJson(ref reader, options);
          break;

        case "occurencePeriod":
          OccurencePeriod = new fhirCsR5.Models.Period();
          OccurencePeriod.DeserializeJson(ref reader, options);
          break;

        case "partOf":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PartOf = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objPartOf = new fhirCsR5.Models.Reference();
            objPartOf.DeserializeJson(ref reader, options);
            PartOf.Add(objPartOf);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PartOf.Count == 0)
          {
            PartOf = null;
          }

          break;

        case "performer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Performer = new List<MedicationAdministrationPerformer>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.MedicationAdministrationPerformer objPerformer = new fhirCsR5.Models.MedicationAdministrationPerformer();
            objPerformer.DeserializeJson(ref reader, options);
            Performer.Add(objPerformer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Performer.Count == 0)
          {
            Performer = null;
          }

          break;

        case "reason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Reason = new List<CodeableReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableReference objReason = new fhirCsR5.Models.CodeableReference();
            objReason.DeserializeJson(ref reader, options);
            Reason.Add(objReason);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Reason.Count == 0)
          {
            Reason = null;
          }

          break;

        case "recorded":
          Recorded = reader.GetString();
          break;

        case "_recorded":
          _Recorded = new fhirCsR5.Models.Element();
          _Recorded.DeserializeJson(ref reader, options);
          break;

        case "request":
          Request = new fhirCsR5.Models.Reference();
          Request.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR5.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "statusReason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          StatusReason = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objStatusReason = new fhirCsR5.Models.CodeableConcept();
            objStatusReason.DeserializeJson(ref reader, options);
            StatusReason.Add(objStatusReason);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (StatusReason.Count == 0)
          {
            StatusReason = null;
          }

          break;

        case "subject":
          Subject = new fhirCsR5.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "supportingInformation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SupportingInformation = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objSupportingInformation = new fhirCsR5.Models.Reference();
            objSupportingInformation.DeserializeJson(ref reader, options);
            SupportingInformation.Add(objSupportingInformation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SupportingInformation.Count == 0)
          {
            SupportingInformation = null;
          }

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
  /// Code Values for the MedicationAdministration.status field
  /// </summary>
  public static class MedicationAdministrationStatusCodes {
    public const string IN_PROGRESS = "in-progress";
    public const string NOT_DONE = "not-done";
    public const string ON_HOLD = "on-hold";
    public const string COMPLETED = "completed";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string STOPPED = "stopped";
    public const string UNKNOWN = "unknown";
  }
}
