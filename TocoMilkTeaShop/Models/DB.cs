using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TocoMilkTeaShop.Models
{
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CosumeBill> CosumeBills { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<HubMaterial> HubMaterials { get; set; }
        public virtual DbSet<ImportBill> ImportBills { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<CosumeDetail> CosumeDetails { get; set; }
        public virtual DbSet<HubDetail> HubDetails { get; set; }
        public virtual DbSet<ImportDetailBill> ImportDetailBills { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Passwords)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.CustomerPhoneNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CosumeBill>()
                .HasMany(e => e.CosumeDetails)
                .WithRequired(e => e.CosumeBill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HubMaterial>()
                .HasMany(e => e.HubDetails)
                .WithRequired(e => e.HubMaterial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ImportBill>()
                .HasMany(e => e.ImportDetailBills)
                .WithRequired(e => e.ImportBill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);



            modelBuilder.Entity<Material>()
                .HasMany(e => e.HubDetails)
                .WithRequired(e => e.Material)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Material>()
                .HasMany(e => e.ImportDetailBills)
                .WithRequired(e => e.Material)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Salary>()
                .Property(e => e.WorkingTime)
                .IsUnicode(false);
        }
    }
}
