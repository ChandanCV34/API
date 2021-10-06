using OrderDetailsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderDetailsAPI.Services
{
    public class OrderDetailsService
    {
        private readonly OrderDetailsContext _context;

        public OrderDetailsService(OrderDetailsContext context)
        {
            _context = context;
        }
        public OrderDetails Add(OrderDetails order)
        {

            _context.orderDetails.Add(order);

            _context.SaveChanges();
            return order;
        }
    }
}
