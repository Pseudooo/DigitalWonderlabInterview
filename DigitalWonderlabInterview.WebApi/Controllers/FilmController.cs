using DigitalWonderlabInterview.Service.Commands;
using DigitalWonderlabInterview.Service.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DigitalWonderlabInterview.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmController : ControllerBase
{
    private readonly IMediator _mediator;

    public FilmController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("add")]
    public async Task<ActionResult> AddFilmAsync([FromBody] AddFilmCommand command)
    {
        var result = await _mediator.Send(command);
        return Created("", result);
    }

    [HttpPost("search")]
    public async Task<ActionResult> SearchForFilm([FromBody] SearchForFilmQuery query)
    {
        var result = await _mediator.Send(query);
        return Ok(result);
    }

}