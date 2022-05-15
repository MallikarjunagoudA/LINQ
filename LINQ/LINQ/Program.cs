using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Employee> emp = new List<Employee>()
            {
                new Employee(){EmpID=1, EmpName="gana1",Empphone=00000077,EmpMail="gana@gmail.com"},
                new Employee(){EmpID=2, EmpName="gana2",Empphone=00000055,EmpMail="mgana@gmail.com"},
                new Employee(){EmpID=3, EmpName="gana3",Empphone=00000044,EmpMail="kgana@gmail.com"},
                new Employee(){EmpID=4, EmpName="gana4",Empphone=00000033,EmpMail="hgana@gmail.com"},
                new Employee(){EmpID=5, EmpName="gana5",Empphone=00000022,EmpMail="fgana@gmail.com"}
            };


            Console.WriteLine("query syntax");

            //query syntax linq demo

            var list =(from a in emp
                    where a.EmpName.Contains("gana")
                    select a).ToList();   

            foreach(Employee e in list)
            {
                Console.WriteLine("empname {0}, empmail {1}", e.EmpName, e.EmpMail);
            }

            //method syntax

            var list1 = emp.Where(e => e.EmpName.Contains("gana"));//.Select(e => e);

            Console.WriteLine("method syntax");
            foreach (Employee e in list1)
            {
                Console.WriteLine("empname {0}, empmail {1}", e.EmpName, e.EmpMail);
            }









            //Ienumerable linq demo

            Console.WriteLine("Ienumerable syntax");
            IEnumerable<Employee> list2 = (from a in emp
                        where a.EmpName.Contains("gana")
                        select a).ToList();

            foreach (Employee e in list2)
            {
                Console.WriteLine("empname {0}, empmail {1}", e.EmpName, e.EmpMail);
            }

            //Iquerable linq demo

            IQueryable<Employee> list3   = emp.AsQueryable().Where(e => e.EmpName.Contains("gana"));//.Select(e => e);

            Console.WriteLine("Ienumerable syntax");
            foreach (Employee e in list3)
            {
                Console.WriteLine("empname {0}, empmail {1}", e.EmpName, e.EmpMail);
            }






            //chapter 6
            //linq operators
            //select in linq
            /*selct the data with 
             * other class
             * ananymous method
             * with index
             */

            //basic query 

            var BasicQuery = (from a in emp
                        select a).ToList();

            Console.WriteLine("Ienumerable syntax");
            foreach (Employee e in list3)
            {
                Console.WriteLine("empname {0}, empmail {1}", e.EmpName, e.Empphone);
            }

            var BasicMethod= emp.ToList();

            Console.WriteLine("Ienumerable syntax");
            foreach (Employee e in list3)
            {
                Console.WriteLine("empname {0}, empmail {1}", e.EmpName, e.Empphone);
            }




            /*
             * operations
             */

            //fetch only id
            
            var Fectchonlyid=(from e in emp
                              select e.EmpID).ToList();


            var FetchOnlyid1 =emp.Select(e => e.EmpID).ToList(); 



            //fetch only id as string

            var FectchonlyidasString = (from e in emp
                                select e.EmpID.ToString()).ToList();

            var FetchOnlyid1asString = emp.Select(e => e.EmpID.ToString()).ToList();






            //fetch data as object

            var FectchonlyidasObj = (from e in emp
                                     select new Employee() 
                                     {
                                         EmpID = e.EmpID,
                                         EmpName = e.EmpName 
                                     }
                                     ).ToList();


            var FetchOnlyidasObj = emp.Select(e =>new Employee 
            {
                EmpName =e.EmpName,
                EmpMail=e.EmpMail
            }).ToList();



            /* 
             * fetch data to other class
             */
            var FectchToStudent = (from e in emp
                                     select new Student()
                                     {
                                         EmpID = e.EmpID,
                                         EmpName = e.EmpName
                                     }
                                 ).ToList();


            var FectchToStudent1 = emp.Select(e => new Student
            {
                EmpName = e.EmpName,
                EmpMail = e.EmpMail
            }).ToList();






            /*
             * select many method
             */











        }
    }

    class Employee
    {

        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int Empphone { get; set; }
        public string EmpMail { get; set; }
        
    }


    class Student
    {

        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int Empphone { get; set; }
        public string EmpMail { get; set; }

    }

}
