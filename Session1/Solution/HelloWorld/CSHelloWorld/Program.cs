
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {
        //System.Console.WriteLine("CS says 'Hello World!'");
        //List<Student> students = new List<Student> { new Student(), new UnderGraduate(), new Graduate() };
        //foreach (Student s in students)
        //    s.ChooseMajor();

        dynamic person = new ExpandoObject();
        person.Name = "Keith";
        person.Age = 32;
        person.Company = new ExpandoObject();
        person.Company.Name = "360i";

        Console.WriteLine("mio nome è {0}", person.Name);

        BigInteger result = 0;
        for (int x = 0; x < 100; x++) {
            BigInteger p = BigInteger.Pow(2, x);
            Console.WriteLine("\n 2^{0} = {1}\n", x, p);
           result += p;
            //Console.ReadKey();
        }
        Console.WriteLine("result = {0}", result);
    }
}

namespace FactoryApp
{
    public class Widget
    {
        public string SKUNumber { get; set; }
        public uint LotNumber { get; set; }
        public string Color { get; set; }
    }
}

namespace ShippingApp
{
    public class Widget
    {
        public float Weight { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
    }
}

public class Student
{
    public virtual void ChooseMajor()
    {
        Console.WriteLine("I want to be an astronaut!");
    }
}
public class UnderGraduate : Student
{
    public override void ChooseMajor()
    {
        Console.WriteLine("I just want to get a degree!");
    }
}
public class Graduate : Student
{
    public override void ChooseMajor()
    {
        Console.WriteLine("I just want to change the world!");
    }
}