using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Implementation
{
    public class AddressDetails: IAddress
    {
        public Models.Address GetAddressDetails(int userID)
        {
            Console.WriteLine("\t Subsystem Address: GetAddressDetails");
            return new Models.Address();
        }
    }
}
