// LSP : is said that we can change the child class with parent class object without getting any errors

// here LSP is violated because there in emp2's object is i change to CEO's object that i am going to assign a employee as manager to CEO that
// is not a good thing.

namespace CSharp_PR_7.LSP.Violated
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Employee emp = new Manager();
			emp.Name = "Abhi";
			emp.ID = "123";


			Employee emp2 = new Employee();
			//Employee emp2 = new CEO(); this is not good thing like assigning a mentor to CEO.
			emp2.Name = "jil";
			emp2.ID = "123";
			emp2.AssignManager(emp);

			emp2.PrintDetails();
		}
	}
}
