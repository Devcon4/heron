using HeronApi.Data;
using HeronApi.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

public record GetHeroResponse(Hero hero, List<HeroAbility> abilities);
public record GetHeroRequest(string HashId) : IRequest<GetHeroResponse>;

public class getHeroHandler : IRequestHandler<GetHeroRequest, GetHeroResponse> {
  private readonly HeronDBContext _db;

  public getHeroHandler(HeronDBContext db) { _db = db; }
  public async Task<GetHeroResponse> Handle(GetHeroRequest request, CancellationToken cancellationToken) {
    var hero = await _db.Heroes.FirstAsync(h => h.Id.ToString().StartsWith(request.HashId));
    return new GetHeroResponse(
      hero,
      await _db.HeroAblities.Where(a => a.HeroId == hero.Id).ToListAsync<HeroAbility>(cancellationToken));
  }
}