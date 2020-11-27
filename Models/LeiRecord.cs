using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GleifApi.Models
{
	/// <summary>
	/// LEI reistration record
	/// </summary>
	public class LeiRecord
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
}

