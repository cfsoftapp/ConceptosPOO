using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopPOO
{
    public abstract class Product : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id}  {Description}" +
                $"\n\tPrice..........: {$"{Price:C2}",12}" +
                $"\n\tTax............: {$"{Tax:P2}",12}";
        }
    }
}