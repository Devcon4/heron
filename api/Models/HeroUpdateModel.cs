namespace HeronApi.Models;
public record HeroUpdate(Guid Id, Guid AbilityId, string DeveloperComments, string ChangeNotes);