using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Data.Migrations
{
    public partial class SeedHeroDescriptionAndType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Heroes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Heroes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("13d7bac1-6962-46d8-b4e5-664d1ed7d0a1"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Ana's versatile arsenal allows her to affect heroes all over the battlefield. Her Biotic Rifle rounds and Biotic Grenades heal allies and damage or impair enemies; her sidearm tranquilizes key targets, and Nano Boost gives one of her comrades a considerable increase in power.", "Support" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("14c6674f-103f-4692-9851-75d0a04a9714"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Baptiste wields an assortment of experimental devices and weaponry to keep allies alive and eliminate threats under fierce conditions. A battle-hardened combat medic, he is just as capable of saving lives as he is taking out the enemy.", "Support" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("1e6fcfa4-8eeb-4044-86bb-ae7a605c5e52"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Repair protocols and the ability to transform between stationary Assault, mobile Recon and devastating Tank configurations provide Bastion with a high probability of victory.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("2c91c753-12fe-4856-a86a-5f7aa708fb00"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Brigitte specializes in armor. She can throw Repair Packs to heal teammates, or automatically heal nearby allies when she damages foes with her Flail. Her Flail is capable of a wide swing to strike multiple targets, or a Whip Shot that stuns an enemy at range. When entering the fray, Barrier Shield provides personal defense while she attacks enemies with Shield Bash. Brigitte's ultimate ability, Rally, gives her a substantial short-term boost of speed and provides long-lasting armor to all her nearby allies.", "Support" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("312ba684-057b-4087-ac67-d087ee2d2d20"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Armed with his Peacekeeper revolver, Cassidy takes out targets with deadeye precision and dives out of danger with eagle-like speed.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("31ae0ce9-4fd7-4f27-978e-7c0ac8eded83"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "D.Va's mech is nimble and powerful—its twin Fusion Cannons blast away with autofire at short range, and she can use its Boosters to barrel over enemies and obstacles, or deflect attacks with her projectile-dismantling Defense Matrix.", "Tank" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("36c03343-024a-4140-bf33-d0081bd57159"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Doomfist's cybernetics make him a highly-mobile, powerful frontline fighter. In addition to dealing ranged damage with his Hand Cannon, Doomfist can slam the ground, knock enemies into the air and off balance, or charge into the fray with his Rocket Punch. When facing a tightly packed group, Doomfist leaps out of view, then crashes down to earth with a spectacular Meteor Strike.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("39f4761b-02cc-4689-9993-6d096b7c49c9"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Echo is an evolutionary robot programmed with a rapidly adapting artificial intelligence, versatile enough to fill multiple battlefield combat roles.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("4828b36a-7d8a-418f-96a0-038c881cbc1c"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Genji flings precise and deadly Shuriken at his targets, and uses his technologically-advanced katana to deflect projectiles or deliver a Swift Strike that cuts down", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("4bca8882-a741-447c-b8bf-80a2f75f34ca"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Hanzo's versatile arrows can reveal his enemies or fragment to strike multiple targets. He can scale walls to fire his bow from on high, or summon a titanic spirit dragon.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("5572ee56-0f5a-466b-bdb7-d72032b8f25c"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Junkrat's area-denying armaments include a Frag Launcher that lobs bouncing grenades, Concussion Mines that send enemies flying, and Steel Traps that stop foes dead in their tracks.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("5f94bf75-2400-4145-ab6a-475728f6f559"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "On the battlefield, Lúcio's cutting-edge Sonic Amplifier buffets enemies with projectiles and knocks foes back with blasts of sound. His songs can both heal his team or boost their movement speed, and he can switch between tracks on the fly.", "Support" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("69346bd9-da97-4e0b-a88f-0221e41cc0b3"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Mei's weather-altering devices slow opponents and protect locations. Her Endothermic Blaster unleashes damaging icicles and frost streams, and she can Cryo-Freeze herself to guard against counterattacks, or obstruct the opposing team's movements with an Ice Wall.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("6dcddb81-22e3-4b1b-835c-01cb1328ce50"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Mercy's Valkyrie Suit helps keep her close to teammates like a guardian angel; healing, resurrecting or strengthening them with the beams emanating from her Caduceus Staff.", "Support" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("721ba171-0e14-4bc0-bb7d-5b7ce24429a2"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Moira's biotic abilities enable her to contribute healing or damage in any crisis. While Biotic Grasp gives Moira short-range options, her Biotic Orbs contribute longer-range, hands-off damage and healing; she can also Fade to escape groups or remain close to allies in need of support. Once she's charged Coalescence, Moira can save multiple allies from elimination at once or finish off weakened enemies.", "Support" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("73b2abd0-73c9-4d20-a42d-9ffec155ccfe"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Orisa serves as the central anchor of her team, and defends her teammates from the frontline with a protective barrier. She can attack from long range, fortify her own defenses, launch graviton charges to slow and move enemies, and deploy a Supercharger to boost the damage output of multiple allies at once.", "Tank" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("81828968-6173-4c2e-87a5-e13eae5598ad"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Soaring through the air in her combat armor, and armed with a launcher that lays down high-explosive rockets, Pharah is a force to be reckoned with.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("9473a0a1-b9ea-470f-bc22-a8f6e3d3f1e7"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Hellfire Shotguns, the ghostly ability to become immune to damage, and the power to step between shadows make Reaper one of the deadliest beings on Earth.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("a0b92948-70c1-4627-8f7a-ed7e1d40c28f"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Clad in powered armor and swinging his hammer, Reinhardt leads a rocket-propelled charge across the battleground and defends his squadmates with a massive energy barrier.", "Tank" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("a6a86d93-69c6-476e-8f3e-3b7782179f0b"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Roadhog uses his signature Chain Hook to pull his enemies close before shredding them with blasts from his Scrap Gun. He's hardy enough to withstand tremendous damage, and can recover his health with a short breather.", "Tank" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("c0e9f882-bb15-43c4-b052-fd8126609ebb"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Sigma is an eccentric astrophysicist and volatile tank who gained the power to control gravity in an orbital experiment gone wrong. Manipulated by Talon and deployed as a living weapon, Sigma's presence on the battlefield cannot be ignored.", "Tank" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("c524d03c-f4a9-4b5c-afa2-cc1cb2d6f640"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Armed with cutting-edge weaponry, including an experimental pulse rifle that's capable of firing spirals of high-powered Helix Rockets, Soldier: 76 has the speed and support know-how of a highly trained warrior.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("c53bebcf-7503-44aa-b84d-e9068fcf847b"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Stealth and debilitating attacks make Sombra a powerful infiltrator. Her hacking can disrupt her enemies, ensuring they're easier to take out, while her EMP provides the upper hand against multiple foes at once. Sombra's ability to Translocate and camouflage herself makes her a hard target to pin down.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("cd77e568-d337-4d36-935f-7a5ed21ae705"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Ashe quickly fires her rifle from the hip or uses her weapon's aim-down sights to line up a high damage shot. She blasts enemies by throwing dynamite, and her coach gun packs enough punch to put some distance between her and her foes. And Ashe is not alone, as she can call on her omnic ally Bob, to join the fray when the need arises.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("d13bd682-16ad-45dd-9694-5009fc2e15d4"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Symmetra utilizes her Photon Projector to dispatch adversaries, shield her associates, construct teleportation pads and deploy particle-blasting Sentry Turrets.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("da360eea-e946-4056-a9dd-3d5bc6cd3fd5"),
                columns: new[] { "Description", "Name", "Type" },
                values: new object[] { "Torbjörn's extensive arsenal includes a rivet gun, hammer, and a personal forge that he can use to build turrets.", "Torbjörn", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("db92993e-f997-4b99-9708-5f04bb4b24cb"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Toting twin pulse pistols, energy-based time bombs, and rapid-fire banter, Tracer is able to \"blink\" through space and rewind her personal timeline as she battles to right wrongs the world over.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("f11983cd-457f-47d1-8170-82be0113e033"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Widowmaker equips herself with whatever it takes to eliminate her targets, including mines that dispense poisonous gas, a visor that grants her squad infra-sight, and a powerful sniper rifle that can fire in fully-automatic mode.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("f25dd3c1-3d5a-47dc-ae53-ea0137654d35"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Winston wields impressive inventions—a jump pack, electricity-blasting Tesla Cannon, portable shield projector and more—with literal gorilla strength.", "Tank" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("f8a29d50-838a-42f8-ae9d-0e907e283d48"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Wrecking Ball rolls across the battlefield, using his arsenal of weapons and his mech's powerful body to crush his enemies.", "Tank" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("fc3d9b4b-c95b-4b5b-abd9-7ca6adc1d964"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Deploying powerful personal barriers that convert incoming damage into energy for her massive Particle Cannon, Zarya is an invaluable asset on the front lines of any battle.", "Damage" });

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("fe52b22a-90c3-4e15-900a-b97d9caabab1"),
                columns: new[] { "Description", "Type" },
                values: new object[] { "Zenyatta calls upon orbs of harmony and discord to heal his teammates and weaken his opponents, all while pursuing a transcendent state of immunity to damage.", "Support" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Heroes");

            migrationBuilder.UpdateData(
                table: "Heroes",
                keyColumn: "Id",
                keyValue: new Guid("da360eea-e946-4056-a9dd-3d5bc6cd3fd5"),
                column: "Name",
                value: "Torbjorn");
        }
    }
}
