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
        public int OrdersId { get; set; }

        [Required]
        public OrdersEntity Orders { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Required]
        public ProductEntity Product { get; set; }

        [Required]
        [Column("unit_price")]
        public double UnitPrice { get; set; }

        [Required]
        [Column("quantity")]
        public int Quantity { get; set; }

        [Required]
        [Column("discount")]
        public double Discount { get; set; }

        public OrderDetailEntity(POS.ViewModel.OrderDetailModel model)
        {
            OrdersId = model.OrdersId;
            ProductId = model.ProductId;
            UnitPrice= model.UnitPrice;
            Quantity = model.Quantity;
            Discount = model.Discount;

        }

        public OrderDetailEntity()
        {

        }
    }
}