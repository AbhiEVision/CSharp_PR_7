namespace CSharp_PR_7.ISP.Violated.Interface
{
    internal interface ILibraryItem
    {
        string LibID { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        string Description { get; set; }
        int Pages { get; set; }
        int CheckOutDurationInDays { get; set; }
        string BorrowerName { get; set; }
        DateTime BorrowDate { get; set; }

        void CheckIn();
        void CheckOut(string borrower);

    }
}
