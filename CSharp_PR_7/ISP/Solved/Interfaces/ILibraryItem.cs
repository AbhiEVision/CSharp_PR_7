using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_7.ISP.Solved.Interfaces
{
	internal interface ILibraryItem
	{
		string LibID { get; set; }
		string Title { get; set; }
		string Description { get; set; }
	}
}
