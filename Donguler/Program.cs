using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Python";
            string kurs2 = "Java";
            string kurs3 = "C#";
            string kurs4 = "C";
            string kurs5 = "Html";


            string[] kurslar = new string[] { kurs1, kurs2, kurs3, kurs4,kurs5};
            


            //for (int i = 0; i < kurslar.Length ; i++)
           // {
           //     Console.WriteLine(kurslar[i]);

            //}

            foreach (var item in kurslar)
            {
                if (item == kurs1)
                {
                    Console.WriteLine("Hello Python");

                }
                else if (item == kurs2)
                {
                    Console.WriteLine("Hello Java");


                }

                

                    

            }

            int a = 0;

            while (a<kurslar.Length)
            {
                Console.WriteLine("Hello");
                a = a + 1;

            }
            

            




            
            
            
        }
    } 
}
