using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = new List<string>();       // list collection
            value.Add("Saffron");                       // add element
            value.Add("Green");
            value.Add("Blue");
            value.Add("Yellow");
            value.Add("Orange");
            value.Add("pink");
            value.Remove("Black");              // remove element
            value.Remove("Grey");
            value.Insert(3, "Brown");         // insert element
            foreach (string st in value)
            {
                Console.WriteLine(st);
                Console.ReadLine();
            }
        }
    }
}