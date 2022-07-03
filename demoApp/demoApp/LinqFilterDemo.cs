using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoApp.model;

/*
 **** Where***
 * Where is used for filtering the collection based on given criteria.
 * 
 * Where extension method has two overload methods. Use a second overload method to know the index of current element in the collection.
 * 
 * Method Syntax requires the whole lambda expression in Where extension method whereas Query syntax requires only expression body.
 * 
 * Multiple Where extension methods are valid in a single LINQ query.
 * 
 * 
 * OfType()
 * 
 * 
 * 
 * The Where operator filters the collection based on a predicate function.
 * 
 * The OfType operator filters the collection based on a given type
 * 
 * Where and OfType extension methods can be called multiple times in a single LINQ query.
 * 
 * 
 * 
 * 
 */










namespace demoApp
{				
	public  class LinqFilterDemo
	{
		public  void FilterDemo()
		{
			// Student collection
			IList<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
				new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
				new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
			};


			Console.WriteLine("**************** where ************************");


			//qs
			var filterValue = (from stdList in studentList
							  where stdList.Age>12 && stdList.Age<20
							  select stdList);

			//ms
			var filterValuems = studentList.Where(x => x.Age > 15 && x.Age < 25);

			Func<Student, bool> isTeenAger = delegate (Student s) {
				return s.Age > 12 && s.Age < 20;
			};

			var filteredResult = from s in studentList
								 where isTeenAger(s)
								 select s;



			var filteredResult1 = from s in studentList
								 where isTeenAgerFromstatic(s)
								 select s;

			foreach (var std in filteredResult)
				Console.WriteLine(std.StudentName);


			//OVERLOAD SECOND PARAMETER.

			var val = studentList.Where((s, i) =>
			{
				
				return i % 2 == 0;
			});

			foreach(Student i in val)
            {
				Console.WriteLine(i.Age);

			}

			//multiple where clause accept in linq.
			var filteredResult2 = from s in studentList
								  where isTeenAgerFromstatic(s)
								  where isTeenAger(s)
								  select s;



			Console.WriteLine("****************OfType()************************");



			//////////////////////////////      OfType()  ///////////////////////////////////////////

			IList mixedList = new ArrayList();

			mixedList.Add(0);
			mixedList.Add("hello");
			mixedList.Add("hi");
			mixedList.Add("namaste");
			mixedList.Add(3);
			mixedList.Add(5);
			mixedList.Add(0);
			mixedList.Add(0);
			mixedList.Add(0);
			mixedList.Add(0);

			var mixedListCount=mixedList.Count;
			Console.WriteLine(mixedListCount);

			//qs
			var ofTypeqs = (from m in mixedList.OfType<int>()
							select m);

			//ms
			var oftypems = mixedList.OfType<string>();


			foreach (var c in mixedList)
			{
				Console.WriteLine(c);

			}
			foreach (string a in oftypems)
            {
				Console.WriteLine(a);

			}
			foreach (int b in ofTypeqs)
			{
				Console.WriteLine(b);

			}




















		}

		public static bool isTeenAgerFromstatic(Student s)
		{
			return s.Age > 12 && s.Age < 20;
		}

		



	}

}
