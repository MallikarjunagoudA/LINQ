using System;
using System.Collections.Generic;
using System.Linq;

namespace QuantifierOperation
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             * Quantifier operator
             * 
             * this can used on data source to check if some or all elements of that data source satisfy the condition or not
             * 
             * all the method in quantifier operator are return Boolean
             * 
             * condition may be for some or all
             * 
             * Methods
             * All(whether all the elements of the data source satisfy the condtion)
             * Any(whether  at least one element of the data source satisfy the condition)
             * Contains(Check whether the data source contains a specified element)
             * 
             */

            //All method
            Console.WriteLine("all method");
            List<student> std = new List<student>()
            {
                new student() { stdID=1, stdName="sujata",marks=89},
                new student() { stdID=2, stdName="suj",marks=90},
                new student() { stdID=2, stdName="hasuj",marks=91},
                new student() { stdID=2, stdName="yasuj",marks=99},
                new student() { stdID=3, stdName="jata",marks=95}
            };

            var stdAllms = std.All(s => s.marks > 80);//this results boolean

            if (stdAllms)
            {
                Console.WriteLine("condition true");

            }
            else
            {
                Console.WriteLine("condition false");
            }


            var stdAllql = (from s in std
                            select s).All(x => x.marks > 90);

            if (stdAllql)
            {
                Console.WriteLine("condition true");

            }
            else
            {
                Console.WriteLine("condition false");
            }



            //any method

            Console.WriteLine("any method");

            var stdAnyms = std.Any(s => s.marks > 80);//this results boolean

            if (stdAnyms)
            {
                Console.WriteLine("condition true");

            }
            else
            {
                Console.WriteLine("condition false");
            }


            var stdAnyql = (from s in std
                            select s).All(x => x.marks < 70);

            if (stdAnyql)
            {
                Console.WriteLine("condition true");

            }
            else
            {
                Console.WriteLine("condition false");
            }


            //contails method

            Console.WriteLine("contains");

            var stdContailsms = std.Any(s => s.stdName.Contains("suj"));//this results boolean

            if (stdContailsms)
            {
                Console.WriteLine("condition true");

            }
            else
            {
                Console.WriteLine("condition false");
            }


            var stdContainsql = (from s in std
                                 select s.stdName).Contains("suj");

            if (stdContainsql)
            {
                Console.WriteLine("condition true");

            }
            else
            {
                Console.WriteLine("condition false");
            }


        }
    }

    public class student
    {
        public int stdID { get; set; }
        public string stdName { get; set; }
        public int marks { get; set; }
    }
}
