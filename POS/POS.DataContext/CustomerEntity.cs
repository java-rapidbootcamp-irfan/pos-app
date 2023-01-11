using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Repository
{
    [Table("tbl_cutomers")]
    public class CustomerEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("company_name")]
        public string CompanyName { get; set; }

        [Column("contact_name")]
        public String ContactName { get; set; }

        [Column("contact_title")]
        public string ContactTitle { get; set; }

        [Column("adress")]
        public string Address { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("region")]
        public string Region { get; set; }

        [Column("postal_code")]
        public string PostalCode { get; set; }

        [Column("country")]
        public string Country { get; set; }

        [Column("phone")]
        public int Phone { get; set; }

        [Column("fax")]
        public string Fax { get; set; }

        public ICollection<OrdersEntity> orderEntities { get; set; }
    }
}
