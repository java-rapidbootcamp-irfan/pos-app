using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.ViewModel
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public int SupplierId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public long QuantityPerUnit { get; set; }

        [Required]
        public double UnitPrice { get; set; }

        [Required]
        public long UnitInStock { get; set; }

        [Required]
        public long UnitOnOrder { get; set; }

        [Required]
        public long ReorderLevel { get; set; }

        [Required]
        public string Discontinued { get; set; }
    }
}