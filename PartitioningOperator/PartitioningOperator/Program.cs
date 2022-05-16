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
             * Partitioning data operations
             * 
             * These are used to divide data source inot two parts and return one of them as output without changing element positions.
             * 
             * examples
             * select top n number of records from data source
             * select records from a data-source until a specified condtion is true.
             * select all records except first n nuber of records.
             * skip records from a data-source until a specified condtion is true and select rest all records.
             * can be used to implement pagination from a data-source.
             * 
             * 
             * partition data methods
             * 
             * Take
             * TakeWhile
             * Skip
             * SkipWhile
             * 
             */



            List<int> num = new List<int>() { 1, 2, 3, 4, 1, 3, 6, 7, 8, 5, 7 };
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




            /*
             * Take operator
             * take operator is used to get first n number of records from a d-s where n is an interger which is passed in take method.
             * take method can be used in method syntax and mixed syntax
             * take method will make any change in element position
             * 
             */




            var ms = num.Take(4).ToList();
            var msWithWhere = num.Take(4).Where(x=>x>5).ToList();

            var mixedsyn = (from x in num select num).Take(5).ToArray();



            Console.WriteLine("Take done");



            /*
             * TakeWhile Operator
             * 
             * this is used to get all records from a d-s until a specified conditon is true.
             * once the condtion is failed takeWhile will not validate rest elements even if the condtion is true for remaining elements.
             * TakeWhile method can be used in method syntax and mixed syntax.
             * TakeWhile method will not make any change in element position.
             * 
             */




            //basic example
            var aa = new string[] { "cc", "aa", "bb", "cc", "dd", "cc", "cc"};
            var bb = new string[] { "ee", "ff", "cc", "dd" };

            var cc = aa.TakeWhile(a=>a.Contains("cc")).ToList();



            /*
             * 
             * skip Operator
             * 
             * Skip operator is used to skip first n number of records from a data sorce and select remaining elements as an output.
             * where n is an interger which is passed in Skip method.
             * skip method can be used in method syntax and mixed syntax.
             * skip method will not make any change in element position.  
             * 
              */

            var skipms = aa.Skip(3).ToList();

            var skipqs = (from a in aa
                          select a).Skip(4).ToList();

            /*
             * skipWhile operator
             * SkipWhile operator is used to skip all records from a data source until a condtion is true and select remaining elemetns as an output.
             * SkipWhile method can be used in method syntax and mixed syntax.
             * SkipWhile method will not make any change in element position. 
             * 
             */

            var skipms = aa.SkipWhile(a=>a.Contains("cc")).ToList();

            var skipqs = (from a in aa
                          select a.Contains("cc")).Skip(4).ToList();
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
