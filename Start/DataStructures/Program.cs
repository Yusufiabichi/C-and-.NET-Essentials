using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] comedians = {"Leo Gallergher", "Lave Chappelle", "Chris Rock", 
                "Eddie Murphy", "Richard Pryor", "Yusufia Bichi" };
            List<string> strList = new List<string>(10);

            strList.AddRange(comedians);

            strList.Add("Mahdi Yusuf");
            strList.Add("Sani Usman");

            Console.WriteLine($"Count and Capacity: {strList.Count}, {strList.Capacity}");

            //PrintList(strList); 

            // get item by index
            //Console.WriteLine($"Item Value: {strList[4].Length}");
            //List<string> strList2 = new List<string>(10);
            foreach(string str in strList)
            {
                Console.WriteLine($"The Length of {str} is: {str.Length}");
            }

            // remove item from the list
            strList.RemoveAt(3);
            strList.Remove("Yusufia Bichi");

            // sort the list
            strList.Sort();
            //PrintList(strList);

            // search the list
            Console.WriteLine (strList.Contains("Dave Chappelle"));

            // Exists function
            bool found = strList.Exists(x => x.Length > 15);
            Console.WriteLine($"Item found: {found}");

            // use the find function to search through items
            string item = "";
            item = strList.Find(x => x.StartsWith("L"));
            Console.WriteLine($"Item: {item}");

            // The findAll function can fimd multiple itmes
            List<string> itemList = strList.FindAll(x => x.StartsWith("L"));
            PrintList(itemList);

            // Use TrueForAll to see if a given condition is true for all elements
            bool result = strList.TrueForAll(x => x.Length > 10);
            Console.WriteLine($"Result: {result}");

        }

        static void PrintList(List<string> theList)
        {
            foreach(string str in theList)
            {
                Console.WriteLine(str);
            }
        }
    }
}