using CSharp_PR_7.DIP.Solved.Interface;

namespace CSharp_PR_7.DIP.Solved
{
	internal class HouseBuilder
	{
		public static IHouse GiveMeHouse(string houseType)
		{
			if (houseType == "Roof")
			{
				return new RoofHouse(2, "House1", true);
			}
			if (houseType == "Farm")
			{
				return new FarmHouse(2, "House1", true);
			}

			return null;
		}
	}
}
