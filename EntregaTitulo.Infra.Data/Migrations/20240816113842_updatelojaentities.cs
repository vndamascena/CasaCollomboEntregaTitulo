using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntregaTitulo.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatelojaentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LOJA",
                table: "PENDENCIAENTREGA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LOJA",
                table: "ENTREGA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LOJA",
                table: "BAIXAENTREGA",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LOJA",
                table: "PENDENCIAENTREGA");

            migrationBuilder.DropColumn(
                name: "LOJA",
                table: "ENTREGA");

            migrationBuilder.DropColumn(
                name: "LOJA",
                table: "BAIXAENTREGA");
        }
    }
}
