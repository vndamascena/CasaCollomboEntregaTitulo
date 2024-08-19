using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntregaTitulo.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class pendiasem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DIASEMANAPENDENCIA",
                table: "PENDENCIAENTREGA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PROXIMAENTREGA",
                table: "PENDENCIAENTREGA",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DIASEMANAPENDENCIA",
                table: "PENDENCIAENTREGA");

            migrationBuilder.DropColumn(
                name: "PROXIMAENTREGA",
                table: "PENDENCIAENTREGA");
        }
    }
}
