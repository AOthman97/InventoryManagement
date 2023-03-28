using InventoryManagement.CoreBusiness;

namespace InventoryManagement.UseCases.Interfaces
{
    public interface IViewInventoryByIdUseCase
    {
        Task<Inventory?> ExecuteAsync(int Id);
    }
}