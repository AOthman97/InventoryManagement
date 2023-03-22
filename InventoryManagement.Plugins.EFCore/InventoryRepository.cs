using InventoryManagement.CoreBusiness;
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

        // This method is inherited from the <IInventoryRepository> Interface that has this method
        public async Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
        {
            return await this.context.Inventories.Where(x => x.InventoryName.Contains(name) || 
                                                        string.IsNullOrWhiteSpace(name)).ToListAsync();
        }
    }
}