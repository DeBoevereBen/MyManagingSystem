using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyManagingSystem.CustomerService.Customers;
using MyManagingSystem.WebApi.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyManagingSystem.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("new")]
        [HttpPost]
        public async Task<IActionResult> CreateNewCustomer([FromBody] NewCustomerDTO customer)
        {
            return Ok(
                await _mediator.Send(new CreateNewCustomer
                {
                    Address = customer.Address,
                    Name = customer.Name,
                    Email = customer.Email,
                })
               );
        }
    }
}
