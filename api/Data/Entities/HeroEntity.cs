using HeronApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HeronApi.Data.Entities;

public record HeroEntity(Guid Id, string Name, string Type, string Description) : Hero(Id, Name, Type, Description) { }
public class HeroEntityTypeConfiguration : IEntityTypeConfiguration<HeroEntity> {

  public void Configure(EntityTypeBuilder<HeroEntity> builder) {
    builder.HasData(
      SeedHeroes.Ana,
      SeedHeroes.Ashe,
      SeedHeroes.Baptiste,
      SeedHeroes.Bastion,
      SeedHeroes.Brigitte,
      SeedHeroes.Cassidy,
      SeedHeroes.Dva,
      SeedHeroes.Doomfist,
      SeedHeroes.Echo,
      SeedHeroes.Genji,
      SeedHeroes.Hanzo,
      SeedHeroes.Junkrat,
      SeedHeroes.Lucio,
      SeedHeroes.Mei,
      SeedHeroes.Mercy,
      SeedHeroes.Moira,
      SeedHeroes.Orisa,
      SeedHeroes.Pharah,
      SeedHeroes.Reaper,
      SeedHeroes.Reinhardt,
      SeedHeroes.Roadhog,
      SeedHeroes.Sigma,
      SeedHeroes.Soldier,
      SeedHeroes.Sombra,
      SeedHeroes.Symmetra,
      SeedHeroes.Torbjorn,
      SeedHeroes.Tracer,
      SeedHeroes.Widowmaker,
      SeedHeroes.Winston,
      SeedHeroes.Hammond,
      SeedHeroes.Zarya,
      SeedHeroes.Zenyatta
    );
  }
}

public static class HeroTypes {
  public static string Support = "Support";
  public static string Damage = "Damage";
  public static string Tank = "Tank";
}

