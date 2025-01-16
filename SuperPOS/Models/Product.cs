using System.ComponentModel.DataAnnotations.Schema;

namespace SuperPOS.Models
{
    internal class Product : BaseModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductCategoryId { get; set; }
        [ForeignKey(nameof(ProductCategoryId))]
        public virtual ProductCategory ProductCategory { get; set; }
        public decimal PurchasePrice { get; set; } = 0;
        public decimal SellingPrice { get; set; } = 0;
        public int Stock { get; set; } = 0 ;
    }
}
