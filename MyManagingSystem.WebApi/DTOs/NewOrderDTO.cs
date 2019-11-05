using MyManagingSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManagingSystem.WebApi.DTOs
{
    public class NewOrderDTO
    {
        public List<ProductAmount> Products { get; set; }
        public Guid CustomerGuid { get; set; } = Guid.NewGuid();

        public NewOrderDTO()
        {
            Products = new List<ProductAmount>() { 
                new ProductAmount()
                {
                    Amount = 4,
                    ProductId = Guid.NewGuid()
                },
                new ProductAmount()
                {
                    Amount = 2,
                    ProductId = Guid.NewGuid()
                },
                new ProductAmount()
                {
                    Amount = 6,
                    ProductId = Guid.NewGuid()
                }
            };
        }
    }
}
