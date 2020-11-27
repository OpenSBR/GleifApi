using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GleifApi.Models
{
    /// <summary>
    /// LEI entity legal name
    /// </summary>
    public class LegalName
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
}
