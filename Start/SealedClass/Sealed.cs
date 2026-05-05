public class A
{
    public A() {
        Console.WriteLine("A");
    }

    public virtual void Func1()
    {
        Console.WriteLine("Func1 in Class A");
    }
}
public class B : A { 
    public B() { 
        Console.WriteLine("B");
    }

    public override void Func1()
    {
        Console.WriteLine("Func1 in Class B");
    }

}


//Example 2

public class C
{
    public C()
    {
        Console.WriteLine("C");
    }
    public virtual void Func2()
    {
        Console.WriteLine("Func2 in Class C");
    }
}

public class D: C
{
    public D()
    {
        Console.WriteLine("D");
    }
    public override sealed void Func2()
    {
        Console.WriteLine("Func2 in Class D");
    }
}

public class E : D
{
    public E() { 
        Console.WriteLine("E");
    }

    public override void Func2()
    {
        Console.WriteLine("Func2 in Class E");  
    }
}