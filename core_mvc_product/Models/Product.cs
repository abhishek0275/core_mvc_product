using System.ComponentModel.DataAnnotations.Schema;

namespace core_mvc_product.Models
{
    [Table("Product")]
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductCode { get; set; } = string.Empty;

        public string ProductName { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public decimal CostPrice { get; set; }

        public int Quantity { get; set; }

        public string Unit { get; set; } = "PCS";

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
