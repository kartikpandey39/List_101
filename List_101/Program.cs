using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_101
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public String Type { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                ID = 101,
                Name = "Aatank",
                Salary = 4000 , // $/per hour :P
                Type = " Regular"
            };
            Customer c2 = new Customer()
            {
                ID = 102,
                Name = "Agent 48",
                Salary = 5000, // $/per hour :P
                Type = " Regular"
            };
            Customer c3 = new Customer()
            {
                ID = 103,
                Name = "popa",
                Salary = 4500, // $/per hour :P
                Type = " Regular"
            };
            Customer c4 = new Customer()
            {
                ID = 104,
                Name = "Chedi",
                Salary = 35000, // $/per hour :P
                Type = " Non regular"
            };
            Customer c5 = new Customer()
            {
                ID = 105,
                Name = "Hurt Locker",
                Salary = 5500, // $/per hour :P
                Type = " Non regular"
            };
            List<Customer> list = new List<Customer>();
            //list.Add(c1);
            //list.Add(c2);
            //list.Add(c3);
           
            list.AddRange(new List<Customer>() { c1, c2, c3 });
            List<Customer> ListNonRegular = new List<Customer>();
            ListNonRegular.Add(c4);
            ListNonRegular.Add(c5);

            //foreach (Customer i in list)
            //{
            //    Console.WriteLine("Id ={0}, Name={1}, Salary={2}", i.ID, i.Name, i.Salary);
            //}
            list.AddRange(ListNonRegular);
            Customer c6;
            int c4LastIndex;
            //list.Insert(0, c4);
            // list.InsertRange(0, ListNonRegular);
            Console.WriteLine(  "list contains C2 ={0}", list.Contains(c2));
            Console.WriteLine("list.Exists(cust => cust.Salary > 4000)= {0}", list.Exists(cust => cust.Salary > 4000));
            c4LastIndex=  list.LastIndexOf(c4);
            Console.WriteLine("last index od c4 is" +c4LastIndex);

            foreach (Customer i in list)
            {
                Console.WriteLine("Id ={0}, Name={1}, Salary={2}", i.ID, i.Name, i.Salary);
            }
            Console.Read();
        }
    }
}
