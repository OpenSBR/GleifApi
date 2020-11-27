using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GleifApi.Models
{
	/// <summary>
	/// Validation authority
	/// </summary>
	public class ValidationAuthority
	{
		[JsonPropertyName("ValidationAuthorityID")]
		public UnnamedType? ValidationAuthorityId { get; set; }

		[JsonPropertyName("ValidationAuthorityEntityID")]
		public UnnamedType? ValidationAuthorityEntityId { get; set; }
	}
}
