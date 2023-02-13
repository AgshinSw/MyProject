using System;

namespace Mushteri
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Yaratmaq ya Silmek?");
            string Answer = Console.ReadLine();

            if (Answer == "Yaratmaq")
            {
                Console.Write("Ad: ");
                string MusteriAd = Console.ReadLine();

                Console.Write("İD: ");
                string Musteriİd = Console.ReadLine();

                Console.Write("Soyad: ");
                string MusteriSoyad = Console.ReadLine();



                MushteriYarat(MusteriAd, Musteriİd, MusteriSoyad);
            }

            else if (Answer == "Silmek")
            {
                MushteriManager.MustheriProperties mushteri1 = new MushteriManager.MustheriProperties();

                Console.Write("Ad: ");
                string MusteriAd = Console.ReadLine();
                mushteri1.Ad = MusteriAd;

                MushteriSil(mushteri1);

            }

            else
            {

                Console.WriteLine("Bele secim yoxdur!!!");
                    
            }

            




            





        }


        static void MushteriYarat(string mushteri,string Musteriİd,string MusteriSoyad)
        {

            MushteriManager.MustheriProperties mushteri1 = new MushteriManager.MustheriProperties();
            mushteri1.Ad = mushteri;
            mushteri1.İD = Musteriİd;
            mushteri1.Soyad = MusteriSoyad;
            mushteri1.Aktivlik = true;
            Console.WriteLine("Yeni mushteri yaratdiniz!: " + mushteri1.Ad + mushteri1.Soyad);
        }

        static void MushteriSil(MushteriManager.MustheriProperties mushteri)
        {
            Console.WriteLine("Mushterini sildiniz: " + mushteri.Ad + mushteri.Soyad);
        }

    }
}
