﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManagingSystem.Domain.Models
{
    public class ProductAmount
    {
        public Guid ProductId { get; set; }
        public int Amount { get; set; }
    }
}
