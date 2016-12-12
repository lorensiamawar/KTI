namespace KTI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tamu")]
    public partial class Tamu
    {
        [Key]
        public int Id_Tamu { get; set; }

        [DisplayName("Nama")]
        [Required]
        [StringLength(50)]
        public string Nama_Tamu { get; set; }

        [Required]
        [StringLength(100)]
        public string Alamat { get; set; }

        [DisplayName("No.Hp")]
        [Required]
        [StringLength(10)]
        public string No_Hp { get; set; }

        [DisplayName("Ucapan")]
        [Required]
        public string Ucapan_Selamat { get; set; }
    }
}
