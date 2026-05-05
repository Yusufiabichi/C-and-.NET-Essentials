//// See https://aka.ms/new-console-template for more information
//using System.Text.RegularExpressions;

//int testint;

//Console.WriteLine("Type your Math expression below");
//string input = Console.ReadLine();
//Console.WriteLine(input);

//try
//{
//    testint = int.Parse(input);
//    Console.WriteLine($"Input parsed as: {testint}");
//}
//catch (FormatException e)
//{
//    Console.WriteLine($"Could not Parsed: {e.Message}");
//}


//Book book1 = new Book("8797646358", "Leo Tolstoy", "War & Peace");
//Book book2 = new Book("8797878546", "Yusufia Bichi", "My tech Journey");
//Console.WriteLine(book1);
//Console.WriteLine(book2);

//book2._ISBN = "12345678";
//Console.WriteLine(book2);



Employee emp1 = new Employee { FirstName = "Yusufia", LastName= "Bichi", ID = 1432, Department = "ICT" };
Employee emp2 = new Employee{FirstName = "John", LastName = "Doe", ID = 1433, Department = "HR"};
Console.WriteLine(emp1);
Console.WriteLine(emp2);
Employee emp3 = new Employee("Jane", "Smith", 1434, "Finance");
//emp1.ID = 9876;
//Console.WriteLine(emp1);
