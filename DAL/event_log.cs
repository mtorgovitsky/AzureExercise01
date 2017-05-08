namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sys.event_log")]
    public partial class event_log
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
        [StringLength(64)]
        public string event_category { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(64)]
        public string event_type { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int event_subtype { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(64)]
        public string event_subtype_desc { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int severity { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int event_count { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(64)]
        public string description { get; set; }

        [Column(TypeName = "xml")]
        public string additional_data { get; set; }
    }
}
