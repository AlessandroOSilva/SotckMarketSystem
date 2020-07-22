using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace MarketStockSystem.Migrations
{
    public partial class newMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CodAtivo = table.Column<string>(maxLength: 6, nullable: true),
                    CotacaoAtual = table.Column<double>(nullable: false),
                    Empresa = table.Column<string>(maxLength: 100, nullable: false),
                    Segmento = table.Column<int>(maxLength: 100, nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    LucroAnoAnt = table.Column<double>(nullable: false),
                    QuantAcoes = table.Column<int>(nullable: false),
                    DividaLiquida = table.Column<double>(nullable: false),
                    PatrimonioLiquido = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acoes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acoes");
        }
    }
}
