// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

int testint;

Console.WriteLine("Type your Math expression below");
string input = Console.ReadLine();
Console.WriteLine(input);

try
{
    testint = int.Parse(input);
    Console.WriteLine($"Input parsed as: {testint}");
}
catch (FormatException e)
{
    Console.WriteLine($"Could not Parsed: {e.Message}");
}
