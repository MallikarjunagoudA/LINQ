using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
ElementAt           Returns the element at a specified index in a collection  --index

ElementAtOrDefault	Returns the element at a specified index in a collection or a default value if the index is out of range. --index

First	            Returns the first element of a collection, or the first element that satisfies a condition.--condition

FirstOrDefault	    Returns the first element of a collection, or the first element that satisfies a condition. Returns a default value if index is out of range. --condtions

Last	            Returns the last element of a collection, or the last element that satisfies a condition --condtions

LastOrDefault	    Returns the last element of a collection, or the last element that satisfies a condition. Returns a default value if no such element exists.--condtions

Single	            Returns the only element of a collection, or the only element that satisfies a condition.--condtions

SingleOrDefault	    Returns the only element of a collection, or the only element that satisfies a condition. Returns a default value if no such element exists or the collection does not contain exactly one element. --condtions

*/

namespace demoApp
{
    internal class Elements
    {

        public void FunElement()
        {

            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };


            //element
            var a = intList.ElementAt(4);

            //elementAt()
            var b = intList.ElementAtOrDefault(3);

            //first
            var c = intList.Where(s=>s%2==0).First();

            //firstordefault
            var d = intList.Where(s => s / 2 == 0).FirstOrDefault();

            
            //explore more on first, last and single









        }

    }
}
