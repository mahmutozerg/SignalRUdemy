using Microsoft.EntityFrameworkCore;
using SignalR.Core.Entities;
using SignalRApi.DAL.Entities;

namespace SignalRRepository.Concrete;

public class SignalRContext:DbContext
{
    public DbSet<About> Abouts { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts{ get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Feature> Features{ get; set; }
    public DbSet<Product>  Products { get; set; }
    public DbSet<SocialMedia> Socialmedias { get; set; }
    public DbSet<Testimonial> Testimonials{ get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;Initial Catalog=SignalRDb;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }
}