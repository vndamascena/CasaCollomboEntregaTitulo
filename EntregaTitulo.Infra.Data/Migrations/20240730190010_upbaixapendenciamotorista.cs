using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntregaTitulo.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class upbaixapendenciamotorista : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MOTORISTA",
                table: "PENDENCIAENTREGA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MOTORISTAATUAL",
                table: "PENDENCIAENTREGA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MOTORISTA",
                table: "BAIXAENTREGA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MOTORISTAATUAL",
                table: "BAIXAENTREGA",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MOTORISTA",
                table: "PENDENCIAENTREGA");

            migrationBuilder.DropColumn(
                name: "MOTORISTAATUAL",
                table: "PENDENCIAENTREGA");

            migrationBuilder.DropColumn(
                name: "MOTORISTA",
                table: "BAIXAENTREGA");

            migrationBuilder.DropColumn(
                name: "MOTORISTAATUAL",
                table: "BAIXAENTREGA");
        }
    }
}
