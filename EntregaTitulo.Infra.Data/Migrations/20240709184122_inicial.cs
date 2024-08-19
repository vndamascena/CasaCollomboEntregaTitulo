using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntregaTitulo.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ENTREGA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NUMERONOTA = table.Column<int>(type: "int", nullable: false),
                    NOMECLIENTE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ATIVO = table.Column<bool>(type: "bit", nullable: false),
                    VALOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMAGEMURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OBSERVACAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USUARIOID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DIASEMANA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENTREGA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BAIXAENTREGA",
                columns: table => new
                {
                    IDBAIXAENTREGA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ENTREGAID = table.Column<int>(type: "int", nullable: false),
                    NUMERONOTA = table.Column<int>(type: "int", nullable: true),
                    NOMECLIENTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    VALORNOTA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URLIMAGEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIASEMANA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OBSERVACAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    USUARIOID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntregaId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BAIXAENTREGA", x => x.IDBAIXAENTREGA);
                    table.ForeignKey(
                        name: "FK_BAIXAENTREGA_ENTREGA_ENTREGAID",
                        column: x => x.ENTREGAID,
                        principalTable: "ENTREGA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BAIXAENTREGA_ENTREGA_EntregaId1",
                        column: x => x.EntregaId1,
                        principalTable: "ENTREGA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PENDENCIAENTREGA",
                columns: table => new
                {
                    IDPENDENCIA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ENTREGAID = table.Column<int>(type: "int", nullable: false),
                    NUMERONOTA = table.Column<int>(type: "int", nullable: true),
                    NOMECLIENTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    VALORNOTA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URLIMAGEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OBSERVACAO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OBSERVACAOPENDENCIA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USUARIOID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIASEMANA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntregaId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PENDENCIAENTREGA", x => x.IDPENDENCIA);
                    table.ForeignKey(
                        name: "FK_PENDENCIAENTREGA_ENTREGA_ENTREGAID",
                        column: x => x.ENTREGAID,
                        principalTable: "ENTREGA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PENDENCIAENTREGA_ENTREGA_EntregaId1",
                        column: x => x.EntregaId1,
                        principalTable: "ENTREGA",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BAIXAENTREGA_ENTREGAID",
                table: "BAIXAENTREGA",
                column: "ENTREGAID");

            migrationBuilder.CreateIndex(
                name: "IX_BAIXAENTREGA_EntregaId1",
                table: "BAIXAENTREGA",
                column: "EntregaId1");

            migrationBuilder.CreateIndex(
                name: "IX_PENDENCIAENTREGA_ENTREGAID",
                table: "PENDENCIAENTREGA",
                column: "ENTREGAID");

            migrationBuilder.CreateIndex(
                name: "IX_PENDENCIAENTREGA_EntregaId1",
                table: "PENDENCIAENTREGA",
                column: "EntregaId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BAIXAENTREGA");

            migrationBuilder.DropTable(
                name: "PENDENCIAENTREGA");

            migrationBuilder.DropTable(
                name: "ENTREGA");
        }
    }
}
