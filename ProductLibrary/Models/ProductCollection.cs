using System.Collections;
using System.Collections.Generic;

namespace ProductLibrary.Models
{
    public class ProductCollection : IEnumerable
    {
        List<Product> _productList = null;
        public ProductCollection()
        {
            _productList = new List<Product>();
            SeedData();
        }
        public Product this[int index] 
        {
            get => _productList[index];
        }
        private void SeedData()
        {
            this.Add(ProductObjectFactory.CreateNewProduct("Coffee", "Hot beverages", 4.55m));
            this.Add(ProductObjectFactory.CreateNewProduct("Coca-Cola", "Cold beverages", 2.50m));
            this.Add(ProductObjectFactory.CreateNewProduct("Milk", "Cold beverages", 1.20m));
            this.Add(ProductObjectFactory.CreateNewProduct("Tea", "Hot beverages", 4.70m));
            this.Add(ProductObjectFactory.CreateNewProduct("Water", "Cold beverages", 2.00m));
        }
        public void Add(Product product)
        {
            _productList.Add(product);
        }

        public IEnumerator GetEnumerator()
        {
            return _productList.GetEnumerator();
        }
    }
}
