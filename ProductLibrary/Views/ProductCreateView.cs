using ProductLibrary.Models;
using System;

namespace ProductLibrary.Views
{
    public class ProductCreateView
    {
        private ProductCollection _products = null;

        public ProductCreateView(ProductCollection products)
        {
            _products = products;
        }
        public void RunCreateView()
        {
            string name = null;
            string description = null;
            decimal price = 0;

            Console.Clear();
            Console.WriteLine(ProductCommonOutputText.GetApplicationHeading());
            Console.WriteLine();
            Console.WriteLine(ProductCommonOutputText.GetColumnHeadings());
            Console.WriteLine();
            Console.Write("Enter product name:\t");
            name = Console.ReadLine();

            Console.Write("Enter product description:\t");
            description = Console.ReadLine();

            Console.Write("Enter price:\t");
            price = decimal.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Pls press [S] to save product to database");
            ConsoleKey consoleKey = Console.ReadKey().Key;
            if (consoleKey == ConsoleKey.S)
            {
                _products.Add(ProductObjectFactory.CreateNewProduct(name, description, price));
            }
        }
    }
}
