﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pinturas.DataAccess.Data;

namespace Pinturas.DataAccess.Migrations
{
    [DbContext(typeof(PinturasDbContext))]
    [Migration("20220328190730_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pinturas.Entities.Category", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Categories");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Name = "Cubism"
                    },
                    new
                    {
                        Id = 2,
                        Name = "Expressionism"
                    },
                    new
                    {
                        Id = 3,
                        Name = "Impressionism"
                    },

                    new
                    {
                        Id = 4,
                        Name = "Post-Impressionism"
                    }
                );
            });

            modelBuilder.Entity("Pinturas.Entities.Product", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("CategoryId")
                    .HasColumnType("int");

                b.Property<DateTime?>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Descriptipn")
                    .HasColumnType("nvarchar(max)");

                b.Property<double?>("Discount")
                    .HasColumnType("float");

                b.Property<string>("ImageUrl")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime?>("ModifiedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double?>("Price")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.HasIndex("CategoryId");

                b.ToTable("Products");

                b.HasData(
                    new
                    {
                        Id = 1,
                        CategoryId = 2,
                        Discount = 0.10,
                        ImageUrl = "https://commons.wikimedia.org/wiki/File:Edvard_Munch_-_The_Scream_-_Google_Art_Project.jpg",
                        Name = "The Scream",
                        Price = 130.0
                    },
                    new
                    {
                        Id = 2,
                        CategoryId = 2,
                        Discount = 0.15,
                        ImageUrl = "https://bayaiyi.com/wp-content/uploads/2020/06/Jeanne-Hebuterne-with-Necklace.jpg",
                        Name = "Jeanne Hébuterne with Hat and Necklace",
                        Price = 110.0
                    },
                    new
                    {
                        Id = 3,
                        CategoryId = 4,
                        Discount = 0.10,
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg/1024px-Van_Gogh_-_Starry_Night_-_Google_Art_Project.jpg",
                        Name = "The Starry Night",
                        Price = 180.0
                    },
                    new
                    {
                        Id = 4,
                        CategoryId = 4,
                        Discount = 0.05,
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/69/Les_Joueurs_de_cartes%2C_par_Paul_C%C3%A9zanne.jpg",
                        Name = "Les Joueurs de Cartes",
                        Price = 190.0
                    },
                    new
                    {
                        Id = 5,
                        CategoryId = 1,
                        Discount = 0.10,
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/tr/7/7f/Picasso_Guernica.jpg",
                        Name = "Guernica",
                        Price = 220.0
                    },
                    new
                    {
                        Id = 6,
                        CategoryId = 1,
                        Discount = 0.15,
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/11/Ram%C3%B3nG%C3%B3mezdelaSerna.JPG",
                        Name = "Portrait of Ramón Gómez de la Serna",
                        Price = 105.0
                    },

                    new
                    {
                        Id = 7,
                        CategoryId = 3,
                        Discount = 0.05,
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a0/Claude_Monet_-_Jardin_%C3%A0_Sainte-Adresse.jpg",
                        Name = "Garden at Sainte-Adresse",
                        Price = 160.0
                    },

                    new
                    {
                        Id = 8,
                        CategoryId = 3,
                        Discount = 0.10,
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/90/Edouard_Manet_-_Luncheon_on_the_Grass_-_Google_Art_Project.jpg",
                        Name = "The Luncheon on the Grass",
                        Price = 150.0
                    });
            });

            modelBuilder.Entity("Pinturas.Entities.Product", b =>
            {
                b.HasOne("Pinturas.Entities.Category", "Category")
                    .WithMany("Products")
                    .HasForeignKey("CategoryId")
                    .OnDelete(DeleteBehavior.NoAction);

                b.Navigation("Category");
            });

            modelBuilder.Entity("Pinturas.Entities.Category", b =>
            {
                b.Navigation("Products");
            });
#pragma warning restore 612, 618
        }
    }
}