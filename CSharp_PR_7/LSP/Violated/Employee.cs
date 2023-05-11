namespace CSharp_PR_7.LSP.Violated
{
	internal class Employee
	{
		private string _id;
		private string _name;
		private Employee _manager = null;

		public string ID { get { return _id; } set { _id = value; } }
		public string Name { get { return _name; } set { _name = value; } }
		public Employee Manager {  get { return _manager; } }
		

		public virtual void AssignManager(Employee employee)
		{
			_manager = employee;
			Console.WriteLine($"{_name}'s manager is {_manager.Name}");
		}

		public void PrintDetails()
		{
			string s = $"\n\nName : {_name} \nID : {_id} \nManager : {_manager.Name}";
			Console.WriteLine(s);
		}
	}
}
