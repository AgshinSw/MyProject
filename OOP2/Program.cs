using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer = new IndividualCustomer();
            customer.ID = 2;
            customer.CustomerNo = 2;
            customer.Name = "Aqsin";
            customer.LastName = "Elekberli";
            customer.TcNo = "12312312";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.ID = 2;
            customer2.CustomerNo = 2;
            customer2.CompanyName = "Lidersoft";
            customer2.TaxNo = "234324242";

            CustomerManager customermanager = new CustomerManager();
            customermanager.Add(customer);
            customermanager.Add(customer2);
            
        }
    }
}
