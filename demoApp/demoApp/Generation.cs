using demoApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//default empty
//it will use to assign the Empty and it will allow the default value as parameter as we want.

//Empty
//Returns an empty collection

//Range	
//Generates collection of IEnumerable<T> type with specified number of elements with sequential values, starting from first element.

//Repeat	
//Generates a collection of IEnumerable<T> type with specified number of elements and each element contains same specified value.

namespace demoApp
{
    public class Generation
    {

        public void Generations()
        {


            //Default Empty.

            var var1 = new List<string>();

            var str1 = var1.DefaultIfEmpty();
            var str2 = var1.DefaultIfEmpty("none");


            var var2 = new List<int>();

            var int1 = var2.DefaultIfEmpty();
            var int2 = var2.DefaultIfEmpty(100);




            //Empty

            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<Student>();

            Console.WriteLine("Count: {0} ", emptyCollection1.Count());
            Console.WriteLine("Type: {0} ", emptyCollection1.GetType().Name);

            Console.WriteLine("Count: {0} ", emptyCollection2.Count());
            Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name);


            //range
            var intCollection = Enumerable.Range(10, 10);
            Console.WriteLine("Total Count: {0} ", intCollection.Count());

            for (int i = 0; i < intCollection.Count(); i++)
                Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));




            //repeat
            var intCollection1 = Enumerable.Repeat<int>(10, 10);
            Console.WriteLine("Total Count: {0} ", intCollection1.Count());

            for (int i = 0; i < intCollection1.Count(); i++)
                Console.WriteLine("Value at index {0} : {1}", i, intCollection1.ElementAt(i));

        }
    }
}
