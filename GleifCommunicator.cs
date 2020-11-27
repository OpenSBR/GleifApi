using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GleifApi.Models;

namespace GleifApi
{
	/// <summary>
	/// GLEIF API class
	/// </summary>
	public class GleifCommunicator
	{
		const string GLEIF = "GLEIF";

		/// <summary>
		/// GLEIF search base URI, default https://leilookup.gleif.org/api/v2/leirecords?lei={lei}
		/// </summary>
		public readonly string BaseUri = "https://leilookup.gleif.org/api/v2/leirecords?lei={lei}";

		// https://leilookup.gleif.org/api/v2/leirecords?lei=506700GE1G29325QX363

		HttpClient? _client;

		/// <summary>
		/// Constructor which creates a new HttpClient
		/// </summary>
		public GleifCommunicator()
		{
			_client = new HttpClient();
		}

		/// <summary>
		/// Constructor which uses .NET Core HTTP Client Factory
		/// </summary>
		/// <param name="httpClientFactory">HTTP Client Factory</param>
		public GleifCommunicator(IHttpClientFactory httpClientFactory)
		{
			_client = httpClientFactory.CreateClient(GLEIF);
		}

		/// <summary>
		/// Constructor which uses .NET Core HTTP Client Factory
		/// </summary>
		/// <param name="httpClientFactory">HTTP Client Factory</param>
		/// <param name="baseUri">Set a custom GLEIF Search API path</param>
		public GleifCommunicator(IHttpClientFactory httpClientFactory, string baseUri)
		{
			_client = httpClientFactory.CreateClient(GLEIF);

			BaseUri = baseUri;
		}

		public async Task<IEnumerable<LeiRecord>> GetLeiRecordsAsync(params string[] leiCodes)
		{
			string leiLookup = string.Join(',', leiCodes);

			return await GetRecordsAsync(leiLookup);
		}

		/// <summary>
		/// Retrieve LEI records for a specific LEI code
		/// </summary>
		/// <param name="leiCode">Legal Entity Identifier</param>
		/// <returns>LEI record(s)</returns>
		async Task<IEnumerable<LeiRecord>> GetRecordsAsync(string leiCode)
		{
			if (_client == null)
				throw new HttpRequestException("Cient not initialized");

			string request = BaseUri.Replace("{lei}", leiCode);

			HttpResponseMessage response = await _client.GetAsync(request);

			if (response.IsSuccessStatusCode)
			{
				LeiRecord[]? record = await response.Content.ReadAsJsonAsync<LeiRecord[]>();

				if (record != null)
					return record;
			}

			return Enumerable.Empty<LeiRecord>();
		}
	}
}
