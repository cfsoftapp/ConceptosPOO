using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopPOO
{
    public class FixedPriceProduct : Product
    {
        public override decimal GetValueToPay()
        {
            return Price * (1 + (decimal)Tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValue..........: {$"{GetValueToPay():C2}",12}";//Interpolación para alinear a la derecha, le damos 15 caracteres
        }
    }
}