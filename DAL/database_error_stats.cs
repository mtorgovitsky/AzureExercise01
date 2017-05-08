namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sys.database_error_stats")]
    public partial class database_error_stats
    {
        [Key]
        [Column(Order = 0)]
        public string database_name { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "datetime2")]
        public DateTime start_time { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "datetime2")]
        public DateTime end_time { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int error_number { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int error_count { get; set; }
    }
}
