namespace App.ProductApi
{
    public class Product
    {
        static private int sayac = 0;
        private int _id;
        public Product()
        {
            sayac++;
            _id = sayac;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Category { get; set; }
    }
}
