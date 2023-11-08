using Application.Commands;
using Application.Queries;
using Application.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllItems()
        {
            var results = await _mediator.Send(new GetAllItemsQuery());

            return Ok(results);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateItem([FromBody] CreateItemRequest item)
        {
            var result = await _mediator.Send(new CreateItemCommand(item.Title, item.Description));
            return Ok(result);
        }
    }
}