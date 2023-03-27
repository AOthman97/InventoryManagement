using InventoryManagement.CoreBusiness;

namespace InventoryManagement.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task AddInventoryAsync(Inventory inventory);
        Task<IEnumerable<Inventory>> GetInventoriesByName(string name);
        Task<Inventory?> GetInventoryByIdAsync(int id);
        Task UpdateInventoryAsync(Inventory inventory);
    }
}