namespace CSharp_PR_7.DIP.Violated
{
	internal class FarmHouse
	{
		public int doorNo;
		public string houseName;
		public bool isHavePool;

		public FarmHouse(int doorNo, string houseName, bool needPool)
		{
			this.doorNo = doorNo;
			this.houseName = houseName;
			this.isHavePool = needPool;
		}
	}
}
