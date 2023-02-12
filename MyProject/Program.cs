using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Giris = false;
            double dollarnKursu = 1.7;
            double dollarınbuGunkukursu = 1.8;
          
            if (dollarnKursu>dollarınbuGunkukursu)
            {
                Console.WriteLine("Azalma");
            }
            else if (dollarnKursu < dollarınbuGunkukursu)
            {
                Console.WriteLine("Artma");
                
            }
            else
            {
                Console.WriteLine("Deysmedi");



            }
            var result = dollarnKursu > dollarınbuGunkukursu ? "Azalma" : "Artma";

            Console.WriteLine(result);


            //reqemprosda();





        }

        static void reqemprosda()
        {


            double a = 5.4;
            Console.WriteLine(a);
           








        }    
            



    }
}