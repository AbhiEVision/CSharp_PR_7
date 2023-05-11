using CSharp_PR_7.LSP.Solved.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_7.LSP.Solved
{
	internal class CEO : IManaged
	{
		private string _name;
		private string _id;

		public string ID { get { return _id; } set { _id = value; } }
		public string Name { get { return _name; } set { _name = value; } }

		public void FireSomeOne()
		{
			Console.WriteLine("You are fired!");
		}

		public void PrintDetails()
		{
			Console.WriteLine($"\nName : {_name}\nID : {_id}");
		}
	}
}
