using InventoryManagement.CoreBusiness;

namespace InventoryManagement.UseCases.Interfaces
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}