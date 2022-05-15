using System;
//adding collections and the linq
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace LINQSelectManyDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             * select many method
             * 
             * select many method used to project each element of sequence to an IEnumerable<T> and flatterns the resulting sequence to one sequence.
             * 
             * selectMany combines records from a sequence of result and converts it into one result.
             *   
             *   selectMany comes under the projection category.
             *   
             */


            // example 1

            List<string> friends = new List<string>() { "hanamanth", "bheema" };

            var selctManyID = (from friend in friends
                               from ch in friend
                               select ch);

            foreach (var c in selctManyID)
            {
                Console.WriteLine("each value as stirng make one as {0}", c);
            }


            /*
             * output
             * each value as stirng make one as h
             * each value as stirng make one as a
             * each value as stirng make one as n
             * each value as stirng make one as a
             * each value as stirng make one as m
             * each value as stirng make one as a
             * each value as stirng make one as n
             * each value as stirng make one as t
             * each value as stirng make one as h
             * each value as stirng make one as b
             * each value as stirng make one as h
             * each value as stirng make one as e
             * each value as stirng make one as e
             * each value as stirng make one as m
             * each value as stirng make one as a
            */


            //example 2

            Console.WriteLine("example 2 get data from complex datasource");
            List<Employee> e = new List<Employee>() { 
            
            new Employee{empid = 1, empName =new List<string>() {"mallikarjuna", "anandagoud", "arahunasi"} },
            new Employee{empid = 2, empName =new List<string>() {"venkaraddi", "anandagoud", "arahunasi"} },
            new Employee{empid = 3, empName =new List<string>() {"Hemaraddi", "sangangoud", "arahunasi"} },
            
            };


            //method
             Console.WriteLine("method");
            var empNameList = e.SelectMany(emp => emp.empName).ToList();


            foreach (var c in empNameList)
            {
                Console.WriteLine("{0}", c);
            }

            //query
            Console.WriteLine("query");

            var empNameList1 = (from emp in e
                                from empName in emp.empName
                                select empName).ToList();



            foreach (var c in empNameList1)
            {
                Console.WriteLine("{0}", c);
            }

            /* output
             * method
             * mallikarjuna
             * anandagoud
             * arahunasi
             * venkaraddi
             * anandagoud
             * arahunasi
             * Hemaraddi
             * sangangoud
             * arahunasi
             * query
             * mallikarjuna
             * anandagoud
             * arahunasi
             * venkaraddi
             * anandagoud
             * arahunasi
             * Hemaraddi
             * sangangoud
             * arahunasi
            */


            //get distinct

            Console.WriteLine("query => get distinct");

            var empNameList2 = (from emp in e
                                from empName in emp.empName
                                select empName).Distinct().ToList();



            foreach (var c in empNameList2)
            {
                Console.WriteLine("{0}", c);
            }



        }
    }

    class Employee
    {
        public int empid { get; set; }
        public List<string> empName { get; set; }

    }

}
