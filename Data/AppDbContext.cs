using ECommerceAppBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAppBackend.Data;

public class AppDbContext : DbContext
{
    private IConfiguration Config { get; set; }
    public AppDbContext(IConfiguration config)  
    {
        Config = config;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Config.GetConnectionString("MSSQL_ConnectionString"));
    }

    public DbSet<ItemModel> Items { get; set; }
    public DbSet<ShopCartModel> ShopCarts { get; set; }
    public DbSet<UserModel> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Ensure uniqueness of the Email field
        modelBuilder.Entity<UserModel>()
            .HasIndex(u => u.Email)
            .IsUnique();
        // Add 20 sample electronic devices
        string[] productNames = {
                "Logitech Mouse Pro",
                "Philips Coffee Machine",
                "Samsung Smart TV",
                "Apple iPhone 13",
                "Sony Noise Cancelling Headphones",
                "Dell Inspiron Laptop",
                "Canon DSLR Camera",
                "Bose Soundbar",
                "Fitbit Versa Smartwatch",
                "Nintendo Switch",
                "Amazon Echo Dot",
                "Microsoft Surface Pro",
                "HP LaserJet Printer",
                "LG UltraWide Monitor",
                "GoPro Hero Action Camera",
                "Lenovo ThinkPad Laptop",
                "Google Nest Thermostat",
                "Asus Gaming Mouse",
                "JBL Portable Bluetooth Speaker",
                "Garmin GPS Watch"
            };

        Random rnd = new Random();
        for (int i = 1; i <= 20; i++)
        {
            modelBuilder.Entity<ItemModel>().HasData(
                new ItemModel
                {
                    Id = i,
                    Name = productNames[rnd.Next(productNames.Length)],
                    Description = $"Description for {productNames[rnd.Next(productNames.Length)]}",
                    Price = GetRandomPrice(),
                    InStock = GetRandomStock(),
                    Discount = null, // No discount
                    SerialNumber = GetRandomSerialNumber(),
                    

                });
        }
    }

    private string GetRandomSerialNumber()
    {
        Random rnd = new Random();
        return rnd.Next(100000, 999999).ToString();
    }
    // Generate random price for sample items
    private double GetRandomPrice()
    {
        Random rnd = new Random();
        return Math.Round(rnd.NextDouble() * 1000, 2); // Random price between 0 and 1000
    }

    // Generate random stock for sample items
    private int GetRandomStock()
    {
        Random rnd = new Random();
        return rnd.Next(1, 100); // Random stock between 1 and 100
    }
}