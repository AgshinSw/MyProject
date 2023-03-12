using System;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() {DateOfBirth = new DateTime(2004, 01, 5), FirstName = "Aqsin",LastName = "Elekberli",NationalityID = "234567898"};
            CustomerManager customermanager = new CustomerManager();
            customermanager.Add(customer);
            customermanager.Check(customer);
            customermanager.Update(customer);

            Offer offer = new Offer() {Name = "25% discount"};
            offer.Add(offer);
            
            Game game = new Game() { name = "God of War", ID = 12313123, price = 20};
           
            SaleManager sale = new SaleManager();

            sale.Sale(customer,game,10,20,offer);
            
        }
    }
}
