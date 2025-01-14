// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.JsonExtensions;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model.JsonExtensions
{
  /// <summary>
  /// JSON Serialization Extensions for Slot
  /// </summary>
  public static class SlotJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Slot into JSON
    /// </summary>
    public static void SerializeJson(this Slot current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Slot");
      // Complex: Slot, Export: Slot, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Identifier != null) && (current.Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();
        foreach (Identifier val in current.Identifier)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ServiceCategory != null) && (current.ServiceCategory.Count != 0))
      {
        writer.WritePropertyName("serviceCategory");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.ServiceCategory)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.ServiceType != null) && (current.ServiceType.Count != 0))
      {
        writer.WritePropertyName("serviceType");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.ServiceType)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Specialty != null) && (current.Specialty.Count != 0))
      {
        writer.WritePropertyName("specialty");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Specialty)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.AppointmentType != null)
      {
        writer.WritePropertyName("appointmentType");
        current.AppointmentType.SerializeJson(writer, options);
      }

      writer.WritePropertyName("schedule");
      current.Schedule.SerializeJson(writer, options);

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      writer.WriteString("start",((DateTimeOffset)current.StartElement.Value).ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK",System.Globalization.CultureInfo.InvariantCulture));

      writer.WriteString("end",((DateTimeOffset)current.EndElement.Value).ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK",System.Globalization.CultureInfo.InvariantCulture));

      if (current.OverbookedElement != null)
      {
        if (current.OverbookedElement.Value != null)
        {
          writer.WriteBoolean("overbooked",(bool)current.OverbookedElement.Value);
        }
        if (current.OverbookedElement.HasExtensions() || (!string.IsNullOrEmpty(current.OverbookedElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_overbooked",false,current.OverbookedElement.Extension,current.OverbookedElement.ElementId);
        }
      }

      if (current.CommentElement != null)
      {
        if (!string.IsNullOrEmpty(current.CommentElement.Value))
        {
          writer.WriteString("comment",current.CommentElement.Value);
        }
        if (current.CommentElement.HasExtensions() || (!string.IsNullOrEmpty(current.CommentElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_comment",false,current.CommentElement.Extension,current.CommentElement.ElementId);
        }
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Slot
    /// </summary>
    public static void DeserializeJson(this Slot current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Slot >>> Slot.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Slot: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Slot
    /// </summary>
    public static void DeserializeJsonProperty(this Slot current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Slot error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"Slot error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "serviceCategory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Slot error reading 'serviceCategory' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ServiceCategory = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_ServiceCategory = new Hl7.Fhir.Model.CodeableConcept();
            v_ServiceCategory.DeserializeJson(ref reader, options);
            current.ServiceCategory.Add(v_ServiceCategory);

            if (!reader.Read())
            {
              throw new JsonException($"Slot error reading 'serviceCategory' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ServiceCategory.Count == 0)
          {
            current.ServiceCategory = null;
          }
          break;

        case "serviceType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Slot error reading 'serviceType' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ServiceType = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_ServiceType = new Hl7.Fhir.Model.CodeableConcept();
            v_ServiceType.DeserializeJson(ref reader, options);
            current.ServiceType.Add(v_ServiceType);

            if (!reader.Read())
            {
              throw new JsonException($"Slot error reading 'serviceType' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ServiceType.Count == 0)
          {
            current.ServiceType = null;
          }
          break;

        case "specialty":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"Slot error reading 'specialty' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Specialty = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Specialty = new Hl7.Fhir.Model.CodeableConcept();
            v_Specialty.DeserializeJson(ref reader, options);
            current.Specialty.Add(v_Specialty);

            if (!reader.Read())
            {
              throw new JsonException($"Slot error reading 'specialty' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Specialty.Count == 0)
          {
            current.Specialty = null;
          }
          break;

        case "appointmentType":
          current.AppointmentType = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.AppointmentType).DeserializeJson(ref reader, options);
          break;

        case "schedule":
          current.Schedule = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Schedule).DeserializeJson(ref reader, options);
          break;

        case "status":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Slot.SlotStatus>();
            reader.Skip();
          }
          else
          {
            current.StatusElement = new Code<Hl7.Fhir.Model.Slot.SlotStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Slot.SlotStatus>(reader.GetString()));
          }
          break;

        case "_status":
          if (current.StatusElement == null) { current.StatusElement = new Code<Hl7.Fhir.Model.Slot.SlotStatus>(); }
          ((Hl7.Fhir.Model.Element)current.StatusElement).DeserializeJson(ref reader, options);
          break;

        case "start":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StartElement = new Instant();
            reader.Skip();
          }
          else
          {
            current.StartElement = new Instant(DateTimeOffset.Parse(reader.GetString()));
          }
          break;

        case "_start":
          if (current.StartElement == null) { current.StartElement = new Instant(); }
          ((Hl7.Fhir.Model.Element)current.StartElement).DeserializeJson(ref reader, options);
          break;

        case "end":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.EndElement = new Instant();
            reader.Skip();
          }
          else
          {
            current.EndElement = new Instant(DateTimeOffset.Parse(reader.GetString()));
          }
          break;

        case "_end":
          if (current.EndElement == null) { current.EndElement = new Instant(); }
          ((Hl7.Fhir.Model.Element)current.EndElement).DeserializeJson(ref reader, options);
          break;

        case "overbooked":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.OverbookedElement = new FhirBoolean();
            reader.Skip();
          }
          else
          {
            current.OverbookedElement = new FhirBoolean(reader.GetBoolean());
          }
          break;

        case "_overbooked":
          if (current.OverbookedElement == null) { current.OverbookedElement = new FhirBoolean(); }
          ((Hl7.Fhir.Model.Element)current.OverbookedElement).DeserializeJson(ref reader, options);
          break;

        case "comment":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.CommentElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.CommentElement = new FhirString(reader.GetString());
          }
          break;

        case "_comment":
          if (current.CommentElement == null) { current.CommentElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.CommentElement).DeserializeJson(ref reader, options);
          break;

        // Complex: Slot, Export: Slot, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class SlotJsonConverter : JsonConverter<Slot>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Slot value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Slot Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Slot target = new Slot();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
