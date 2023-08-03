﻿using System.Collections.Generic;
using System;

namespace FreeCourse.Web.Models.Orders
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; private set; }
        public string BuyerId { get; private set; }
        public List<OrderItemViewModel> OrderItems { get; private set; }
    }
}
