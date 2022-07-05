using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoApp.model
{

   
		public class Student
		{

			public int StudentID { get; set; }
			public string StudentName { get; set; }
			public int Age { get; set; }

        public int StandardID { get; set; }

    }

		public class groupedResult1
		{

			public int sum { get; set; }
			public double avg { get; set; }


		}

		public class Standard
		{
			public int StandardID { get; set; }
			public string StandardName { get; set; }
		}

	public class Student1
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int age { get; set; }
	}


}
