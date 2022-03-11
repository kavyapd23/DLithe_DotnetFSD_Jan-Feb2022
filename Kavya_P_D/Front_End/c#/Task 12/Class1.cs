using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_Bootcamp_Task32
{
    class GenericsClass<T>
    {
        public GenericsClass(T msg)
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
            GenericsClass<string> gen = new GenericsClass<string>("This is generic class");
            GenericsClass<int> gen1 = new GenericsClass<int>(200);
            GenericsClass<char> gench = new GenericsClass<char>('N');
            gen.Show("This is generic class");
            gen.Show(200);
            gen.Show('N');
        }
    }
}