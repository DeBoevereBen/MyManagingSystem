using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyManagingSystem.ProductService.Products
{
    public class CreateNewProduct : IRequest
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public Guid ProductGuid { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
    }

    public class CreateNewProductHandler : IRequestHandler<CreateNewProduct>
    {
        public async Task<Unit> Handle(CreateNewProduct request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }




}
