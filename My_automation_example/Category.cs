using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_automation_example
{
    [Table("Table_Category")]
    internal class Category
    {
        [Key]
        public int Category_Id { get; set; }

        [Required, MaxLength(50)]
        public string Category_Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

}
