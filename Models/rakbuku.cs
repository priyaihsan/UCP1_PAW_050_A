using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TokoBuku.Models
{
    public class rakbuku
    {
        //ID Buku
        [Key]
        public int id_buku { get; set; }
        //Nama Buku
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Nama Buku")]
        public string nama_buku { get; set; }
        //Kategori Buku
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Kategori Buku")]
        public string kategori_buku { get; set; }
        //Harga
        [Column(TypeName = "int")]
        [DisplayName("Harga")]
        public int harga { get; set; }
        //Gambar Buku
        [Column(TypeName = "varchar(120)")]
        [DisplayName("Gambar Buku")]
        public string gambar_buku { get; set; }
        //Penerbit Buku
        [Column(TypeName = "varchar(80)")]
        [DisplayName("Penerbit Buku")]
        public string penerbit_buku { get; set; }
        //Diskon
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Diskon")]
        public string diskon { get; set; }
        //Jumlah Buku
        [Column(TypeName = "int")]
        [DisplayName("Jumlah Buku")]
        public int jumlah_buku { get; set; }
    }
}