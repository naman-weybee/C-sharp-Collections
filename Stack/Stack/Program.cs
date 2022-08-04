using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new Stack<string>();
            names.Push("ankit");
            names.Push("jay");
            names.Push("peter");
            names.Push("ankit");
            names.Push("john");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("After Pop, Peek element: " + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("After Pop, Peek element: " + names.Peek());
            Console.ReadLine();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var names = new Stack<int>();
    //        names.Push(111);
    //        names.Push(20);
    //        names.Push(10);
    //        names.Push(20);
    //        names.Push(50);
    //        foreach (var name in names)
    //        {
    //            Console.WriteLine(name);
    //        }
    //        Console.WriteLine("Peek element: " + names.Peek());
    //        Console.WriteLine("Pop: " + names.Pop());
    //        Console.WriteLine("After Pop, Peek element: " + names.Peek());
    //        Console.WriteLine("Pop: " + names.Pop());
    //        Console.WriteLine("After Pop, Peek element: " + names.Peek());
    //        Console.ReadLine();
    //    }
    //}
}

