namespace CSharp_PR_7.SRP.Solved
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			StandardMessage.ProgramStartMessage();

			Person person = new();

			StandardMessage.PrintStatement("Enter first name :");
			person.firstName = Console.ReadLine();

			StandardMessage.PrintStatement("Enter last name :");
			person.lastName = Console.ReadLine();

			if (Validation.ValidateString(person.firstName))
			{
				StandardMessage.PrintError("Invalid First name");
				StandardMessage.ProgramEndMessage();
				return;
			}

			if (Validation.ValidateString(person.lastName))
			{
				StandardMessage.PrintError("Invalid Last name");
				StandardMessage.ProgramEndMessage();
				return;
			}

			person.PrintPersonDetails();

			StandardMessage.ProgramEndMessage();
		}
	}
}
