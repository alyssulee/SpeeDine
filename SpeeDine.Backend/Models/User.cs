using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeeDine.Backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<OrderItem> Orders { get; set; }
        public List<OrderItem> Cart { get; set; }
        public List<OrderItem> Bill { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
            Orders = new List<OrderItem>();     // Placed Orders
            Cart = new List<OrderItem>();       // Items in Cart
            Bill = new List<OrderItem>();       // Items being added to the bill
        }

        private double CalculateCost(List<OrderItem> itemList)
        {
            double total = 0;
            foreach (var orderItem in itemList)
            {
                total += orderItem.MenuItem.Price;
                if (orderItem.Side != null)
                {
                    total += orderItem.Side.ExtraCost;
                }
            }
            return total;
        }

        public double CalculateOrdersSubTotal()
        {
            return CalculateCost(Orders);
        }

        public double CalculateCartSubTotal()
        {
            return CalculateCost(Cart);
        }
    }
}
