using ETicaret.DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.DataAccessLayer
{
    public class ETicaretContext : DbContext
    {
        public ETicaretContext()
        {
            
        }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=BORA\BRCTN; Database=ETicaretDb; trusted_connection=true ;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductFavorite>()
                .HasKey(t => new { t.ProductId, t.FavoriteId });
            modelBuilder.Entity<ProductFavorite>()
                .HasOne(t => t.Product)
                .WithMany(t => t.Favorites)
                .HasForeignKey(t => t.ProductId);
            modelBuilder.Entity<ProductFavorite>()
                .HasOne(t => t.Favorite)
                .WithMany(t => t.Products)
                .HasForeignKey(t => t.FavoriteId);

        }



        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
      
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
 
    }
}
