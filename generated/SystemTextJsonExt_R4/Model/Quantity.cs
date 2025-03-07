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
  /// JSON Serialization Extensions for Quantity
  /// </summary>
  public static class QuantityJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Quantity into JSON
    /// </summary>
    public static void SerializeJson(this Quantity current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Complex: Quantity, Export: Quantity, Base: Element (Element)
      ((Hl7.Fhir.Model.Element)current).SerializeJson(writer, options, false);

      if (current.ValueElement != null)
      {
        if (current.ValueElement.Value != null)
        {
          writer.WriteNumber("value",(decimal)current.ValueElement.Value);
        }
        if (current.ValueElement.HasExtensions() || (!string.IsNullOrEmpty(current.ValueElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_value",false,current.ValueElement.Extension,current.ValueElement.ElementId);
        }
      }

      if (current.ComparatorElement != null)
      {
        if (current.ComparatorElement.Value != null)
        {
          writer.WriteString("comparator",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.ComparatorElement.Value));
        }
        if (current.ComparatorElement.HasExtensions() || (!string.IsNullOrEmpty(current.ComparatorElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_comparator",false,current.ComparatorElement.Extension,current.ComparatorElement.ElementId);
        }
      }

      if (current.UnitElement != null)
      {
        if (!string.IsNullOrEmpty(current.UnitElement.Value))
        {
          writer.WriteString("unit",current.UnitElement.Value);
        }
        if (current.UnitElement.HasExtensions() || (!string.IsNullOrEmpty(current.UnitElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_unit",false,current.UnitElement.Extension,current.UnitElement.ElementId);
        }
      }

      if (current.SystemElement != null)
      {
        if (!string.IsNullOrEmpty(current.SystemElement.Value))
        {
          writer.WriteString("system",current.SystemElement.Value);
        }
        if (current.SystemElement.HasExtensions() || (!string.IsNullOrEmpty(current.SystemElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_system",false,current.SystemElement.Extension,current.SystemElement.ElementId);
        }
      }

      if (current.CodeElement != null)
      {
        if (!string.IsNullOrEmpty(current.CodeElement.Value))
        {
          writer.WriteString("code",current.CodeElement.Value.Trim());
        }
        if (current.CodeElement.HasExtensions() || (!string.IsNullOrEmpty(current.CodeElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_code",false,current.CodeElement.Extension,current.CodeElement.ElementId);
        }
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Quantity
    /// </summary>
    public static void DeserializeJson(this Quantity current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"Quantity >>> Quantity.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"Quantity: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Quantity
    /// </summary>
    public static void DeserializeJsonProperty(this Quantity current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "value":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ValueElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.ValueElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_value":
          if (current.ValueElement == null) { current.ValueElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.ValueElement).DeserializeJson(ref reader, options);
          break;

        case "comparator":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ComparatorElement = new Code<Hl7.Fhir.Model.Age.QuantityComparator>();
            reader.Skip();
          }
          else
          {
            current.ComparatorElement = new Code<Hl7.Fhir.Model.Age.QuantityComparator>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.Age.QuantityComparator>(reader.GetString()));
          }
          break;

        case "_comparator":
          if (current.ComparatorElement == null) { current.ComparatorElement = new Code<Hl7.Fhir.Model.Age.QuantityComparator>(); }
          ((Hl7.Fhir.Model.Element)current.ComparatorElement).DeserializeJson(ref reader, options);
          break;

        case "unit":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.UnitElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.UnitElement = new FhirString(reader.GetString());
          }
          break;

        case "_unit":
          if (current.UnitElement == null) { current.UnitElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.UnitElement).DeserializeJson(ref reader, options);
          break;

        case "system":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.SystemElement = new FhirUri();
            reader.Skip();
          }
          else
          {
            current.SystemElement = new FhirUri(reader.GetString());
          }
          break;

        case "_system":
          if (current.SystemElement == null) { current.SystemElement = new FhirUri(); }
          ((Hl7.Fhir.Model.Element)current.SystemElement).DeserializeJson(ref reader, options);
          break;

        case "code":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.CodeElement = new Code();
            reader.Skip();
          }
          else
          {
            current.CodeElement = new Code(reader.GetString());
          }
          break;

        case "_code":
          if (current.CodeElement == null) { current.CodeElement = new Code(); }
          ((Hl7.Fhir.Model.Element)current.CodeElement).DeserializeJson(ref reader, options);
          break;

        // Complex: Quantity, Export: Quantity, Base: Element
        default:
          ((Hl7.Fhir.Model.Element)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class QuantityJsonConverter : JsonConverter<Quantity>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Quantity value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Quantity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Quantity target = new Quantity();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
