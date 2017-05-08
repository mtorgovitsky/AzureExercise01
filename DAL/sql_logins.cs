namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sys.sql_logins")]
    public partial class sql_logins
    {
        [StringLength(128)]
        public string name { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int principal_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [MaxLength(85)]
        public byte[] sid { get; set; }

        [StringLength(1)]
        public string type { get; set; }

        [StringLength(60)]
        public string type_desc { get; set; }

        public bool? is_disabled { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime create_date { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime modify_date { get; set; }

        [StringLength(128)]
        public string default_database_name { get; set; }

        [StringLength(128)]
        public string default_language_name { get; set; }

        public int? credential_id { get; set; }

        public bool? is_policy_checked { get; set; }

        public bool? is_expiration_checked { get; set; }

        [Key]
        [Column(Order = 4)]
        [MaxLength(512)]
        public byte[] password_hash { get; set; }
    }
}
