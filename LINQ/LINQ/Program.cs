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

        }
    }

    class Employee
    {

        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int Empphone { get; set; }
        public string EmpMail { get; set; }
        
    }
}
