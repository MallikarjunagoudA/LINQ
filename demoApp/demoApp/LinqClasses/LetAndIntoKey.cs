using demoApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






//The 'let' keyword is useful in query syntax.It projects a new range variable,
//allows re - use of the expression and makes the query more readable.

//Use "into" keyword in LINQ query to form a group
namespace demoApp
{
    public class LetAndIntoKey
    {

        public void letinto()
        {


            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };


            var lowercaseStudentNames = from s in studentList
                                        where s.StudentName.ToLower().StartsWith("r")
                                        select s.StudentName.ToLower();


            //using let
            var lowercaseStudentNames1 = from s in studentList
                                        let lowercaseStudentName = s.StudentName.ToLower()
                                        where lowercaseStudentName.StartsWith("r")
                                        select lowercaseStudentName;




        }

    }
}
