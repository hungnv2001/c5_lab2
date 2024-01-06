using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab1.Migrations
{
    public partial class no1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Home_addr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Office_addr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblClient",
                columns: table => new
                {
                    clientName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    PhoName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblClient", x => x.clientName);
                    table.ForeignKey(
                        name: "FK_tblClient_tblAddress_AddressID",
                        column: x => x.AddressID,
                        principalTable: "tblAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblClient_AddressID",
                table: "tblClient",
                column: "AddressID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblClient");

            migrationBuilder.DropTable(
                name: "tblAddress");
        }
    }
}
