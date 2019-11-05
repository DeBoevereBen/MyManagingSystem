using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManagingSystem.Domain.Models
{
    public class Order
    {
        public Guid Guid { get; set; }
        public DateTime OrderTime { get; set; }
        public Guid CustomerGuid { get; set; }
        public List<ProductAmount> Products { get; set; }
    }
}
