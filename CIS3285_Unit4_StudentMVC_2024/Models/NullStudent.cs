

namespace CIS3285_Unit4_StudentMVC_2024.Models
{
	public class Null Student : IStudentInterface
	{
		public NullStudent()
		{
			
		}


		public int Id
		{
			get { return -1; }
			set { }
		}

		public string Name
		{
			get { return "Null Student"; }
			set { }
		}

		public int Credits
		{
			get { return -999; }
			set { }
		}
	}
}
