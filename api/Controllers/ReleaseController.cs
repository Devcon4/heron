using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HeronApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReleaseController : ControllerBase {
  private readonly IMediator _mediator;

  public ReleaseController(IMediator mediator) { _mediator = mediator; }

  [HttpGet()]
  public async Task<GetReleasesResponse> GetReleases() {
    return await _mediator.Send(new GetReleasesRequest());
  }

  [HttpGet("{id:guid}")]
  public async Task<GetReleaseResponse> GetRelease(Guid id) {
    return await _mediator.Send(new GetReleaseRequest(id));
  }
}