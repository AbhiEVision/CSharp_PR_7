using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_7.SRP.Solved
{
	internal class Validation
	{
		public static bool ValidateString(string s)
		{
			return string.IsNullOrWhiteSpace(s) && string.IsNullOrEmpty(s);
		}
	}
}
