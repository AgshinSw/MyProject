using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.İd = 1;
            product1.CategoryİD = 2;
            product1.ProductName = "Stol";
            product1.UnitPrice = 15;
            product1.UnitsİnStock = 100;

            Product product2 = new Product { İd = 2, CategoryİD = 3,ProductName = "Qelem", UnitPrice = 20,UnitsİnStock = 30 };

            ProductManager productmanager = new ProductManager();
            productmanager.Add(product1);
            

        }
    }
}
