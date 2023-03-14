namespace MyYouGile.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Perfomance")]
    public partial class Perfomance
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StageID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        public int PerfomanceStatus { get; set; }

        public virtual Project Project { get; set; }

        public virtual Stage Stage { get; set; }

        public virtual Status Status { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual User User { get; set; }
    }
}
