using System;
using System.Collections.Generic;

namespace ListPractice
{
    //public class Customer
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public int Salary { get; set; }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Customer customer1 = new Customer();
    //        customer1.ID = 101;
    //        customer1.Name = "john";
    //        customer1.Salary = 60000;

    //        Customer customer2 = new Customer();
    //        customer2.ID = 102;
    //        customer2.Name = "dev";
    //        customer2.Salary = 80000;

    //        Customer customer3 = new Customer();
    //        customer3.ID = 103;
    //        customer3.Name = "ayush";
    //        customer3.Salary = 70000;

    //        List<Customer> customers = new List<Customer>();
    //        customers.Add(customer1);
    //        customers.Add(customer2);
    //        customers.Add(customer3);

    //        //foreach (Customer cs in customers)
    //        //{
    //        //    Console.WriteLine("Id: {0}, Name: {1}, Salary: {2}", cs.ID, cs.Name, cs.Salary);
    //        //}
    //        //Console.ReadLine();

    //        for(int i = 0; i < customers.Count; i++)
    //        {
    //            Customer cs = customers[i];
    //            Console.WriteLine("Id: {0}, Name: {1}, Salary: {2}", cs.ID, cs.Name, cs.Salary);
    //        }
    //        Console.ReadLine();
    //    }
    //}


    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    public class SavingsCustomer : Customer
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID = 101;
            customer1.Name = "john";
            customer1.Salary = 60000;

            Customer customer2 = new Customer();
            customer2.ID = 102;
            customer2.Name = "dev";
            customer2.Salary = 80000;

            Customer customer3 = new Customer();
            customer3.ID = 103;
            customer3.Name = "ayush";
            customer3.Salary = 70000;

            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Insert(0, customer3);

            Console.WriteLine(customers.IndexOf(customer3));
            Console.WriteLine(customers.IndexOf(customer3, 1));
            Console.WriteLine(customers.IndexOf(customer3, 1, 2));
            Console.WriteLine(customers.IndexOf(customer3, 1, 3));
            Console.WriteLine();

            SavingsCustomer sc = new SavingsCustomer();
            customers.Add(sc);

            foreach (Customer cs in customers)      // using forEach loop
            {
                Console.WriteLine("Id: {0}, Name: {1}, Salary: {2}", cs.ID, cs.Name, cs.Salary);
            }

            //for (int i = 0; i < customers.Count; i++)      // using for loop
            //{
            //    Customer cs = customers[i];
            //    Console.WriteLine("Id: {0}, Name: {1}, Salary: {2}", cs.ID, cs.Name, cs.Salary);
            //}
            Console.ReadLine();
        }
    }
}
