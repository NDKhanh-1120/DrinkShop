namespace TocoMilkTeaShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportDetailBill")]
    public partial class ImportDetailBill
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ImportID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaterialID { get; set; }

        public int? Quatity { get; set; }
        public int? Price { get; set; }

        public virtual ImportBill ImportBill { get; set; }

        public virtual Material Material { get; set; }
    }
}
