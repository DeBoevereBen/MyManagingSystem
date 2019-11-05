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
    public class CreateNewOrder : IRequest<Order>
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public Guid OrderGuid { get; set; }
        public DateTime OrderTime { get; set; }
        public List<ProductAmount> Products { get; set; }
        public Guid CustomerGuid { get; set; }
    }

    public class CreateNewOrderHandler : IRequestHandler<CreateNewOrder, Order>
    {
        public async Task<Order> Handle(CreateNewOrder request, CancellationToken cancellationToken)
        {
            return new Order
            {
                CustomerGuid = request.CustomerGuid,
                Guid = request.Guid,
                OrderTime = request.OrderTime,
                Products = request.Products
            };
        }
    }
}
