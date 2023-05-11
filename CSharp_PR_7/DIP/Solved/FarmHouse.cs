using CSharp_PR_7.DIP.Solved.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_7.DIP.Solved
{
	internal class FarmHouse : IHouse
	{
		public string Name { get; set; }
		public bool IsHavePool { get; set; }
		public int DoorNo { get; set; }

		public FarmHouse(int doorNo, string houseName, bool needPool)
		{
			DoorNo = doorNo;
			Name = houseName;
			IsHavePool = needPool;
		}
	}
}
