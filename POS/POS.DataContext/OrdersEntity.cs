using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Repository
{
    [Table("tbl_orders")]
    public class OrdersEntity
    {
        [Key]
        [Column("order_id")]
        public int OrederId { get; set; }

        public CustomersEntity Customers { get; set; }

        public EmployeEntity Employes { get; set; }

        [Column("order_date")]
        public DateTime OrderDate { get; set; }

        [Column("required_date")]
        public DateTime RequireDate { get; set; }

        [Column("shipped_date")]
        public DateTime ShippedDate { get; set; }

        [Column("ship_via")]
        public int ShipVia { get; set; }

        [Column("freight")]
        public int Freight { get; set; }

        [Column("ship_name")]
        public string ShipName { get; set; }

        [Column("ship_adress")]
        public string ShipAddress { get; set; }

        [Column("ship_city")]
        public string ShipCity { get; set; }

        [Column("ship_region")]
        public string ShipRegion { get; set; }

        [Column("ship_postal_code")]
        public int ShipPostalCode { get; set;}

        [Column("ship_country")]
        public string ShipCountry { get; set; }

        public ICollection<OrderDetailEntity> orderDetails { get; set; }

    }
}
