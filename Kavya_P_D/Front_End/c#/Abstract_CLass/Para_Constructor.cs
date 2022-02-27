class Demo
{
    string name;
    int age;
    public Demo(string name, int age) //paramertrized constructor
    {//It automatically gets executed when we create the instance of the class it has same name as class name
        this.name = name;
        this.age = age;
    }
    public Demo(Demo d) //copy constructor through the Demo d
    {
        this.name = d.name;
        this.age = d.age;
    }
    public void getData()
    {
        Console.WriteLine("Name is:{0}", name);
        Console.WriteLine("Age is:{0}", age);
    }
}
class Program
{
    //main method
    static void Main(string[] args)
    {
        Demo obj = new Demo("Lanjenthoi", 20);
        obj.getData();
        Demo obj1 = new Demo(obj); //new object
        obj1.getData();
        Console.ReadLine();
    }
}