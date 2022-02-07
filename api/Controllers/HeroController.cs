using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HeronApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HeroesController : ControllerBase {
  private readonly IMediator _mediator;

  public HeroesController(IMediator mediator) { _mediator = mediator; }

  [HttpGet()]
  public async Task<GetHeroesResponse> GetHeroes() {
    return await _mediator.Send(new GetHeroesRequest());
  }

  [HttpGet("{hashid}")]
  public async Task<GetHeroResponse> GetHero(string hashid) {
    return await _mediator.Send(new GetHeroRequest(hashid));
  }
}