namespace CSharp_PR_7.OCP.Solved.Accounts
{
	internal class CurrentAccount : IBankAccount
	{
		private string _userName;
		private string _password;

		public string UserName { get { return _userName; } set { _userName = value; } }
		public string Password { get { return _password; } set { _password = value; } }

		public CurrentAccount(string account, string password)
		{
			this._userName = account;
			this._password = password;
		}

		public double CalculateIntrust(double money)
		{
			return money * 0.08;
		}
	}
}
