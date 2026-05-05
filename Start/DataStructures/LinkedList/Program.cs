using System;
using System.Collections.Generic;

namespace LinkedListExample
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            string[] songs = { "Shout", "Torbulence", "Essence", "All I can Do", "In my hand", "Soco", "In My bed", "On top your Matter" };

            // Create the LinkedList that holds string
            LinkedList<string> myList = new LinkedList<string>(songs);

            // Items can be added at the front or back of the list
            myList.AddFirst("Africa");
            myList.AddLast("The Trust");

            // LinkedList can be iterated
            //foreach (string s in myList)
            //{
            //    Console.WriteLine(s);
            //}
            Console.WriteLine("-----------------------");

            // First and Last properties eturn LinkedListNodes
            LinkedListNode<string> first = myList.First;
            LinkedListNode<string> last = myList.Last;
            //Console.WriteLine(first.Value);
            //Console.WriteLine(last.Value);

            // Items can be added or removed relative to an existing item
            myList.AddAfter(first, "Here come the sun");
            //foreach(string s in myList)
            //{
            //    Console.WriteLine(s);
            //}

            // Search for items i the List with Contains and Find 
            Console.WriteLine(myList.Contains("Essence"));
            Console.WriteLine(myList.Find("Torbulence"));

            // The List can then travered with thse properties
            Console.WriteLine(first.Next.Value);
            Console.WriteLine(last.Previous.Value);

        }
    }
}