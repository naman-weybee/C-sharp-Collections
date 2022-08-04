using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("ankit");
            names.Enqueue("jay");
            names.Enqueue("peter");
            names.Enqueue("ankit");
            names.Enqueue("john");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
            Console.ReadLine();
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Queue<int> names = new Queue<int>();
    //        names.Enqueue(111);
    //        names.Enqueue(99);
    //        names.Enqueue(52);
    //        names.Enqueue(20);
    //        names.Enqueue(10);
    //        foreach (var name in names)
    //        {
    //            Console.WriteLine(name);
    //        }
    //        Console.WriteLine("Peek element: " + names.Peek());
    //        Console.WriteLine("Dequeue: " + names.Dequeue());
    //        Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
    //        Console.WriteLine("Dequeue: " + names.Dequeue());
    //        Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
    //        Console.ReadLine();
    //    }
    //}
}
