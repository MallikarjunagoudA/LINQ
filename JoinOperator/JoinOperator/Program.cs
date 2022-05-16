using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;


namespace JoinOperator
{
    public class Program
    {
        static void Main(string[] args)
        {



            /*
             * 
             * Join operator
             * 
             * as per microsoft document -
             * "A join of two data ssources is the association fo objects in one data souce with objects that share a common attribute in another data souce"
             *
             *in simple words-
             *"Join operations are used to get data from multiple data souces based on some common property in data sources"
             *
             *Join operations methods
             *
             *Join(used to ge data from 2 data sources)
             *GroupJoin(used to get data from 2 data sources by grouping all the elements)
             *
             */


            List<Student> std = new List<Student>()
            {
                new Student {ID=1, adressid=0},
                new Student {ID=1, adressid=2},
                new Student {ID=1, adressid=0},
                new Student {ID=1, adressid=4},
                new Student {ID=1, adressid=3},
                new Student {ID=1, adressid=0}
            };

            List<StudentAdress> stdAdres = new List<StudentAdress>()
            {
                new StudentAdress {Id=1, address="line 1"},
                new StudentAdress {Id=2, address="line 1"},
                new StudentAdress {Id=3, address="line 1"},
                new StudentAdress {Id=4, address="line 1"},
                new StudentAdress {Id=5, address="line 1"}
            };


            /*
             * inner join
             * 
             * in simple words -inner join =elements which has a common properties in both the data sources.
             */



            var innerJoinqs = (from s in std
                               join ss in stdAdres on s.adressid equals ss.Id
                               select s).ToList();

            /*
             * 
             * Group join
             * 
             * group jon is applied on 2 more data sources based on a key which links both the data sources and produce result in form of groups.
             * 
             * in simple words- it is used to group the result based on common key.
             * 
             */


            var gropuJoin = (from s in std
                               join ss in stdAdres on s.adressid equals ss.Id into stdgroups
                               select stdgroups).ToList();



            /*
             * LEFT JOIN
             *  in the left or left outer join 
             *  "all data from first data source is return, regardless of whether it has any related data in second data source."
             *
             *if for few(or all) records data is not available in second d-s then null value is returned for second d-s.
             *
             *left join or left outer join both are same because outer keyword is optional.
             */
             
                   var Leftjoin = (from s in std
                               join ss in stdAdres on s.adressid equals ss.Id into studentAddress
                              from stud in studentAddress.DefaultIfEmpty()
                                    select new { s, stud}).ToList();



            /*
            * Right JOIN
            *  in the left or left outer join 
            *  "all data from first data source is return, regardless of whether it has any related data in second data source."
            *
            *if for few(or all) records data is not available in First d-s then null value is returned for first d-s.
            *
            *RIGHT join or riht outer join both are same because outer keyword is optional.
            */
            var Rightjoin = (from s in stdAdres
                             join ss in std on s.Id equals ss.adressid into studentAddress
                            from stud in studentAddress.DefaultIfEmpty()
                            select new { s, stud }).ToList();



            /*
             * elementat() and elementatOrDefault()
             * 
             * elementAt() we need to pass the index value. if ntg is available then its through the exception
             * 
             * elementatOrDefault() will return index valule or else wil return default value. for int 0 and for string null as default.
             * 
             */

            var aa = new string[] { "aa", "bb", "cc", "dd" };
            var bb = new int[] { 1,3,2,5,4,6,8,6 };

            var elementAt = aa.ElementAt(0);

            var elementAtordefaultIs = aa.ElementAtOrDefault(10);



        }
    }

    public class Student
    {

        public int ID { get; set; }
        public int adressid { get; set; }

    }

    public class StudentAdress
    {
        public int Id { get; set; }
        public string address { get; set; }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return x.ID.Equals(y.ID) && x.adressid.Equals(y.adressid);
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            int idhash = obj.ID.GetHashCode();
            int Nmaehash = obj.adressid.GetHashCode();

            return idhash ^ Nmaehash;
        }
    }

}
