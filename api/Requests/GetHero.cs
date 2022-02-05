using HeronApi.Data;
using HeronApi.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

public record GetHeroResponse(Hero hero);
public record GetHeroRequest(Guid Id) : IRequest<GetHeroResponse>;

public class getHeroHandler : IRequestHandler<GetHeroRequest, GetHeroResponse> {
  private readonly HeronDBContext _db;

  public getHeroHandler(HeronDBContext db) { _db = db; }
  public async Task<GetHeroResponse> Handle(GetHeroRequest request, CancellationToken cancellationToken) {
    return new GetHeroResponse(await _db.Heroes.FirstAsync(h => h.Id == request.Id));
  }

}