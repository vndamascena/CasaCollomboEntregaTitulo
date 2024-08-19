using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntregaTitulo.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class tabepebaup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DataEntrega",
                table: "PENDENCIAENTREGA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PERIODO",
                table: "PENDENCIAENTREGA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VENDEDOR",
                table: "PENDENCIAENTREGA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataEntrega",
                table: "BAIXAENTREGA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PERIODO",
                table: "BAIXAENTREGA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VENDEDOR",
                table: "BAIXAENTREGA",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataEntrega",
                table: "PENDENCIAENTREGA");

            migrationBuilder.DropColumn(
                name: "PERIODO",
                table: "PENDENCIAENTREGA");

            migrationBuilder.DropColumn(
                name: "VENDEDOR",
                table: "PENDENCIAENTREGA");

            migrationBuilder.DropColumn(
                name: "DataEntrega",
                table: "BAIXAENTREGA");

            migrationBuilder.DropColumn(
                name: "PERIODO",
                table: "BAIXAENTREGA");

            migrationBuilder.DropColumn(
                name: "VENDEDOR",
                table: "BAIXAENTREGA");
        }
    }
}
