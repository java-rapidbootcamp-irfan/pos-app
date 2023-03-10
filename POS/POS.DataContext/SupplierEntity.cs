using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Repository
{
    [Table("tbl_supplier")]
    public class SupplierEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("company_name")]
        public string CompanyName { get; set; }
        [Column("contact_name")]
        public string ContactName { get; set; }
        [Column("contact_title")]
        public string ContactTitle { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("region")]
        public string Region { get; set; }
        [Column("postal_code")]
        public int PostalCode { get; set; }
        [Column("country")]
        public string Country { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("fax")]
        public string Fax { get; set; }
        [Column("home_page")]
        public string HomePage { get; set; }

        public ICollection<ProductEntity> products { get; set; }
        public SupplierEntity()
        {

        }


        public SupplierEntity(POS.ViewModel.SupplierModel model)
        {
            CompanyName = model.CompanyName;
            ContactName = model.ContactName;
            ContactTitle = model.ContactTitle;
            Address = model.Address;
            City = model.City;
            Region = model.Region;
            PostalCode = model.PostalCode;
            Country = model.Country;
            Phone = model.Phone;
            Fax = model.Fax;
            HomePage = model.HomePage;
        }
        
    }
}