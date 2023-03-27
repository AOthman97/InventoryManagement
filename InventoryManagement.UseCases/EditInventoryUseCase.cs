using InventoryManagement.CoreBusiness;
using InventoryManagement.UseCases.Interfaces;
using InventoryManagement.UseCases.PluginInterfaces;

namespace InventoryManagement.UseCases
{
    public class EditInventoryUseCase : IEditInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public EditInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(Inventory inventory)
        {
            await inventoryRepository.UpdateInventoryAsync(inventory);
        }
    }
}