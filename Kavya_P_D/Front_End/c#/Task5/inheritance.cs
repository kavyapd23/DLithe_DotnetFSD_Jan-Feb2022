using System;
namespace DLithe
{
    public class A
    {
        public string Name = "anil";
        public void GetName()
        {
            Console.WriteLine("Name:, Name);
       }
}
public B extends A
{

   public string Location;
public void GetLocation()
{
    Console.WriteLine(&quot; Location: &quot;, Location);
       }
    }
    public class C extends B
{

   public int Age;
public void GetAge()
{
    Console.WriteLine(&quot; Age: { 0}
    &quot;, Age);
       }
    }
    class Program
{
    static void Main(string[] args)
    {
        C c = new C();
        c.Name = &quot; John Doe&quot; ;
        c.Location = &quot; Hyderabad & quot; ;
        c.Age = 32;
        Console.WriteLine(&quot;\nPress Any Key to Exit..&quot;);
        Console.ReadLine();
    }
}
}