using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HeronApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HeroController : ControllerBase {
  private readonly IMediator _mediator;

  public HeroController(IMediator mediator) { _mediator = mediator; }

  [HttpGet()]
  public async Task<GetHeroesResponse> GetHeroes() {
    return await _mediator.Send(new GetHeroesRequest());
  }

  [HttpGet("{hashid}")]
  public async Task<GetHeroResponse> GetHero(string hashid) {
    return await _mediator.Send(new GetHeroRequest(hashid));
  }
}