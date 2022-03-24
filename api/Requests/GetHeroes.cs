using HeronApi.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

public record HeroListItem(Guid Id, string Name);
public record GetHeroesResponse(List<HeroListItem> List, int count);
public record GetHeroesRequest : IRequest<GetHeroesResponse> { }

public class getHeroesHandler : IRequestHandler<GetHeroesRequest, GetHeroesResponse> {
  private readonly HeronDBContext _db;

  public getHeroesHandler(HeronDBContext db) { _db = db; }
  public async Task<GetHeroesResponse> Handle(GetHeroesRequest request, CancellationToken cancellationToken) {
    return new GetHeroesResponse(
      await _db.Heroes.Select(h => new HeroListItem(h.Id, h.Name)).ToListAsync(cancellationToken),
      await _db.Heroes.CountAsync(cancellationToken));
  }
}