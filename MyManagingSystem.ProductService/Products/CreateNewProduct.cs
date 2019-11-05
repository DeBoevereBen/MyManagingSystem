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
    public class CreateNewProduct : IRequest<Product>
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public Guid ProductGuid { get; set; } = Guid.NewGuid();
        public double Price { get; set; }
        public string Name { get; set; }
    }

    public class CreateNewProductHandler : IRequestHandler<CreateNewProduct, Product>
    {
        public async Task<Product> Handle(CreateNewProduct request, CancellationToken cancellationToken)
        {
            return new Product
            {
                Guid = request.ProductGuid,
                Name = request.Name,
                Price = request.Price
            };
        }
    }




}
