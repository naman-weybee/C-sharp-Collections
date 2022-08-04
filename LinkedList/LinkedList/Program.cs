using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("ankit");
            names.AddLast("peter");
            names.AddFirst("dev");
            names.AddLast("jay");
            names.AddLast("john");
            names.AddFirst("rahul");
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
    //        var names = new LinkedList<int>();
    //        names.AddLast(10);
    //        names.AddLast(110);
    //        names.AddFirst(80);
    //        names.AddLast(97);
    //        names.AddLast(15);
    //        names.AddFirst(50);
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
    //        var names = new LinkedList<string>();
    //        names.AddLast("ankit");
    //        names.AddLast("peter");
    //        names.AddFirst("dev");
    //        names.AddLast("jay");
    //        names.AddLast("john");
    //        names.AddFirst("rahul");

    //        LinkedListNode<string> node = names.Find("jay");
    //        names.AddBefore(node, "ayush");
    //        names.AddAfter(node, "yash");

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
    //        var names = new LinkedList<int>();
    //        names.AddLast(10);
    //        names.AddLast(110);
    //        names.AddFirst(80);
    //        names.AddLast(97);
    //        names.AddLast(15);
    //        names.AddFirst(50);

    //        LinkedListNode<int> node = names.Find(97);
    //        names.AddBefore(node, 96);
    //        names.AddAfter(node, 98);

    //        foreach (var name in names)
    //        {
    //            Console.WriteLine(name);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
