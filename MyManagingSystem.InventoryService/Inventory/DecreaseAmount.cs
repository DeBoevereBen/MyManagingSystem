using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyManagingSystem.InventoryService.Inventory
{
    public class DecreaseAmount : IRequest
    {
        public Guid Guid { get; set; }
        public Guid ProductGuid { get; set; }
        public int Amount { get; set; }
    }

    public class DecreaseAmountHandler : IRequestHandler<DecreaseAmount>
    {
        public Task<Unit> Handle(DecreaseAmount request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
