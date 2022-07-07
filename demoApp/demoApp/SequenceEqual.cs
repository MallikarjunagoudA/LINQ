using demoApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
*   There is only one equality operator: SequenceEqual.The SequenceEqual method checks whether the number of elements, 
    value of each element and order of elements in two collections are equal or not.

*   If the collection contains elements of primitive data types then it compares the values and number of elements,
    whereas collection with complex type elements, checks the references of the objects. So,
    if the objects have the same reference then they considered as equal otherwise they are considered not equal.


*   The SequenceEqual method compares the number of items and their values for primitive data types.
    The SequenceEqual method compares the reference of objects for complex data types.
    Use IEqualityComparer class to compare two colection of complex type using SequenceEqual method.


Concatenation Operator: Concat

*   The Concat() method appends two sequences of the same type and returns a new sequence (collection).

*/




namespace demoApp
{
    internal class SequenceEqual
    {

        public void seqEqual()
        {

            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            IList<string> strList2 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            bool isEqual1 = strList1.SequenceEqual(strList2); // returns true
            Console.WriteLine(isEqual1);


            //FOR OBJ

            Student std = new Student() { StudentID = 1, StudentName = "Bill" };

            IList<Student> studentList1 = new List<Student>() { std };

            IList<Student> studentList2 = new List<Student>() { std };

            bool isEqual = studentList1.SequenceEqual(studentList2); // returns true

            Student std1 = new Student() { StudentID = 1, StudentName = "Bill" };
            Student std2 = new Student() { StudentID = 1, StudentName = "Bill" };

            IList<Student> studentList3 = new List<Student>() { std1 };

            IList<Student> studentList4 = new List<Student>() { std2 };

            isEqual = studentList3.SequenceEqual(studentList4);// returns false



                    ///obj complex comparision.
                    ///
                    IList<Student> studentList5 = new List<Student>() 
                    {
                        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
                    };

                    IList<Student> studentList6 = new List<Student>() {
                        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
                    };
                    // following returns true
                    bool isEqual4 = studentList5.SequenceEqual(studentList6, new StudentComparer());





            ///concat
            ///
            IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
            IList<string> collection2 = new List<string>() { "Five", "Six" };

            var collection3 = collection1.Concat(collection2);
            foreach (string str in collection3)
                Console.WriteLine(str);


            IList<int> collection11 = new List<int>() { 1, 2, 3 };
            IList<int> collection22 = new List<int>() { 4, 5, 6 };

            var collection33 = collection11.Concat(collection22);

            foreach (int i in collection33)
                Console.WriteLine(i);

        }









    }









}
