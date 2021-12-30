namespace TocoMilkTeaShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillID { get; set; }

        public DateTime? Time { get; set; }
        public DateTime? TimeDate 
        {
            get 
            {
                return Time.Value.Date;
            }
        }

        [StringLength(10)]
        public string CustomerPhoneNumber { get; set; }

        public short? BranchID { get; set; }

        public int? EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
