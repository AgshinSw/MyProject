using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class Calculator
    {
        public void topla(int reqem1, int reqem2)
        {
            int cavab = reqem1 + reqem2;
            Console.WriteLine(cavab);
        }

        public void cixma(int reqem1,int reqem2)
        {

            int cavab = reqem1 - reqem2;
            Console.WriteLine(cavab);
        }

        public void bolme(int reqem1, int reqem2)
        {

            int cavab = reqem1/reqem2;
            Console.WriteLine(cavab);
        }

        public void vurma(int reqem1, int reqem2)
        {

            int cavab = reqem1*reqem2;
            Console.WriteLine(cavab);
        }

    }
}
