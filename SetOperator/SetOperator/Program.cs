using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SetOperator
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             * set operations
             * 
             * Distinct(removes duplicate values from data source)
             * 
             * Except(returns all the elements from one data source taht do not exist in second data source)
             * 
             * Intersect (returns all the elements which exist in both the data source)
             * 
             * Union (teturns all the elements that appear in either of two data sources)
             * 
             */

            /*
             * Distinct Operator
             * 
             * Distinct operator is used to return distnct records from data source
             * it has 2 overloaded method
             * distinct can be used with comparer also.
             * we will use the IEqaulityComparer to use distinct with complex data source 
             */

            List<int> num = new List<int>() { 1, 2, 3, 4, 1, 3, 6, 7, 8, 5, 7 };

            var ms = num.Distinct().ToList();


            //ex 2

            List<Student> std = new List<Student>()
            {
                new Student{ ID=1, name="Malli"},
                new Student{ ID=2, name="Mallikar"},
                new Student{ ID=1, name="Malli"},
                new Student{ ID=3, name="Mallikarjuna"},
                new Student{ ID=2, name="Mallikar"},
            };

            List<Student> std1 = new List<Student>()
            {
                new Student{ ID=1, name="Malli"},
                new Student{ ID=2, name="Mallikar"},
                new Student{ ID=1, name="Malli"},
                new Student{ ID=5, name="Mallikarjuna"},
                new Student{ ID=6, name="Mallikar"},
            };


            //here for complex data source we need to use IequalityComparer use distinct

            var ms1 = std.Distinct(new StudentComparer()).ToList();

            Console.WriteLine("distinct done");


            /*
             * Exept Operator
             * 
             * Except operator is used to return all the eleements from one data source that do not exist in second data source.
             * it has 2 overloaded methods.
             * except can be used with comparer aslo.
             */


            //basic example
            var aa =new string[] { "aa","bb","cc","dd"};
            var bb =new string[] { "ee","ff","cc","dd"};

            var cc = aa.Except(bb).ToList();

            //o/p
            // aa and bb

            //complex example
            var exceptms = std.Except(std1, new StudentComparer()).ToList();

            var exceptqs = (from s in std
                            select s).Except(std1, new StudentComparer()).ToList();



            /*
             * 
             * intersect Operator
             * 
             * intersect is used to find the common elements in both sata sources
             * it has 2 overloaded methods.
             * intersect can be used with comparer also.
             * 
             */

            var intersectms = aa.Intersect(bb).ToList();


            var intersectqs = (from a in aa
                               select a).Intersect(bb).ToList();


            //o/p 
            //cc and dd


            //complex example
            var intersectms1 = std.Intersect(std1, new StudentComparer()).ToList();

            var interssectqs1 = (from s in std
                            select s).Intersect(std1, new StudentComparer()).ToList();

            Console.WriteLine("interssect done");


            /*
             * Union operator
             * 
             * union operator is used to combine multiple data sources
             * union operator removes all the duplicate elements
             * it has 2 overloaed methods
             * union can be used with comparer also.
             */

            //ex 1

            var unionms = aa.Union(bb).ToList();


            var unionqs = (from a in aa
                               select a).Union(bb).ToList();

            //o/p 
            //aa bb cc dd ee ff

            //ex complex
            var unionms1 = std.Union(std1, new StudentComparer()).ToList();

            var unionql1 = (from s in std
                                 select s).Union(std1, new StudentComparer()).ToList();

            Console.WriteLine("union done");
        }
    }

    public class Student 
    {

        public int ID { get; set; }
        public string name { get; set; }

    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return x.ID.Equals(y.ID) && x.name.Equals(y.name);
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            int idhash = obj.ID.GetHashCode();
            int Nmaehash = obj.name.GetHashCode();

            return idhash ^ Nmaehash;
        }
    }

}
