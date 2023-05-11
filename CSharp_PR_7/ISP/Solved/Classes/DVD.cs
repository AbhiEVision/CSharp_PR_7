using CSharp_PR_7.ISP.Solved.Interfaces;

namespace CSharp_PR_7.ISP.Solved.Classes
{
	internal class DVD : IDVD
	{
		public string Duration { get; set; }
		public string LibID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
