using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyManagingSystem.CustomerService.Customers
{
    public class CreateNewCustomer : IRequest
    {
        public Guid Guid { get; set; }
        public Guid CustomerGuid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }

    public class CreateNewCustomerHandler : IRequestHandler<CreateNewCustomer>
    {
        public Task<Unit> Handle(CreateNewCustomer request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
