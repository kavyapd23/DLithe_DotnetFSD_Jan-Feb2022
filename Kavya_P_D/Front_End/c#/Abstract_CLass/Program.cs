using System;
public abstract class Color
{
    public abstract void display();//no implementation 
    protected string name;
    // abstract method
    public abstract string Name
    {
        get;
        set;
    }
    public abstract void calculate(double x);
}

public class Black : Color
{
    // provide implementation of abstract method and to properties by using the key word override
    public override string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public override void display()
    {
        Console.WriteLine("Black");
    }
    public override void calculate(double x)
    {
        Console.WriteLine("SQUARE ROOT IS " + Math.Sqrt(x));
    }
}

public class Red : Color
{
    // provide implementation of abstract method
    public override string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public override void display()
    {
        Console.WriteLine("Red");
    }
    public override void calculate(double x)
    {
        Console.WriteLine("SQUARE is :" + (x * x));
    }
}

public class Blue : Color
{
    // provide implementation of abstract method
    public override string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public override void display()
    {
        Console.WriteLine("Blue");
    }
    public override void calculate(double x)
    {
        Console.WriteLine("CUBE is :" + (x * x * x));
    }
}

public class MyClass
{
    public static void Main()
    {
        Color C;
        C = new Black();
        Console.WriteLine(C.Name = "ABC");
        C.display();
        C.calculate(5);
        C = new Red();
        Console.WriteLine(C.Name = "XYZ");
        C.display();
        C.calculate(5);
        C = new Blue();
        Console.WriteLine(C.Name = "012");
        C.display();
        C.calculate(5);

    }
}

