using System;
namespace ConsoleApp
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OPERATORS");
            int sum = 25 + 40;
            int sub = 85 - 30;
            int mul = 3 * 5;
            int div = 100 / 2;
            int mod = 117 % 2;
            Console.WriteLine("addition:" + sum);
            Console.WriteLine("subtraction:" + sub);
            Console.WriteLine("multiplication:" + mul);
            Console.WriteLine("division:" + div);
            Console.WriteLine("modulus:" + mod);

            int i = 8;
            Console.WriteLine("post increment:" + i++);
            Console.WriteLine("pre increment" + (++i));
            int dec = 12;
            Console.WriteLine("post decrement:" + dec--);
            Console.WriteLine("pre decrement:" + (--dec));
            int a = 5, b = 10;
            Console.WriteLine("Before Swap a=" + a + " b=" + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("after Swap a=" + a + " b=" + b);
            int num1, num2, num3;
            num1 = 10;
            num2 = 20;
            num3 = 30;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("num1 is larger");
                }
                else
                {
                    Console.WriteLine("num3 is larger");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("num2 is larger");
            }
            else
            {
                Console.WriteLine("num3 is larger");

            }
        }


    }
}