using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Apipizza.Models
{
    public partial class Topping
    {
       
        [Key]
        public int ToppingNumber { get; set; }
        public string ToppingName { get; set; }
        public int? ToppingPrice { get; set; }

        //public virtual ICollection<OrderItemDetail> OrderItemDetails { get; set; }
    }
}
