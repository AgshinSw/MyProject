using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Credit3Manager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Credit3 calculated");
        }

        public void Choose()
        {
            throw new NotImplementedException();
        }
    }
}
