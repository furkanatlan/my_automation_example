using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace My_automation_example
{
    [Table("Table_Customer")]

    internal class Customer
    {
        [Key]
        public int Customer_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Customer_Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Customer_Surname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Customer_email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Customer_telephone { get; set; }

    }
}
