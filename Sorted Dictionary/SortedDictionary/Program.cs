using System;
using System.Collections.Generic;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            names.Add("1", "ayush");
            names.Add("3", "raj");
            names.Add("5", "yash");
            names.Add("2", "dev");
            names.Add("4", "john");
            foreach (KeyValuePair<string, string> name in names)
            {
                Console.WriteLine(name.Key + " " + name.Value);
            }
            Console.ReadLine();
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        SortedDictionary<string, string> names = new SortedDictionary<string, string>();
    //        names.Add("first", "ayush");
    //        names.Add("second", "raj");
    //        names.Add("third", "yash");
    //        names.Add("forth", "dev");
    //        names.Add("fifth", "john");
    //        foreach (KeyValuePair<string, string> name in names)
    //        {
    //            Console.WriteLine(name.Key + " " + name.Value);
    //        }
    //        Console.ReadLine();
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        SortedDictionary<int, string> names = new SortedDictionary<int, string>();
    //        names.Add(1, "ayush");
    //        names.Add(3, "raj");
    //        names.Add(5, "yash");
    //        names.Add(2, "dev");
    //        names.Add(4, "john");
    //        foreach (KeyValuePair<int, string> name in names)
    //        {
    //            Console.WriteLine(name.Key + " " + name.Value);
    //        }
    //        Console.ReadLine();
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        SortedDictionary<int, int> names = new SortedDictionary<int, int>();
    //        names.Add(1, 95);
    //        names.Add(3, 96);
    //        names.Add(5, 97);
    //        names.Add(2, 98);
    //        names.Add(4, 99);
    //        foreach (KeyValuePair<int, int> name in names)
    //        {
    //            Console.WriteLine(name.Key + " " + name.Value);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
