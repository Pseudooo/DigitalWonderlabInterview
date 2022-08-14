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
    public ActionResult AddFilm()
    {
        throw new NotImplementedException();
    }

    [HttpGet("search")]
    public ActionResult SearchForFilm()
    {
        throw new NotImplementedException();
    }

}