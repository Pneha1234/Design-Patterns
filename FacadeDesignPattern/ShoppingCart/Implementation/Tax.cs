using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Implementation
{
    public class Tax:ITax
    {
        public void ApplyTax(int cartID, double taxPercent)
        {
            Console.WriteLine("\t Subsystem Tax:ApplyTax");
        }
        public double GetTaxByState(string state)
        {
            Console.WriteLine("\t Subsystem Tax: GetTaxByState");
            return 10;
        }
    }
}
