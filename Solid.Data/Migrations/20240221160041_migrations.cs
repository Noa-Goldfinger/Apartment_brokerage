using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SellsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyerId = table.Column<int>(type: "int", nullable: false),
                    Payment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellsList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellsList_ClientsList_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "ClientsList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentOwnersList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    SellId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentOwnersList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApartmentOwnersList_SellsList_SellId",
                        column: x => x.SellId,
                        principalTable: "SellsList",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApartmentsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumBuilding = table.Column<int>(type: "int", nullable: false),
                    NumApartment = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    apartmentOwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentsList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApartmentsList_ApartmentOwnersList_apartmentOwnerId",
                        column: x => x.apartmentOwnerId,
                        principalTable: "ApartmentOwnersList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentOwnersList_SellId",
                table: "ApartmentOwnersList",
                column: "SellId");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentsList_apartmentOwnerId",
                table: "ApartmentsList",
                column: "apartmentOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_SellsList_BuyerId",
                table: "SellsList",
                column: "BuyerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApartmentsList");

            migrationBuilder.DropTable(
                name: "ApartmentOwnersList");

            migrationBuilder.DropTable(
                name: "SellsList");

            migrationBuilder.DropTable(
                name: "ClientsList");
        }
    }
}
