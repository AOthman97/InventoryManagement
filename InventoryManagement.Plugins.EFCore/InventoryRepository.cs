﻿using InventoryManagement.CoreBusiness;
using InventoryManagement.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Plugins.EFCore
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly InventoryManagementDBContext context;

        public InventoryRepository(InventoryManagementDBContext context)
        {
            this.context = context;
        }

        public async Task AddInventoryAsync(Inventory inventory)
        {
            context.Inventories.Add(inventory);
            await context.SaveChangesAsync();
        }

        // This method is inherited from the <IInventoryRepository> Interface that has this method
        public async Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
        {
            return await context.Inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase) || 
                                                        string.IsNullOrWhiteSpace(name)).ToListAsync();
        }

        public async Task<Inventory?> GetInventoryByIdAsync(int id)
        {
            return await context.Inventories.FindAsync(id);
        }

        public async Task UpdateInventoryAsync(Inventory inventory)
        {
            var inv = await context.Inventories.FindAsync(inventory.InventoryId);
            if(inv != null)
            {
                inv.InventoryName = inventory.InventoryName;
                inv.Quantity = inventory.Quantity;
                inv.Price = inventory.Price;

                await context.SaveChangesAsync();
            }
        }
    }
}