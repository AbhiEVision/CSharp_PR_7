namespace CSharp_PR_7.LSP.Violated
{
	internal class CEO : Employee
	{
		// here i can access Assign Manager 

		// it is not possible
		public override void AssignManager(Employee employee)
		{
			throw new NotImplementedException();
		}
	}
}
