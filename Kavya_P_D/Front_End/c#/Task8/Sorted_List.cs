using System;
using System.Collections;//it has key value pair
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Collections
{
    class Program1
    {
        static void Main(string[] args)
        {
            var value = new SortedList<string, int>();            // sortedlist collection
            value.Add("java", 3);                                               // add element
            value.Add("javascript", 4);
            value.Add("c-sharp", 5);
            value.Add("dotnet", 25);
            value.Add("python", 27);
            value.Add("typescript", 57);
            value.Clear();
            foreach (var pair in value)
            {
                Console.WriteLine(pair);
                Console.ReadLine();
            }
        }
    }
}