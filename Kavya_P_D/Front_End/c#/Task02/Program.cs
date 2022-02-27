using System;

namespace Encapsulation
{
    class Person 
    {
        private string name; 
        string email; 


        public string Name  
        {
            
            get { return name; }
            set { name = value; }

        }

        public Person() //Constructor (no return type)
        {
            email = "Romita@gmail.com";
            Console.WriteLine(email);
        }
        public Person(out int a)
        {
            a = 10;


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            Person my2 = new Person(out int x);
            myObj.Name = "Romita";

            Console.WriteLine(myObj.Name);
            Console.Write(x);
        }
    }
}