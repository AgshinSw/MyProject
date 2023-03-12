using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class OfferManager
    {
        public void Add(Offer offer)
        {
            Console.WriteLine(offer.Name + " added ");
        }

        public void Update(Offer offer )
        {
            Console.WriteLine(offer.Name + " updated ");
        }

        public void Delete(Offer offer )
        {
            Console.WriteLine(offer.Name + " deleted ");
        }
    }
}
