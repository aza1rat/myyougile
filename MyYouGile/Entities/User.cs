namespace MyYouGile.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Assignment = new HashSet<Assignment>();
            Perfomance = new HashSet<Perfomance>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserSurname { get; set; }

        [Required]
        [StringLength(50)]
        public string UserFirstname { get; set; }

        [Required]
        [StringLength(50)]
        public string UserPatronymic { get; set; }

        [Required]
        [StringLength(60)]
        public string UserLogin { get; set; }

        [Required]
        [StringLength(50)]
        public string UserPassword { get; set; }

        public int UserRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assignment> Assignment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Perfomance> Perfomance { get; set; }

        public virtual Role Role { get; set; }
    }
}
