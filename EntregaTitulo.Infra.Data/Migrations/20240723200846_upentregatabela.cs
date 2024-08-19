using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntregaTitulo.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class upentregatabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PERIODO",
                table: "ENTREGA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PERIODO",
                table: "ENTREGA");
        }
    }
}
