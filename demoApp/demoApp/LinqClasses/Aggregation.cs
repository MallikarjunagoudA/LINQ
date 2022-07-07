using demoApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * Method	    Description
 * Aggregate	Performs a custom aggregation operation on the values in the collection.
 * Average	    calculates the average of the numeric items in the collection.
 * Count	    Counts the elements in a collection.
 * LongCount	Counts the elements in a collection.
 * Max	        Finds the largest value in the collection.
 * Min      	Finds the smallest value in the collection.
 * Sum        	Calculates sum of the values in the collection.
 * 
 */





namespace demoApp
{
    public class Aggregation
    {

        public void Aggregations()
        {
            IList<Student> studentList = new List<Student>() {

                    new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }

            };
            IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

            //aggregation

            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 = s1 + "," + s2); 
        Console.WriteLine(commaSeperatedString);


            //ex 2
            var aggreatename = studentList.Aggregate<Student, string>(
                     "student Names:",
                     (str, s) => str += s.StudentName + ",");
            Console.WriteLine(aggreatename);


            //ex 4
            var sumofage = studentList.Aggregate<Student, int>(
                0,
                (str,s)=>str +=s.Age);
            Console.WriteLine(sumofage);

            //ex 3

            string arr = studentList.Aggregate<Student, string, string>(
                string.Empty,
                (str, s) =>str +=s.StudentName+",",
                (str)=>str.Substring(0,str.Length-1));



            string commaSeparatedStudentNames = studentList.Aggregate<Student, string, string>(
                                                        String.Empty, // seed value
                                                        (str, s) => str += s.StudentName + ",", // returns result using seed value, String.Empty goes to lambda expression as str
                                                        str => str.Substring(0, str.Length - 1)); // result selector that removes last comma

            Console.WriteLine(aggreatename);



            //avarage:

            IList<int> intlist = new List<int> { 10, 20, 30, 40, 50 };

            double avg = intlist.Average();
;
            Console.WriteLine(avg);

            //ex 2

            var avgStudentage = studentList.Average(s => s.Age);








        }



    }
}
