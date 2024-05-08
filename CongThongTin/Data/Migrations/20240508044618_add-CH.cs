using Microsoft.EntityFrameworkCore.Migrations;

namespace CongThongTin.Data.Migrations
{
    public partial class addCH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuahang",
                columns: table => new
                {
                    MaCH = table.Column<string>(maxLength: 50, nullable: false),
                    TenCH = table.Column<string>(maxLength: 150, nullable: true),
                    DiaChi = table.Column<string>(maxLength: 300, nullable: true),
                    IDmap = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuahang", x => x.MaCH);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuahang");
        }
    }
}
