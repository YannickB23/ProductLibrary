using ProductLibrary.Models;
using System;

namespace ProductLibrary.Views
{
    public class ProductRecordsView
    {
        private ProductCollection _products = null;
        public ProductRecordsView(ProductCollection products)
        {
            _products = products;
        }
        public void RunRecordsView()
        {
            Console.WriteLine(ProductCommonOutputText.GetColumnHeadings());
            foreach (Product item in _products)
            {
                Console.WriteLine(item.GetProductInfo());
            }
        }
    }
}
