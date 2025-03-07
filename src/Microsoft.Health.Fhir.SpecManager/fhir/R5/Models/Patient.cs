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
  /// Contact covers all kinds of contact parties: family members, business contacts, guardians, caregivers. Not applicable to register pedigree and family ties beyond use of having contact.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<PatientContact>))]
  public class PatientContact : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Address for the contact person.
    /// </summary>
    public Address Address { get; set; }
    /// <summary>
    /// Administrative Gender - the gender that the contact person is considered to have for administration and record keeping purposes.
    /// </summary>
    public string Gender { get; set; }
    /// <summary>
    /// Extension container element for Gender
    /// </summary>
    public Element _Gender { get; set; }
    /// <summary>
    /// A name associated with the contact person.
    /// </summary>
    public HumanName Name { get; set; }
    /// <summary>
    /// Organization on behalf of which the contact is acting or for which the contact is working.
    /// </summary>
    public Reference Organization { get; set; }
    /// <summary>
    /// The period during which this contact person or organization is valid to be contacted relating to this patient.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// The nature of the relationship between the patient and the contact person.
    /// </summary>
    public List<CodeableConcept> Relationship { get; set; }
    /// <summary>
    /// Contact may have multiple ways to be contacted with different uses or applicable periods.  May need to have options for contacting the person urgently, and also to help with identification.
    /// </summary>
    public List<ContactPoint> Telecom { get; set; }
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

      if ((Relationship != null) && (Relationship.Count != 0))
      {
        writer.WritePropertyName("relationship");
        writer.WriteStartArray();

        foreach (CodeableConcept valRelationship in Relationship)
        {
          valRelationship.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Name != null)
      {
        writer.WritePropertyName("name");
        Name.SerializeJson(writer, options);
      }

      if ((Telecom != null) && (Telecom.Count != 0))
      {
        writer.WritePropertyName("telecom");
        writer.WriteStartArray();

        foreach (ContactPoint valTelecom in Telecom)
        {
          valTelecom.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Address != null)
      {
        writer.WritePropertyName("address");
        Address.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Gender))
      {
        writer.WriteString("gender", (string)Gender!);
      }

      if (_Gender != null)
      {
        writer.WritePropertyName("_gender");
        _Gender.SerializeJson(writer, options);
      }

      if (Organization != null)
      {
        writer.WritePropertyName("organization");
        Organization.SerializeJson(writer, options);
      }

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
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
        case "address":
          Address = new fhirCsR5.Models.Address();
          Address.DeserializeJson(ref reader, options);
          break;

        case "gender":
          Gender = reader.GetString();
          break;

        case "_gender":
          _Gender = new fhirCsR5.Models.Element();
          _Gender.DeserializeJson(ref reader, options);
          break;

        case "name":
          Name = new fhirCsR5.Models.HumanName();
          Name.DeserializeJson(ref reader, options);
          break;

        case "organization":
          Organization = new fhirCsR5.Models.Reference();
          Organization.DeserializeJson(ref reader, options);
          break;

        case "period":
          Period = new fhirCsR5.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "relationship":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Relationship = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objRelationship = new fhirCsR5.Models.CodeableConcept();
            objRelationship.DeserializeJson(ref reader, options);
            Relationship.Add(objRelationship);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Relationship.Count == 0)
          {
            Relationship = null;
          }

          break;

        case "telecom":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Telecom = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.ContactPoint objTelecom = new fhirCsR5.Models.ContactPoint();
            objTelecom.DeserializeJson(ref reader, options);
            Telecom.Add(objTelecom);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Telecom.Count == 0)
          {
            Telecom = null;
          }

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
  /// Code Values for the Patient.contact.gender field
  /// </summary>
  public static class PatientContactGenderCodes {
    public const string MALE = "male";
    public const string FEMALE = "female";
    public const string OTHER = "other";
    public const string UNKNOWN = "unknown";
  }
  /// <summary>
  /// If no language is specified, this *implies* that the default local language is spoken.  If you need to convey proficiency for multiple modes, then you need multiple Patient.Communication associations.   For animals, language is not a relevant field, and should be absent from the instance. If the Patient does not speak the default local language, then the Interpreter Required Standard can be used to explicitly declare that an interpreter is required.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<PatientCommunication>))]
  public class PatientCommunication : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The structure aa-BB with this exact casing is one the most widely used notations for locale. However not all systems actually code this but instead have it as free text. Hence CodeableConcept instead of code as the data type.
    /// </summary>
    public CodeableConcept Language { get; set; }
    /// <summary>
    /// This language is specifically identified for communicating healthcare information.
    /// </summary>
    public bool? Preferred { get; set; }
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

      if (Language != null)
      {
        writer.WritePropertyName("language");
        Language.SerializeJson(writer, options);
      }

      if (Preferred != null)
      {
        writer.WriteBoolean("preferred", (bool)Preferred!);
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
        case "language":
          Language = new fhirCsR5.Models.CodeableConcept();
          Language.DeserializeJson(ref reader, options);
          break;

        case "preferred":
          Preferred = reader.GetBoolean();
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
  /// There is no assumption that linked patient records have mutual links.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<PatientLink>))]
  public class PatientLink : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Referencing a RelatedPerson here removes the need to use a Person record to associate a Patient and RelatedPerson as the same individual.
    /// </summary>
    public Reference Other { get; set; }
    /// <summary>
    /// The type of link between this patient resource and another patient resource.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
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

      if (Other != null)
      {
        writer.WritePropertyName("other");
        Other.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(writer, options);
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
        case "other":
          Other = new fhirCsR5.Models.Reference();
          Other.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new fhirCsR5.Models.Element();
          _Type.DeserializeJson(ref reader, options);
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
  /// Code Values for the Patient.link.type field
  /// </summary>
  public static class PatientLinkTypeCodes {
    public const string REPLACED_BY = "replaced-by";
    public const string REPLACES = "replaces";
    public const string REFER = "refer";
    public const string SEEALSO = "seealso";
  }
  /// <summary>
  /// Demographics and other administrative information about an individual or animal receiving care or other health-related services.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<Patient>))]
  public class Patient : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "Patient";
    /// <summary>
    /// If a record is inactive, and linked to an active record, then future patient/record updates should occur on the other patient.
    /// </summary>
    public bool? Active { get; set; }
    /// <summary>
    /// Patient may have multiple addresses with different uses or applicable periods.
    /// </summary>
    public List<Address> Address { get; set; }
    /// <summary>
    /// At least an estimated year should be provided as a guess if the real DOB is unknown  There is a standard extension "patient-birthTime" available that should be used where Time is required (such as in maternity/infant care systems).
    /// </summary>
    public string BirthDate { get; set; }
    /// <summary>
    /// Extension container element for BirthDate
    /// </summary>
    public Element _BirthDate { get; set; }
    /// <summary>
    /// If no language is specified, this *implies* that the default local language is spoken.  If you need to convey proficiency for multiple modes, then you need multiple Patient.Communication associations.   For animals, language is not a relevant field, and should be absent from the instance. If the Patient does not speak the default local language, then the Interpreter Required Standard can be used to explicitly declare that an interpreter is required.
    /// </summary>
    public List<PatientCommunication> Communication { get; set; }
    /// <summary>
    /// Contact covers all kinds of contact parties: family members, business contacts, guardians, caregivers. Not applicable to register pedigree and family ties beyond use of having contact.
    /// </summary>
    public List<PatientContact> Contact { get; set; }
    /// <summary>
    /// If there's no value in the instance, it means there is no statement on whether or not the individual is deceased. Most systems will interpret the absence of a value as a sign of the person being alive.
    /// </summary>
    public bool? DeceasedBoolean { get; set; }
    /// <summary>
    /// If there's no value in the instance, it means there is no statement on whether or not the individual is deceased. Most systems will interpret the absence of a value as a sign of the person being alive.
    /// </summary>
    public string DeceasedDateTime { get; set; }
    /// <summary>
    /// Extension container element for DeceasedDateTime
    /// </summary>
    public Element _DeceasedDateTime { get; set; }
    /// <summary>
    /// The gender might not match the biological sex as determined by genetics or the individual's preferred identification. Note that for both humans and particularly animals, there are other legitimate possibilities than male and female, though the vast majority of systems and contexts only support male and female.  Systems providing decision support or enforcing business rules should ideally do this on the basis of Observations dealing with the specific sex or gender aspect of interest (anatomical, chromosomal, social, etc.)  However, because these observations are infrequently recorded, defaulting to the administrative gender is common practice.  Where such defaulting occurs, rule enforcement should allow for the variation between administrative and biological, chromosomal and other gender aspects.  For example, an alert about a hysterectomy on a male should be handled as a warning or overridable error, not a "hard" error.  See the Patient Gender and Sex section for additional information about communicating patient gender and sex.
    /// </summary>
    public string Gender { get; set; }
    /// <summary>
    /// Extension container element for Gender
    /// </summary>
    public Element _Gender { get; set; }
    /// <summary>
    /// This may be the primary care provider (in a GP context), or it may be a patient nominated care manager in a community/disability setting, or even organization that will provide people to perform the care provider roles.  It is not to be used to record Care Teams, these should be in a CareTeam resource that may be linked to the CarePlan or EpisodeOfCare resources.
    /// Multiple GPs may be recorded against the patient for various reasons, such as a student that has his home GP listed along with the GP at university during the school semesters, or a "fly-in/fly-out" worker that has the onsite GP also included with his home GP to remain aware of medical issues.
    /// Jurisdictions may decide that they can profile this down to 1 if desired, or 1 per type.
    /// </summary>
    public List<Reference> GeneralPractitioner { get; set; }
    /// <summary>
    /// An identifier for this patient.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// There is no assumption that linked patient records have mutual links.
    /// </summary>
    public List<PatientLink> Link { get; set; }
    /// <summary>
    /// There is only one managing organization for a specific patient record. Other organizations will have their own Patient record, and may use the Link property to join the records together (or a Person resource which can include confidence ratings for the association).
    /// </summary>
    public Reference ManagingOrganization { get; set; }
    /// <summary>
    /// This field contains a patient's most recent marital (civil) status.
    /// </summary>
    public CodeableConcept MaritalStatus { get; set; }
    /// <summary>
    /// Where the valueInteger is provided, the number is the birth number in the sequence. E.g. The middle birth in triplets would be valueInteger=2 and the third born would have valueInteger=3 If a boolean value was provided for this triplets example, then all 3 patient records would have valueBoolean=true (the ordering is not indicated).
    /// </summary>
    public bool? MultipleBirthBoolean { get; set; }
    /// <summary>
    /// Where the valueInteger is provided, the number is the birth number in the sequence. E.g. The middle birth in triplets would be valueInteger=2 and the third born would have valueInteger=3 If a boolean value was provided for this triplets example, then all 3 patient records would have valueBoolean=true (the ordering is not indicated).
    /// </summary>
    public int? MultipleBirthInteger { get; set; }
    /// <summary>
    /// A patient may have multiple names with different uses or applicable periods. For animals, the name is a "HumanName" in the sense that is assigned and used by humans and has the same patterns.
    /// </summary>
    public List<HumanName> Name { get; set; }
    /// <summary>
    /// Guidelines:
    /// * Use id photos, not clinical photos.
    /// * Limit dimensions to thumbnail.
    /// * Keep byte count low to ease resource updates.
    /// </summary>
    public List<Attachment> Photo { get; set; }
    /// <summary>
    /// A Patient may have multiple ways to be contacted with different uses or applicable periods.  May need to have options for contacting the person urgently and also to help with identification. The address might not go directly to the individual, but may reach another party that is able to proxy for the patient (i.e. home phone, or pet owner's phone).
    /// </summary>
    public List<ContactPoint> Telecom { get; set; }
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

      if (Active != null)
      {
        writer.WriteBoolean("active", (bool)Active!);
      }

      if ((Name != null) && (Name.Count != 0))
      {
        writer.WritePropertyName("name");
        writer.WriteStartArray();

        foreach (HumanName valName in Name)
        {
          valName.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Telecom != null) && (Telecom.Count != 0))
      {
        writer.WritePropertyName("telecom");
        writer.WriteStartArray();

        foreach (ContactPoint valTelecom in Telecom)
        {
          valTelecom.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Gender))
      {
        writer.WriteString("gender", (string)Gender!);
      }

      if (_Gender != null)
      {
        writer.WritePropertyName("_gender");
        _Gender.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(BirthDate))
      {
        writer.WriteString("birthDate", (string)BirthDate!);
      }

      if (_BirthDate != null)
      {
        writer.WritePropertyName("_birthDate");
        _BirthDate.SerializeJson(writer, options);
      }

      if (DeceasedBoolean != null)
      {
        writer.WriteBoolean("deceasedBoolean", (bool)DeceasedBoolean!);
      }

      if (!string.IsNullOrEmpty(DeceasedDateTime))
      {
        writer.WriteString("deceasedDateTime", (string)DeceasedDateTime!);
      }

      if (_DeceasedDateTime != null)
      {
        writer.WritePropertyName("_deceasedDateTime");
        _DeceasedDateTime.SerializeJson(writer, options);
      }

      if ((Address != null) && (Address.Count != 0))
      {
        writer.WritePropertyName("address");
        writer.WriteStartArray();

        foreach (Address valAddress in Address)
        {
          valAddress.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (MaritalStatus != null)
      {
        writer.WritePropertyName("maritalStatus");
        MaritalStatus.SerializeJson(writer, options);
      }

      if (MultipleBirthBoolean != null)
      {
        writer.WriteBoolean("multipleBirthBoolean", (bool)MultipleBirthBoolean!);
      }

      if (MultipleBirthInteger != null)
      {
        writer.WriteNumber("multipleBirthInteger", (int)MultipleBirthInteger!);
      }

      if ((Photo != null) && (Photo.Count != 0))
      {
        writer.WritePropertyName("photo");
        writer.WriteStartArray();

        foreach (Attachment valPhoto in Photo)
        {
          valPhoto.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Contact != null) && (Contact.Count != 0))
      {
        writer.WritePropertyName("contact");
        writer.WriteStartArray();

        foreach (PatientContact valContact in Contact)
        {
          valContact.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Communication != null) && (Communication.Count != 0))
      {
        writer.WritePropertyName("communication");
        writer.WriteStartArray();

        foreach (PatientCommunication valCommunication in Communication)
        {
          valCommunication.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((GeneralPractitioner != null) && (GeneralPractitioner.Count != 0))
      {
        writer.WritePropertyName("generalPractitioner");
        writer.WriteStartArray();

        foreach (Reference valGeneralPractitioner in GeneralPractitioner)
        {
          valGeneralPractitioner.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (ManagingOrganization != null)
      {
        writer.WritePropertyName("managingOrganization");
        ManagingOrganization.SerializeJson(writer, options);
      }

      if ((Link != null) && (Link.Count != 0))
      {
        writer.WritePropertyName("link");
        writer.WriteStartArray();

        foreach (PatientLink valLink in Link)
        {
          valLink.SerializeJson(writer, options, true);
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
        case "active":
          Active = reader.GetBoolean();
          break;

        case "address":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Address = new List<Address>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Address objAddress = new fhirCsR5.Models.Address();
            objAddress.DeserializeJson(ref reader, options);
            Address.Add(objAddress);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Address.Count == 0)
          {
            Address = null;
          }

          break;

        case "birthDate":
          BirthDate = reader.GetString();
          break;

        case "_birthDate":
          _BirthDate = new fhirCsR5.Models.Element();
          _BirthDate.DeserializeJson(ref reader, options);
          break;

        case "communication":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Communication = new List<PatientCommunication>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.PatientCommunication objCommunication = new fhirCsR5.Models.PatientCommunication();
            objCommunication.DeserializeJson(ref reader, options);
            Communication.Add(objCommunication);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Communication.Count == 0)
          {
            Communication = null;
          }

          break;

        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Contact = new List<PatientContact>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.PatientContact objContact = new fhirCsR5.Models.PatientContact();
            objContact.DeserializeJson(ref reader, options);
            Contact.Add(objContact);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Contact.Count == 0)
          {
            Contact = null;
          }

          break;

        case "deceasedBoolean":
          DeceasedBoolean = reader.GetBoolean();
          break;

        case "deceasedDateTime":
          DeceasedDateTime = reader.GetString();
          break;

        case "_deceasedDateTime":
          _DeceasedDateTime = new fhirCsR5.Models.Element();
          _DeceasedDateTime.DeserializeJson(ref reader, options);
          break;

        case "gender":
          Gender = reader.GetString();
          break;

        case "_gender":
          _Gender = new fhirCsR5.Models.Element();
          _Gender.DeserializeJson(ref reader, options);
          break;

        case "generalPractitioner":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          GeneralPractitioner = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objGeneralPractitioner = new fhirCsR5.Models.Reference();
            objGeneralPractitioner.DeserializeJson(ref reader, options);
            GeneralPractitioner.Add(objGeneralPractitioner);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (GeneralPractitioner.Count == 0)
          {
            GeneralPractitioner = null;
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

        case "link":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Link = new List<PatientLink>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.PatientLink objLink = new fhirCsR5.Models.PatientLink();
            objLink.DeserializeJson(ref reader, options);
            Link.Add(objLink);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Link.Count == 0)
          {
            Link = null;
          }

          break;

        case "managingOrganization":
          ManagingOrganization = new fhirCsR5.Models.Reference();
          ManagingOrganization.DeserializeJson(ref reader, options);
          break;

        case "maritalStatus":
          MaritalStatus = new fhirCsR5.Models.CodeableConcept();
          MaritalStatus.DeserializeJson(ref reader, options);
          break;

        case "multipleBirthBoolean":
          MultipleBirthBoolean = reader.GetBoolean();
          break;

        case "multipleBirthInteger":
          MultipleBirthInteger = reader.GetInt32();
          break;

        case "name":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Name = new List<HumanName>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.HumanName objName = new fhirCsR5.Models.HumanName();
            objName.DeserializeJson(ref reader, options);
            Name.Add(objName);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Name.Count == 0)
          {
            Name = null;
          }

          break;

        case "photo":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Photo = new List<Attachment>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Attachment objPhoto = new fhirCsR5.Models.Attachment();
            objPhoto.DeserializeJson(ref reader, options);
            Photo.Add(objPhoto);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Photo.Count == 0)
          {
            Photo = null;
          }

          break;

        case "telecom":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Telecom = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.ContactPoint objTelecom = new fhirCsR5.Models.ContactPoint();
            objTelecom.DeserializeJson(ref reader, options);
            Telecom.Add(objTelecom);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Telecom.Count == 0)
          {
            Telecom = null;
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
  /// Code Values for the Patient.gender field
  /// </summary>
  public static class PatientGenderCodes {
    public const string MALE = "male";
    public const string FEMALE = "female";
    public const string OTHER = "other";
    public const string UNKNOWN = "unknown";
  }
}
