namespace ProductLibrary.Models
{
    public class Product
    {
        private static int _nextId = 0;
        private int _id = 0;
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Id
        {
            get => _id;
        }
        public Product()
        {
            _nextId++;
            _id = _nextId;
        }
        public Product(string name, string descreption, decimal price): this()
        {
            Name = name;
            Description = descreption;
            Price = price;
        }
        public string GetProductInfo()
        {
            string productInfo = $"{Id.ToString().PadRight(6)}\t{Name.PadRight(15)}\t{Description.PadRight(30)}\t{Price.ToString()}\n";
            return productInfo;
        }
    }
}
