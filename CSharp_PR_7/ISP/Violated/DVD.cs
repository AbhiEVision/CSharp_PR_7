using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_PR_7.ISP.Violated.Interface;

namespace CSharp_PR_7.ISP.Violated
{
    internal class DVD : ILibraryItem
	{
		public string LibID { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public string Description { get; set; }

		// DVD doesn't contains a pages
		public int Pages { get; set; }
		public int CheckOutDurationInDays { get; set; }
		public string BorrowerName { get; set; }
		public DateTime BorrowDate { get; set; }

		
		public void CheckIn()
		{
			BorrowerName = string.Empty;
		}

		public void CheckOut(string borrower)
		{
			BorrowerName = borrower;
			BorrowDate = DateTime.Now;
		}
	}
}
