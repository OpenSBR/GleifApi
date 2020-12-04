using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GleifApi.Models
{
    /// <summary>
    /// Registration of LEI record
    /// </summary>
    public class Registration
    {
        /// <summary>
        /// Initial registration
        /// </summary>
        [JsonPropertyName("InitialRegistrationDate")]
        public UnnamedDateType? InitialRegistrationDate { get; set; }

        /// <summary>
        /// Last update
        /// </summary>
        [JsonPropertyName("LastUpdateDate")]
        public UnnamedDateType? LastUpdateDate { get; set; }

        /// <summary>
        /// Registration status, e.g. ISSUED
        /// </summary>
        [JsonPropertyName("RegistrationStatus")]
        public UnnamedType? RegistrationStatus { get; set; }

        /// <summary>
        /// Next renewal date
        /// </summary>
        [JsonPropertyName("NextRenewalDate")]
        public UnnamedDateType? NextRenewalDate { get; set; }

        /// <summary>
        /// Managing LOU
        /// </summary>
        [JsonPropertyName("ManagingLOU")]
        public UnnamedType? ManagingLou { get; set; }

        /// <summary>
        /// Validation sources
        /// </summary>
        [JsonPropertyName("ValidationSources")]
        public UnnamedType? ValidationSources { get; set; }

        /// <summary>
        /// Validation authority
        /// </summary>
        [JsonPropertyName("ValidationAuthority")]
        public ValidationAuthority? ValidationAuthority { get; set; }
    }
}
