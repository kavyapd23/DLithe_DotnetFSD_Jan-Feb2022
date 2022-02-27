using System;

namespace Inheritance //Single,multi-level,Hierarchical inheritance
{
    class Parent  // base class (parent) ,sealed class cannot be inherited
    {
        public string empname = "Lanjenbi";
        public void feature()
        {
            Console.WriteLine("Parent class:Lanjenbi");
        }
    }

    class Child : Parent // derived class (child)
    {
        public string location = "Manipur";
    }

    class Child1 : Parent //Hierarchical inheritance
    {
        public string salary = "55000";
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a ob object
            Child ob = new Child();
            Child1 ob1 = new Child1();

            // Call the feature() method (From the Parent class) on the ob object
            ob.feature();
            ob1.feature();

            Console.WriteLine(ob.empname + " " + ob.location);
            Console.WriteLine(ob1.empname + " " + ob1.salary);
        }
    }
}