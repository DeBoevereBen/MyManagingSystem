using MediatR;
using MyManagingSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyManagingSystem.InventoryService.Inventory
{
    public class AddToInventory : IRequest
    {
        public Guid Guid { get; set; }
        public int Amount { get; set; }
        public Guid ProductGuid { get; set; }
    }

    public class AddToInventoryHandler : IRequestHandler<AddToInventory>
    {
        public Task<Unit> Handle(AddToInventory request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
