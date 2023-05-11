// here OCP solved because i made a common interface of BankAccount means when we want to add any new account type than we can implement that 
// interface and we don't have to modify the existing code.

using CSharp_PR_7.OCP.Solved.Accounts;

namespace CSharp_PR_7.OCP.Solved
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			IBankAccount account = new SalaryAccount("Abhi Patel", "Abhi@123");

			Console.WriteLine(account.CalculateIntrust(1000));

			IBankAccount account1 = new CurrentAccount("Jil Patel", "Jil@123");

			Console.WriteLine(account1.CalculateIntrust(1000));
		}

	}
}
