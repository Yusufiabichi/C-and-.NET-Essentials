using System;
using System.Text;


public sealed class App
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("ABC", 50);
        Console.WriteLine($"Capacity: {sb.Capacity}, MaxCapacity: {sb.MaxCapacity}");

        sb.Append(new char[] { 'D', 'E', 'F' });

        sb.AppendFormat("GHI{0}{1}", 'J', 'k');

        Console.WriteLine($"{sb.Length} chars, string: {sb.ToString()}");

        sb.AppendJoin("-", new char[] { 'L', 'M', 'N', 'O' });

        sb.Insert(0, "Alphabet: ");

        sb.Replace('k', 'K');

        Console.WriteLine($"{sb.Length} chars, string: {sb.ToString()}");
    }
}