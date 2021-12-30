namespace TocoMilkTeaShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Salary")]
    public partial class Salary
    {
        public int ID { get; set; }

        public int? EmployeeID { get; set; }

        public short? Mouth { get; set; }

        [StringLength(10)]
        public string WorkingTime { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
