using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GleifApi
{
    /// <summary>
    /// LEI reistration record
    /// </summary>
    public partial class LeiRecord
    {
        /// <summary>
        /// Legal Entity Identifier
        /// </summary>
        [JsonPropertyName("LEI")]
        public UnnamedType? Lei { get; set; }

        /// <summary>
        /// Entity information
        /// </summary>
        [JsonPropertyName("Entity")]
        public Entity? Entity { get; set; }

        /// <summary>
        /// Registration information
        /// </summary>
        [JsonPropertyName("Registration")]
        public Registration? Registration { get; set; }
    }

    /// <summary>
    /// LEI entity
    /// </summary>
    public partial class Entity
    {
        /// <summary>
        /// Legal name
        /// </summary>
        [JsonPropertyName("LegalName")]
        public LegalName? LegalName { get; set; }

        /// <summary>
        /// Legal address
        /// </summary>
        [JsonPropertyName("LegalAddress")]
        public Address? LegalAddress { get; set; }

        /// <summary>
        /// Headquarter's address
        /// </summary>
        [JsonPropertyName("HeadquartersAddress")]
        public Address? HeadquartersAddress { get; set; }

        [JsonPropertyName("RegistrationAuthority")]
        public RegistrationAuthority? RegistrationAuthority { get; set; }

        [JsonPropertyName("LegalJurisdiction")]
        public UnnamedType? LegalJurisdiction { get; set; }

        [JsonPropertyName("LegalForm")]
        public LegalForm? LegalForm { get; set; }

        [JsonPropertyName("EntityStatus")]
        public UnnamedType? EntityStatus { get; set; }
    }

    /// <summary>
    /// API conversion type
    /// </summary>
    public partial class UnnamedType
    {
        /// <summary>
        /// Text value
        /// </summary>
        [JsonPropertyName("$")]
        public string? Text { get; set; }

        public static implicit operator UnnamedType(string text)
        {
            UnnamedType lei = new UnnamedType() { Text = text };
            return lei;
        }

        public static implicit operator string?(UnnamedType lei)
		{
            return lei?.Text;
		}
    }

    /// <summary>
    /// LEI entity address
    /// </summary>
    public partial class Address
    {
        [JsonPropertyName("@xml:lang")]
        public string? XmlLang { get; set; }

        /// <summary>
        /// First address line
        /// </summary>
        [JsonPropertyName("FirstAddressLine")]
        public UnnamedType? FirstAddressLine { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [JsonPropertyName("City")]
        public UnnamedType? City { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [JsonPropertyName("Region")]
        public UnnamedType? Region { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [JsonPropertyName("Country")]
        public UnnamedType? Country { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        [JsonPropertyName("PostalCode")]
        public UnnamedType? PostalCode { get; set; }
    }

    /// <summary>
    ///  LEI entity legal form
    /// </summary>
    public partial class LegalForm
    {
        [JsonPropertyName("EntityLegalFormCode")]
        public UnnamedType? EntityLegalFormCode { get; set; }
    }

    /// <summary>
    /// LEI entity legal name
    /// </summary>
    public partial class LegalName
    {
        /// <summary>
        /// Content language
        /// </summary>
        [JsonPropertyName("@xml:lang")]
        public string? XmlLang { get; set; }

        /// <summary>
        /// Legal name
        /// </summary>
        [JsonPropertyName("$")]
        public string? Name { get; set; }
    }

    /// <summary>
    /// Registration authority
    /// </summary>
    public partial class RegistrationAuthority
    {
        [JsonPropertyName("RegistrationAuthorityID")]
        public UnnamedType? RegistrationAuthorityId { get; set; }

        [JsonPropertyName("RegistrationAuthorityEntityID")]
        public UnnamedType? RegistrationAuthorityEntityId { get; set; }
    }

    /// <summary>
    /// Registration of LEI record
    /// </summary>
    public partial class Registration
    {
        [JsonPropertyName("InitialRegistrationDate")]
        public UnnamedType? InitialRegistrationDate { get; set; }

        [JsonPropertyName("LastUpdateDate")]
        public UnnamedType? LastUpdateDate { get; set; }

        [JsonPropertyName("RegistrationStatus")]
        public UnnamedType? RegistrationStatus { get; set; }

        [JsonPropertyName("NextRenewalDate")]
        public UnnamedType? NextRenewalDate { get; set; }

        [JsonPropertyName("ManagingLOU")]
        public UnnamedType? ManagingLou { get; set; }

        [JsonPropertyName("ValidationSources")]
        public UnnamedType? ValidationSources { get; set; }

        [JsonPropertyName("ValidationAuthority")]
        public ValidationAuthority? ValidationAuthority { get; set; }
    }

    /// <summary>
    /// Validation authority
    /// </summary>
    public partial class ValidationAuthority
    {
        [JsonPropertyName("ValidationAuthorityID")]
        public UnnamedType? ValidationAuthorityId { get; set; }

        [JsonPropertyName("ValidationAuthorityEntityID")]
        public UnnamedType? ValidationAuthorityEntityId { get; set; }
    }
}

