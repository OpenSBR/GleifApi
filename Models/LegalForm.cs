using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GleifApi.Models
{
    /// <summary>
    ///  LEI entity legal form
    /// </summary>
    public partial class LegalForm
    {
        /// <summary>
        /// Entity legal form code
        /// </summary>
        [JsonPropertyName("EntityLegalFormCode")]
        public UnnamedType? EntityLegalFormCode { get; set; }
    }
}
