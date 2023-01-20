using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Repository
{
    [Table("tbl_orders")]
    public class OrdersEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("customer_id")]
        public int CustomersId { get; set; }

        [Required]
        public CustomersEntity Customers { get; set; }

        [Column("employe_id")]
        public int EmployeId { get; set; }

        [Required]
        public EmployeEntity Employe { get; set; }

        [Required]
        [Column("order_date")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Column("required_date")]
        public DateTime RequiredDate { get; set; }

        [Required]
        [Column("shipped_date")]
        public DateTime ShippedDate { get; set; }

        [Required]
        [Column("ship_via")]
        public int ShipVia { get; set; }

        [Required]
        [Column("freight")]
        public int Freight { get; set; }

        [Required]
        [Column("ship_name")]
        public string ShipName { get; set; }

        [Required]
        [Column("ship_address")]
        public string ShipAddress { get; set; }

        [Required]
        [Column("ship_city")]
        public string ShipCity { get; set; }

        [Required]
        [Column("ship_region")]
        public string ShipRegion { get; set; }

        [Required]
        [Column("ship_postal_code")]
        public string ShipPostalCode { get; set; }

        [Required]
        [Column("ship_country")]
        public string ShipCountry { get; set; }

        public List<OrderDetailEntity> OrderDetails { get; set; }

      /*
        public OrdersEntity(POS.ViewModel.OrdersModel model)
        {
            CustomersId = model.CustomersId;
            EmployeId= model.EmployeId;
            OrderDate= model.OrderDate;
            RequiredDate= model.RequiredDate;
            ShippedDate= model.ShippedDate;
            ShipVia = model.ShipVia;
            Freight = model.Freight;
            ShipName = model.ShipName;
            ShipAddress = model.ShipAddress;
            ShipCity = model.ShipCity;
            ShipRegion = model.ShipRegion;
            ShipPostalCode = model.ShipPostalCode;
            ShipCountry = model.ShipCountry;

        }
      */

        public OrdersEntity()
        {

        }

    }
}