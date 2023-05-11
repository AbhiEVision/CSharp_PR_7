using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_7.ISP.Solved.Interfaces
{
	internal interface IAudioBook : ILibraryItem
	{
		string Length { get; set; }
	}
}
