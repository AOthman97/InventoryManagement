using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        [Required(ErrorMessage = "Inventory Name is Required!")]
        public string InventoryName { get; set; } = string.Empty;
        [Range(0, int.MaxValue, ErrorMessage = "Qty must be greater than or equal to 0")]
        public int Quantity { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than or equal to 0")]
        public decimal Price { get; set; }
    }
}