using Microsoft.EntityFrameworkCore;

namespace project.Models
{
    public class myDbContext:DbContext
    {

        public DbSet<User> user {get;set;}
        public DbSet<UserClothes> userClothes { get; set; }
        public DbSet<UserShoes> userShoes { get; set; }
        public DbSet<Shoes> shoes { get; set; }

        public DbSet<Clothes> clothes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=shopping;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserClothes>().HasKey(a => new{a.userId, a.clothesId});
            modelBuilder.Entity<UserShoes>().HasKey(a => new{a.userId,a.shoesId});
            base.OnModelCreating(modelBuilder);
        }




    }
}
