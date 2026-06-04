// Example file for C# Applied Data Structures by Joe Marini
// Programming Challenge

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;

namespace Challenge
{
    class Program
    {
        static void PrintStringStats(string TheString)
        {
            // Split the string on space character boundary
            string[] wordArray = TheString.Split(' ');

            // TODO: Count the total number of words
            Console.WriteLine($"Word Count: {wordArray.Length}");

            // TODO: Find the longest word in the list
            List<int> lengths = new List<int>();
            foreach (string wrd in wordArray)
            {
                int chrLength = wrd.Length;
                //Console.WriteLine(wrd);
                lengths.Add(chrLength);
                PrintWords(wrd, chrLength);
            }
            //Console.WriteLine(string.Join(", ", lengths));

            var order = lengths.OrderByDescending(w => w);
            var largest = order.FirstOrDefault();
            var smallest = order.LastOrDefault();

            //Console.WriteLine($"The largest number is {largest}");
            //Console.WriteLine($"The smallest number is {smallest}");

            //lengths.Sort();
            //Console.WriteLine($"Sorted lengths: {string.Join(", ", lengths)}");
            //Console.WriteLine(lengths.Last());

            int max = lengths.Max();
            int maxIndex = lengths.ToList().IndexOf(max);
            //Console.WriteLine($"The longest word is: {wordArray[maxIndex]} with a length of {max}");


            int maxNum = 0;
            int least= lengths[0];

            for (int i = 0; i < lengths.Count; i++)
            {
                int a = lengths[i];
                if(a > maxNum)
                {
                    maxNum = a;
                }
                if(a < least)
                {
                    least = a;
                }
            }
            //Console.WriteLine($"The max is: {maxNum}");
            //Console.WriteLine($"The least is: {least}");

            // TODO: Build the word count data


            // TODO: Print out the word count data
            //Console.WriteLine(wordArray);

        }
        static void PrintWords(string theWords, int wrdLength)
        {
            //Console.WriteLine($"The word: '{theWords}' is {wrdLength} lengths");
        }

        // string validation
        static Boolean IsUpperCase(string s)
        {
            return s.All(char.IsUpper);
        }

        static Boolean IsLowerCase(string s)
        {
            return s.All(char.IsLower);
        }

        static Boolean IsPasswordComplex(string s)
        {
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit) && s.Any(char.IsSymbol);
        }

        static string Nomarlized(string input)
        {
            return input.ToLower().Trim().Replace(",", "");
        }




        static void Main(string[] args)
        {
            string[] GettysburgAddress = {
                "Four score and seven years ago our",
                "fathers brought forth on this continent",
                "a new nation conceived in Liberty",
                "and dedicated to the proposition",
                "that all men are created equal",
                "Now we are engaged in a great civil war",
                "testing whether that nation",
                "or any nation so conceived and so dedicated",
                "can long endure",
                "We are met on a great battlefield of that war",
                "We have come to dedicate a portion of that field",
                "as a final resting place for those who",
                "here gave their lives that that nation might live",
                "It is altogether fitting",
                "and proper that we should do this"
            };

            //foreach(string word in GettysburgAddress)
            //{
            //    Console.WriteLine(word);
            //}


            //String Validation

            //Console.WriteLine(IsUpperCase("hello"));
            //Console.WriteLine(IsUpperCase("HELLO"));
            //Console.WriteLine(IsLowerCase("HELLO"));
            //Console.WriteLine(IsLowerCase("hello"));
            Console.WriteLine(IsPasswordComplex("Hello0^"));
            Console.WriteLine(Nomarlized("Hello, There GOODDAy"));

            // TODO: Convert the string array to a single string and call PrintStringStats
            string TheText = string.Join(" ", GettysburgAddress).ToLower();
            //Console.WriteLine(TheText);
            PrintStringStats(TheText);
        }
    }
}