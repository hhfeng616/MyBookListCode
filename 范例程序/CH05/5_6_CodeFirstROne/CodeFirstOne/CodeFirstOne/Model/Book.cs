namespace CodeFirstOne.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Pages { get; set; }

        public string ISBN { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public virtual Product Product { get; set; }
    }
}
