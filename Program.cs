using System.Collections.Generic;
using System.Collections;
using System;

namespace prop_indexada
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer[1] = new Customer("a", 1);
            Console.WriteLine(customer[1]);
        }
    }

    class Customer
    {
        private readonly IDictionary<int, Customer> customer = new Dictionary<int, Customer>();
        public string Name { get; set; }
        public int Id { get; set; }

        public Customer(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public Customer()
        {
        }

        public Customer this[int index]
        {
            get
            {
                return customer[index];
            }
            set
            {
                customer[index] = value;
            }
        }

        public override string ToString() => $"{Name} {Id}";
    }
}
