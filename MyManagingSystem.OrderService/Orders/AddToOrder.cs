using MediatR;
using MyManagingSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyManagingSystem.OrderService.Orders
{
    public class AddToOrder: IRequest
    {
        public Guid Guid { get; set; }
        public Guid OrderGuid { get; set; }
        public ProductAmount ProductAmount { get; set; }
    }

    public class AddToOrderHandler : IRequestHandler<AddToOrder>
    {
        public Task<Unit> Handle(AddToOrder request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
