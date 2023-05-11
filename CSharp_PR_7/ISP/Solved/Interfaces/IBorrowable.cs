using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_7.ISP.Solved.Interfaces
{
	internal interface IBorrowable
	{
		int CheckOutDurationInDays { get; set; }
		string BorrowerName { get; set; }
		DateTime BorrowDate { get; set; }

		void CheckIn();
		void CheckOut(string borrower);
	}
}
