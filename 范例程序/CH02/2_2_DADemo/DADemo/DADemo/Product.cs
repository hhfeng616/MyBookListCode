using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DADemo
{
    [Table("KProduct")]
    public class Product
    {
        [Key]      
        public int PId { get; set; }
        [Required]
        [Column("ProductName")]
        [MaxLength(
            50, 
            ErrorMessage = "ProductName 字段数据长度不得大于 50 "), 
            MinLength(2)]
        [Index("ProductNameIndex",2, IsUnique = true)]
        public string Name { get; set; }
        [Column("ListPrice", TypeName = "money")]
        public decimal Price { get; set; }

        [Index("CategoryIndex",1)]
        public int CategoryId { get; set; }        

        [NotMapped]
        public decimal SPrice { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; set; }

    }
}
