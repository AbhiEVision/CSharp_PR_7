namespace CSharp_PR_7.DIP.Violated
{
	internal class RoofHouse
	{
		public int doorNo;
		public string houseName;
		public bool isHavePool;

		public RoofHouse(int doorNo, string houseName, bool needPool)
		{
			this.doorNo = doorNo;
			this.houseName = houseName;
			this.isHavePool = needPool;
		}
	}
}
