namespace WorkshopPOO
{
    public class Invoice : IPay
    {
        private List<Product> _products;

        public Invoice()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal GetValueToPay()
        {
            return _products.Sum(p => p.GetValueToPay());
        }

        public override string ToString()
        {
            Console.WriteLine("RECEIPT");
            Console.WriteLine("-------------------------------------------------");

            decimal payroll = 0;
            foreach (Product product in _products)
            {
                Console.WriteLine(product.ToString());
                payroll += product.GetValueToPay();
            }

            return $"\t              ====================" +
                $"\n\tValue..........: {$"{payroll:C2}",12}";
        }
    }
}