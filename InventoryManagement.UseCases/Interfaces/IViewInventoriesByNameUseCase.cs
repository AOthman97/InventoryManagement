using InventoryManagement.CoreBusiness;

namespace InventoryManagement.UseCases.Interfaces
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}