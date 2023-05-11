using CSharp_PR_7.ISP.Solved.Interfaces;

namespace CSharp_PR_7.ISP.Solved.Classes
{
	internal class AudioBook : IAudioBook
	{
		public string Length { get; set; }
		public string LibID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
