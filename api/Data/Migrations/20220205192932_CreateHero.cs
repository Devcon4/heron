using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Data.Migrations
{
  public partial class CreateHero : Migration {
    protected override void Up(MigrationBuilder migrationBuilder) {
      migrationBuilder.CreateTable(
        name: "Heroes",
        columns : table => new {
          Id = table.Column<Guid>(type: "uuid", nullable : false),
            Name = table.Column<string>(type: "text", nullable : false)
        },
        constraints : table => {
          table.PrimaryKey("PK_Heroes", x => x.Id);
        });

      migrationBuilder.InsertData(
        table: "Heroes",
        columns : new [] { "Id", "Name" },
        values : new object[, ] { { new Guid("13d7bac1-6962-46d8-b4e5-664d1ed7d0a1"), "Ana" }, { new Guid("14c6674f-103f-4692-9851-75d0a04a9714"), "Baptiste" }, { new Guid("1e6fcfa4-8eeb-4044-86bb-ae7a605c5e52"), "Bastion" }, { new Guid("2c91c753-12fe-4856-a86a-5f7aa708fb00"), "Brigitte" }, { new Guid("312ba684-057b-4087-ac67-d087ee2d2d20"), "Cassidy" }, { new Guid("31ae0ce9-4fd7-4f27-978e-7c0ac8eded83"), "D.Va" }, { new Guid("36c03343-024a-4140-bf33-d0081bd57159"), "Doomfist" }, { new Guid("39f4761b-02cc-4689-9993-6d096b7c49c9"), "Echo" }, { new Guid("4828b36a-7d8a-418f-96a0-038c881cbc1c"), "Genji" }, { new Guid("4bca8882-a741-447c-b8bf-80a2f75f34ca"), "Hanzo" }, { new Guid("5572ee56-0f5a-466b-bdb7-d72032b8f25c"), "Junkrat" }, { new Guid("5f94bf75-2400-4145-ab6a-475728f6f559"), "Lucio" }, { new Guid("69346bd9-da97-4e0b-a88f-0221e41cc0b3"), "Mei" }, { new Guid("6dcddb81-22e3-4b1b-835c-01cb1328ce50"), "Mercy" }, { new Guid("721ba171-0e14-4bc0-bb7d-5b7ce24429a2"), "Moira" }, { new Guid("73b2abd0-73c9-4d20-a42d-9ffec155ccfe"), "Orisa" }, { new Guid("81828968-6173-4c2e-87a5-e13eae5598ad"), "Pharah" }, { new Guid("9473a0a1-b9ea-470f-bc22-a8f6e3d3f1e7"), "Reaper" }, { new Guid("a0b92948-70c1-4627-8f7a-ed7e1d40c28f"), "Reinhardt" }, { new Guid("a6a86d93-69c6-476e-8f3e-3b7782179f0b"), "Roadhog" }, { new Guid("c0e9f882-bb15-43c4-b052-fd8126609ebb"), "Sigma" }, { new Guid("c524d03c-f4a9-4b5c-afa2-cc1cb2d6f640"), "Soldier: 76" }, { new Guid("c53bebcf-7503-44aa-b84d-e9068fcf847b"), "Sombra" }, { new Guid("cd77e568-d337-4d36-935f-7a5ed21ae705"), "Ashe" }, { new Guid("d13bd682-16ad-45dd-9694-5009fc2e15d4"), "Symmetra" }, { new Guid("da360eea-e946-4056-a9dd-3d5bc6cd3fd5"), "Torbjorn" }, { new Guid("db92993e-f997-4b99-9708-5f04bb4b24cb"), "Tracer" }, { new Guid("f11983cd-457f-47d1-8170-82be0113e033"), "Widowmaker" }, { new Guid("f25dd3c1-3d5a-47dc-ae53-ea0137654d35"), "Winston" }, { new Guid("f8a29d50-838a-42f8-ae9d-0e907e283d48"), "Wrecking Ball" }, { new Guid("fc3d9b4b-c95b-4b5b-abd9-7ca6adc1d964"), "Zarya" }, { new Guid("fe52b22a-90c3-4e15-900a-b97d9caabab1"), "Zenyatta" }
        });
    }

    protected override void Down(MigrationBuilder migrationBuilder) {
      migrationBuilder.DropTable(
        name: "Heroes");
    }
  }
}