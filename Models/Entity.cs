using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GleifApi.Models
{
    /// <summary>
    /// LEI entity
    /// </summary>
    public class Entity
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

        /// <summary>
        /// Registration authority
        /// </summary>
        [JsonPropertyName("RegistrationAuthority")]
        public RegistrationAuthority? RegistrationAuthority { get; set; }

        /// <summary>
        /// Legal jurisdiction, ISO 3166-1 alpha-2
        /// </summary>
        [JsonPropertyName("LegalJurisdiction")]
        public UnnamedType? LegalJurisdiction { get; set; }

        /// <summary>
        /// Legal form
        /// </summary>
        [JsonPropertyName("LegalForm")]
        public LegalForm? LegalForm { get; set; }

        /// <summary>
        /// Entity status: e.g. ACTIVE
        /// </summary>
        [JsonPropertyName("EntityStatus")]
        public UnnamedType? EntityStatus { get; set; }
    }
}
