using System;

namespace DLithe
{
    public class A
    {
        public string Name;

        public void Getname()

        {
            Console.WriteLine("Name: {0}", Name);
        }
    }

    public class B : A

    {
        public string Location;
        public void GetLocation()
        {
            Console.WriteLine("Location:{0} ", Location);
        }
    }

    public class C : B
    {
        public int Age;
        public void GetAge()
        {
            Console.WriteLine("Age: {0}", Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.Name = "Lanjenthoi";
            c.Location = "Manipur";
            c.Age = 24;

            Console.WriteLine("\nPress Any Key to Exit..");
            Console.ReadLine();
            c.Getname();
            c.GetLocation();
            c.GetAge();
        }
    }
}