using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoApp.model;


/*
 * 
 * Projection Operators: Select, SelectMany
 * 
 *There are two projection operators available in LINQ. 1) Select 2) SelectMany
 *
 * Select 
 * Projects values that are based on a transform function.
 * 
 * 
 * select Many
 * 
 * Projects sequences of values that are based on a transform function and then flattens them into one sequence.
 * 
 * 
 
 * 
 */



namespace demoApp
{
    public class LinqProjections
    {

        public void projections()
        {
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John gana" },
            new Student() { StudentID = 2, StudentName = "Moin gange subbu" },
            new Student() { StudentID = 3, StudentName = "Bill lakshmi shanta" },
            new Student() { StudentID = 4, StudentName = "Ram rahim rabart" },
            new Student() { StudentID = 5, StudentName = "Ron vikrant " }
            };

            //ms

            var selectms = studentList.Select(s => s);

            //qs

            var selectqs = (from s in studentList
                            select (s)).ToList();

            // select many
            //     Projects sequences of values that are based on a transform function and then flattens them into one sequence.

            var selectmany = (from std in studentList
                              from s in std.StudentName.Substring(0, 2)
                              select (s)).ToList();

            var selectmanyex = (from std in studentList
                              from s in std.StudentName.Split(" ")
                              select (s)).ToList();

        }

    }
}
