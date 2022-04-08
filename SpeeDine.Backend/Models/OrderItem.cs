using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeeDine.Backend.Models
{
    public record OrderItem(int Id, MenuItem MenuItem, int Quantity, OrderStatus OrderStatus, MenuSide? Side, string SpecialInstructions) 
    {
        public int Quantity { get; set; } = Quantity;
        public OrderStatus OrderStatus { get; set; } = OrderStatus;
    };

    public enum OrderStatus
    {
        PendingOrder,   // Order is in cart
        Waiting,        // Order has not been delivered
        Delivered       // Order has been delivered
    }
}
