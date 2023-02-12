using System;

namespace ClassIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            Sirket sirket = new Sirket();
            sirket.SirketAdi = "Lideroft";
            sirket.SirketProqramcisi = "Aqsin";
            sirket.SirketMaasi = 1000;

            Sirket sirket2 = new Sirket();
            sirket2.SirketAdi = "Bestsoft";
            sirket2.SirketProqramcisi = "Kamran";
            sirket2.SirketMaasi = 4000;

            Sirket sirket3 = new Sirket();
            sirket3.SirketAdi = "Lidertech";
            sirket3.SirketProqramcisi = "Meherrem";
            sirket3.SirketMaasi = 10000;


            Sirket[] sirketler = new Sirket[] { sirket, sirket2, sirket3 };

            foreach (var item in sirketler)
            {


                Console.WriteLine(item.SirketAdi + " " + item.SirketProqramcisi + " " + item.SirketMaasi);
            };

            Nomenklatura nomenklatura1 = new Nomenklatura();
            nomenklatura1.Adi = "Stol";
            nomenklatura1.Qiymeti = 100;
            nomenklatura1.İzahi = "Palıd ağacından stol";

            Nomenklatura nomenklatura2 = new Nomenklatura();
            nomenklatura2.Adi = "Skaf";
            nomenklatura2.Qiymeti = 1000;
            nomenklatura2.İzahi = "Möhkəm şkaf";

            Nomenklatura nomenklatura3 = new Nomenklatura();
            nomenklatura3.Adi = "Qaöı";
            nomenklatura3.Qiymeti = 167;
            nomenklatura3.İzahi = "Qara qapı";

            Nomenklatura[] mallar = new Nomenklatura[] { nomenklatura1, nomenklatura2, nomenklatura3 };

            foreach (var item in mallar)

            {
                Console.WriteLine(item.Adi + " " + item.Qiymeti + " " + item.İzahi);
                NomenklaturaElaveEden nomenklaturaelaveeden = new NomenklaturaElaveEden();
                nomenklaturaelaveeden.ElaveEt(item.Adi);
            }


















        }

        class Sirket
        {
            public string SirketAdi { get; set; }
            public string SirketProqramcisi { get; set; }
            public int SirketMaasi { get; set; }
        }

    }

}
