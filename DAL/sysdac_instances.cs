namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sysdac_instances
    {
        public Guid? instance_id { get; set; }

        [Key]
        [Column(Order = 0)]
        public string instance_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public string type_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(64)]
        public string type_version { get; set; }

        [StringLength(4000)]
        public string description { get; set; }

        public byte[] type_stream { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime date_created { get; set; }

        [Key]
        [Column(Order = 4)]
        public string created_by { get; set; }

        [Key]
        [Column(Order = 5)]
        public string database_name { get; set; }
    }
}
