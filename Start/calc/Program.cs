// See https://aka.ms/new-console-template for more information
// using System.Text.RegularExpressions;

// int testint;

// int num = 2;
// Console.WriteLine(typeof(num));
// Console.WriteLine(num);

// Console.WriteLine("Type your Math expression below");
// string input = Console.ReadLine();
// Console.WriteLine(input);

// foreach (char ch in input)
// {
//     try
//     {
//         testint = int.Parse(ch);
//         Console.WriteLine($"'{ch}'parsed as: {testint}");
//     }
//     catch (FormatException e)
//     {
//         Console.WriteLine($"'{ch}'Could not be parsed{e.Message}");
//     }
//     Console.WriteLine(ch);
// }


// try
// {
//     testint = int.Parse(input);
//     Console.WriteLine($"Input parsed as: {testint}");
// }
// catch (FormatException e)
// {
//     Console.WriteLine($"Could not Parsed: {e.Message}");
// }


// Rectangle rect1 = new Rectangle(10, 20);
// Rectangle rect2 = new Rectangle(30);
// Console.WriteLine(rect1.GetArea());
// Console.WriteLine(rect2.GetArea());

// rect1.width = 5;
// rect1.height = 7;
// Console.WriteLine(rect1.GetArea());

// rect1.Width = 5;
// rect1.Height = 8;
// Console.WriteLine(rect1.GetArea());

// rect1.BorderSize = 5;
// Console.WriteLine($"{rect1.BorderSize}");
// rect1.Width = 5;
// rect1.Height = 6;
// Console.WriteLine(rect1.GetArea());


// Square sq1 = new Square(30, 20);
// Square sq2 = new Square(20);
// Console.WriteLine(sq1.SquareArea());
// Console.WriteLine(sq2.SquareArea());
// sq1.Width = 40;
// sq1.Height = -30;
// Console.WriteLine(sq1.SquareArea());



using System.Reflection.Metadata;

User usr = new User("yusufia", "yusufia@yahoo.com", "07068538000");
Console.WriteLine(usr.GetDescription());
Console.WriteLine(usr.Name);
