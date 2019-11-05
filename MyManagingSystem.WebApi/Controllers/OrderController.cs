using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyManagingSystem.OrderService.Orders;
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
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("new")]
        public async Task<IActionResult> CreateNewOrder([FromBody] NewOrderDTO order)
        {
            var o = await _mediator.Send(new CreateNewOrder
            {
                CustomerGuid = order.CustomerGuid,
                Products = order.Products
            });
            return Ok(o);
        }
    }
}
