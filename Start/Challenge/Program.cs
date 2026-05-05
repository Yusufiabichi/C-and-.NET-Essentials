
var emp1 = new Employee { ID = 1432, FullName = "Yusufia", Department = "Tech" };
var emp2 = new Hourly { ID = 9772, FullName = "Mahir", Department = "ICT", PayRate=5000};
var emp3 = new Salaried { ID = 4633, FullName = "Bichi", Department = "Sales", Salary=700000};

Console.WriteLine(emp1);
Console.WriteLine($"-Hourly Employees-");
Console.WriteLine(emp2);
Console.WriteLine($"-Salary Employees-");
Console.WriteLine(emp3);
Console.WriteLine($"-Adjust-Pay-");
emp2.AdjustPay(40);
emp3.AdjustPay(20);
Console.WriteLine(emp2);
Console.WriteLine(emp3);

//Console.WriteLine($"-Hourly Employees-");
//foreach (var emp in Hourly)
//{
//    Console.WriteLine(emp);
//}

