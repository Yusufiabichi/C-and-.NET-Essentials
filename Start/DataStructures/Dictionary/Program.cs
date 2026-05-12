using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Dictionary map keys to values, keys must be unique
            Dictionary<string, string> fileType = new Dictionary<string, string>();

            // Add some keys and values to the dictionary
            fileType.Add(".bmp", "Bitmap file");
            fileType.Add(".txt", "Text file");
            fileType.Add(".html", "HTML file");
            fileType.Add(".jpg", "JPEG Image");

            // Print the count
            Console.WriteLine($"Count is: {fileType.Count}");

            // Trying to add an existing key will throw an exception
            //fileType.Add(".txt", "Just the Text");

            // TryAdd function makes it convenient to see if there's a duplicate
            bool added = fileType.TryAdd(".txt", "Just the text");
            Console.WriteLine(added);   // => false

            // Dictionaries are also like associative arrays
            Console.WriteLine($"Key value: {fileType[".html"]}");

            // This way, setting an existing key just overwrites the value
            fileType[".html"] = "Web Page";
            Console.WriteLine($"Key value: {fileType[".html"]}");

            // See if a Dictionary contains a key or a value
            Console.WriteLine($"Contains key: {fileType.ContainsKey(".bmp")}");
            Console.WriteLine($"Contains key: {fileType.ContainsValue(".HTML file")}");

            // Remove Items
            fileType.Remove(".bmp");
            Console.WriteLine($"Contains key: {fileType.ContainsKey(".bmp")}");


        }
    }
}