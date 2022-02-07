using HeronApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HeronApi.Data.Entities;

public static class HeroIds {
  public static Guid Ana = new Guid("13d7bac1-6962-46d8-b4e5-664d1ed7d0a1");
  public static Guid Ashe = new Guid("cd77e568-d337-4d36-935f-7a5ed21ae705");
  public static Guid Baptiste = new Guid("14c6674f-103f-4692-9851-75d0a04a9714");
  public static Guid Bastion = new Guid("1e6fcfa4-8eeb-4044-86bb-ae7a605c5e52");
  public static Guid Brigitte = new Guid("2c91c753-12fe-4856-a86a-5f7aa708fb00");
  public static Guid Cassidy = new Guid("312ba684-057b-4087-ac67-d087ee2d2d20");
  public static Guid Dva = new Guid("31ae0ce9-4fd7-4f27-978e-7c0ac8eded83");
  public static Guid Doomfist = new Guid("36c03343-024a-4140-bf33-d0081bd57159");
  public static Guid Echo = new Guid("39f4761b-02cc-4689-9993-6d096b7c49c9");
  public static Guid Genji = new Guid("4828b36a-7d8a-418f-96a0-038c881cbc1c");
  public static Guid Hanzo = new Guid("4bca8882-a741-447c-b8bf-80a2f75f34ca");
  public static Guid Junkrat = new Guid("5572ee56-0f5a-466b-bdb7-d72032b8f25c");
  public static Guid Lucio = new Guid("5f94bf75-2400-4145-ab6a-475728f6f559");
  public static Guid Mei = new Guid("69346bd9-da97-4e0b-a88f-0221e41cc0b3");
  public static Guid Mercy = new Guid("6dcddb81-22e3-4b1b-835c-01cb1328ce50");
  public static Guid Moira = new Guid("721ba171-0e14-4bc0-bb7d-5b7ce24429a2");
  public static Guid Orisa = new Guid("73b2abd0-73c9-4d20-a42d-9ffec155ccfe");
  public static Guid Pharah = new Guid("81828968-6173-4c2e-87a5-e13eae5598ad");
  public static Guid Reaper = new Guid("9473a0a1-b9ea-470f-bc22-a8f6e3d3f1e7");
  public static Guid Reinhardt = new Guid("a0b92948-70c1-4627-8f7a-ed7e1d40c28f");
  public static Guid Roadhog = new Guid("a6a86d93-69c6-476e-8f3e-3b7782179f0b");
  public static Guid Sigma = new Guid("c0e9f882-bb15-43c4-b052-fd8126609ebb");
  public static Guid Soldier = new Guid("c524d03c-f4a9-4b5c-afa2-cc1cb2d6f640");
  public static Guid Sombra = new Guid("c53bebcf-7503-44aa-b84d-e9068fcf847b");
  public static Guid Symmetra = new Guid("d13bd682-16ad-45dd-9694-5009fc2e15d4");
  public static Guid Torbjorn = new Guid("da360eea-e946-4056-a9dd-3d5bc6cd3fd5");
  public static Guid Tracer = new Guid("db92993e-f997-4b99-9708-5f04bb4b24cb");
  public static Guid Widowmaker = new Guid("f11983cd-457f-47d1-8170-82be0113e033");
  public static Guid Winston = new Guid("f25dd3c1-3d5a-47dc-ae53-ea0137654d35");
  public static Guid Hammond = new Guid("f8a29d50-838a-42f8-ae9d-0e907e283d48");
  public static Guid Zarya = new Guid("fc3d9b4b-c95b-4b5b-abd9-7ca6adc1d964");
  public static Guid Zenyatta = new Guid("fe52b22a-90c3-4e15-900a-b97d9caabab1");
}

public record HeroEntity(Guid Id, string Name) : Hero(Id, Name) { }
public class HeroEntityTypeConfiguration : IEntityTypeConfiguration<HeroEntity> {

  public void Configure(EntityTypeBuilder<HeroEntity> builder) {
    builder.HasData(
      new { Id = HeroIds.Ana, Name = "Ana" },
      new { Id = HeroIds.Ashe, Name = "Ashe" },
      new { Id = HeroIds.Baptiste, Name = "Baptiste" },
      new { Id = HeroIds.Bastion, Name = "Bastion" },
      new { Id = HeroIds.Brigitte, Name = "Brigitte" },
      new { Id = HeroIds.Cassidy, Name = "Cassidy" },
      new { Id = HeroIds.Dva, Name = "D.Va" },
      new { Id = HeroIds.Doomfist, Name = "Doomfist" },
      new { Id = HeroIds.Echo, Name = "Echo" },
      new { Id = HeroIds.Genji, Name = "Genji" },
      new { Id = HeroIds.Hanzo, Name = "Hanzo" },
      new { Id = HeroIds.Junkrat, Name = "Junkrat" },
      new { Id = HeroIds.Lucio, Name = "Lucio" },
      new { Id = HeroIds.Mei, Name = "Mei" },
      new { Id = HeroIds.Mercy, Name = "Mercy" },
      new { Id = HeroIds.Moira, Name = "Moira" },
      new { Id = HeroIds.Orisa, Name = "Orisa" },
      new { Id = HeroIds.Pharah, Name = "Pharah" },
      new { Id = HeroIds.Reaper, Name = "Reaper" },
      new { Id = HeroIds.Reinhardt, Name = "Reinhardt" },
      new { Id = HeroIds.Roadhog, Name = "Roadhog" },
      new { Id = HeroIds.Sigma, Name = "Sigma" },
      new { Id = HeroIds.Soldier, Name = "Soldier: 76" },
      new { Id = HeroIds.Sombra, Name = "Sombra" },
      new { Id = HeroIds.Symmetra, Name = "Symmetra" },
      new { Id = HeroIds.Torbjorn, Name = "Torbjorn" },
      new { Id = HeroIds.Tracer, Name = "Tracer" },
      new { Id = HeroIds.Widowmaker, Name = "Widowmaker" },
      new { Id = HeroIds.Winston, Name = "Winston" },
      new { Id = HeroIds.Hammond, Name = "Wrecking Ball" },
      new { Id = HeroIds.Zarya, Name = "Zarya" },
      new { Id = HeroIds.Zenyatta, Name = "Zenyatta" }
    );
  }
}