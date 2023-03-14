namespace MyYouGile.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Project")]
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            Assignment = new HashSet<Assignment>();
            Perfomance = new HashSet<Perfomance>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectID { get; set; }

        [Required]
        [StringLength(150)]
        public string ProjectName { get; set; }

        [Required]
        [StringLength(500)]
        public string ProjectDescription { get; set; }

        public decimal ProjectPrice { get; set; }

        [Column(TypeName = "image")]
        public byte[] ProjectImage { get; set; }

        public int ProjectCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assignment> Assignment { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Perfomance> Perfomance { get; set; }
    }
}
