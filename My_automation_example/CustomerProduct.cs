using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_automation_example
{
    [Table("Table_CustomerProduct")]
    internal class CustomerProduct
    {
        [Key]
        public int CusPro_Id { get; set; }

        [ForeignKey("Customer")]
        public int Customer_Id { get; set; }

        [ForeignKey("Product")]
        public int Product_Id { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }

}
