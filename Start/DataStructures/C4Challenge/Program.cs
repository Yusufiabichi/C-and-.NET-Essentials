// Example file for C# Applied Data Structures by Joe Marini
// Programming Challenge

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;
using System.Collections;

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

        static void ParseContents(string s)
        {
            Console.WriteLine("Option A");
            foreach(char c in s)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("Option B");
            for( int i=0; i< s.Length; i++)
            {
                char c = s[i];
                Console.WriteLine(c);
            }
        }

        // Algorithm driven strings in C#
        static String Reverse(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            StringBuilder reversed = new StringBuilder(input.Length);

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            return reversed.ToString();
        }

        static String Reverse2(String input)
        {
            if (string.IsNullOrEmpty(input)){
                return input;
            }
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        // Reversed words
        public static string ReverseEachWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            string[] reverseWords = words.Select(Reverse).ToArray();
            string reversedSentence = string.Join(" ", reverseWords);
            return reversedSentence;
        }

        // Linear Search
        static Boolean LinearSearch(int[] input, int n)
        {
            foreach(int current in input)
            {
                if(n == current)
                {
                    return true;
                }
            }
            return false;
        }

        // Binary Search
        static Boolean BinarySearch(int[] inputArray, int item)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            
            while(min <= max)
            {
                int mid = (min = max + min) / 2;
                if(item == inputArray[mid])
                {
                    return true;
                } else if(item < inputArray[mid])
                {
                    max = mid - 1;
                } else
                {
                    max = mid + 1;
                }
            }
            return true;
        }

        // Aggregate and Filters
        static int[] FindEvenNums(int[] arr1, int[] arr2)
        {
            ArrayList result = new ArrayList();

            foreach( int num in arr1)
            {
                if(num % 2 == 0)
                {
                    result.Add(num);
                }
            }

            foreach(int num in arr2)
            {
                if(num % 2 == 0)
                {
                    result.Add(num);
                }
            }

            return (int[])result.ToArray(typeof(int));
        }

        static int[] FindOddNums(int[] arr1, int[] arr2)
        {
            ArrayList result2 = new ArrayList();

            foreach(int num in arr1)
            {
                if (num % 2 != 0)
                {
                    result2.Add(num);
                }
            }

            foreach(int num in arr2)
            {
                if(num % 2 != 0)
                {
                    result2.Add(num);
                }
            }

            return (int[])result2.ToArray(typeof(int));
        }

        // Reverse an Array
        static int[] Reverse(int[] input)
        {
            int[] reversed = new int[input.Length];

            for (int i = 0; i < reversed.Length; i++)
            {
                reversed[i] = input[input.Length - i - 1];
            }

            return reversed;
        }

        static void ReverseInPlace(int[] input)
        {
            for(int i = 0; i < input.Length / 2; i++)
            {
                // Swap index(i) with index(input.Length - i -1)
                int temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
        }

        // Queue algorithms
        static void PrintBinary(int n)
        {
            if(n <= 0)
            {
                return;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            for (int i = 0; i < n; i++)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);
                queue.Enqueue(current * 10);
                queue.Enqueue(current * 10 + 1);
            }

            Console.WriteLine();

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
            //Console.WriteLine(IsPasswordComplex("Hello0^"));
            //Console.WriteLine(Nomarlized("Hello, There GOODDAy"));
            //ParseContents("Hello World");

            // Algorithm driven strings in C#
            //Console.WriteLine(Reverse2("Hello world"));
            //Console.WriteLine(Reverse2("Here we come"));
            //Console.WriteLine(Reverse2(""));
            //Console.WriteLine(Reverse2("I'm not OK"));
            //Console.WriteLine(Reverse2(""));
            //Console.WriteLine(Reverse2(null));
            //string sentence = "Hello world here I come";
            //Console.WriteLine(ReverseEachWord(sentence));

            // Linear Search
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(LinearSearch(arr, 4));
            //Console.WriteLine(LinearSearch(arr, 8));

            // Built in function for Linear search
            int item = Array.Find(arr, element => element == 3);
            //Console.WriteLine(item);
            int[] items = Array.FindAll(arr, element => element >= 5);
            //Array.ForEach(items, Console.WriteLine);

            // Binary Search
            //Console.WriteLine(BinarySearch(arr, 2));
            //Console.WriteLine(BinarySearch(arr, 0));
            int searched = Array.BinarySearch(arr, 1);
            //Console.WriteLine(searched);

            // Aggregate and Filter
            int[] arr1 = { -8, 2, 3, -9, 11, 20 };
            int[] arr2 = { 0, -2, -5, -39, 10, 7 };

            int[] evenArr = FindEvenNums(arr1,  arr2);
            //Array.ForEach(evenArr, Console.WriteLine);
            int[] oddArr = FindOddNums(arr1, arr2);
            //Array.ForEach(oddArr, Console.WriteLine);

            // Reverse Array
            int[] input = { 1, 2, 3, 4, 5, 6 };
            //Array.ForEach(Reverse(input), Console.WriteLine);
            ReverseInPlace(input);
            ReverseInPlace(input);
            //Array.ForEach(input, Console.WriteLine);

            // LinkedList
            LinkedList<string> listy = new LinkedList<string>();
            //AddLast
            //AddFirst
            listy.AddLast("Yusufia");
            listy.AddLast("Isah");
            listy.AddLast("Haydar");
            listy.AddLast("Yasir");
            listy.AddLast("Musbahu");

            //Console.WriteLine(listy.Contains("Yusufia"));
            //Console.WriteLine(listy.Count);

            listy.RemoveFirst();
            foreach(string name in listy)
            {
                //Console.Write(name + "->");
            }

            // Queue operations 
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Enqueue(6);
            queue.Enqueue(9);

            int removedItem = queue.Dequeue();
            Console.WriteLine(removedItem);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

            int current;
            while(queue.TryDequeue(out current))
            {
                Console.WriteLine(current);
            }

            // Print Binary
            PrintBinary(5);
            PrintBinary(-2);
            PrintBinary(0);
            PrintBinary(2);
            PrintBinary(8);
            PrintBinary(9);

            // Stack Operations
            Stack<string> stack = new Stack<string>();

            Console.WriteLine("Start Main");
            stack.Push("Main");
            Console.WriteLine("Start ResponseBuilder");
            stack.Push("ResponseBuilder");
            Console.WriteLine("Start CallExternalService");
            stack.Push("CallExternalService");
            Console.WriteLine("END " + stack.Pop());
            Console.WriteLine("Start ParseExtensionData");
            stack.Push("ParseExternalData");
            Console.WriteLine("END " + stack.Pop());
            Console.WriteLine("END " + stack.Pop());
            Console.WriteLine("END " + stack.Pop());

            // Stack.Peek()
            // Stack.TryPeek()


            // TODO: Convert the string array to a single string and call PrintStringStats
            string TheText = string.Join(" ", GettysburgAddress).ToLower();
            //Console.WriteLine(TheText);
            //PrintStringStats(TheText);
        }
    }
}