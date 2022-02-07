using HeronApi.Data;
using HeronApi.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

public record GetReleasesResponse(List<Release> List, int count);
public record GetReleasesRequest : IRequest<GetReleasesResponse> { }

public class getReleasesHandler : IRequestHandler<GetReleasesRequest, GetReleasesResponse> {
  private readonly HeronDBContext _db;

  public getReleasesHandler(HeronDBContext db) { _db = db; }
  public async Task<GetReleasesResponse> Handle(GetReleasesRequest request, CancellationToken cancellationToken) {
    return new GetReleasesResponse(
      await _db.Releases.ToListAsync<Release>(cancellationToken),
      await _db.Releases.CountAsync(cancellationToken));
  }
}