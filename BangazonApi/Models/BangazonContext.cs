using Microsoft.EntityFrameworkCore;

namespace BangazonApi.Models
{
    public class BangazonContext : DbContext
    {
        public BangazonContext(DbContextOptions<BangazonContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customer { get; set; }
      //  public DbSet<Product> Product { get; set; }
      //  public DbSet<CustomerFave> CustomerFave { get; set; }
      //  public DbSet<Order> Order { get; set; }
       // public DbSet<PaymentType> PaymentType { get; set; }
       // public DbSet<LineItem> LineItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");

            // modelBuilder.Entity<Order>()
            //     .Property(b => b.DateCreated)
            //     .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");

            // modelBuilder.Entity<PaymentType>()
            //     .Property(b => b.DateCreated)
            //     .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");
        }
    }

}