public class Book
{
    public readonly string _ISBN;
    public string _author;
    public string _title;

    public Book(string ISBN, string Author, string Title)
    {
        _ISBN = ISBN;
        _author = Author;
        _title = Title;
    }

    public override string ToString() => $"ISBN: {_ISBN}, Author: {_author}, Title: {_title}";
}

public class Employee
{
    private int _id;
    public Employee(){}
    public Employee(string fname, string lname, int id, string dept) { 
        FirstName = fname;
        Department = dept;
        LastName = lname;
        ID = id;
    }
    public int ID
    {
        get => _id;
        init => _id = value;
    }
    public required string FirstName { get;set; }
    public string LastName
    {
        get; set;
    }
    public string Department { get;set; }
    public override string ToString() => $"ID: {ID}, Name: {FirstName} {LastName}, Department: {Department}";
}