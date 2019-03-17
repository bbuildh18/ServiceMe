using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class inventory_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Item",
                newName: "ItemID");

            migrationBuilder.AddColumn<bool>(
                name: "IsSerialized",
                table: "Item",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "UnitPrice",
                table: "Item",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustID);
                });

            migrationBuilder.CreateTable(
                name: "CustReceiptDetails",
                columns: table => new
                {
                    CustReceiptDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustReceiptDetails", x => x.CustReceiptDetailID);
                });

            migrationBuilder.CreateTable(
                name: "GrnHeads",
                columns: table => new
                {
                    GrnHeadID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrnHeads", x => x.GrnHeadID);
                });

            migrationBuilder.CreateTable(
                name: "ItemFacInvs",
                columns: table => new
                {
                    ItemFacInvID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemFacID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemFacInvs", x => x.ItemFacInvID);
                });

            migrationBuilder.CreateTable(
                name: "ItemFacs",
                columns: table => new
                {
                    ItemFacID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemID = table.Column<int>(nullable: false),
                    Qty = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemFacs", x => x.ItemFacID);
                });

            migrationBuilder.CreateTable(
                name: "MiscExpencesDetails",
                columns: table => new
                {
                    MiscExpencesDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiscExpencesDetails", x => x.MiscExpencesDetailID);
                });

            migrationBuilder.CreateTable(
                name: "MiscExpencesHeads",
                columns: table => new
                {
                    MiscExpencesHeadID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiscExpencesHeads", x => x.MiscExpencesHeadID);
                });

            migrationBuilder.CreateTable(
                name: "MiscIncomeDetails",
                columns: table => new
                {
                    MiscIncomeDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiscIncomeDetails", x => x.MiscIncomeDetailID);
                });

            migrationBuilder.CreateTable(
                name: "MiscIncomeHeads",
                columns: table => new
                {
                    MiscIncomeHeadID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiscIncomeHeads", x => x.MiscIncomeHeadID);
                });

            migrationBuilder.CreateTable(
                name: "SrnDetails",
                columns: table => new
                {
                    SrnDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SrnDetails", x => x.SrnDetailID);
                });

            migrationBuilder.CreateTable(
                name: "SrnHeads",
                columns: table => new
                {
                    SrnHeadID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SrnHeads", x => x.SrnHeadID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "CustReceiptHeads",
                columns: table => new
                {
                    CustReceiptHeadID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustReceiptHeads", x => x.CustReceiptHeadID);
                    table.ForeignKey(
                        name: "FK_CustReceiptHeads_Customers_CustID",
                        column: x => x.CustID,
                        principalTable: "Customers",
                        principalColumn: "CustID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GrnDetails",
                columns: table => new
                {
                    GRNDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GrnHeadID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrnDetails", x => x.GRNDetailID);
                    table.ForeignKey(
                        name: "FK_GrnDetails_GrnHeads_GrnHeadID",
                        column: x => x.GrnHeadID,
                        principalTable: "GrnHeads",
                        principalColumn: "GrnHeadID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustReceiptHeads_CustID",
                table: "CustReceiptHeads",
                column: "CustID");

            migrationBuilder.CreateIndex(
                name: "IX_GrnDetails_GrnHeadID",
                table: "GrnDetails",
                column: "GrnHeadID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustReceiptDetails");

            migrationBuilder.DropTable(
                name: "CustReceiptHeads");

            migrationBuilder.DropTable(
                name: "GrnDetails");

            migrationBuilder.DropTable(
                name: "ItemFacInvs");

            migrationBuilder.DropTable(
                name: "ItemFacs");

            migrationBuilder.DropTable(
                name: "MiscExpencesDetails");

            migrationBuilder.DropTable(
                name: "MiscExpencesHeads");

            migrationBuilder.DropTable(
                name: "MiscIncomeDetails");

            migrationBuilder.DropTable(
                name: "MiscIncomeHeads");

            migrationBuilder.DropTable(
                name: "SrnDetails");

            migrationBuilder.DropTable(
                name: "SrnHeads");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "GrnHeads");

            migrationBuilder.DropColumn(
                name: "IsSerialized",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "ItemID",
                table: "Item",
                newName: "ItemId");
        }
    }
}
