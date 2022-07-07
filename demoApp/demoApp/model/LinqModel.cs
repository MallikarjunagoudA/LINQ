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


	//   class studentCompare : IEqualityComparer<Student>
	//{

	//public bool eqaul(Student x, Student y)
	//      {
	//	if(x.StudentID==y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
	//          {
	//		return true;
	//          }
	//	else
	//          {
	//		return false;

	//          }

	//      }

	//public int getHashcode(Student obj)
	//      {
	//	return obj.GetHashCode();
	//      }
	//}

	class StudentComparer : IEqualityComparer<Student>
	{
		public bool Equals(Student x, Student y)
		{
			if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
				return true;

			return false;
		}

		public int GetHashCode(Student obj)
		{
			return obj.GetHashCode();
		}
	}


}
