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
  /// JSON Serialization Extensions for ObservationDefinition
  /// </summary>
  public static class ObservationDefinitionJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR ObservationDefinition into JSON
    /// </summary>
    public static void SerializeJson(this ObservationDefinition current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","ObservationDefinition");
      // Complex: ObservationDefinition, Export: ObservationDefinition, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Category != null) && (current.Category.Count != 0))
      {
        writer.WritePropertyName("category");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Category)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      writer.WritePropertyName("code");
      current.Code.SerializeJson(writer, options);

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

      if ((current.PermittedDataTypeElement != null) && (current.PermittedDataTypeElement.Count != 0))
      {
        int valueCount = 0;
        int extensionCount = 0;
        foreach (Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType> val in current.PermittedDataTypeElement)
        {
          if (val.Value != null) { valueCount++; }
          if (val.HasExtensions()) { extensionCount++; }
        }

        if (valueCount > 0)
        {
          writer.WritePropertyName("permittedDataType");
          writer.WriteStartArray();
          foreach (Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType> val in current.PermittedDataTypeElement)
          {
            if (val.Value == null)
            {
              writer.WriteNullValue();
            }
            else
            {
              writer.WriteStringValue(Hl7.Fhir.Utility.EnumUtility.GetLiteral(val.Value));
            }
          }

          writer.WriteEndArray();
        }

        if (extensionCount > 0)
        {
          writer.WritePropertyName("_permittedDataType");
          writer.WriteStartArray();
          foreach (Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType> val in current.PermittedDataTypeElement)
          {
            if (val.HasExtensions() || (!string.IsNullOrEmpty(val.ElementId)))
            {
              JsonStreamUtilities.SerializeExtensionList(writer,options,string.Empty,true,val.Extension,val.ElementId);
            }
            else
            {
              writer.WriteNullValue();
            }

          }

          writer.WriteEndArray();
        }
      }

      if (current.MultipleResultsAllowedElement != null)
      {
        if (current.MultipleResultsAllowedElement.Value != null)
        {
          writer.WriteBoolean("multipleResultsAllowed",(bool)current.MultipleResultsAllowedElement.Value);
        }
        if (current.MultipleResultsAllowedElement.HasExtensions() || (!string.IsNullOrEmpty(current.MultipleResultsAllowedElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_multipleResultsAllowed",false,current.MultipleResultsAllowedElement.Extension,current.MultipleResultsAllowedElement.ElementId);
        }
      }

      if (current.Method != null)
      {
        writer.WritePropertyName("method");
        current.Method.SerializeJson(writer, options);
      }

      if (current.PreferredReportNameElement != null)
      {
        if (!string.IsNullOrEmpty(current.PreferredReportNameElement.Value))
        {
          writer.WriteString("preferredReportName",current.PreferredReportNameElement.Value);
        }
        if (current.PreferredReportNameElement.HasExtensions() || (!string.IsNullOrEmpty(current.PreferredReportNameElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_preferredReportName",false,current.PreferredReportNameElement.Extension,current.PreferredReportNameElement.ElementId);
        }
      }

      if (current.QuantitativeDetails != null)
      {
        writer.WritePropertyName("quantitativeDetails");
        current.QuantitativeDetails.SerializeJson(writer, options);
      }

      if ((current.QualifiedInterval != null) && (current.QualifiedInterval.Count != 0))
      {
        writer.WritePropertyName("qualifiedInterval");
        writer.WriteStartArray();
        foreach (ObservationDefinition.QualifiedIntervalComponent val in current.QualifiedInterval)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.ValidCodedValueSet != null)
      {
        writer.WritePropertyName("validCodedValueSet");
        current.ValidCodedValueSet.SerializeJson(writer, options);
      }

      if (current.NormalCodedValueSet != null)
      {
        writer.WritePropertyName("normalCodedValueSet");
        current.NormalCodedValueSet.SerializeJson(writer, options);
      }

      if (current.AbnormalCodedValueSet != null)
      {
        writer.WritePropertyName("abnormalCodedValueSet");
        current.AbnormalCodedValueSet.SerializeJson(writer, options);
      }

      if (current.CriticalCodedValueSet != null)
      {
        writer.WritePropertyName("criticalCodedValueSet");
        current.CriticalCodedValueSet.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ObservationDefinition
    /// </summary>
    public static void DeserializeJson(this ObservationDefinition current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"ObservationDefinition >>> ObservationDefinition.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"ObservationDefinition: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ObservationDefinition
    /// </summary>
    public static void DeserializeJsonProperty(this ObservationDefinition current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ObservationDefinition error reading 'category' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Category = new Hl7.Fhir.Model.CodeableConcept();
            v_Category.DeserializeJson(ref reader, options);
            current.Category.Add(v_Category);

            if (!reader.Read())
            {
              throw new JsonException($"ObservationDefinition error reading 'category' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Category.Count == 0)
          {
            current.Category = null;
          }
          break;

        case "code":
          current.Code = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Code).DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ObservationDefinition error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"ObservationDefinition error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "permittedDataType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ObservationDefinition error reading 'permittedDataType' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.PermittedDataTypeElement = new List<Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.PermittedDataTypeElement.Add(new Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>());
              reader.Skip();
            }
            else
            {
              current.PermittedDataTypeElement.Add(new Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>(reader.GetString())));
            }

            if (!reader.Read())
            {
              throw new JsonException($"ObservationDefinition error reading 'permittedDataType' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PermittedDataTypeElement.Count == 0)
          {
            current.PermittedDataTypeElement = null;
          }
          break;

        case "_permittedDataType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ObservationDefinition error reading 'permittedDataType' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_permittedDataType = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_permittedDataType >= current.PermittedDataTypeElement.Count)
            {
              current.PermittedDataTypeElement.Add(new Code<Hl7.Fhir.Model.ObservationDefinition.ObservationDataType>());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.PermittedDataTypeElement[i_permittedDataType++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"ObservationDefinition error reading 'permittedDataType' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "multipleResultsAllowed":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.MultipleResultsAllowedElement = new FhirBoolean();
            reader.Skip();
          }
          else
          {
            current.MultipleResultsAllowedElement = new FhirBoolean(reader.GetBoolean());
          }
          break;

        case "_multipleResultsAllowed":
          if (current.MultipleResultsAllowedElement == null) { current.MultipleResultsAllowedElement = new FhirBoolean(); }
          ((Hl7.Fhir.Model.Element)current.MultipleResultsAllowedElement).DeserializeJson(ref reader, options);
          break;

        case "method":
          current.Method = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Method).DeserializeJson(ref reader, options);
          break;

        case "preferredReportName":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.PreferredReportNameElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.PreferredReportNameElement = new FhirString(reader.GetString());
          }
          break;

        case "_preferredReportName":
          if (current.PreferredReportNameElement == null) { current.PreferredReportNameElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.PreferredReportNameElement).DeserializeJson(ref reader, options);
          break;

        case "quantitativeDetails":
          current.QuantitativeDetails = new Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent();
          ((Hl7.Fhir.Model.ObservationDefinition.QuantitativeDetailsComponent)current.QuantitativeDetails).DeserializeJson(ref reader, options);
          break;

        case "qualifiedInterval":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"ObservationDefinition error reading 'qualifiedInterval' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.QualifiedInterval = new List<ObservationDefinition.QualifiedIntervalComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent v_QualifiedInterval = new Hl7.Fhir.Model.ObservationDefinition.QualifiedIntervalComponent();
            v_QualifiedInterval.DeserializeJson(ref reader, options);
            current.QualifiedInterval.Add(v_QualifiedInterval);

            if (!reader.Read())
            {
              throw new JsonException($"ObservationDefinition error reading 'qualifiedInterval' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.QualifiedInterval.Count == 0)
          {
            current.QualifiedInterval = null;
          }
          break;

        case "validCodedValueSet":
          current.ValidCodedValueSet = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.ValidCodedValueSet).DeserializeJson(ref reader, options);
          break;

        case "normalCodedValueSet":
          current.NormalCodedValueSet = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.NormalCodedValueSet).DeserializeJson(ref reader, options);
          break;

        case "abnormalCodedValueSet":
          current.AbnormalCodedValueSet = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.AbnormalCodedValueSet).DeserializeJson(ref reader, options);
          break;

        case "criticalCodedValueSet":
          current.CriticalCodedValueSet = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.CriticalCodedValueSet).DeserializeJson(ref reader, options);
          break;

        // Complex: ObservationDefinition, Export: ObservationDefinition, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR ObservationDefinition#QuantitativeDetails into JSON
    /// </summary>
    public static void SerializeJson(this ObservationDefinition.QuantitativeDetailsComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: ObservationDefinition#QuantitativeDetails, Export: QuantitativeDetailsComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.CustomaryUnit != null)
      {
        writer.WritePropertyName("customaryUnit");
        current.CustomaryUnit.SerializeJson(writer, options);
      }

      if (current.Unit != null)
      {
        writer.WritePropertyName("unit");
        current.Unit.SerializeJson(writer, options);
      }

      if (current.ConversionFactorElement != null)
      {
        if (current.ConversionFactorElement.Value != null)
        {
          writer.WriteNumber("conversionFactor",(decimal)current.ConversionFactorElement.Value);
        }
        if (current.ConversionFactorElement.HasExtensions() || (!string.IsNullOrEmpty(current.ConversionFactorElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_conversionFactor",false,current.ConversionFactorElement.Extension,current.ConversionFactorElement.ElementId);
        }
      }

      if (current.DecimalPrecisionElement != null)
      {
        if (current.DecimalPrecisionElement.Value != null)
        {
          writer.WriteNumber("decimalPrecision",(int)current.DecimalPrecisionElement.Value);
        }
        if (current.DecimalPrecisionElement.HasExtensions() || (!string.IsNullOrEmpty(current.DecimalPrecisionElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_decimalPrecision",false,current.DecimalPrecisionElement.Extension,current.DecimalPrecisionElement.ElementId);
        }
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ObservationDefinition#QuantitativeDetails
    /// </summary>
    public static void DeserializeJson(this ObservationDefinition.QuantitativeDetailsComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"ObservationDefinition.QuantitativeDetailsComponent >>> ObservationDefinition#QuantitativeDetails.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"ObservationDefinition.QuantitativeDetailsComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ObservationDefinition#QuantitativeDetails
    /// </summary>
    public static void DeserializeJsonProperty(this ObservationDefinition.QuantitativeDetailsComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "customaryUnit":
          current.CustomaryUnit = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.CustomaryUnit).DeserializeJson(ref reader, options);
          break;

        case "unit":
          current.Unit = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Unit).DeserializeJson(ref reader, options);
          break;

        case "conversionFactor":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ConversionFactorElement = new FhirDecimal();
            reader.Skip();
          }
          else
          {
            current.ConversionFactorElement = new FhirDecimal(reader.GetDecimal());
          }
          break;

        case "_conversionFactor":
          if (current.ConversionFactorElement == null) { current.ConversionFactorElement = new FhirDecimal(); }
          ((Hl7.Fhir.Model.Element)current.ConversionFactorElement).DeserializeJson(ref reader, options);
          break;

        case "decimalPrecision":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DecimalPrecisionElement = new Integer();
            reader.Skip();
          }
          else
          {
            current.DecimalPrecisionElement = new Integer(reader.GetInt32());
          }
          break;

        case "_decimalPrecision":
          if (current.DecimalPrecisionElement == null) { current.DecimalPrecisionElement = new Integer(); }
          ((Hl7.Fhir.Model.Element)current.DecimalPrecisionElement).DeserializeJson(ref reader, options);
          break;

        // Complex: quantitativeDetails, Export: QuantitativeDetailsComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR ObservationDefinition#QualifiedInterval into JSON
    /// </summary>
    public static void SerializeJson(this ObservationDefinition.QualifiedIntervalComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: ObservationDefinition#QualifiedInterval, Export: QualifiedIntervalComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if (current.CategoryElement != null)
      {
        if (current.CategoryElement.Value != null)
        {
          writer.WriteString("category",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.CategoryElement.Value));
        }
        if (current.CategoryElement.HasExtensions() || (!string.IsNullOrEmpty(current.CategoryElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_category",false,current.CategoryElement.Extension,current.CategoryElement.ElementId);
        }
      }

      if (current.Range != null)
      {
        writer.WritePropertyName("range");
        current.Range.SerializeJson(writer, options);
      }

      if (current.Context != null)
      {
        writer.WritePropertyName("context");
        current.Context.SerializeJson(writer, options);
      }

      if ((current.AppliesTo != null) && (current.AppliesTo.Count != 0))
      {
        writer.WritePropertyName("appliesTo");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.AppliesTo)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.GenderElement != null)
      {
        if (current.GenderElement.Value != null)
        {
          writer.WriteString("gender",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.GenderElement.Value));
        }
        if (current.GenderElement.HasExtensions() || (!string.IsNullOrEmpty(current.GenderElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_gender",false,current.GenderElement.Extension,current.GenderElement.ElementId);
        }
      }

      if (current.Age != null)
      {
        writer.WritePropertyName("age");
        current.Age.SerializeJson(writer, options);
      }

      if (current.GestationalAge != null)
      {
        writer.WritePropertyName("gestationalAge");
        current.GestationalAge.SerializeJson(writer, options);
      }

      if (current.ConditionElement != null)
      {
        if (!string.IsNullOrEmpty(current.ConditionElement.Value))
        {
          writer.WriteString("condition",current.ConditionElement.Value);
        }
        if (current.ConditionElement.HasExtensions() || (!string.IsNullOrEmpty(current.ConditionElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_condition",false,current.ConditionElement.Extension,current.ConditionElement.ElementId);
        }
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ObservationDefinition#QualifiedInterval
    /// </summary>
    public static void DeserializeJson(this ObservationDefinition.QualifiedIntervalComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"ObservationDefinition.QualifiedIntervalComponent >>> ObservationDefinition#QualifiedInterval.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"ObservationDefinition.QualifiedIntervalComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ObservationDefinition#QualifiedInterval
    /// </summary>
    public static void DeserializeJsonProperty(this ObservationDefinition.QualifiedIntervalComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "category":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.CategoryElement = new Code<Hl7.Fhir.Model.ObservationDefinition.ObservationRangeCategory>();
            reader.Skip();
          }
          else
          {
            current.CategoryElement = new Code<Hl7.Fhir.Model.ObservationDefinition.ObservationRangeCategory>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.ObservationDefinition.ObservationRangeCategory>(reader.GetString()));
          }
          break;

        case "_category":
          if (current.CategoryElement == null) { current.CategoryElement = new Code<Hl7.Fhir.Model.ObservationDefinition.ObservationRangeCategory>(); }
          ((Hl7.Fhir.Model.Element)current.CategoryElement).DeserializeJson(ref reader, options);
          break;

        case "range":
          current.Range = new Hl7.Fhir.Model.Range();
          ((Hl7.Fhir.Model.Range)current.Range).DeserializeJson(ref reader, options);
          break;

        case "context":
          current.Context = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Context).DeserializeJson(ref reader, options);
          break;

        case "appliesTo":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"QualifiedIntervalComponent error reading 'appliesTo' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.AppliesTo = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_AppliesTo = new Hl7.Fhir.Model.CodeableConcept();
            v_AppliesTo.DeserializeJson(ref reader, options);
            current.AppliesTo.Add(v_AppliesTo);

            if (!reader.Read())
            {
              throw new JsonException($"QualifiedIntervalComponent error reading 'appliesTo' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.AppliesTo.Count == 0)
          {
            current.AppliesTo = null;
          }
          break;

        case "gender":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.GenderElement = new Code<Hl7.Fhir.Model.AdministrativeGender>();
            reader.Skip();
          }
          else
          {
            current.GenderElement = new Code<Hl7.Fhir.Model.AdministrativeGender>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.AdministrativeGender>(reader.GetString()));
          }
          break;

        case "_gender":
          if (current.GenderElement == null) { current.GenderElement = new Code<Hl7.Fhir.Model.AdministrativeGender>(); }
          ((Hl7.Fhir.Model.Element)current.GenderElement).DeserializeJson(ref reader, options);
          break;

        case "age":
          current.Age = new Hl7.Fhir.Model.Range();
          ((Hl7.Fhir.Model.Range)current.Age).DeserializeJson(ref reader, options);
          break;

        case "gestationalAge":
          current.GestationalAge = new Hl7.Fhir.Model.Range();
          ((Hl7.Fhir.Model.Range)current.GestationalAge).DeserializeJson(ref reader, options);
          break;

        case "condition":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ConditionElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.ConditionElement = new FhirString(reader.GetString());
          }
          break;

        case "_condition":
          if (current.ConditionElement == null) { current.ConditionElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.ConditionElement).DeserializeJson(ref reader, options);
          break;

        // Complex: qualifiedInterval, Export: QualifiedIntervalComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class ObservationDefinitionJsonConverter : JsonConverter<ObservationDefinition>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, ObservationDefinition value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override ObservationDefinition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        ObservationDefinition target = new ObservationDefinition();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
