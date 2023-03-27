using InventoryManagement.CoreBusiness;

namespace InventoryManagement.UseCases.Interfaces
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}