
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Repository
{
    [Table("tbl_product")]
    public class ProductEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("product_name")]
        public string ProductName { get; set; }

        public SupplierEntity Supplier { get; set; }

        public CategoryEntity Category { get; set; }

        [Column("quantity_per_unit")]
        public long QuantityPerUnit { get; set; }

        [Column("unit_price")]
        public double UnitPrice { get; set; }

        [Column("unit_in_stock")]
        public long UnitInStock { get; set; }

        [Column("unit_on_order")]
        public long UnitOnOrder { get; set; }

        [Column("reorder_level")]
        public long ReorderLevel { get; set; }

        [Column("discontinued")]
        public bool Discontinued { get; set; }

        public ICollection<OrderDetailEntity> orderDetailEntities { get; set; }

    }
}
