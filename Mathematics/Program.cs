using System;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.Write("Emeliyyat:");
            string emeliyyat = Console.ReadLine();

            if (emeliyyat == "toplama")
            {
                Console.Write("Birinci toplanan:");
                string toplama1 = Console.ReadLine();
                Console.Write("İkinci toplanan:");
                string toplama2 = Console.ReadLine();

                int reqem1 = Convert.ToInt32(toplama1);
                int reqem2 = Convert.ToInt32(toplama2);


                calculator.topla(reqem1, reqem2);        
            }
            else if (emeliyyat == "cixma")
            {
                Console.Write("Azalan:");
                string azalan = Console.ReadLine();
                Console.Write("Cixilan:");
                string cixilan = Console.ReadLine();

                int reqem1 = Convert.ToInt32(azalan);
                int reqem2 = Convert.ToInt32(cixilan);


                calculator.cixma(reqem1, reqem2);
            }
            else if (emeliyyat == "vurma")
            {
                Console.Write("Vuran:");
                string vuran = Console.ReadLine();
                Console.Write("Vurulan:");
                string vurulan = Console.ReadLine();

                int reqem1 = Convert.ToInt32(vuran);
                int reqem2 = Convert.ToInt32(vurulan);


                calculator.vurma(reqem1, reqem2);
            }

            else if (emeliyyat == "bolme")
            {
                Console.Write("Bolunen:");
                string Bolunen = Console.ReadLine();
                Console.Write("Bolen:");
                string Bolen = Console.ReadLine();

                int reqem1 = Convert.ToInt32(Bolunen);
                int reqem2 = Convert.ToInt32(Bolen);


                calculator.bolme(reqem1, reqem2);

            }



            
        }
    }
}
