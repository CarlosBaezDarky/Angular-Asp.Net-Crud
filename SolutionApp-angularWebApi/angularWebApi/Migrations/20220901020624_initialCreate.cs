using Microsoft.EntityFrameworkCore.Migrations;

namespace angularWebApi.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "paymentDetails",
                columns: table => new
                {
                    paymentDetail_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardOwerName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ExpirationDate = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    SecurityCode = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentDetails", x => x.paymentDetail_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "paymentDetails");
        }
    }
}
