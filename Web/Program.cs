using System;
using System.Net;
using System.IO;


namespace Web
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient WEB = new WebClient();

            Console.Write("Enter the video URL:");
            string link = Console.ReadLine();
            string filename = "c://users//Administrator//Desktop//İnstagramFiles//file1.jpg";
            //string filename = "file1.jpg";

            //WEB.DownloadFile(link, filename);
            WEB.DownloadFile(link, filename);
            Console.WriteLine("Succsess!");
        }
    }
}
