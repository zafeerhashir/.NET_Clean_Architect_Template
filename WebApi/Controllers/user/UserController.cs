using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.UseCases.Users.Queries.GetAllUserQuery;
using Application.UseCases.Users.Commands.GetByIdUserQuery;
using Application.UseCases.Users.Commands.CreateUserCommand;

// This is standard template code only for understanding to developer later it will be removed
namespace EcotimeWebApi.Controllers.user
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _mediator.Send(new GetAllUserQuery());
            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] int id)
        {
            var response = await _mediator.Send(new GetByIdUserQuery() { Id = id });
            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }



        [HttpPost]
        public async Task<ActionResult> InsertAsync([FromBody] CreateUserCommand command)
        {
            if (command is null) return BadRequest();

            var response = await _mediator.Send(command);

            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }


    }
}
