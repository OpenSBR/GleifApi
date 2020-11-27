using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GleifApi.Models
{
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

		public override string? ToString()
		{
			return Text;
		}
	}
}
