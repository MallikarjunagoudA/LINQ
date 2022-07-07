using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Skip
//  Skips elements up to a specified position starting from the first element in a sequence.

//SkipWhile
//	Skips elements based on a condition until an element does not satisfy the condition. If the first element itself doesn't satisfy the condition, it then skips 0 elements and returns all the elements in the sequence.

//Take
//	Takes elements up to a specified position starting from the first element in a sequence.

//TakeWhile
//	Returns elements from the first element until an element does not satisfy the condition. If the first element itself doesn't satisfy the condition then returns an empty collection.


namespace demoApp
{
    public class Partitioning
    {

        public void partitions()
        {
            //skip
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

            var newList = strList.Skip(2);

            foreach (var str in newList)
                Console.WriteLine(str);


            //skipwhile()
            var resultList = strList.SkipWhile(s => s.Length < 4);

            foreach (string str in resultList)
                Console.WriteLine(str);

            //Output:
            //Three
            //Four
            //Five
            //Six




            var resultList1 = strList.SkipWhile(s => s.Length < 4);

            foreach (string str in resultList1)
                Console.WriteLine(str);

            //Output:
            //Three
            //One
            //Two
            //Four
            //Five
            //Six




            //take
            var resultList2 = strList.Take(2);


            //takewhile
            var resultList3 = strList.TakeWhile(s => s.Length < 4);




        }


    }
}
