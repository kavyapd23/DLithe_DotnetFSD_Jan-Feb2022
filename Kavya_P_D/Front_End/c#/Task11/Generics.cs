using System;
namespace CSharpProgram
{      //generic class accepts any kind of datatype
    class GenericClass<T>
    {//here <T> is a generic class
        public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> gen = new GenericClass<string>("Hello");
            GenericClass<int> genI = new GenericClass<int>(1);
            GenericClass<char> getCh = new GenericClass<char>('K');
            gen.Show("Hello");//call the show method to display the msg
            gen.Show(1);
            gen.Show('K');
        }
    }
}