namespace SaveChangesDemo.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "必须指定商品名称")]
        public string Name { get; set; }

        [Range(10, 500, ErrorMessage = "商品价格范围 10-500")]
        public int Price { get; set; }
        [Range(10, 500, ErrorMessage = "商品价格范围 10-500")]
        public int SPrice { get; set; }




        //[Required]
        //public string Name { get; set; }

        //[Range(10, 500)]
        //public int Price { get; set; }
        //[Range(10, 500)]
        //public int SPrice { get; set; }
    }
}
