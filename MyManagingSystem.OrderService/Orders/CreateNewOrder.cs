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
    public class CreateNewOrder : IRequest
    {
        public Guid Guid { get; set; }
        public Guid OrderGuid { get; set; }
        public DateTime OrderTime { get; set; }
        public List<ProductAmount> Products { get; set; }
        public Guid CustomerGuid { get; set; }
    }

    public class CreateNewOrderHandler : IRequestHandler<CreateNewOrder>
    {
        public Task<Unit> Handle(CreateNewOrder request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
