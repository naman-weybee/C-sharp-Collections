using System;
using System.Collections.Generic;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new SortedSet<string>();
            names.Add("ankit");
            names.Add("jay");
            names.Add("peter");
            names.Add("ankit");
            names.Add("john");
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
    //        var names = new SortedSet<string>() { "ankit", "jay", "peter", "john", "peter" };
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
    //        var names = new SortedSet<int>();
    //        names.Add(30);
    //        names.Add(20);
    //        names.Add(10);
    //        names.Add(20);
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
    //        var names = new SortedSet<int>() { 50, 20, 10, 20, 30 };
    //        foreach (var name in names)
    //        {
    //            Console.WriteLine(name);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
