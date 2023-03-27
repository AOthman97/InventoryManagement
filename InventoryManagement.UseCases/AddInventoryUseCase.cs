using InventoryManagement.CoreBusiness;
using InventoryManagement.UseCases.Interfaces;
using InventoryManagement.UseCases.PluginInterfaces;

namespace InventoryManagement.UseCases
{
    public class AddInventoryUseCase : IAddInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public AddInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(Inventory inventory)
        {
            await inventoryRepository.AddInventoryAsync(inventory);
        }
    }
}