using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderItem.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int userId { get; set; }
        public int menuitemId { get; set; }
        public string menuitemName { get; set; }
    }
}
