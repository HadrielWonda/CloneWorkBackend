﻿// <auto-generated />
using System;
using DigitalInvest.FundingPlatform.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DigitalInvest.FundingPlatform.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210402184225_CreateDbAndSeedData")]
    partial class CreateDbAndSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DigitalInvest.FundingPlatform.DataAccess.Entitities.Funding", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("Investment")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Target")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Fundings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e9bb08ec-4048-42ae-8038-7fd10f962909"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 5, 1, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 1",
                            Target = 710867.0
                        },
                        new
                        {
                            Id = new Guid("635141f1-dd57-4c05-a91b-78edc2c96a53"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 4, 30, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 2",
                            Target = 512358.0
                        },
                        new
                        {
                            Id = new Guid("cae5b156-19ee-4a0c-a154-1ceef75ff1e7"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 4, 24, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 3",
                            Target = 699383.0
                        },
                        new
                        {
                            Id = new Guid("b4892525-4bbb-4a8a-8895-0f5e012d6829"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 4, 26, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 4",
                            Target = 614863.0
                        },
                        new
                        {
                            Id = new Guid("7ed0bc0b-3b5f-4105-b71d-46d115782023"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 5, 6, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 5",
                            Target = 835391.0
                        },
                        new
                        {
                            Id = new Guid("9b416e32-06c3-43c8-b70c-d9afd91bdf9c"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 5, 9, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 6",
                            Target = 554932.0
                        },
                        new
                        {
                            Id = new Guid("11cbf0c7-e2cb-4bcd-9e3a-7a79a139e2ec"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 5, 1, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 7",
                            Target = 947473.0
                        },
                        new
                        {
                            Id = new Guid("cfe7745d-fa31-4720-9b90-d3d27c89513d"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 5, 1, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 8",
                            Target = 765839.0
                        },
                        new
                        {
                            Id = new Guid("c10d4c86-c332-4db2-bcdd-9cc7f75fd143"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 4, 29, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 9",
                            Target = 795119.0
                        },
                        new
                        {
                            Id = new Guid("691e9bf2-9e22-436b-b48c-f25bcbdca3d1"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 4, 26, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 10",
                            Target = 716728.0
                        },
                        new
                        {
                            Id = new Guid("31e31705-a939-4469-ae7e-34f0e085a64a"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 4, 29, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 11",
                            Target = 750120.0
                        },
                        new
                        {
                            Id = new Guid("fe23d2c3-0edf-4b10-8af8-e2459484f100"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 4, 25, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 12",
                            Target = 699202.0
                        },
                        new
                        {
                            Id = new Guid("8514bc6c-75dc-4169-a12c-6778edb0ec64"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 5, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 13",
                            Target = 646972.0
                        },
                        new
                        {
                            Id = new Guid("c92b8fc3-4205-47ea-9ffb-941752a8d50d"),
                            CreatedOn = new DateTime(2021, 4, 2, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            ExpirationDate = new DateTime(2021, 4, 27, 18, 42, 24, 998, DateTimeKind.Utc).AddTicks(3315),
                            Investment = 0.0,
                            Name = "Property 14",
                            Target = 841235.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
