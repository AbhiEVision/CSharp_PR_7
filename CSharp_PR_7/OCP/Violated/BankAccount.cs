namespace CSharp_PR_7.OCP.Violated
{
	internal class BankAccount
	{
		private string _userName;
		private string _password;
		public AccountType accountType { get; init; }

		public string Account { get { return _userName; } set { _userName = value; } }
		public string Password { get { return _password; } set { _password = value; } }

		public BankAccount(string account, string password, AccountType accountType)
		{
			Account = account;
			Password = password;
			this.accountType = accountType;
		}

		public double CalculateIntrust(double money)
		{
			if (accountType == AccountType.CurrentAccount)
			{
				return money * 0.8;
			}
			else if (accountType == AccountType.SavingAccount)
			{
				return money * 0.5;
			}

			return money;
		}
	}
}
