namespace TocoMilkTeaShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Drawing;
    using System.IO;

    [Table("Menu")]
    public partial class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public int? Price { get; set; }
        [StringLength(50)]
        public string ImagePath { get; set; }
        public Image ProductImage
        {
            get
            {
                if (!string.IsNullOrEmpty(ImagePath) && File.Exists(ImagePath))
                {
                    return Image.FromFile(ImagePath);
                }
                else return null;
            }
        }
    }
}
