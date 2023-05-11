// DIP says that higher-level modules should not depend on lower-level modules; instead, they should both depend on abstractions.

// here house depends on FarmHouse class directly so we have to remove that.

namespace CSharp_PR_7.DIP.Violated
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			RoofHouse house1 = new(4, "Patel's", true);

			FarmHouse house2 = new(4, "Dashadiya's", false);
		}
	}
}
