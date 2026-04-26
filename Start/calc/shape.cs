using System.Net.Sockets;

// ANONYMOUS TYPES STARTS
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

// class Rectangle
// {
//     public Rectangle(int w, int h)
// {
//     width = w;
//     height = h;
// }
// public Rectangle(int side)
// {
//     width = height = side;
// }
// public int GetArea()
// {
//     return width * height;
// }

// public int Width
// {
//     get { return width; }
//     set { width = value; }
// }
// public int Height
// {
//     get
//     {
//         return height;
//     }
//     set
//     {
//         if (value < 0)
//         {
//             throw new ArgumentOutOfRangeException("Height", "Must be > 0");
//         }
//         height = value;
//     }
// }
// public int BorderSize
// {
//     get; set;
// } = 1;
// // members that hold the data
// int width;
// int height;
// }

// class Square
// {
//     public Square(int a, int b)
// {
//     width = a;
//     height = b;
// }
// public Square(int side)
// {
//     width = height = side;
// }
// public int SquareArea()
// {
//     return width * height;
// }
// public int SideSum()
// {
//     return width + height;
// }

// public int Width
// {
//     get
//     {
//         return width;
//     }
//     set
//     {
//         if (value < 0)
//         {
//             throw new ArgumentOutOfRangeException("Width", "Must be > 0");
//         }
//         width = value;
//     }
// }
// public int Height
// {
//     get
//     {
//         return height;
//     }
//     set
//     {
//         if (value < 0)
//         {
//             throw new ArgumentOutOfRangeException("Height", "Must be > 0");
//         }
//         height = value;
//     }
// }

// // members
// int width;
// int height;
// }

class User
{
    string _username;
    // string _password;
    string _email;
    string _phone;


    public User(string username, string email, string phone)
    {
        _username = username;
        _email = email;
        _phone = phone;
    }

    public string GetDescription()
    {
        return $"The User is created with Username: {_username}, email: {_email}, and Phone Number'{_phone}'";
    }

    public string Name
    {
        get
        {
            return _username;
        }
        set
        {
            if (value.Length < 5)
            {
                throw new ArgumentOutOfRangeException("Username", "Must be more than 5 characters");
            }
            _username = value;
        }
    }
}


// INHERITANCE STARTS
class Shape2D
{
    public Shape2D() { }

    // Methods must be marked as 'virstual' 
    public virtual float GetArea()
    {
        return 0.0f;
    }

    public override string ToString() => $"This object is '{GetType()}'";
}

class Circle : Shape2D
{
    public Circle(int r)
    {
        radius = r;
    }
    public override float GetArea()
    {
        return (3.14f * (radius * radius));
    }
    int radius;
}

class Rectangle : Shape2D
{
    public Rectangle(int w, int h)
    {
        width = w;
        height = h;
    }

    public override float GetArea()
    {
        return width * height;
    }
    int width;
    int height;
}

class Square : Rectangle
{
    public Square(int side) : base(side, side)
    {

    }
}
// INHERITANCE ENDS


// ACCESS MODIFIERS STARTS 
public class MyClass
{
    public MyClass() { }
    public void Func1()
    {
        Console.WriteLine("This is a Func1");
        SomeValue += 1;
    }

    // Protected members can be accessed from the class and its subclass
    protected void Func2()
    {
        Console.WriteLine("This is Func2");
        SomeValue -= 1;
    }
    private int SomeValue = 1;
    public int Data
    {
        get
        {
            return SomeValue;
        }
        set
        {
            SomeValue = value;
        }
    }
}

class DerivedClass : MyClass
{
    public DerivedClass() { }
    public void Func3()
    {
        Console.WriteLine("This is Func3");
        // SomeValue += 1;  this value cannot be accessed due to it's protection level
        // Func2 can be access here because DerivedClass is a subclass of MyClass
        Func2();
    }
}
// ACCESS MODIFIERS END


// OBJECT INITIALIZERS STARTS
public class Pet
{
    public string Name { get; set; } = "";
    public int Age { get; set; } = 0;
    public Pet() { }
}
public class Dog : Pet
{
    public bool IsTrained { get; set; } = false;
    public Dog() { }
}
public class Cat : Pet
{
    public bool IsDeclawed { get; set; } = false;
    public Cat() { }
}
public class PetOwner
{
    public string Name { get; set; } = "";
    public List<Pet>? Pets { get; set; }
}
// OBJECT INITIALIZERS ENDS



// READ-ONLY MEMBERS START
public class Book
{
    private string _ISBN = "";
    private string _title = "";
    private string _author = "";
    public Book(string ISBN, string Title, string Author)
    {
        _ISBN = ISBN;
        _title = Title;
        _author = Author;
    }
    public void Update(string ISBN, string Title, string Author)
    {
        _ISBN = ISBN;
        _title = Title;
        _author = Author;
    }
}
// READ-ONLY MEMBERS ENDS


// INIT_ONLY PROPERTIES START
public class Employee
{
    private readonly int _id;
    public Employee() { }
    public Employee(string fname, string lname, int id, string dept)
    {
        FirstName = fname;
        LastName = lname;
        ID = id;
        Department = dept;
    }
    public int ID
    {
        get => _id;
        init => _id = value;
    }
    public string? FirstName
    {
        get; set;
    }
    public string? LastName
    {
        get; set;
    }
    public string? Department
    {
        get; set;
    }
    public override string ToString() => $"{FirstName} {LastName}, ID:{ID} in {Department}";
}






class Info
{
    public Info(string n, string a)
    {
        name = n;
        address = a;
    }
    public string GetInfo()
    {
        return $"My name is {name} from {address}";
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    string name;
    string address;
}