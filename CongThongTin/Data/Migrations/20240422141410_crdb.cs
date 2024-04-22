using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CongThongTin.Data.Migrations
{
    public partial class crdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Number_Type",
                columns: table => new
                {
                    Number_TypeID = table.Column<string>(maxLength: 50, nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 150, nullable: true),
                    cost = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Number_Type", x => x.Number_TypeID);
                });

            migrationBuilder.CreateTable(
                name: "Package_Cate",
                columns: table => new
                {
                    Package_CateID = table.Column<string>(maxLength: 20, nullable: false),
                    Package_name = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package_Cate", x => x.Package_CateID);
                });

            migrationBuilder.CreateTable(
                name: "Post_cate",
                columns: table => new
                {
                    PostCateID = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_cate", x => x.PostCateID);
                });

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    Package_ID = table.Column<string>(maxLength: 50, nullable: false),
                    Package_title = table.Column<string>(maxLength: 100, nullable: true),
                    Package_CateID = table.Column<string>(maxLength: 20, nullable: true),
                    Package_content = table.Column<string>(nullable: true),
                    PostCateID = table.Column<string>(maxLength: 50, nullable: true),
                    cost = table.Column<string>(maxLength: 25, nullable: true),
                    link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Package_ID);
                    table.ForeignKey(
                        name: "FK_Package_Package_Cate_Package_CateID",
                        column: x => x.Package_CateID,
                        principalTable: "Package_Cate",
                        principalColumn: "Package_CateID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Package_Post_cate_PostCateID",
                        column: x => x.PostCateID,
                        principalTable: "Post_cate",
                        principalColumn: "PostCateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phone_number",
                columns: table => new
                {
                    Number = table.Column<string>(maxLength: 10, nullable: false),
                    Number_TypeID = table.Column<string>(maxLength: 50, nullable: true),
                    PostCateID = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 150, nullable: true),
                    link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone_number", x => x.Number);
                    table.ForeignKey(
                        name: "FK_Phone_number_Number_Type_Number_TypeID",
                        column: x => x.Number_TypeID,
                        principalTable: "Number_Type",
                        principalColumn: "Number_TypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phone_number_Post_cate_PostCateID",
                        column: x => x.PostCateID,
                        principalTable: "Post_cate",
                        principalColumn: "PostCateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostID = table.Column<string>(maxLength: 50, nullable: false),
                    PostCateID = table.Column<string>(maxLength: 50, nullable: true),
                    Post_title = table.Column<string>(maxLength: 250, nullable: true),
                    Post_content = table.Column<string>(nullable: true),
                    avatar = table.Column<string>(nullable: true),
                    Date_created = table.Column<DateTime>(nullable: false),
                    Date_update = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_Post_Post_cate_PostCateID",
                        column: x => x.PostCateID,
                        principalTable: "Post_cate",
                        principalColumn: "PostCateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Package_Package_CateID",
                table: "Package",
                column: "Package_CateID");

            migrationBuilder.CreateIndex(
                name: "IX_Package_PostCateID",
                table: "Package",
                column: "PostCateID");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_number_Number_TypeID",
                table: "Phone_number",
                column: "Number_TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_number_PostCateID",
                table: "Phone_number",
                column: "PostCateID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_PostCateID",
                table: "Post",
                column: "PostCateID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "Phone_number");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Package_Cate");

            migrationBuilder.DropTable(
                name: "Number_Type");

            migrationBuilder.DropTable(
                name: "Post_cate");
        }
    }
}
