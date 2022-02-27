using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Collections
{
    class Stack
    {
        static void Main(string[] args)
        {
            var value = new Stack<int>();                          // stack collection
            value.Push(10);                                                    // adding the element
            value.Push(40);
            value.Push(33);
            value.Push(62);
            value.Push(48);
            value.Push(21);
            value.Push(31);
            Console.WriteLine(value.Pop());
            Console.WriteLine(value.Peek());
            Console.WriteLine();
            foreach (int item in value)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
    }
}