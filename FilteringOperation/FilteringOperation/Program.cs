using System;
using System.Collections.Generic;
using System.Linq;

namespace FilteringOperation
{
    public  class Program
    {
        static void Main(string[] args)
        {

            /*
             * filter opeation
             * 
             * filtering is the process to get only those elements from the data source who satisfy the specified condition.
             * 
             * we can write more than one condition based on the requirment.
             * 
             * example
             * 
             * employee having salary less than 50k
             * 
             * employee name start with s and age is less 40 years
             * 
             */

            List<Employee> emp = new List<Employee>()
            {
                new Employee {empId = 1, empName ="Mallikarjun", empAge=25, empSalary=500000},
                new Employee {empId = 2, empName ="gana", empAge=24, empSalary=550000},
                new Employee {empId = 3, empName ="ahish", empAge=23, empSalary=560000},
                new Employee {empId = 4, empName ="manu", empAge=20, empSalary=50000}
            };


            /*filter operator
             * 
             * 
             * where operator
             * where comes upder filter operator
             * where always expect the condition
             * 
             */

            var querysyntax = (from e in emp
                               where e.empId % 2 == 0 && e.empName.Contains("a")
                               select e).ToList();

            var methodSyntax = emp.Where(e => e.empSalary > 55000 && e.empAge < 24).ToList();

            foreach(Employee e in querysyntax)
            {
                Console.WriteLine("{0}", e.empSalary);
            }


            foreach (Employee e in methodSyntax)
            {
                Console.WriteLine("{0}", e.empSalary);
            }




            /*
             * OfType operator
             * 
             * comes upder filter operator
             * 
             * used to filter data based on the type of data
             * 
             *used as generic method to filter the based on the any type.
             *
             */

            var datasourceForOftype = new List<object>() { "malli", "manu", "madhu", 1, 3, 4, 5, 6, 7,2 };

            var filterBasedOnType = datasourceForOftype.OfType<string>();


            Console.WriteLine("use of OfType Method taking only string");
            foreach (string e in filterBasedOnType)
            {
                Console.WriteLine("{0}", e);
            }

            var filterBasedOnType1 = datasourceForOftype.OfType<int>();

            Console.WriteLine("use of OfType Method taking only integer");
            foreach (int e in filterBasedOnType1)
            {
                Console.WriteLine("{0}", e);
            }




            /*
             * sorting operator
             * 
             * sorting is used to manage the data in perticuler order
             * 
             * it many asc or desc
             * 
             * order my based on int or other data type
             * 
             * 
             * There are 5 sorting methods 
             * 
             * OrderBy
             * OrderByDesecending
             * ThenBy
             * ThenByDescending
             * Reverse
             * 
             */

            /*
             * OrderBy
             * 
             * used to asc order and for any data type 
             */
            var Orderbyoperator = datasourceForOftype.OfType<int>().OrderBy(e=>e).ToList();

            var orderbyoperator1 = (from e in emp
                                    where e.empSalary > 50000
                                    orderby e
                                    select e).ToString();

            Console.WriteLine("use of orderBy Method taking only integer");
            foreach (int e in Orderbyoperator)
            {
                Console.WriteLine("{0}", e);    
            }

            /*
           * OrderByDescending
           * 
           * used to desc order and for any data type 
           */

            var Orderbydescoperator = datasourceForOftype.OfType<int>().OrderByDescending(e => e).ToList();

            var orderbydescoperator1 = (from e in emp
                                    where e.empSalary > 50000
                                    orderby e descending
                                    select e).ToString();

            Console.WriteLine("use of orderBydescending Method taking only integer");
            foreach (int e in Orderbyoperator)
            {
                Console.WriteLine("{0}", e);
            }






            /*
            * thenBy
            * 
            * ThenBy method used to sort the data on the second level and so on in asc order
            * 
            * TheyByDescending
            * 
            * ThenByDescending method used to sort the data on the second level and so on in desc order
            * 
            * "these method are used with the orderBy and orderbyDescending operator"
            * 
            * examples
            * `first sort on empName and then sort on the salary`
            * 
            */

            var ThenByopeator = emp.OrderByDescending(e => e.empName).ThenBy(e => e.empSalary).ToList();

            var ThenByopeator1 = (from e in emp
                                        orderby e.empAge descending, e.empSalary descending
                                       
                                        select e).ToString();

            Console.WriteLine("use of ThenBy() Method");
            foreach (Employee e in ThenByopeator)
            {
                Console.WriteLine("{0},{1}", e.empName ,e.empSalary);
            }


            /*
             * reverse 
             * 
             * reverse available in system.linq and system.collection.generic
             * 
             */
            Console.WriteLine("reverse method");
            var rollnumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("before reverse method");

            foreach (int i in rollnumbers)
            {
                Console.WriteLine("{0}", i);
            }
            var revRoll = rollnumbers.Reverse();



            var qs = (from roll in rollnumbers
                      select roll).Reverse();
            Console.WriteLine("after reverse method");

            foreach (int i in revRoll)
            {
                Console.WriteLine("{0}", i);
            }


            //for a generic method


            var rollnumbersGeneric = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("before reverse method");

            foreach (int i in rollnumbers)
            {
                Console.WriteLine("{0}", i);
            }
            rollnumbersGeneric.Reverse();

            var rol =rollnumbersGeneric.AsQueryable().Reverse();



            var rol1 = (from roll in rollnumbersGeneric
                      select roll).AsQueryable().Reverse();

            Console.WriteLine("after reverse method");

            foreach (int i in revRoll)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }

    public class Employee
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public int empSalary { get; set; }
        public int empAge { get; set; }
    }
}
