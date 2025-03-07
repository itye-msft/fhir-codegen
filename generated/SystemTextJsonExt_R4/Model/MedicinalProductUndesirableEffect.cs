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
  /// JSON Serialization Extensions for MedicinalProductUndesirableEffect
  /// </summary>
  public static class MedicinalProductUndesirableEffectJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR MedicinalProductUndesirableEffect into JSON
    /// </summary>
    public static void SerializeJson(this MedicinalProductUndesirableEffect current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","MedicinalProductUndesirableEffect");
      // Complex: MedicinalProductUndesirableEffect, Export: MedicinalProductUndesirableEffect, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Subject != null) && (current.Subject.Count != 0))
      {
        writer.WritePropertyName("subject");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Subject)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.SymptomConditionEffect != null)
      {
        writer.WritePropertyName("symptomConditionEffect");
        current.SymptomConditionEffect.SerializeJson(writer, options);
      }

      if (current.Classification != null)
      {
        writer.WritePropertyName("classification");
        current.Classification.SerializeJson(writer, options);
      }

      if (current.FrequencyOfOccurrence != null)
      {
        writer.WritePropertyName("frequencyOfOccurrence");
        current.FrequencyOfOccurrence.SerializeJson(writer, options);
      }

      if ((current.Population != null) && (current.Population.Count != 0))
      {
        writer.WritePropertyName("population");
        writer.WriteStartArray();
        foreach (Population val in current.Population)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductUndesirableEffect
    /// </summary>
    public static void DeserializeJson(this MedicinalProductUndesirableEffect current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"MedicinalProductUndesirableEffect >>> MedicinalProductUndesirableEffect.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"MedicinalProductUndesirableEffect: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR MedicinalProductUndesirableEffect
    /// </summary>
    public static void DeserializeJsonProperty(this MedicinalProductUndesirableEffect current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "subject":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductUndesirableEffect error reading 'subject' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Subject = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Subject = new Hl7.Fhir.Model.ResourceReference();
            v_Subject.DeserializeJson(ref reader, options);
            current.Subject.Add(v_Subject);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductUndesirableEffect error reading 'subject' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Subject.Count == 0)
          {
            current.Subject = null;
          }
          break;

        case "symptomConditionEffect":
          current.SymptomConditionEffect = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.SymptomConditionEffect).DeserializeJson(ref reader, options);
          break;

        case "classification":
          current.Classification = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Classification).DeserializeJson(ref reader, options);
          break;

        case "frequencyOfOccurrence":
          current.FrequencyOfOccurrence = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.FrequencyOfOccurrence).DeserializeJson(ref reader, options);
          break;

        case "population":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"MedicinalProductUndesirableEffect error reading 'population' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Population = new List<Population>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Population v_Population = new Hl7.Fhir.Model.Population();
            v_Population.DeserializeJson(ref reader, options);
            current.Population.Add(v_Population);

            if (!reader.Read())
            {
              throw new JsonException($"MedicinalProductUndesirableEffect error reading 'population' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Population.Count == 0)
          {
            current.Population = null;
          }
          break;

        // Complex: MedicinalProductUndesirableEffect, Export: MedicinalProductUndesirableEffect, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class MedicinalProductUndesirableEffectJsonConverter : JsonConverter<MedicinalProductUndesirableEffect>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, MedicinalProductUndesirableEffect value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override MedicinalProductUndesirableEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        MedicinalProductUndesirableEffect target = new MedicinalProductUndesirableEffect();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
