﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Credit1Manager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Calculated Credit1!");
        }

        public void Choose()
        {
            throw new NotImplementedException();
        }
    }
}
