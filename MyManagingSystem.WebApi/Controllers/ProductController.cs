using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyManagingSystem.ProductService.Products;
using MyManagingSystem.WebApi.DTOs;
using System;
using System.Threading.Tasks;

namespace MyManagingSystem.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("{guid}")]
        [HttpGet]
        public async Task<IActionResult> GetProductByGuid(string guid)
        {
            var p = await _mediator.Send(new FindProduct { ProductGuid = Guid.NewGuid() });
            return Ok(p);
        }

        [Route("new")]
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] NewProductDTO product)
        {
            var p = await _mediator.Send(new CreateNewProduct { Name = product.Name, Price = product.Price });
            return Ok(p);
        }
    }
}
