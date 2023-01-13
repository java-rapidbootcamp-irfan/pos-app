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
        [Required]
        [Column("company_name")]
        public string CompanyName { get; set; }
        [Required]
        [Column("contact_name")]
        public string ContactName { get; set; }
        [Required]
        [Column("contact_title")]
        public string ContactTitle { get; set; }
        [Required]
        [Column("adress")]
        public string Address { get; set; }
        [Required]
        [Column("city")]
        public string City { get; set; }
        [Required]
        [Column("region")]
        public string Region { get; set; }
        [Required]
        [Column("postal_code")]
        public string PostalCode { get; set; }
        [Required]
        [Column("country")]
        public string Country { get; set; }
        [Required]
        [Column("phone")]
        public int Phone { get; set; }
        [Required]
        [Column("fax")]
        public string Fax { get; set; }

        public ICollection<OrdersEntity> orders { get; set; }
        public CustomerEntity(POS.ViewModel.CustomerModel model) 
        {
            CompanyName = model.CompanyName;
            CompanyName= model.CompanyName; 
            ContactTitle= model.ContactTitle;   
            Address = model.Address;    
            City = model.City;  
            Region = model.Region;  
            PostalCode = model.PostalCode;  
            Country = model.Country;    
            Phone = model.Phone;    
            Fax = model.Fax;    

        }

        public CustomerEntity() 
        {
        }
    }
}
