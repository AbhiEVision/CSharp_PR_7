using CSharp_PR_7.ISP.Solved.Interfaces;

namespace CSharp_PR_7.ISP.Solved.Classes
{
	internal class Book : IBookItem
	{
		public string Author { get; set; }
		public int Pages { get; set; }
		public string LibID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
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
