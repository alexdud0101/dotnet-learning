namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            var product = obj as Product;
            if(product is null)
            {
                return false;
            }

            return this.Name == product.Name &&
                    this.Price == product.Price;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
