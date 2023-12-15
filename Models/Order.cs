﻿using System;
using System.Collections.Generic;

namespace eCommerceDotNetCoreMVC.web.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; } // Link to the User model
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsCompleted { get; set; }

        // Navigation properties
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        // Other properties as needed
    }
}
