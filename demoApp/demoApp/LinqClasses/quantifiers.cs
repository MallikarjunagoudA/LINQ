using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoApp.model;

/*
 * 
 * 
 * All	    =>     Checks for all the elements in a sequence satisfies the specified condition. 
 * 
 *Any	    =>     Checks if any of the elements in a sequence satisfies the specified condition
 * 
 * Contains	=>     Checks if the sequence contains a specific element 
 * 
 */




namespace demoApp
{
    public class quantifiers
    {
        public void quantifier()
        {
                IList<Student> studentlist = new List<Student>()
            {
                new Student {StandardID=1, StudentName="manoju", Age=23},
                new Student {StandardID=2, StudentName="mallu", Age=24},
                new Student {StandardID=3, StudentName="vanku", Age=19},
                new Student {StandardID=4, StudentName="gana", Age=22},
                new Student {StandardID=5, StudentName="ahish", Age=23}
            };


            // ex for all
                var exforAll = studentlist.All(s => s.Age > 12 && s.Age < 20);

            Console.WriteLine(exforAll);

            // ex for Any
            var exforAny = studentlist.Any(s => s.Age > 12 && s.Age < 20);

            Console.WriteLine(exforAny);

            // ex for Contains
            var exforContains = studentlist.Select(s=>s.StudentName.Contains("g"));

            Console.WriteLine(exforContains);

            // ex for startwith
            var exforSart = studentlist.Select(s => s.StudentName.StartsWith("m"));

            Console.WriteLine(exforSart);


        }
     

    }
}
