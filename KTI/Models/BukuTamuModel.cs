namespace KTI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BukuTamuModel : DbContext
    {
        public BukuTamuModel()
            : base("name=BukuTamuModels")
        {
        }

        public virtual DbSet<Tamu> Tamus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tamu>()
                .Property(e => e.Nama_Tamu)
                .IsUnicode(false);

            modelBuilder.Entity<Tamu>()
                .Property(e => e.Alamat)
                .IsUnicode(false);

            modelBuilder.Entity<Tamu>()
                .Property(e => e.No_Hp)
                .IsUnicode(false);

            modelBuilder.Entity<Tamu>()
                .Property(e => e.Ucapan_Selamat)
                .IsUnicode(false);
        }
    }
}
