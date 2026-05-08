using System;
using System.Collections.Generic;

namespace QueueExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQue = new Queue<string>();

            // Add item to the end of the Queue. The QUEUE order is FIFO, so the first item added is the first item removed/ Printed
            myQue.Enqueue("One");
            myQue.Enqueue("Two");
            myQue.Enqueue("Three");
            myQue.Enqueue("Four");
            myQue.Enqueue("Five");

            // Count the Queue items
            Console.WriteLine(myQue.Count);

            // Enumerate the Queue, Note Queue is FIFO, so the first item added is the first item enumerated
            foreach(string s in myQue)
            {
                Console.WriteLine(s);
            }

            // Peek at the front of the Queue
            Console.WriteLine("The first is: " + myQue.Peek());

            // Remove item from the front of the Queue
            string dQue = myQue.Dequeue();
            Console.WriteLine(dQue);
            dQue = myQue.Dequeue();
            Console.WriteLine(dQue);

            Console.WriteLine(myQue.Count);

            // Search the items using Contains
            Console.WriteLine($"myQueue contains 'one': {myQue.Contains("one")}");
            Console.WriteLine($"myQueue contains 'one': {myQue.Contains("Five")}");

            // clear all items
            myQue.Clear();
            Console.WriteLine(myQue.Count);



        }
    }
}