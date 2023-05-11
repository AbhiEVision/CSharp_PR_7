using CSharp_PR_7.ISP.Violated.Interface;

namespace CSharp_PR_7.ISP.Violated
{
    internal class AudioBook : ILibraryItem
	{
		public string LibID { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public string Description { get; set; }

		// Audio Book Doesn't contains a pages
		public int Pages { get; set; }
		public int CheckOutDurationInDays { get; set; }

		// Audio Book Doesn't have Details of Borrower
		public string BorrowerName { get; set; }
		public DateTime BorrowDate { get; set; }

		// not implemented because audio book is in digital format so don't need of checked in and checked out
		public void CheckIn()
		{
			throw new NotImplementedException();
		}

		public void CheckOut(string borrower)
		{
			throw new NotImplementedException();
		}
	}
}
