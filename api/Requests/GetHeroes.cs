using HeronApi.Data;
using HeronApi.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

public record GetHeroesResponse(List<Hero> List, int count);
public record GetHeroesRequest : IRequest<GetHeroesResponse> { }

public class getHeroesHandler : IRequestHandler<GetHeroesRequest, GetHeroesResponse> {
  private readonly HeronDBContext _db;

  public getHeroesHandler(HeronDBContext db) { _db = db; }
  public async Task<GetHeroesResponse> Handle(GetHeroesRequest request, CancellationToken cancellationToken) {
    return new GetHeroesResponse(
      await _db.Heroes.ToListAsync<Hero>(cancellationToken),
      await _db.Heroes.CountAsync(cancellationToken));
  }
}