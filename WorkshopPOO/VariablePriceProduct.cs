using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopPOO
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal GetValueToPay()
        {
            return ((decimal)Quantity * Price) * (1 + (decimal)Tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
               $"\n\tMeasurement....: {Measurement}" +
               $"\n\tQuantity.......: {$"{Quantity:N2}",12}" +
               $"\n\tValue..........: {$"{GetValueToPay():C2}",12}";
        }
    }
}