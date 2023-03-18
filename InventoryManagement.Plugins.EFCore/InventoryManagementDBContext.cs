using InventoryManagement.CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Plugins.EFCore
{
    public class InventoryManagementDBContext : DbContext
    {
        public InventoryManagementDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding data before connecting to real db
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory
                {
                    InventoryId = 500,
                    InventoryName = "Bahri",
                    Price = 2300,
                    Quantity = 100
                },
                new Inventory
                {
                    InventoryId = 21,
                    InventoryName = "Khartoum",
                    Price = 2000,
                    Quantity = 300
                },
                new Inventory
                {
                    InventoryId = 163,
                    InventoryName = "Omdurman",
                    Price = 5000,
                    Quantity = 30
                },
                new Inventory
                {
                    InventoryId = 360,
                    InventoryName = "Kalakla",
                    Price = 6300,
                    Quantity = 10
                }
                );
        }
    }
}