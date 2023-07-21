using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Difficulty> Difficultys { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Defficulties
            // Easy , Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("acf1976e-98eb-4ba3-a738-3a697f58cac1"),
                    Name = "Easy",
                },
                new Difficulty()
                {
                    Id = Guid.Parse("8f0c279d-89ce-4a1c-b113-b9031b22dfef"),
                    Name = "Medium",
                },
                new Difficulty()
                {
                    Id =  Guid.Parse("1efcd22a-e209-4ac0-9fd7-ccc976791fc9"),
                    Name = "Hard",
                }
            };
            //seed difficultys to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed data for Regions
            var regions = new List<Region>
            {
                new Region()
                {
                    Id =  Guid.Parse("2f28018d-778f-4a7f-9ceb-7138f92f7ffa"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region()
                {
                    Id = Guid.Parse("98fb4423-4be6-4117-b13d-db769915fc50"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id = Guid.Parse("e06c161e-d225-47d6-a552-4e3e7d84b37d"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null,
                },
                new Region()
                {
                    Id = Guid.Parse("52bf972d-4a7f-47df-adc1-07bc95b6959e"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region()
                {
                    Id = Guid.Parse("0ca1d8df-1c14-4268-8537-68ed6c3e4081"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                },
                new Region()
                {
                    Id = Guid.Parse("52010945-9ce6-4b72-bf2c-24b4fece7e4f"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null,
                }
            };
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