public static class SeedHeroes {
  public static Hero Ana = new Hero(HeroIds.Ana, "Ana", HeroTypes.Support, "Ana's versatile arsenal allows her to affect heroes all over the battlefield. Her Biotic Rifle rounds and Biotic Grenades heal allies and damage or impair enemies; her sidearm tranquilizes key targets, and Nano Boost gives one of her comrades a considerable increase in power.");
  public static Hero Ashe = new Hero(HeroIds.Ashe, "Ashe", HeroTypes.Damage, "Ashe quickly fires her rifle from the hip or uses her weapon's aim-down sights to line up a high damage shot. She blasts enemies by throwing dynamite, and her coach gun packs enough punch to put some distance between her and her foes. And Ashe is not alone, as she can call on her omnic ally Bob, to join the fray when the need arises.");
  public static Hero Baptiste = new Hero(HeroIds.Baptiste, "Baptiste", HeroTypes.Support, "Baptiste wields an assortment of experimental devices and weaponry to keep allies alive and eliminate threats under fierce conditions. A battle-hardened combat medic, he is just as capable of saving lives as he is taking out the enemy.");
  public static Hero Bastion = new Hero(HeroIds.Bastion, "Bastion", HeroTypes.Damage, "Repair protocols and the ability to transform between stationary Assault, mobile Recon and devastating Tank configurations provide Bastion with a high probability of victory.");
  public static Hero Brigitte = new Hero(HeroIds.Brigitte, "Brigitte", HeroTypes.Support, "Brigitte specializes in armor. She can throw Repair Packs to heal teammates, or automatically heal nearby allies when she damages foes with her Flail. Her Flail is capable of a wide swing to strike multiple targets, or a Whip Shot that stuns an enemy at range. When entering the fray, Barrier Shield provides personal defense while she attacks enemies with Shield Bash. Brigitte's ultimate ability, Rally, gives her a substantial short-term boost of speed and provides long-lasting armor to all her nearby allies.");
  public static Hero Cassidy = new Hero(HeroIds.Cassidy, "Cassidy", HeroTypes.Damage, "Armed with his Peacekeeper revolver, Cassidy takes out targets with deadeye precision and dives out of danger with eagle-like speed.");
  public static Hero Dva = new Hero(HeroIds.Dva, "D.Va", HeroTypes.Tank, "D.Va's mech is nimble and powerful—its twin Fusion Cannons blast away with autofire at short range, and she can use its Boosters to barrel over enemies and obstacles, or deflect attacks with her projectile-dismantling Defense Matrix.");
  public static Hero Doomfist = new Hero(HeroIds.Doomfist, "Doomfist", HeroTypes.Damage, "Doomfist's cybernetics make him a highly-mobile, powerful frontline fighter. In addition to dealing ranged damage with his Hand Cannon, Doomfist can slam the ground, knock enemies into the air and off balance, or charge into the fray with his Rocket Punch. When facing a tightly packed group, Doomfist leaps out of view, then crashes down to earth with a spectacular Meteor Strike.");
  public static Hero Echo = new Hero(HeroIds.Echo, "Echo", HeroTypes.Damage, "Echo is an evolutionary robot programmed with a rapidly adapting artificial intelligence, versatile enough to fill multiple battlefield combat roles.");
  public static Hero Genji = new Hero(HeroIds.Genji, "Genji", HeroTypes.Damage, "Genji flings precise and deadly Shuriken at his targets, and uses his technologically-advanced katana to deflect projectiles or deliver a Swift Strike that cuts down");
  public static Hero Hanzo = new Hero(HeroIds.Hanzo, "Hanzo", HeroTypes.Damage, "Hanzo's versatile arrows can reveal his enemies or fragment to strike multiple targets. He can scale walls to fire his bow from on high, or summon a titanic spirit dragon.");
  public static Hero Junkrat = new Hero(HeroIds.Junkrat, "Junkrat", HeroTypes.Damage, "Junkrat's area-denying armaments include a Frag Launcher that lobs bouncing grenades, Concussion Mines that send enemies flying, and Steel Traps that stop foes dead in their tracks.");
  public static Hero Lucio = new Hero(HeroIds.Lucio, "Lucio", HeroTypes.Support, "On the battlefield, Lúcio's cutting-edge Sonic Amplifier buffets enemies with projectiles and knocks foes back with blasts of sound. His songs can both heal his team or boost their movement speed, and he can switch between tracks on the fly.");
  public static Hero Mei = new Hero(HeroIds.Mei, "Mei", HeroTypes.Damage, "Mei's weather-altering devices slow opponents and protect locations. Her Endothermic Blaster unleashes damaging icicles and frost streams, and she can Cryo-Freeze herself to guard against counterattacks, or obstruct the opposing team's movements with an Ice Wall.");
  public static Hero Mercy = new Hero(HeroIds.Mercy, "Mercy", HeroTypes.Support, "Mercy's Valkyrie Suit helps keep her close to teammates like a guardian angel; healing, resurrecting or strengthening them with the beams emanating from her Caduceus Staff.");
  public static Hero Moira = new Hero(HeroIds.Moira, "Moira", HeroTypes.Support, "Moira's biotic abilities enable her to contribute healing or damage in any crisis. While Biotic Grasp gives Moira short-range options, her Biotic Orbs contribute longer-range, hands-off damage and healing; she can also Fade to escape groups or remain close to allies in need of support. Once she's charged Coalescence, Moira can save multiple allies from elimination at once or finish off weakened enemies.");
  public static Hero Orisa = new Hero(HeroIds.Orisa, "Orisa", HeroTypes.Tank, "Orisa serves as the central anchor of her team, and defends her teammates from the frontline with a protective barrier. She can attack from long range, fortify her own defenses, launch graviton charges to slow and move enemies, and deploy a Supercharger to boost the damage output of multiple allies at once.");
  public static Hero Pharah = new Hero(HeroIds.Pharah, "Pharah", HeroTypes.Damage, "Soaring through the air in her combat armor, and armed with a launcher that lays down high-explosive rockets, Pharah is a force to be reckoned with.");
  public static Hero Reaper = new Hero(HeroIds.Reaper, "Reaper", HeroTypes.Damage, "Hellfire Shotguns, the ghostly ability to become immune to damage, and the power to step between shadows make Reaper one of the deadliest beings on Earth.");
  public static Hero Reinhardt = new Hero(HeroIds.Reinhardt, "Reinhardt", HeroTypes.Tank, "Clad in powered armor and swinging his hammer, Reinhardt leads a rocket-propelled charge across the battleground and defends his squadmates with a massive energy barrier.");
  public static Hero Roadhog = new Hero(HeroIds.Roadhog, "Roadhog", HeroTypes.Tank, "Roadhog uses his signature Chain Hook to pull his enemies close before shredding them with blasts from his Scrap Gun. He's hardy enough to withstand tremendous damage, and can recover his health with a short breather.");
  public static Hero Sigma = new Hero(HeroIds.Sigma, "Sigma", HeroTypes.Tank, "Sigma is an eccentric astrophysicist and volatile tank who gained the power to control gravity in an orbital experiment gone wrong. Manipulated by Talon and deployed as a living weapon, Sigma's presence on the battlefield cannot be ignored.");
  public static Hero Soldier = new Hero(HeroIds.Soldier, "Soldier: 76", HeroTypes.Damage, "Armed with cutting-edge weaponry, including an experimental pulse rifle that's capable of firing spirals of high-powered Helix Rockets, Soldier: 76 has the speed and support know-how of a highly trained warrior.");
  public static Hero Sombra = new Hero(HeroIds.Sombra, "Sombra", HeroTypes.Damage, "Stealth and debilitating attacks make Sombra a powerful infiltrator. Her hacking can disrupt her enemies, ensuring they're easier to take out, while her EMP provides the upper hand against multiple foes at once. Sombra's ability to Translocate and camouflage herself makes her a hard target to pin down.");
  public static Hero Symmetra = new Hero(HeroIds.Symmetra, "Symmetra", HeroTypes.Damage, "Symmetra utilizes her Photon Projector to dispatch adversaries, shield her associates, construct teleportation pads and deploy particle-blasting Sentry Turrets.");
  public static Hero Torbjorn = new Hero(HeroIds.Torbjorn, "Torbjörn", HeroTypes.Damage, "Torbjörn's extensive arsenal includes a rivet gun, hammer, and a personal forge that he can use to build turrets.");
  public static Hero Tracer = new Hero(HeroIds.Tracer, "Tracer", HeroTypes.Damage, "Toting twin pulse pistols, energy-based time bombs, and rapid-fire banter, Tracer is able to \"blink\" through space and rewind her personal timeline as she battles to right wrongs the world over.");
  public static Hero Widowmaker = new Hero(HeroIds.Widowmaker, "Widowmaker", HeroTypes.Damage, "Widowmaker equips herself with whatever it takes to eliminate her targets, including mines that dispense poisonous gas, a visor that grants her squad infra-sight, and a powerful sniper rifle that can fire in fully-automatic mode.");
  public static Hero Winston = new Hero(HeroIds.Winston, "Winston", HeroTypes.Tank, "Winston wields impressive inventions—a jump pack, electricity-blasting Tesla Cannon, portable shield projector and more—with literal gorilla strength.");
  public static Hero Hammond = new Hero(HeroIds.Hammond, "Wrecking Ball", HeroTypes.Tank, "Wrecking Ball rolls across the battlefield, using his arsenal of weapons and his mech's powerful body to crush his enemies.");
  public static Hero Zarya = new Hero(HeroIds.Zarya, "Zarya", HeroTypes.Damage, "Deploying powerful personal barriers that convert incoming damage into energy for her massive Particle Cannon, Zarya is an invaluable asset on the front lines of any battle.");
  public static Hero Zenyatta = new Hero(HeroIds.Zenyatta, "Zenyatta", HeroTypes.Support, "Zenyatta calls upon orbs of harmony and discord to heal his teammates and weaken his opponents, all while pursuing a transcendent state of immunity to damage.");
}

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