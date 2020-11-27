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
	public partial class UnnamedDateType
	{
		/// <summary>
		/// Text value
		/// </summary>
		[JsonPropertyName("$")]
		public DateTime? Date { get; set; }

		public static implicit operator UnnamedDateType(DateTime date)
		{
			UnnamedDateType datetype = new UnnamedDateType() { Date = date };
			return datetype;
		}

		public static implicit operator DateTime?(UnnamedDateType datetype)
		{
			return datetype?.Date;
		}

		public override string? ToString()
		{
			return Date?.ToString();
		}
	}
}
