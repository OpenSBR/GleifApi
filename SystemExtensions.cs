using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace GleifApi
{
	/// <summary>
	/// Static extension class
	/// </summary>
	internal static class SystemExtensions
	{
		/// <summary>
		/// Deserialize JSON response
		/// </summary>
		/// <typeparam name="T">Deserialization class</typeparam>
		/// <param name="content">HttpContent</param>
		/// <returns>Strongly typed http response</returns>
		internal static async Task<T?> ReadAsJsonAsync<T>(this HttpContent content)
		{
			string dataAsString = await content.ReadAsStringAsync();

			return JsonSerializer.Deserialize<T>(dataAsString);
		}
	}
}
