using System.Globalization;

namespace LinqAndLambda.Entities
{
    
    internal class Product : Identity
    {
        public double price { get; set; }
        public Category category { get; set; }
        public Product(int id, string name, double price, Category category) : base(id, name)
        {
            this.price = price;
            this.category = category;
        }

        public Product()
        {
        }

        public override string ToString()
        {
            return id
                + ","
                + name
                + ","
                + price.ToString("F2", CultureInfo.InvariantCulture)
                + ","
                + category.name
                + ","
                + category.tier;
        }



    }
}
