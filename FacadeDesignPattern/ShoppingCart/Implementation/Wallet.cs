using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Implementation
{
    public class Wallet:IWallet
    {
        public double GetUserBalance(int userID)
        {
            Console.WriteLine("\t Subsystem Wallet: GetUserBalance");
            return 100;
        }
    }
}
