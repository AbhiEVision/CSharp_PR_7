// ISP says that interface can't force to implement that methods which doesn't belongs to that class

// here Audio book, DVD and Reference book have some properties that doesn't belongs to that but they have to implement them because that 
// implements common interface which are ILibraryItem.

using CSharp_PR_7.ISP.Violated.Interface;

namespace CSharp_PR_7.ISP.Violated
{
    internal class Program
	{
		public static void Main(string[] args)
		{
			ILibraryItem dvd = new DVD();

			// this can't be possible that dvd has page numbers
			//dvd.Pages = 10;
		}
	}
}
