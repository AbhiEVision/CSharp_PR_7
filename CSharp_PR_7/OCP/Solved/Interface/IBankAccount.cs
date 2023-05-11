using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_7.OCP.Solved
{
	internal interface IBankAccount
	{
		string UserName { get; set; }
		string Password {  get; set; }

		double CalculateIntrust(double money);
	}
}
