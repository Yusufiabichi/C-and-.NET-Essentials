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



// using System.Reflection.Metadata;

// User usr = new User("yusufia", "yusufia@yahoo.com", "07068538000");
// Console.WriteLine(usr.GetDescription());
// Console.WriteLine(usr.Name);


// using System.Drawing;
// using System.Security.Cryptography;

// Info tst = new Info("Yusufia", "Bichi");
// Console.WriteLine(tst.GetInfo());



// // INHERITANCE

// Circle c = new Circle(10);
// Rectangle r = new Rectangle(10, 20);
// Square s = new Square(10);

// Console.WriteLine($"{c}");
// Console.WriteLine($"{r}");

// Console.WriteLine($"{c is Shape2D}");
// Console.WriteLine($"{c is Rectangle}");


// Console.WriteLine(c.GetArea());
// Console.WriteLine(r.GetArea());
// Console.WriteLine(s.GetArea());

// void PrintArea(Shape2D shape)
// {
//     Console.WriteLine($"{shape.GetArea()}");
// }

// PrintArea(c);
// PrintArea(r);
// PrintArea(s);

// INHERITANCE END


// ACCESS MODIFIERS START

// MyClass class1 = new MyClass();
// DerivedClass class2 = new DerivedClass();

// Console.WriteLine($"Class1 DAta Value is {class1.Data}");
// class1.Func1();
// class1.Func1();
// Console.WriteLine($"Class1 DAta Value is {class1.Data}");

// Console.WriteLine($"Class2 DAta Value is {class2.Data}");
// class2.Func1();
// class2.Func3();
// Console.WriteLine($"Class2 DAta Value is {class2.Data}");
// ACCESS MODIFIERS ENDS


// ANONYMOUS TYPES START
// var myobj = new
// {
//     Name = "Yusufia Bichi",
//     Age = 24,
//     Address = new
//     {
//         Street = "123 FCE Road",
//         City = "Bichi"
//     }
// };
// Console.WriteLine($"{myobj.Name}, {myobj.Address.Street}");
// Console.WriteLine($"{myobj}");

// // myobj.Name = "Isah";

// var myobj2 = myobj with { Name = "Isah" };
// Console.WriteLine($"{myobj2.Name}, {myobj2.Address.Street}");


// Console.WriteLine($"{myobj.GetType().GetProperty("Name") != null}");
// Console.WriteLine($"{myobj.GetType().GetProperty("Job") != null}");
// ANONYMOUS TYPES ENDS


// OBJECT INITIALIZERS START
// using System.Security.Cryptography;

// Dog dog = new Dog { Name = "Fido", Age = 5, IsTrained = true };
// Cat cat = new Cat { Name = "Kitty", Age = 2, IsDeclawed = false };
// Console.WriteLine($"Dog: {dog.Name}, {dog.Age}");
// Console.WriteLine($"Cat: {cat.Name}, {cat.Age}");

// // anonymous tyopes
// var pet = new
// {
//     Name = "Cahrlie",
//     Age = 7
// };
// Console.WriteLine($"Pet: {pet.Name}, {pet.Age}");

// // Collections initializers
// int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, };
// Console.WriteLine(numbers.Length);

// // Collection initializers with the set of objects
// PetOwner owner = new PetOwner
// {
//     Name = "Yusufia Bichi",
//     Pets = new List<Pet>
//     {
//         new Dog{Name = "Junebug", Age=4},
//         new Cat {Name="Jack", Age=3},
//         new Dog{Name="Max", Age=6}
//     }
// };

// Console.WriteLine($"{owner.Name}'s Pets");
// foreach (Pet p in owner.Pets)
// {
//     Console.WriteLine($"{p.Name}");
// }
// OBJECT INITIALIZERS ENDS


// READ-ONLY MEMBERS START
var book1 = new Book("97568542122", "War and Peace", "Yusufia Idris");
var book2 = new Book("25478541215", "Catch 22", "Bichi Yusuf");
Console.WriteLine($"{book1.ISBN:} {book1.Title} by {book1.Author}");
Console.WriteLine($"{book2}");
// READ-ONLY MEMBERS END












