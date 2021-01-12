using ProductLibrary.Models;
using ProductLibrary.Views;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApplication = false;
            ProductCollection products = new ProductCollection();
            ProductRecordsView productRecordsView = ProductObjectFactory.ProductRecordsViewObject(products);

            while (!endApplication)
            {
                Console.Clear();
                Console.WriteLine(ProductCommonOutputText.GetApplicationHeading());
                productRecordsView.RunRecordsView();
                Console.WriteLine();
                Console.WriteLine(ProductCommonOutputText.GetInstructions());

                ConsoleKey instructionKey = Console.ReadKey().Key;
                switch (instructionKey)
                {
                    case ConsoleKey.C:
                        ProductCreateView productCreateView = ProductObjectFactory.ProductCreateViewObject(products);
                        productCreateView.RunCreateView();
                        break;
                    case ConsoleKey.R:
                        break;
                    case ConsoleKey.U:
                        break;
                    case ConsoleKey.D:
                        break;
                    default:
                        endApplication = true;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
