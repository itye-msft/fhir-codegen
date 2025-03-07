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
  /// JSON Serialization Extensions for Annotation
  /// </summary>
  public static class AnnotationJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Annotation into JSON
    /// </summary>
    public static void SerializeJson(this Annotation current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Complex: Annotation, Export: Annotation, Base: Element (Element)
      ((Hl7.Fhir.Model.Element)current).SerializeJson(writer, options, false);

      if (current.Author != null)
      {
        switch (current.Author)
        {
          case ResourceReference v_ResourceReference:
            writer.WritePropertyName("authorReference");
            v_ResourceReference.SerializeJson(writer, options);
            break;
          case FhirString v_FhirString:
            if (v_FhirString != null)
            {
              if (!string.IsNullOrEmpty(v_FhirString.Value))
              {
                writer.WriteString("authorString",v_FhirString.Value);
              }
              if (v_FhirString.HasExtensions() || (!string.IsNullOrEmpty(v_FhirString.ElementId)))
              {
                JsonStreamUtilities.SerializeExtensionList(writer,options,"_authorString",false,v_FhirString.Extension,v_FhirString.ElementId);
              }
            }
            break;
        }
      }
      if (current.TimeElement != null)
      {
        if (!string.IsNullOrEmpty(current.TimeElement.Value))
        {
          writer.WriteString("time",current.TimeElement.Value);
        }
        if (current.TimeElement.HasExtensions() || (!string.IsNullOrEmpty(current.TimeElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_time",false,current.TimeElement.Extension,current.TimeElement.ElementId);
        }
      }

      writer.WriteString("text",current.Text.Value);

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Annotation
    /// </summary>
    public static void DeserializeJson(this Annotation current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Annotation >>> Annotation.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Annotation: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Annotation
    /// </summary>
    public static void DeserializeJsonProperty(this Annotation current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "authorReference":
          current.Author = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Author).DeserializeJson(ref reader, options);
          break;

        case "authorString":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Author = new FhirString();
            reader.Skip();
          }
          else
          {
            current.Author = new FhirString(reader.GetString());
          }
          break;

        case "_authorString":
          if (current.Author == null) { current.Author = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.Author).DeserializeJson(ref reader, options);
          break;

        case "time":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.TimeElement = new FhirDateTime();
            reader.Skip();
          }
          else
          {
            current.TimeElement = new FhirDateTime(reader.GetString());
          }
          break;

        case "_time":
          if (current.TimeElement == null) { current.TimeElement = new FhirDateTime(); }
          ((Hl7.Fhir.Model.Element)current.TimeElement).DeserializeJson(ref reader, options);
          break;

        case "text":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.Text = new Markdown();
            reader.Skip();
          }
          else
          {
            current.Text = new Markdown(reader.GetString());
          }
          break;

        case "_text":
          if (current.Text == null) { current.Text = new Markdown(); }
          ((Hl7.Fhir.Model.Element)current.Text).DeserializeJson(ref reader, options);
          break;

        // Complex: Annotation, Export: Annotation, Base: Element
        default:
          ((Hl7.Fhir.Model.Element)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class AnnotationJsonConverter : JsonConverter<Annotation>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Annotation value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Annotation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Annotation target = new Annotation();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
