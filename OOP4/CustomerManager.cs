using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class CustomerManager:ICustomerCheckService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added: " + customer.FirstName);
        }

        public void Check(Customer customer)
        {
            Console.WriteLine("Customer properties are true!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted: " + customer.FirstName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer updated: " + customer.FirstName);
        }
    }
}
