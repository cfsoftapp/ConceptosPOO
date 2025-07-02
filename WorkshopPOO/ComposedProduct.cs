using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public List<Product> Products { get; set; }

        public override decimal GetValueToPay()
        {
            decimal subtotal = Products.Sum(p => p.GetValueToPay());
            return subtotal * (1 - (decimal)Discount);
        }

        public override string ToString()
        {
            return $"{Id}  {Description}" +
               $"\n\tProducts.......: {string.Join(", ", Products.Select(p => p.Description))}" +
               $"\n\tDiscount.......: {$"{Discount:P2}",12}" +
               $"\n\tValue..........: {$"{GetValueToPay():C2}",12}";
        }
    }
}