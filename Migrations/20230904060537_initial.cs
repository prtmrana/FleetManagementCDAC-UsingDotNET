using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManagement_Backend.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Billings",
                columns: table => new
                {
                    BillingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerMobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAadharNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPassNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillAmount = table.Column<double>(type: "float", nullable: true),
                    FuelStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: true),
                    PickupHubId = table.Column<int>(type: "int", nullable: true),
                    DropHubId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billings", x => x.BillingId);
                    table.ForeignKey(
                        name: "FK_Billings_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "BookingId");
                    table.ForeignKey(
                        name: "FK_Billings_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId");
                    table.ForeignKey(
                        name: "FK_Billings_Hubs_DropHubId",
                        column: x => x.DropHubId,
                        principalTable: "Hubs",
                        principalColumn: "HubId");
                    table.ForeignKey(
                        name: "FK_Billings_Hubs_PickupHubId",
                        column: x => x.PickupHubId,
                        principalTable: "Hubs",
                        principalColumn: "HubId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Billings_BookingId",
                table: "Billings",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Billings_CarId",
                table: "Billings",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Billings_DropHubId",
                table: "Billings",
                column: "DropHubId");

            migrationBuilder.CreateIndex(
                name: "IX_Billings_PickupHubId",
                table: "Billings",
                column: "PickupHubId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Billings");
        }
    }
}
