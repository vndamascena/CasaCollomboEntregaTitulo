﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntregaTitulo.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class upoentregatabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VENDEDOR",
                table: "ENTREGA",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VENDEDOR",
                table: "ENTREGA");
        }
    }
}