using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GleifApi
{
	/// <summary>
	/// LEI utilities
	/// </summary>
	public static class Utilities
	{
		/// <summary>
		/// Verify LEI code according to ISO/IEC 7064 https://en.wikipedia.org/wiki/ISO/IEC_7064
		/// </summary>
		/// <param name="leiCode">Legal Entity Identifier, 20 characters</param>
		/// <returns>Boolean, true if valid</returns>
		public static bool CheckLeiCode(string leiCode)
		{
			//must be 20 characters long
			if (leiCode == null || leiCode.Length != 20)
				return false;

			StringBuilder sb = new StringBuilder();
			foreach (char c in leiCode.ToCharArray())
			{
				//only numbers
				if (c > 47 && c < 58)
					sb.Append(c - 48);
				//only capital letters
				else if (c > 64 && c < 91)
					sb.Append(c - 55);
				else
					return false;
			}

			return (BigInteger.TryParse(sb.ToString(), out BigInteger bigInt) && bigInt % 97 == 1);
		}

	}
}
