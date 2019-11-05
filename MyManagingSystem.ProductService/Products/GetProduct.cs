using MediatR;
using MyManagingSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyManagingSystem.ProductService.Products
{
    public class GetProduct : IRequest<Product>
    {
        public Guid Guid { get; set; }
        public Guid ProductGuid { get; set; }
    }

    public class GetProductHandler : IRequestHandler<GetProduct, Product>
    {
        public async Task<Product> Handle(GetProduct request, CancellationToken cancellationToken)
        {
            var p = new Product
            {
                Name = "Productje",
                Guid = Guid.NewGuid(),
                Price= 12.00
            };
            return p;
        }
    }
}
