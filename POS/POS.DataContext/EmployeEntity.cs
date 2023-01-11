using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    [Table("tbl_employe")]
    public class EmployeEntity
    {
        [Key]
        [Column("employe_id")]
        public int EmployeId { get; set; }

        [Column("last_name")]
        public String LastName { get; set; }

        [Column("first_name")]
        public String FirstName { get; set; }

        [Column("title")]
        public String Title { get; set; }

        [Column("title_of_courtesy")]
        public String TitleOfCourtesy { get; set; }

        [Column("birth_date")]
        public int BirthDate { get; set; }

        [Column("hire_date")]
        public int HireDate { get; set; }

        [Column("adress")]
        public String Adress { get; set; }

        [Column("city")]
        public String City { get; set; }

        [Column("region")]
        public String Region { get; set; }

        [Column("postal_code")]
        public String PostalCode { get; set; }

        [Column("country")]
        public String Country { get; set; }

        [Column("home_phone")]
        public int HomePhone { get; set; }

        [Column("extension")]
        public String Extension { get; set; }

        [Column("notes")]
        public String Notes { get; set; }

        [Column("reports_to")]
        public int Reports { get; set; }

        [Column("photo_path")]
        public string PhotoPath { get; set; }

        public ICollection<OrdersEntity> orderEntities { get; set; }
    }
}
