// <auto-generated />
using System;
using HeronApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace api.Data.Migrations {
  [DbContext(typeof(HeronDBContext))]
  [Migration("20220205192932_CreateHero")]
  partial class CreateHero {
    protected override void BuildTargetModel(ModelBuilder modelBuilder) {
#pragma warning disable 612, 618
      modelBuilder
        .HasAnnotation("ProductVersion", "6.0.1")
        .HasAnnotation("Relational:MaxIdentifierLength", 63);

      NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

      modelBuilder.Entity("HeronApi.Data.Entities.HeroEntity", b => {
        b.Property<Guid>("Id")
          .ValueGeneratedOnAdd()
          .HasColumnType("uuid");

        b.Property<string>("Name")
          .IsRequired()
          .HasColumnType("text");

        b.HasKey("Id");

        b.ToTable("Heroes");

        b.HasData(
          new {
            Id = new Guid("13d7bac1-6962-46d8-b4e5-664d1ed7d0a1"),
              Name = "Ana"
          },
          new {
            Id = new Guid("cd77e568-d337-4d36-935f-7a5ed21ae705"),
              Name = "Ashe"
          },
          new {
            Id = new Guid("14c6674f-103f-4692-9851-75d0a04a9714"),
              Name = "Baptiste"
          },
          new {
            Id = new Guid("1e6fcfa4-8eeb-4044-86bb-ae7a605c5e52"),
              Name = "Bastion"
          },
          new {
            Id = new Guid("2c91c753-12fe-4856-a86a-5f7aa708fb00"),
              Name = "Brigitte"
          },
          new {
            Id = new Guid("312ba684-057b-4087-ac67-d087ee2d2d20"),
              Name = "Cassidy"
          },
          new {
            Id = new Guid("31ae0ce9-4fd7-4f27-978e-7c0ac8eded83"),
              Name = "D.Va"
          },
          new {
            Id = new Guid("36c03343-024a-4140-bf33-d0081bd57159"),
              Name = "Doomfist"
          },
          new {
            Id = new Guid("39f4761b-02cc-4689-9993-6d096b7c49c9"),
              Name = "Echo"
          },
          new {
            Id = new Guid("4828b36a-7d8a-418f-96a0-038c881cbc1c"),
              Name = "Genji"
          },
          new {
            Id = new Guid("4bca8882-a741-447c-b8bf-80a2f75f34ca"),
              Name = "Hanzo"
          },
          new {
            Id = new Guid("5572ee56-0f5a-466b-bdb7-d72032b8f25c"),
              Name = "Junkrat"
          },
          new {
            Id = new Guid("5f94bf75-2400-4145-ab6a-475728f6f559"),
              Name = "Lucio"
          },
          new {
            Id = new Guid("69346bd9-da97-4e0b-a88f-0221e41cc0b3"),
              Name = "Mei"
          },
          new {
            Id = new Guid("6dcddb81-22e3-4b1b-835c-01cb1328ce50"),
              Name = "Mercy"
          },
          new {
            Id = new Guid("721ba171-0e14-4bc0-bb7d-5b7ce24429a2"),
              Name = "Moira"
          },
          new {
            Id = new Guid("73b2abd0-73c9-4d20-a42d-9ffec155ccfe"),
              Name = "Orisa"
          },
          new {
            Id = new Guid("81828968-6173-4c2e-87a5-e13eae5598ad"),
              Name = "Pharah"
          },
          new {
            Id = new Guid("9473a0a1-b9ea-470f-bc22-a8f6e3d3f1e7"),
              Name = "Reaper"
          },
          new {
            Id = new Guid("a0b92948-70c1-4627-8f7a-ed7e1d40c28f"),
              Name = "Reinhardt"
          },
          new {
            Id = new Guid("a6a86d93-69c6-476e-8f3e-3b7782179f0b"),
              Name = "Roadhog"
          },
          new {
            Id = new Guid("c0e9f882-bb15-43c4-b052-fd8126609ebb"),
              Name = "Sigma"
          },
          new {
            Id = new Guid("c524d03c-f4a9-4b5c-afa2-cc1cb2d6f640"),
              Name = "Soldier: 76"
          },
          new {
            Id = new Guid("c53bebcf-7503-44aa-b84d-e9068fcf847b"),
              Name = "Sombra"
          },
          new {
            Id = new Guid("d13bd682-16ad-45dd-9694-5009fc2e15d4"),
              Name = "Symmetra"
          },
          new {
            Id = new Guid("da360eea-e946-4056-a9dd-3d5bc6cd3fd5"),
              Name = "Torbjorn"
          },
          new {
            Id = new Guid("db92993e-f997-4b99-9708-5f04bb4b24cb"),
              Name = "Tracer"
          },
          new {
            Id = new Guid("f11983cd-457f-47d1-8170-82be0113e033"),
              Name = "Widowmaker"
          },
          new {
            Id = new Guid("f25dd3c1-3d5a-47dc-ae53-ea0137654d35"),
              Name = "Winston"
          },
          new {
            Id = new Guid("f8a29d50-838a-42f8-ae9d-0e907e283d48"),
              Name = "Wrecking Ball"
          },
          new {
            Id = new Guid("fc3d9b4b-c95b-4b5b-abd9-7ca6adc1d964"),
              Name = "Zarya"
          },
          new {
            Id = new Guid("fe52b22a-90c3-4e15-900a-b97d9caabab1"),
              Name = "Zenyatta"
          });
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b => {
        b.Property<string>("Id")
          .HasColumnType("text");

        b.Property<string>("ConcurrencyStamp")
          .IsConcurrencyToken()
          .HasColumnType("text");

        b.Property<string>("Name")
          .HasMaxLength(256)
          .HasColumnType("character varying(256)");

        b.Property<string>("NormalizedName")
          .HasMaxLength(256)
          .HasColumnType("character varying(256)");

        b.HasKey("Id");

        b.HasIndex("NormalizedName")
          .IsUnique()
          .HasDatabaseName("RoleNameIndex");

        b.ToTable("AspNetRoles", (string) null);
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b => {
        b.Property<int>("Id")
          .ValueGeneratedOnAdd()
          .HasColumnType("integer");

        NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

        b.Property<string>("ClaimType")
          .HasColumnType("text");

        b.Property<string>("ClaimValue")
          .HasColumnType("text");

        b.Property<string>("RoleId")
          .IsRequired()
          .HasColumnType("text");

        b.HasKey("Id");

        b.HasIndex("RoleId");

        b.ToTable("AspNetRoleClaims", (string) null);
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b => {
        b.Property<string>("Id")
          .HasColumnType("text");

        b.Property<int>("AccessFailedCount")
          .HasColumnType("integer");

        b.Property<string>("ConcurrencyStamp")
          .IsConcurrencyToken()
          .HasColumnType("text");

        b.Property<string>("Email")
          .HasMaxLength(256)
          .HasColumnType("character varying(256)");

        b.Property<bool>("EmailConfirmed")
          .HasColumnType("boolean");

        b.Property<bool>("LockoutEnabled")
          .HasColumnType("boolean");

        b.Property<DateTimeOffset?>("LockoutEnd")
          .HasColumnType("timestamp with time zone");

        b.Property<string>("NormalizedEmail")
          .HasMaxLength(256)
          .HasColumnType("character varying(256)");

        b.Property<string>("NormalizedUserName")
          .HasMaxLength(256)
          .HasColumnType("character varying(256)");

        b.Property<string>("PasswordHash")
          .HasColumnType("text");

        b.Property<string>("PhoneNumber")
          .HasColumnType("text");

        b.Property<bool>("PhoneNumberConfirmed")
          .HasColumnType("boolean");

        b.Property<string>("SecurityStamp")
          .HasColumnType("text");

        b.Property<bool>("TwoFactorEnabled")
          .HasColumnType("boolean");

        b.Property<string>("UserName")
          .HasMaxLength(256)
          .HasColumnType("character varying(256)");

        b.HasKey("Id");

        b.HasIndex("NormalizedEmail")
          .HasDatabaseName("EmailIndex");

        b.HasIndex("NormalizedUserName")
          .IsUnique()
          .HasDatabaseName("UserNameIndex");

        b.ToTable("AspNetUsers", (string) null);
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b => {
        b.Property<int>("Id")
          .ValueGeneratedOnAdd()
          .HasColumnType("integer");

        NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

        b.Property<string>("ClaimType")
          .HasColumnType("text");

        b.Property<string>("ClaimValue")
          .HasColumnType("text");

        b.Property<string>("UserId")
          .IsRequired()
          .HasColumnType("text");

        b.HasKey("Id");

        b.HasIndex("UserId");

        b.ToTable("AspNetUserClaims", (string) null);
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b => {
        b.Property<string>("LoginProvider")
          .HasColumnType("text");

        b.Property<string>("ProviderKey")
          .HasColumnType("text");

        b.Property<string>("ProviderDisplayName")
          .HasColumnType("text");

        b.Property<string>("UserId")
          .IsRequired()
          .HasColumnType("text");

        b.HasKey("LoginProvider", "ProviderKey");

        b.HasIndex("UserId");

        b.ToTable("AspNetUserLogins", (string) null);
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b => {
        b.Property<string>("UserId")
          .HasColumnType("text");

        b.Property<string>("RoleId")
          .HasColumnType("text");

        b.HasKey("UserId", "RoleId");

        b.HasIndex("RoleId");

        b.ToTable("AspNetUserRoles", (string) null);
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b => {
        b.Property<string>("UserId")
          .HasColumnType("text");

        b.Property<string>("LoginProvider")
          .HasColumnType("text");

        b.Property<string>("Name")
          .HasColumnType("text");

        b.Property<string>("Value")
          .HasColumnType("text");

        b.HasKey("UserId", "LoginProvider", "Name");

        b.ToTable("AspNetUserTokens", (string) null);
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b => {
        b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
          .WithMany()
          .HasForeignKey("RoleId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b => {
        b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
          .WithMany()
          .HasForeignKey("UserId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b => {
        b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
          .WithMany()
          .HasForeignKey("UserId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b => {
        b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
          .WithMany()
          .HasForeignKey("RoleId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();

        b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
          .WithMany()
          .HasForeignKey("UserId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();
      });

      modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b => {
        b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
          .WithMany()
          .HasForeignKey("UserId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();
      });
#pragma warning restore 612, 618
    }
  }
}