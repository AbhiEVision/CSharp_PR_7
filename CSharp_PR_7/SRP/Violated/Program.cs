// here SRP is violated 
// because you can see the all functionality is done in main method like they are taking input form user and also they are validating that input.

namespace CSharp_PR_7.SRP.Violated
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Person person = new();

			Console.WriteLine("============ Program Started ============");

			Console.WriteLine("enter your first name");
			person.firstName = Console.ReadLine();

			Console.WriteLine("enter your last name");
			person.lastName = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(person.firstName))
			{
				Console.WriteLine("you didn't give your first name");
				return;
			}

			if (string.IsNullOrWhiteSpace(person.lastName))
			{
				Console.WriteLine("you didn't give your last name");
				return;
			}

			Console.WriteLine($"your first name is {person.firstName} and last name is {person.lastName}");
			Console.WriteLine("============ Program Ended ============");

		}
	}
}
