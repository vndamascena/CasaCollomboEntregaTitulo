using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntregaTitulo.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class newtabimp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IMPRESSAO",
                columns: table => new
                {
                    IDIMPRESSAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ENTREGAID = table.Column<int>(type: "int", nullable: false),
                    USUARIOID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntregaId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMPRESSAO", x => x.IDIMPRESSAO);
                    table.ForeignKey(
                        name: "FK_IMPRESSAO_ENTREGA_ENTREGAID",
                        column: x => x.ENTREGAID,
                        principalTable: "ENTREGA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IMPRESSAO_ENTREGA_EntregaId1",
                        column: x => x.EntregaId1,
                        principalTable: "ENTREGA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IMPRESSAO_ENTREGAID",
                table: "IMPRESSAO",
                column: "ENTREGAID");

            migrationBuilder.CreateIndex(
                name: "IX_IMPRESSAO_EntregaId1",
                table: "IMPRESSAO",
                column: "EntregaId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IMPRESSAO");
        }
    }
}
