﻿using System;
namespace PolymorphismDemo
{
    // Method Overriding in C#
    class Class1
    {//virtual keyword is use to modify the method
        public virtual void show()
        {
            Console.WriteLine("Super class show method");
        }
    }
    class Class2 : Class1
    {
        public override void show()
        {
            Console.WriteLine("Sub class override show method");
        }
    }
    class Class3 : Class1
    {
        public override void show()
        {
            base.show();//Using the base keyword to call the parent class methods in C#
            Console.WriteLine("Sub class override show method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            Class1 obj1 = new Class2();//Parent class Reference Variable holding subclass object reference.
            Class3 obj2 = new Class3();
            obj.show();
            obj1.show();
            obj2.show();
            Console.ReadKey();
        }
    }
}