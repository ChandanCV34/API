using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apipizza.Models
{
    public partial class pizzaContext : DbContext
    {
        public pizzaContext()
        {
        }

        public pizzaContext(DbContextOptions<pizzaContext> options)
            : base(options)
        {

        }
     
       
       
       
        public virtual DbSet<Topping> Toppings { get; set; }
     
    }
}
