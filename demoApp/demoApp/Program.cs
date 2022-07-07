using System;
using System.Linq;
using demoApp.model;
using demoApp;


namespace demoApp
{
    public class Program
    {

       


        static void Main(string[] args)
        {
            //char[] chars = { 'H', 'e', 'l', 'l', 'o' };

            //string str1 = new string(chars);
            //String str2 = new String(chars);

            //Student std = new Student() { Id = 1, age = 24, Name = "Mallikarjun" };
            //Student std1 = new Student() { Id = 2, age = 24, Name = "Mallu" };
            //Student std2 = new Student() { Id = 3, age = 22, Name = "Arjun" };
            //Student std3 = std;
            //foreach (char c in str1)
            //{
            //    Console.WriteLine(c);
            //}



            //dynamic a = 12;
            //a = "abc";
            //Console.WriteLine(a);

            //var b = 23;
            //var d = 23;

            //Console.WriteLine(std.age.Equals(std3.age));
            //Console.WriteLine(std.age ==  std3.age);



            //object str = "hello";
            //char[] values = { 'h', 'e', 'l', 'l', 'o' };
            //object str6 = new string(values);
            //Console.WriteLine("Using Equality operator: {0}", str == str6);
            //Console.WriteLine("Using equals() method: {0}", str.Equals(str6));


            //Console.ReadLine();


            var str = "hlha";
            var count = str.Length;
            string revStr=String.Empty;
            //var str3 ="";

            var abc =str.Reverse();
            for(int i=count-1;i>=0;i--)
            {

                //revStr = new { str[i] };
                revStr = revStr + str[i];
                //str3.(str[i]);
            }
            //Console.WriteLine(abc);
            //foreach(char c in str)
            //{
            //    revStr = c + revStr;
            //}

            ////var str1 = revStr.ToString();

            //if (str == revStr)
            //{
            //    Console.WriteLine(revStr);

            //}









            LinqFilterDemo lf =new LinqFilterDemo();
            //lf.FilterDemo();

            LinqSorting ls = new LinqSorting();
            //ls.LinqSort();

            LinqGroups lg = new LinqGroups();
            //lg.LinqGroup();

            LinqJoins lj = new LinqJoins();
            //lj.Joins();

            LinqProjections lp = new LinqProjections();
            //lp.projections();

            quantifiers q = new quantifiers();
            q.quantifier();

            Elements e = new Elements();
            e.FunElement();










            Console.ReadLine();

        }
    }

}
