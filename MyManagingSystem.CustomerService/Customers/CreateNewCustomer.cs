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
    public class CreateNewCustomer : IRequest<Customer>
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public Guid CustomerGuid { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }

    public class CreateNewCustomerHandler : IRequestHandler<CreateNewCustomer, Customer>
    {
        public async Task<Customer> Handle(CreateNewCustomer request, CancellationToken cancellationToken)
        {
            return new Customer
            {
                Address = request.Address,
                Email = request.Email,
                Name = request.Name,
                Guid = request.Guid
            };
        }
    }
}
