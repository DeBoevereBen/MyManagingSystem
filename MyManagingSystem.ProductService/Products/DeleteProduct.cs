using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyManagingSystem.ProductService.Products
{
    public class DeleteProduct : IRequest
    {
        public Guid Guid { get; set; }
        public Guid ProductGuid { get; set; }
    }

    public class DeleteTodoHandler : IRequestHandler<DeleteProduct>
    {
        public Task<Unit> Handle(DeleteProduct request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
