using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_automation_example
{
    [Table("Table_Product")]
    internal class Product
    {
        [Key]
        public int Product_Id { get; set; }

        [Required, MaxLength(50)]
        public string Product_Name { get; set; }

        [Required]
        public decimal Product_Price { get; set; }

        [ForeignKey("Category")]
        public int Category_Id { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<CustomerProduct> CustomerProducts { get; set; }
    }

}
