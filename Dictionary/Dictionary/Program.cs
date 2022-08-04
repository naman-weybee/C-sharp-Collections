using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "ayush");
            names.Add("2", "yash");
            names.Add("3", "jay");
            names.Add("4", "john");
            names.Add("5", "ankit");

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
    //        Dictionary<int, string> names = new Dictionary<int, string>();
    //        names.Add(1, "ayush");
    //        names.Add(2, "yash");
    //        names.Add(3, "jay");
    //        names.Add(4, "john");
    //        names.Add(5, "ankit");

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
    //        Dictionary<int, int> names = new Dictionary<int, int>();
    //        names.Add(1, 45);
    //        names.Add(2, 46);
    //        names.Add(3, 47);
    //        names.Add(4, 48);
    //        names.Add(5, 49);

    //        foreach (KeyValuePair<int, int> name in names)
    //        {
    //            Console.WriteLine(name.Key + " " + name.Value);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
