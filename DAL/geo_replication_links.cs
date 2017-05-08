namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sys.geo_replication_links")]
    public partial class geo_replication_links
    {
        public int? database_id { get; set; }

        public DateTimeOffset? start_date { get; set; }

        public DateTimeOffset? modify_date { get; set; }

        [Key]
        public Guid link_guid { get; set; }

        [StringLength(128)]
        public string partner_server { get; set; }

        [StringLength(128)]
        public string partner_database { get; set; }

        public byte? replication_state { get; set; }

        [StringLength(256)]
        public string replication_state_desc { get; set; }

        public byte? role { get; set; }

        [StringLength(256)]
        public string role_desc { get; set; }

        public byte? secondary_allow_connections { get; set; }

        [StringLength(256)]
        public string secondary_allow_connections_desc { get; set; }
    }
}
