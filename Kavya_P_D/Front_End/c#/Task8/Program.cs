using System;
using System.Collections;//it expands automatically as the data is added
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new ArrayList();   //arraylist collection
            data.Add("Enter");             // add element
            data.Add(2);
            data.Add(8);
            data.Add(55);
            data.Add(100);
            data.Add(32);
            data.Remove(55);              // remove element
            foreach (object obj in data)   // iteration
            {
                Console.WriteLine(obj);
                Console.ReadLine();
            }
        }
    }
}