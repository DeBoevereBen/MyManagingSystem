﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManagingSystem.Domain.Models
{
    public class Inventory
    {
        public Guid Guid { get; set; }
        public List<ProductAmount> ProductAmounts { get; set; }
    }
}
