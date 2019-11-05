using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyManagingSystem.InventoryService.Inventory
{
    public class RemoveFromInventory: IRequest
    {
        public Guid Guid { get; set; }
        public Guid ProductGuid { get; set; }
    }

    public class RemoveFromInventoryHandler : IRequestHandler<RemoveFromInventory>
    {
        public Task<Unit> Handle(RemoveFromInventory request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
