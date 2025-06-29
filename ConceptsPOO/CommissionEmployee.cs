﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommisionPercentaje { get; set; }
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommisionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommision percentaje: {$"{CommisionPercentaje:P2}",15}" +
                $"\n\tSales...............: {$"{Sales:C2}",15}" +
                $"\n\tValue to pay........: {$"{GetValueToPay():C2}",15}";
        }
    }
}