using System;

namespace CompleteInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Record myRecord = new Record("Kavya", 50000, "Banglore");
            myRecord.PrintRecord();
            Console.ReadLine();
        }
    }
}