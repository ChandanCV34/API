using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderDetailsAPI.Models
{
    public class OrderDetails
    {
        [Key]
        public int ItemNumber { get; set; }

        public int OrderId { get; set; }
        public int PizzaNumber { get; set; }

    }
}
