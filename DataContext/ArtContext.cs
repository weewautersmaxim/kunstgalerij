using System;
using System.Threading;
using System.Threading.Tasks;
using kunstgalerij.DTO;
using kunstgalerij.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Sneakers.API.Config;

namespace kunstgalerij.DataContext
{
    public interface IArtContext
    {
        DbSet<Artist> Artists { get; set; }
        DbSet<Artwork> Artworks { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<CategoryArtworks> CategoryArtworks { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }

    public class ArtContext : DbContext, IArtContext
    {
        //turning c# code into sql database tables
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryArtworks> CategoryArtworks { get; set; }
        private ConnectionStrings _connectionStrings;

        //telling the code wich database to use
        public ArtContext(DbContextOptions<ArtContext> options, IOptions<ConnectionStrings> connectionStrings) : base(options)
        {
            _connectionStrings = connectionStrings.Value;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()));
            options.UseSqlServer(_connectionStrings.SQL);
        }
        //creating dummydata for the sql database.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryArtworks>()
              .HasKey(cs => new { cs.CategoryId, cs.ArtworkId });

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 1,
                CategoryName = "Modern"
            });
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 2,
                CategoryName = "Classic"
            });
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 3,
                CategoryName = "Abstract"
            });
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 4,
                CategoryName = "figuratief"
            });
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 5,
                CategoryName = "landscape"
            });
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 6,
                CategoryName = "portrait"
            });

            modelBuilder.Entity<Artist>().HasData(new Artist()
            {
                ArtistId = 1,
                Name = "van Gogh",
                FirstName = "Vincent",
                Age = 37,
                Gender = "man",
                Birthplace = "The Netherlands",
                description = "Vincent Willem van Gogh was een Nederlands kunstschilder. Zijn werk valt onder het postimpressionisme, een kunststroming die het negentiende-eeuwse impressionisme opvolgde. Van Gogh wordt gezien als een van de grootste schilders van de 19e eeuw."
            });
            modelBuilder.Entity<Artist>().HasData(new Artist()
            {
                ArtistId = 2,
                Name = "Picasso",
                FirstName = "Pablo",
                Age = 92,
                Gender = "man",
                Birthplace = "Spain",
                description = "He was a draftsman, sculptor and jewelry designer. He was also one of the most famous Spanish painters"
            });
        }


    }
}
