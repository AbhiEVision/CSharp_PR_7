namespace CSharp_PR_7.SRP.Solved
{
	internal class StandardMessage
	{
		public static void ProgramStartMessage()
		{
			Console.WriteLine("============ Program Started ============");
		}

		public static void ProgramEndMessage() 
		{
			Console.WriteLine("============ Program Ended ============");
		}

		public static void PrintStatement(string s)
		{
			Console.WriteLine(s);
		}

		public static void PrintError(string s) 
		{ 
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(s);
			Console.ResetColor();
		}
	}
}
