namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sys.bandwidth_usage")]
    public partial class bandwidth_usage
    {
        [Key]
        [Column(Order = 0)]
        public DateTime time { get; set; }

        [Key]
        [Column(Order = 1)]
        public string database_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string direction { get; set; }

        [Key]
        [Column("class", Order = 3)]
        [StringLength(50)]
        public string _class { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string time_period { get; set; }

        public decimal? quantity { get; set; }
    }
}
