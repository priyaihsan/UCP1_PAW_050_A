using Microsoft.EntityFrameworkCore.Migrations;

namespace TokoBuku.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "rakbuku",
                columns: table => new
                {
                    id_buku = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nama_buku = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    kategori_buku = table.Column<string>(type: "varchar(20)", nullable: true),
                    harga = table.Column<int>(type: "int", nullable: false),
                    gambar_buku = table.Column<string>(type: "varchar(120)", nullable: true),
                    penerbit_buku = table.Column<string>(type: "varchar(80)", nullable: true),
                    diskon = table.Column<string>(type: "varchar(10)", nullable: true),
                    jumlah_buku = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rakbuku", x => x.id_buku);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rakbuku");
        }
    }
}
