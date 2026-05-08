using System;
using System.Collections.Generic;


namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();

            // Push new items to the stack
            myStack.Push("One");
            myStack.Push("Two");
            myStack.Push("Three");
            myStack.Push("Four");

            // Count the properties in the stac
            Console.WriteLine(myStack.Count);

            // Enumerate the stack, Note Stack is LIFO, so the last item added is the first item enumerated
            foreach (string s in myStack)
            {
                Console.WriteLine(s);
            }

            // Peek function returns the top item on the stack without removing it
            string top = myStack.Peek();
            Console.WriteLine($"Top item is: {top}");

            // Pop function returns the top item on the stack and removes it
            string popped = myStack.Pop();
            Console.WriteLine($"Popped item is: {popped}");

            // Search for an element using Contains and the Search function
            Console.WriteLine(myStack.Contains("Five"));
            Console.WriteLine(myStack.Contains("Two"));
        }
    }
}