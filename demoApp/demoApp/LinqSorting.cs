using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoApp.model;


/*
 * order by and order by desc
 * 
 *   LINQ includes five sorting operators: OrderBy, OrderByDescending, ThenBy, ThenByDescending and Reverse
 * 
 *   LINQ query syntax does not support OrderByDescending, ThenBy, ThenByDescending and Reverse. It only supports 'Order By' clause with 'ascending' and 'descending' sorting direction.

 *   LINQ query syntax supports multiple sorting fields seperated by comma whereas you have to use ThenBy & ThenByDescending methods for secondary sorting.
 *   
 *     
 *     
 *     ThenBy()  and ThenByDesceding()
 *     
 *      OrderBy and ThenBy sorts collections in ascending order by default.
 *     
 *		ThenBy or ThenByDescending is used for second level sorting in method syntax.
 *
 *		ThenByDescending method sorts the collection in decending order on another field.
 *
 *		ThenBy or ThenByDescending is NOT applicable in Query syntax.
 *
 *		Apply secondary sorting in query syntax by separating fields using comma.
 *     
 *     
 *     
 *     *reverse
 *     
 *     
 *     
 *     
 *   
 */






namespace demoApp
{
	public class LinqSorting
	{
		public void LinqSort()
		{
			// Student collection
			IList<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
				new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
			};

			//order by qs
			Console.WriteLine("order by qs");

			var orderByResult = from s in studentList
								orderby s.StudentName //Sorts the studentList collection in ascending order
								select s;

			Console.WriteLine("order by descending");

			var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
										  orderby s.StudentName descending
										  select s;

			Console.WriteLine("Ascending Order:");

			foreach (var std in orderByResult)
				Console.WriteLine(std.StudentName);

			Console.WriteLine("Descending Order:");

			foreach (var std in orderByDescendingResult)
				Console.WriteLine(std.StudentName);


			//order by ms
			Console.WriteLine("order by ms");

			var orderbyms = studentList.OrderBy(s => s.Age);
			var orderbydescms = studentList.OrderByDescending(s => s.StudentID);

			foreach (var std in orderbyms)
				Console.WriteLine( std.Age);

			foreach (var std in orderbydescms)
				Console.WriteLine( std.StudentID);




			////////////////////   thenBy()       ////////////////////////////////////////
			Console.WriteLine("then by");

			var thenbyms = studentList.OrderBy(s => s.Age).ThenBy(s => s.StudentName);

			foreach (var std in thenbyms)
				Console.WriteLine(std.Age);


			var thenbydescms = studentList.OrderBy(s => s.Age).ThenByDescending(s => s.StudentName);

			foreach (var std in thenbydescms)
				Console.WriteLine(std.StudentID);



			Console.WriteLine("  reverse  ");

			var reverseusing = studentList.OrderBy(s => s.Age).Reverse();

			foreach (var std in reverseusing)
				Console.WriteLine(std.Age);

		}

	}

}
