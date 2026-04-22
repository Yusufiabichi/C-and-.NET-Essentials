class Rectangle
{
    public Rectangle(int w, int h)
    {
        width = w;
        height = h;
    }
    public Rectangle(int side)
    {
        width = height = side;
    }
    public int GetArea()
    {
        return width * height;
    }

    public int Width
    {
        get { return width; }
        set { width = value; }
    }
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Height", "Must be > 0");
            }
            height = value;
        }
    }
    public int BorderSize
    {
        get; set;
    } = 1;
    // members that hold the data
    int width;
    int height;
}


class Square
{
    public Square(int a, int b)
    {
        width = a;
        height = b;
    }
    public Square(int side)
    {
        width = height = side;
    }
    public int SquareArea()
    {
        return width * height;
    }
    public int SideSum()
    {
        return width + height;
    }

    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Width", "Must be > 0");
            }
            width = value;
        }
    }
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Height", "Must be > 0");
            }
            height = value;
        }
    }

    // members
    int width;
    int height;
}




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
        // set
        // {
        //     if (value.Length < 5)
        //     {
        //         throw new ArgumentOutOfRangeException("Username", "Must be more than 5 characters");
        //     }
        //     _username = value;
        // }
    }
}

