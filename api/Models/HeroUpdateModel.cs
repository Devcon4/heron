namespace HeronApi.Models;
public record HeroUpdate(Guid Id, Guid HeroAbilityId, Guid ReleaseId, string DeveloperComments, string ChangeNotes);