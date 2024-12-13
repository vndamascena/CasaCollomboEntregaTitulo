using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntregaTitulo.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BAIXAETITULORECEBERFUNCIONARIO_TITULORECEBERFUNCIONARIO_ENTREGAID",
                table: "BAIXAETITULORECEBERFUNCIONARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_BAIXAETITULORECEBERFUNCIONARIO_TITULORECEBERFUNCIONARIO_TituloReceberFuncionarioId",
                table: "BAIXAETITULORECEBERFUNCIONARIO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BAIXAETITULORECEBERFUNCIONARIO",
                table: "BAIXAETITULORECEBERFUNCIONARIO");

            migrationBuilder.DropIndex(
                name: "IX_BAIXAETITULORECEBERFUNCIONARIO_ENTREGAID",
                table: "BAIXAETITULORECEBERFUNCIONARIO");

            migrationBuilder.RenameTable(
                name: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "BaixaTituloFuncionario");

            migrationBuilder.RenameColumn(
                name: "VENDEDOR",
                table: "BaixaTituloFuncionario",
                newName: "Vendedor");

            migrationBuilder.RenameColumn(
                name: "USUARIOID",
                table: "BaixaTituloFuncionario",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "OBSERVACAO",
                table: "BaixaTituloFuncionario",
                newName: "Observacao");

            migrationBuilder.RenameColumn(
                name: "NUMERONOTA",
                table: "BaixaTituloFuncionario",
                newName: "NumeroNota");

            migrationBuilder.RenameColumn(
                name: "NOMECLIENTE",
                table: "BaixaTituloFuncionario",
                newName: "NomeCliente");

            migrationBuilder.RenameColumn(
                name: "LOJA",
                table: "BaixaTituloFuncionario",
                newName: "Loja");

            migrationBuilder.RenameColumn(
                name: "DATAVENDA",
                table: "BaixaTituloFuncionario",
                newName: "DataVenda");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "BaixaTituloFuncionario",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VALORNOTA",
                table: "BaixaTituloFuncionario",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "URLIMAGEM",
                table: "BaixaTituloFuncionario",
                newName: "ImagemUrl");

            migrationBuilder.RenameColumn(
                name: "ENTREGAID",
                table: "BaixaTituloFuncionario",
                newName: "TituloId");

            migrationBuilder.RenameColumn(
                name: "DATAPREVPG",
                table: "BaixaTituloFuncionario",
                newName: "DataPrevistaPagamento");

            migrationBuilder.RenameColumn(
                name: "DATA",
                table: "BaixaTituloFuncionario",
                newName: "DataTime");

            migrationBuilder.RenameIndex(
                name: "IX_BAIXAETITULORECEBERFUNCIONARIO_TituloReceberFuncionarioId",
                table: "BaixaTituloFuncionario",
                newName: "IX_BaixaTituloFuncionario_TituloReceberFuncionarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaixaTituloFuncionario",
                table: "BaixaTituloFuncionario",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ESCALA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DATACADASTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IMAGEMURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESCALA", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BaixaTituloFuncionario_TITULORECEBERFUNCIONARIO_TituloReceberFuncionarioId",
                table: "BaixaTituloFuncionario",
                column: "TituloReceberFuncionarioId",
                principalTable: "TITULORECEBERFUNCIONARIO",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaixaTituloFuncionario_TITULORECEBERFUNCIONARIO_TituloReceberFuncionarioId",
                table: "BaixaTituloFuncionario");

            migrationBuilder.DropTable(
                name: "ESCALA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaixaTituloFuncionario",
                table: "BaixaTituloFuncionario");

            migrationBuilder.RenameTable(
                name: "BaixaTituloFuncionario",
                newName: "BAIXAETITULORECEBERFUNCIONARIO");

            migrationBuilder.RenameColumn(
                name: "Vendedor",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "VENDEDOR");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "USUARIOID");

            migrationBuilder.RenameColumn(
                name: "Observacao",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "OBSERVACAO");

            migrationBuilder.RenameColumn(
                name: "NumeroNota",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "NUMERONOTA");

            migrationBuilder.RenameColumn(
                name: "NomeCliente",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "NOMECLIENTE");

            migrationBuilder.RenameColumn(
                name: "Loja",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "LOJA");

            migrationBuilder.RenameColumn(
                name: "DataVenda",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "DATAVENDA");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "VALORNOTA");

            migrationBuilder.RenameColumn(
                name: "TituloId",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "ENTREGAID");

            migrationBuilder.RenameColumn(
                name: "ImagemUrl",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "URLIMAGEM");

            migrationBuilder.RenameColumn(
                name: "DataTime",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "DATA");

            migrationBuilder.RenameColumn(
                name: "DataPrevistaPagamento",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "DATAPREVPG");

            migrationBuilder.RenameIndex(
                name: "IX_BaixaTituloFuncionario_TituloReceberFuncionarioId",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                newName: "IX_BAIXAETITULORECEBERFUNCIONARIO_TituloReceberFuncionarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BAIXAETITULORECEBERFUNCIONARIO",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_BAIXAETITULORECEBERFUNCIONARIO_ENTREGAID",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                column: "ENTREGAID");

            migrationBuilder.AddForeignKey(
                name: "FK_BAIXAETITULORECEBERFUNCIONARIO_TITULORECEBERFUNCIONARIO_ENTREGAID",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                column: "ENTREGAID",
                principalTable: "TITULORECEBERFUNCIONARIO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BAIXAETITULORECEBERFUNCIONARIO_TITULORECEBERFUNCIONARIO_TituloReceberFuncionarioId",
                table: "BAIXAETITULORECEBERFUNCIONARIO",
                column: "TituloReceberFuncionarioId",
                principalTable: "TITULORECEBERFUNCIONARIO",
                principalColumn: "ID");
        }
    }
}
