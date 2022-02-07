using HeronApi.Data;
using HeronApi.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

public record GetReleaseResponse(Release release, List<HeroUpdate> heroUpdates);
public record GetReleaseRequest(Guid Id) : IRequest<GetReleaseResponse>;

public class getReleaseHandler : IRequestHandler<GetReleaseRequest, GetReleaseResponse> {
  private readonly HeronDBContext _db;

  public getReleaseHandler(HeronDBContext db) { _db = db; }
  public async Task<GetReleaseResponse> Handle(GetReleaseRequest request, CancellationToken cancellationToken) {
    var release = await _db.Releases.FirstAsync(r => r.Id == request.Id);
    return new GetReleaseResponse(
      release,
      await _db.HeroUpdates.Where(a => a.ReleaseId == release.Id).ToListAsync<HeroUpdate>(cancellationToken));
  }
}