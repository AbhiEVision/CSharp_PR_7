// OCP said that if class are made that it must be open to extend but close to modify. means if we add new functionality that current
// class's don't be updated!

// Here OCP is violated because if i want to add an one more type of account like boss said to we want to add a SalaryAccount
// than i have to add that type in enum ( AccountType ) and also i have to update the CalculateIntrust Method inside a BankAccount.


namespace CSharp_PR_7.OCP.Violated
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			BankAccount account = new("Abhi Patel", "Abhi@123", AccountType.CurrentAccount);

			Console.WriteLine(account.CalculateIntrust(12334.12332));
		}
	}
}
