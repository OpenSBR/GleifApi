using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GleifApi.Models
{
    /// <summary>
    /// LEI entity address
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Language
        /// </summary>
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
        /// Country, ISO 3166-1 alpha-2
        /// </summary>
        [JsonPropertyName("Country")]
        public UnnamedType? Country { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        [JsonPropertyName("PostalCode")]
        public UnnamedType? PostalCode { get; set; }
    }
}
