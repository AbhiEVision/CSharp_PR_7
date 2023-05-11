using CSharp_PR_7.DIP.Solved.Interface;

namespace CSharp_PR_7.DIP.Solved
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			IHouse house1 = HouseBuilder.GiveMeHouse("Roof");

			IHouse house2 = HouseBuilder.GiveMeHouse("Farm");

            Console.WriteLine(house1.IsHavePool);

			Console.WriteLine(house2.Name);

        }
	}
}
