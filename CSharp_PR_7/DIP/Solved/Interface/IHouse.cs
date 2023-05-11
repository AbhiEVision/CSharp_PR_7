using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_7.DIP.Solved.Interface
{
	internal interface IHouse
	{
		string Name { get; set; }
		bool IsHavePool { get; set; }
		int DoorNo { get; set; }
	}
}
