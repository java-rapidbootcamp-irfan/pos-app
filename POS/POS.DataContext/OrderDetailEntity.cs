using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Repository
{
    [Table("tbl_order_detail")]
    public class OrderDetailEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("order_id")]
        public OrdersEntity Orders { get; set; }

        [Column("product_id")]
        public ProductEntity Product { get; set; }

        [Column("unit_price")]
        public int UnitPrice { get; set; }

        [Column("quantity")]
        public long Quantity { get; set; }

        [Column("discount")]
        public Double Discount { get; set; }

    }
}
