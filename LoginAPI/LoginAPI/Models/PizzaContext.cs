using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAPI.Models
{
    public class PizzaContext:DbContext
    {
        public PizzaContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> users { get; set; }
        //public DbSet<OrderDetailsDTO> orderDetails { get; set; }

        //public DbSet<OrderDTO> ordDetail { get; set; }
    }
}
