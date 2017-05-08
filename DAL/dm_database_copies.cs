namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sys.dm_database_copies")]
    public partial class dm_database_copies
    {
        public int? database_id { get; set; }

        public DateTimeOffset? start_date { get; set; }

        public DateTimeOffset? modify_date { get; set; }

        public float? percent_complete { get; set; }

        public int? error_code { get; set; }

        [StringLength(2048)]
        public string error_desc { get; set; }

        public int? error_severity { get; set; }

        public int? error_state { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid copy_guid { get; set; }

        [StringLength(128)]
        public string partner_server { get; set; }

        [StringLength(128)]
        public string partner_database { get; set; }

        public byte? replication_state { get; set; }

        [StringLength(256)]
        public string replication_state_desc { get; set; }

        public int? maximum_lag { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool is_continuous_copy { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool is_target_role { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool is_offline_secondary { get; set; }

        public bool? is_interlink_connected { get; set; }
    }
}
