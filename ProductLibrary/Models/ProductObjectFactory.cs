using ProductLibrary.Views;

namespace ProductLibrary.Models
{
    public class ProductObjectFactory
    {
        private static ProductCreateView _productCreateView = null;
        public static Product CreateNewProduct(string name, string description, decimal price)
        {
            return new Product { Name = name, Description = description, Price = price };
        }
    public static ProductRecordsView ProductRecordsViewObject(ProductCollection products)
        {
            return new ProductRecordsView(products); 
        }
        public static ProductCreateView ProductCreateViewObject(ProductCollection products)
        {
            if (_productCreateView == null)
            {
                _productCreateView = new ProductCreateView(products);
            }
            return _productCreateView;
        }
    }
}
