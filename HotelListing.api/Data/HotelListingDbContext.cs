using Microsoft.EntityFrameworkCore;

namespace HotelListing.api.Data
{
    //Contract between the application and the DB
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions option) : base(option)
        {

        }


        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //code that configures how data is entered
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "South Africa",
                    ShortName = "SA"
                },
                new Country
                {
                    Id = 2,
                    Name = "United Kingdom",
                    ShortName = "UK"
                },
                new Country
                {
                    Id = 3,
                    Name = "Netherlands",
                    ShortName = "NL"
                },
                new Country
                {
                    Id = 4,
                    Name = "New Zealand",
                    ShortName = "NZ"
                },
                new Country
                {
                    Id = 5,
                    Name = "United States",
                    ShortName = "US"
                },
                new Country
                {
                    Id = 6,
                    Name = "Thailand",
                    ShortName = "TB"
                });
            

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Lagoon Beach Hotel & Spa ",
                    Address = "Cape Town",
                    Rating = 3.7,
                    CountryId = 1,
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Rhino Ridge Safari Lodge",
                    Address = "Hluhluwe iMfolozi Park, 3815, KwaNompondo",
                    Rating = 4.7,
                    CountryId = 1,
                },
                new Hotel
                {
                    Id = 3,
                    Name = "INNSiDE by Meliá",
                    Address = "Liverpool",
                    Rating = 4.1,
                    CountryId = 2,
                },
                 new Hotel
                 {
                     Id = 4,
                     Name = "Sandburn Hall",
                     Address = "York",
                     Rating = 4.2,
                     CountryId = 2,
                 },
                 new Hotel
                 {
                     Id = 5,
                     Name = "Ritz Hotel",
                     Address = "London",
                     Rating = 5.0,
                     CountryId = 2,
                 },
                  new Hotel
                  {
                      Id = 6,
                      Name = "Met Hotel Amsterdam",
                      Address = "Amsterdam",
                      Rating = 4.0,
                      CountryId = 3,
                  },
                  new Hotel
                  {
                      Id = 7,
                      Name = "The Market Hotel",
                      Address = "Groningen",
                      Rating = 4.1,
                      CountryId = 3,
                  },
                   new Hotel
                   {
                       Id = 8,
                       Name = "Hotel Bell",
                       Address = "Zandvoort",
                       Rating = 4.0,
                       CountryId = 3,
                   },
                   new Hotel
                   {
                       Id = 9,
                       Name = "James Cook Hotel Grand Chancellor",
                       Address = "Wellington",
                       Rating = 3.5,
                       CountryId = 4,
                   },
                    new Hotel
                    {
                        Id = 10,
                        Name = "Sudima Hotel Christchurch Airport",
                        Address = "Christchurch",
                        Rating = 3.8,
                        CountryId = 4,
                    },
                    new Hotel
                    {
                        Id = 17,
                        Name = "Novotel Auckland",
                        Address = "Auckland",
                        Rating = 4.0,
                        CountryId = 4,
                    },
                    new Hotel
                    {
                        Id = 11,
                        Name = "The Capitana",
                        Address = "Key West",
                        Rating = 4.2,
                        CountryId = 5,
                    },
                     new Hotel
                     {
                         Id = 12,
                         Name = "Hyatt House",
                         Address = "Perimeter Center, Atlanta",
                         Rating = 4.1,
                         CountryId = 5,
                     },
                     new Hotel
                     {
                         Id = 13,
                         Name = "Fairfield by Marriott Inn & Suites",
                         Address = "Orlando",
                         Rating = 4.1,
                         CountryId = 5,
                     },
                      new Hotel
                      {
                          Id = 14,
                          Name = "El Barrio Lanna- SHA Extra Plus",
                          Address = "Chiang Mai Old TOwn, Chiang Mai",
                          Rating = 4.0,
                          CountryId = 6,
                      },
                       new Hotel
                       {
                           Id = 15,
                           Name = "Eastin Grand Hotel",
                           Address = "Sathorn, Bangkok",
                           Rating = 4.1,
                           CountryId = 6,
                       },
                       new Hotel
                       {
                           Id = 16,
                           Name = "The Royal Paradise Hotel & Spa",
                           Address = "Patong Beach, Phuket",
                           Rating = 4.0,
                           CountryId = 6,
                       }
                );
        }
    }
}
