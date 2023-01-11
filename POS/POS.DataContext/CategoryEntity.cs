using POS.Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.DataContext
{
        [Table("tbl_category")]
        public class CategoryEntity
    {
        [Key]

        [Column("id")]
        public int Id { get; set; }

        [Column("category_name")]
        public String CategoryName { get; set; }

        [Column("description")]
        public String Description { get; set; }

        public ICollection<ProductEntity> productEntities { get; set; }

    }
}