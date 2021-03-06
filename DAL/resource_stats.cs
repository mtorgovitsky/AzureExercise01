namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sys.resource_stats")]
    public partial class resource_stats
    {
        [Key]
        [Column(Order = 0, TypeName = "datetime2")]
        public DateTime start_time { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "datetime2")]
        public DateTime end_time { get; set; }

        [Key]
        [Column(Order = 2)]
        public string database_name { get; set; }

        [Key]
        [Column(Order = 3)]
        public string sku { get; set; }

        public double? storage_in_megabytes { get; set; }

        public decimal? avg_cpu_percent { get; set; }

        public decimal? avg_data_io_percent { get; set; }

        public decimal? avg_log_write_percent { get; set; }

        public decimal? max_worker_percent { get; set; }

        public decimal? max_session_percent { get; set; }

        public int? dtu_limit { get; set; }

        public decimal? xtp_storage_percent { get; set; }
    }
}
