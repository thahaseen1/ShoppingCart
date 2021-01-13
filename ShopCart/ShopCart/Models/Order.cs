using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCart.Models
{
    [Table("CartOrders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      
        public int OrderId { get; set; }
       
        public decimal OrderAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
    }
}
