namespace HeronApi.Models;

public record HeroAbility(Guid Id, Guid HeroId, string Name, string Description, bool IsUltimate);