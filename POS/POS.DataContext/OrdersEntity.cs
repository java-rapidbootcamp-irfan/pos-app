using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    [Table("tbl_orders")]
    public class OrdersEntity
    {
        [Key]
        [Column("order_id")]
        public int OrederId { get; set; }

        [Column("employe_id")]
        public int EmployeId { get; set; }

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
        public String ShipName { get; set; }

        [Column("ship_adress")]
        public String ShipAddress { get; set; }

        [Column("ship_city")]
        public String ShipCity { get; set; }

        [Column("ship_region")]
        public String ShipRegion { get; set; }

        [Column("ship_postal_code")]
        public String ShipPostalCode { get; set;}

        [Column("ship_country")]
        public String ShipCountry { get; set; }

    }
}
