// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kunstgalerij.DataContext;

namespace kunstgalerij.Migrations
{
    [DbContext(typeof(ArtContext))]
    [Migration("20210406141320_first build")]
    partial class firstbuild
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("kunstgalerij.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Birthplace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            Age = 37,
                            Birthplace = "The Netherlands",
                            FirstName = "Vincent",
                            Gender = "man",
                            Name = "van Gogh",
                            description = "Vincent Willem van Gogh was een Nederlands kunstschilder. Zijn werk valt onder het postimpressionisme, een kunststroming die het negentiende-eeuwse impressionisme opvolgde. Van Gogh wordt gezien als een van de grootste schilders van de 19e eeuw."
                        },
                        new
                        {
                            ArtistId = 2,
                            Age = 92,
                            Birthplace = "Spain",
                            FirstName = "Pablo",
                            Gender = "man",
                            Name = "Picasso",
                            description = "He was a draftsman, sculptor and jewelry designer. He was also one of the most famous Spanish painters."
                        });
                });

            modelBuilder.Entity("kunstgalerij.Models.Artwork", b =>
                {
                    b.Property<Guid>("ArtworkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Imagename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ArtworkId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Artworks");
                });

            modelBuilder.Entity("kunstgalerij.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Modern"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Classic"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Abstract"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "figuratief"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "landscape"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "portrait"
                        });
                });

            modelBuilder.Entity("kunstgalerij.Models.CategoryArtworks", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<Guid>("ArtworkId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoryId", "ArtworkId");

                    b.HasIndex("ArtworkId");

                    b.ToTable("CategoryArtworks");
                });

            modelBuilder.Entity("kunstgalerij.Models.Artwork", b =>
                {
                    b.HasOne("kunstgalerij.Models.Artist", "artist")
                        .WithMany("artworks")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("artist");
                });

            modelBuilder.Entity("kunstgalerij.Models.CategoryArtworks", b =>
                {
                    b.HasOne("kunstgalerij.Models.Artwork", null)
                        .WithMany("CategoryArtworks")
                        .HasForeignKey("ArtworkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kunstgalerij.Models.Category", "Category")
                        .WithMany("CategoryArtworks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("kunstgalerij.Models.Artist", b =>
                {
                    b.Navigation("artworks");
                });

            modelBuilder.Entity("kunstgalerij.Models.Artwork", b =>
                {
                    b.Navigation("CategoryArtworks");
                });

            modelBuilder.Entity("kunstgalerij.Models.Category", b =>
                {
                    b.Navigation("CategoryArtworks");
                });
#pragma warning restore 612, 618
        }
    }
}
