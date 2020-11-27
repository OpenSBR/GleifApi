using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GleifApi.Models
{
	/// <summary>
	/// Registration authority
	/// </summary>
	public class RegistrationAuthority
	{
		[JsonPropertyName("RegistrationAuthorityID")]
		public UnnamedType? RegistrationAuthorityId { get; set; }

		[JsonPropertyName("RegistrationAuthorityEntityID")]
		public UnnamedType? RegistrationAuthorityEntityId { get; set; }
	}
}
