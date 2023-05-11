using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_7.OCP.Solved.Accounts
{
	internal class SavingAccount : IBankAccount
	{
		private string _userName;
		private string _password;

		public string UserName { get { return _userName; } set { _userName = value; } }
		public string Password { get { return _password; } set { _password = value; } }

		public SavingAccount(string username, string password)
		{
			this._userName = username;
			this._password = password;
		}

		public double CalculateIntrust(double money)
		{
			return money * 0.05;
		}
	}
}
