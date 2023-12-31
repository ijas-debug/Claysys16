using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Image_App.Models
{
    public partial class DBmodel : DbContext
    {
        public DBmodel()
            : base("name=DBmodel")
        {
        }

        public virtual DbSet<tb1_Image> tb1_Image { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tb1_Image>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tb1_Image>()
                .Property(e => e.Image)
                .IsUnicode(false);
        }
    }
}
