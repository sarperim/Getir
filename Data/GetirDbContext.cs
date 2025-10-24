using Getir.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Getir.Data
{
    public class GetirDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<RefreshToken> RefreshTokens{ get; set; } = null!;

        public GetirDbContext(DbContextOptions<GetirDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
              .HasMany(u => u.Addresses)  
              .WithOne(a => a.User)      
              .HasForeignKey(a => a.UserId); 

            modelBuilder.Entity<User>()
                .HasMany(u => u.RefreshTokens)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId);

        }

    }
}
