using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("john");
            names.Add("dev");
            names.Add("charlie");
            names.Add("ankit");
            names.Add("peter");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var names = new List<int>();
    //        names.Add(10);
    //        names.Add(20);
    //        names.Add(30);
    //        names.Add(40);
    //        names.Add(50);
    //        foreach (var name in names)
    //        {
    //            Console.WriteLine(name);
    //        }
    //        Console.ReadLine();
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var names = new List<string>() { "john", "peter", "charlie", "dev", "ankit" };

    //        foreach (var name in names)
    //        {
    //            Console.WriteLine(name);
    //        }
    //        Console.ReadLine();
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var names = new List<int>() { 10, 20, 30, 40, 50 };

    //        foreach (var name in names)
    //        {
    //            Console.WriteLine(name);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
