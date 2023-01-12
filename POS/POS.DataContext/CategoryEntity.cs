using POS.Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.DataContext
{
        [Table("tbl_category")]
        public class CategoryEntity
    {
        [Key]

        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("category_name")]
        public String CategoryName { get; set; }

        [Required]
        [Column("description")]
        public String Description { get; set; }

        public ICollection<ProductEntity> products { get; set; }
        public CategoryEntity(POS.ViewModel.CategoryModel model)
        {
            CategoryName = model.CategoryName;
            Description = model.Description;
        }

        public CategoryEntity() 
        {
            
        }
    }
}