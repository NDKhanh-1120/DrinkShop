namespace TocoMilkTeaShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CosumeBill")]
    public partial class CosumeBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CosumeBill()
        {
            CosumeDetails = new HashSet<CosumeDetail>();
        }

        [Key]
        public int CosumeID { get; set; }

        public double? QuatityCosume { get; set; }

        public DateTime? Times { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CosumeDetail> CosumeDetails { get; set; }
    }
}
