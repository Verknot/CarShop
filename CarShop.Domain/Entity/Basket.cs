﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Domain.Entity
{
    public class Basket
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }

        public List<Order> Orders { get; set; }
    }
}
