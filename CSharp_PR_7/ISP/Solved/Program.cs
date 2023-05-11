// here i made a different interfaces for every class so its only inherits only needed properties.

using CSharp_PR_7.ISP.Solved.Classes;
using CSharp_PR_7.ISP.Solved.Interfaces;

namespace CSharp_PR_7.ISP.Solved
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			IDVD dvd = new DVD();

			IReferenceBook referenceBook = new ReferenceBook();

			IBookItem book = new Book();

			IAudioBook audioBook = new AudioBook();
		}
	}
}
