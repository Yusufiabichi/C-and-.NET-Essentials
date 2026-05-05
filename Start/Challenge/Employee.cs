public class Employee
{
    private int _id;
    public Employee() {}
    public Employee(int id, string fname, string dept) { 
        ID = id;
        FullName = fname;
        Department = dept;
    }
    public required int ID
    {
        get => _id;
        init => _id = value;
    }
    public required string FullName{
        get; set;
    }
    public required string Department {  get; set; }

    public virtual decimal AdjustPay(decimal num)
    {
        return 0;
    }

    public override string ToString() => $"ID: {ID}, {FullName}, {Department}";
}

public class Hourly : Employee
{
    public Hourly() { }
    public Hourly(int id, string fname, string dept, decimal payrate) 
    :base(id, fname, dept)
    { 
        PayRate = payrate;
    }
    public decimal PayRate
    {
        get; set;
    }

    public override decimal AdjustPay(decimal percNum)
    {
        decimal sum = (PayRate * percNum) / 100;
        return PayRate += sum;
    }
    public override string ToString() => $"ID:{ID}, {FullName}, {Department} ~{PayRate}/day";
}

public class Salaried : Employee
{
    public Salaried() { }
    public Salaried(int id, string fname, string dept, decimal salary) 
        :base(id, fname, dept)
    {
        Salary = salary;
    }
    public decimal Salary
    {
        get; set;
    }

    public override decimal AdjustPay(decimal percNum)
    {
        decimal sum = (Salary * percNum) / 100;
        return Salary += sum;
    }
    public override string ToString() => $"ID:{ID}, {FullName}, {Department} ~{Salary}/month";
}