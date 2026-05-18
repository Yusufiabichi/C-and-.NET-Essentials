// Example file for C# Applied Data Structures by Joe Marini
// Programming Challenge

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Challenge
{
    class Program
    {
        static void PrintStringStats(string TheString)
        {
            // Split the string on space character boundary
            string[] wordArray = TheString.Split(' ');

            // TODO: Count the total number of words
            Console.WriteLine($"Word COunt: {wordArray.Length}");


            // TODO: Find the longest word in the list
            foreach (string wrd in wordArray)
            {
                List<int> lengths = new List<int>();
                int chrLength = wrd.Length;
                //int maxLength = Math.Max(chrLength);
                foreach(int i in chrLength)
                {
                    // Loop throught the lits and find the max Length
                    if(i > chrLength)
                    {
                        lengths.Add(i);
                    }
                }
                Console.WriteLine(lengths);
            }


            // TODO: Build the word count data


            // TODO: Print out the word count data

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

            // TODO: Convert the string array to a single string and call PrintStringStats
            string TheText = string.Join(" ", GettysburgAddress).ToLower();
            //Console.WriteLine(TheText);
            PrintStringStats(TheText);
        }
    }
}