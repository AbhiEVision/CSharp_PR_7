// here LSP will applied properly because i can replace its child

using CSharp_PR_7.LSP.Solved.Interfaces;

namespace CSharp_PR_7.LSP.Solved
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			IManaged ceo = new CEO();
			ceo.Name = "Abhi";
			ceo.ID = "123455";

			IManager emp = new Employee();
			emp.Name = "Jil";
			emp.ID = "12345";
			emp.AssignManager(ceo);

			ceo.PrintDetails();
			emp.PrintDetails();

		}
	}
}
