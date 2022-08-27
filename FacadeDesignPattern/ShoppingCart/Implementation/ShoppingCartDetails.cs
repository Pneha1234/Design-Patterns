using ShoppingCart.Interfaces;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Implementation
{
    public class ShoppingCartDetails:ICart
    {
        public ShoppingCartDetails()
        {

        }
        public int AddItemToCart(int itemID, int Quantity)
        {
            Console.WriteLine("\t SubSystem Cart:AddItemToCart");
            return 15;
        }
        public bool CheckItemAvailability(Product product)
        {
            Console.WriteLine("\t Subsystem Cart:CheckItemAvailablity");
            return true;

        }

        public double GetCartPrice(int cartID)
        {
            throw new NotImplementedException();
        }

        public Product GetItemDetails(int itemID)
        {
            Console.WriteLine("\t Subsystem Cart:GetItemDetails");
            return new Product();
        }
        public bool LockItemInStock(int itemID, int quantity)
        {
            Console.WriteLine("\t Subsytem Cart: LockItemInStock");
            return true;
        }

    }
}
