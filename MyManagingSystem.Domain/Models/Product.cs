using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManagingSystem.Domain.Models
{
    public class Product
    {
        public Guid Guid { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
    }
}
