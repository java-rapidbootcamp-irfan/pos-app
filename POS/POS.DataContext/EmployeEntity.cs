using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Repository
{
    [Table("tbl_employe")]
    public class EmployeEntity
    {
        [Key]
        [Column("employe_id")]
        public int EmployeId { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("title_of_courtesy")]
        public string TitleOfCourtesy { get; set; }

        [Column("birth_date")]
        public DateTime BirthDate { get; set; }

        [Column("hire_date")]
        public DateTime HireDate { get; set; }

        [Column("adress")]
        public string Adress { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("region")]
        public string Region { get; set; }

        [Column("postal_code")]
        public string PostalCode { get; set; }

        [Column("country")]
        public string Country { get; set; }

        [Column("home_phone")]
        public int HomePhone { get; set; }

        [Column("extension")]
        public string Extension { get; set; }

        [Column("notes")]
        public string Notes { get; set; }

        [Column("reports_to")]
        public string Reports { get; set; }

        [Column("photo_path")]
        public string PhotoPath { get; set; }

        public ICollection<OrdersEntity> orderEntities { get; set; }
    }
}
