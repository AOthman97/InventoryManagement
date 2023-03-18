using InventoryManagement.CoreBusiness;
using InventoryManagement.UseCases.PluginInterfaces;

namespace InventoryManagement.Plugins.EFCore
{
    public class InventoryRepository : IInventoryRepository
    {
        // This method is inherited from the <IInventoryRepository> Interface that has this method
        public Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}