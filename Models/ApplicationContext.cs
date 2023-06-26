using Microsoft.EntityFrameworkCore;

namespace MagicVilla.Models
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Villa> VillaAPI { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa() 
                {
                    Id = 1,
                    Name = "Royal villa",
                    Description = "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio",
                    image = "",
                    Occupancy = 10,
                    Rate = 200,
                    sqrt = 550,
                    Aminety = "",
                    AcessToken="",
                    Created_at = DateTime.Now,


                },
                 new Villa()
                 {
                     Id = 2,
                     Name = "luxary  villa",
                     Description = "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio",
                     image = "",
                     Occupancy = 10,
                     Rate = 200,
                     sqrt = 550,
                     Aminety = "",
                     AcessToken = "",
                     Created_at = DateTime.Now,


                 },
                 new Villa()
                 {
                     Id = 3,
                     Name = "Ancient villa",
                     Description = "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio",
                     image = "",
                     Occupancy = 10,
                     Rate = 200,
                     sqrt = 550,
                     Aminety = "",
                     AcessToken = "",
                     Created_at = DateTime.Now,

                 },
                 new Villa()
                 {
                     Id = 4,
                     Name = "palace villa",
                     Description = "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio",
                     image = "",
                     Occupancy = 10,
                     Rate = 200,
                     sqrt = 550,
                     Aminety = "",
                     AcessToken = "",
                     Created_at = DateTime.Now,

                 },
                 new Villa()
                 {
                     Id = 5,
                     Name = "water villa",
                     Description = "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio",
                     image = "",
                     Occupancy = 10,
                     Rate = 200,
                     sqrt = 550,
                     Aminety = "",
                     AcessToken = "",
                     Created_at = DateTime.Now,

                 },
                 new Villa()
                 {
                     Id = 6,
                     Name = "fire villa",
                     Description = "!Loremasdfghjkl;qwertyuiozxcvbnm,asdfghjkqwertyuio",
                     image = "",
                     Occupancy = 10,
                     Rate = 200,
                     sqrt = 550,
                     Aminety = "",
                     AcessToken = "",
                     Created_at = DateTime.Now,

                 }


                );
        }
    }
}
