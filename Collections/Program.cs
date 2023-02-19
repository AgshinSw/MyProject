using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<string> names = new List<string> { "Name1", "Name2", "Name3", "Name4"};
            //names.Remove("Name1");
            names.Add("Hello");


            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            






        }
    }
}
