using InventoryManagement.CoreBusiness;

namespace InventoryManagement.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task AddInventoryAsync(Inventory inventory);
        Task<IEnumerable<Inventory>> GetInventoriesByName(string name);
        Task UpdateInventoryAsync(Inventory inventory);
    }
}