using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Credit2Manager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Calculated Credit2!");
        }

        public void Choose()
        {
            throw new NotImplementedException();
        }
    }
}
