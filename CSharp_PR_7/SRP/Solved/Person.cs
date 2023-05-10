namespace CSharp_PR_7.SRP.Solved
{
	internal class Person
	{
		public string firstName;
		public string lastName;

		public void PrintPersonDetails()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"first name is : {firstName} \nlast name is : {lastName}");
			Console.ResetColor();
		}
	}
}
