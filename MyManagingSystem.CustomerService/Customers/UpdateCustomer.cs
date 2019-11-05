using MediatR;
using MyManagingSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyManagingSystem.CustomerService.Customers
{
    public class UpdateCustomer : IRequest
    {
        public Guid Guid { get; set; }
        public Guid CustomerGuid { get; set; }
        public Customer Customer { get; set; }
    }

    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomer>
    {
        public Task<Unit> Handle(UpdateCustomer request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
