namespace MyYouGile.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stage")]
    public partial class Stage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stage()
        {
            Perfomance = new HashSet<Perfomance>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StageID { get; set; }

        [Required]
        [StringLength(50)]
        public string StageName { get; set; }

        [Column(TypeName = "date")]
        public DateTime StageStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime StageEnd { get; set; }

        public bool StageStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Perfomance> Perfomance { get; set; }
    }
}
