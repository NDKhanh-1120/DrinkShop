namespace TocoMilkTeaShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CosumeDetail")]
    public partial class CosumeDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaterialID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CosumeID { get; set; }

        public int? Quatity { get; set; }

        public virtual CosumeBill CosumeBill { get; set; }

        public virtual Material Material { get; set; }
    }
}
