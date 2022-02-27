using System;

namespace Interface
{
    //An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies)
    //interface name should be start with I
    interface IFirstInterface
    {
        string Name { get; set; }
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }
    interface IThirdInterface
    {
        void myOtherMethod1(); // interface method
    }
    
    // all the above three methods are implemented here
    class DemoClass : IFirstInterface, ISecondInterface, IThirdInterface
    {
        public string Name
        {
            get;
            set;
        }
        public void myMethod()
        {
            Console.WriteLine("HELLO");

        }
        public void myOtherMethod()
        {
            Console.WriteLine("C");
        }
        public void myOtherMethod1()
        {
            Console.WriteLine("SHARP");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.Name = "Lanjenthoi Chanu";
            myObj.myMethod();
            myObj.myOtherMethod();
            myObj.myOtherMethod1();
            Console.WriteLine(myObj.Name);
        }
    }
}