using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class SaleManager
    {
        public void Sale(Customer customer,Game game,int quantity,int price,Offer offer)
        {
            
            string priceString = Convert.ToString(price);
            string quantitystring  = Convert.ToString(quantity);

            Console.WriteLine(quantitystring + " unity of " + game.name +  "  were sold for " +   priceString + " to " +  customer.FirstName + " " +customer.LastName + " with " + offer.Name );
        }


    }
}
