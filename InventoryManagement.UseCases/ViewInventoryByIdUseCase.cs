using InventoryManagement.CoreBusiness;
using InventoryManagement.UseCases.PluginInterfaces;

namespace InventoryManagement.UseCases
{
    public class ViewInventoryByIdUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoryByIdUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<Inventory?> ExecuteAsync(int Id)
        {
            return await inventoryRepository.GetInventoryByIdAsync(Id);
        }
    }
}