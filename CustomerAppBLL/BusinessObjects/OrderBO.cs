﻿using System;
using System.ComponentModel.DataAnnotations;


namespace CustomerAppBLL.BusinessObjects
{
    public class OrderBO
    {
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        public int CustomerId { get; set; }
        public CustomerBO Customer { get; set; }
    }
}
