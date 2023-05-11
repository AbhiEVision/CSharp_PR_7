using CSharp_PR_7.LSP.Solved.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_7.LSP.Solved
{
	internal class Employee : IManager
	{
		private string _id;
		private string _name;
		private IEmployee _manager;

		public string ID { get { return _id; } set { _id = value; } }
		public string Name { get { return _name; } set { _name = value; } }
		public IEmployee Manager { get { return _manager; } }

		public void AssignManager(IEmployee manager)
		{
			_manager = manager;
		}

		public void PrintDetails()
		{
			string s = $"\n\nName : {_name} \nID : {_id} \nManager : {_manager.Name}";
			Console.WriteLine(s);
		}
	}
}
