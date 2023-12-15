using System;
using System.Collections.Generic;

namespace eCommerceDotNetCoreMVC.web.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public string UserId { get; set; }  
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public virtual ICollection<CartItem> CartItems { get; set; }
     }
}
