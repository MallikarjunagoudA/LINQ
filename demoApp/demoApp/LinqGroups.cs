using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoApp.model;


/*
 * Groupby and ToLookup
 * 
 * GroupBy & ToLookup return a collection that has a key and an inner collection based on a key field value.
  
 *  The execution of GroupBy is deferred whereas that of ToLookup is immediate.

 *   A LINQ query syntax can be end with the GroupBy or Select clause.



*/



namespace demoApp
{

	public class LinqGroups
	{


		public void LinqGroup()
		{

			// Student collection
			IList<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
				new Student() { StudentID = 2, StudentName = "Ram",  Age = 21 } ,
				new Student() { StudentID = 3, StudentName = "John",  Age = 18 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 21} ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 13 }
			};

			Console.WriteLine("**************** groupBy ************************");

			//qs
			var groupqs = (from std in studentList
						   group std by std.StudentName into gruStd
						   select (gruStd.Sum(s => s.Age)));

			foreach (int s in groupqs)
			{
				Console.WriteLine(s);
			}

		

			var groupedResult = from s in studentList
								group s by s.Age;

			List<groupedResult1> gl = new List<groupedResult1>();

			


			//ms

			var groupedResultms = studentList.GroupBy(s => s.Age);


			//iterate each group        
			foreach (var ageGroup in groupedResult)
			{
				Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

				foreach (Student s in ageGroup) // Each group has inner collection
					Console.WriteLine("Student Name: {0}", s.StudentName);
			}


			Console.WriteLine("***********  toLookup   *********");
			//ToLookUp only available for ms

			var lookupres = studentList.ToLookup(s => s.StudentName);

			//iterate each group        
			foreach (var ageGroup in lookupres)
			{
				Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

				foreach (Student s in ageGroup) // Each group has inner collection
					Console.WriteLine("Student Name: {0}", s.StudentName);
			}

		}


	}

}
