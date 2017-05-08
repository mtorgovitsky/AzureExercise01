namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sys.database_usage")]
    public partial class database_usage
    {
        public DateTime? time { get; set; }

        [Key]
        [StringLength(50)]
        public string sku { get; set; }

        public decimal? quantity { get; set; }
    }
}
