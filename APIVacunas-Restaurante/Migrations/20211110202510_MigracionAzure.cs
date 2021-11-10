using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIVacunas_Restaurante.Migrations
{
    public partial class MigracionAzure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Carnet = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Carnet);
                });

            migrationBuilder.CreateTable(
                name: "Vacuna",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Carnet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaDeVacunacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCarnet = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacuna", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacuna_Usuario_UsuarioCarnet",
                        column: x => x.UsuarioCarnet,
                        principalTable: "Usuario",
                        principalColumn: "Carnet",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vacuna_UsuarioCarnet",
                table: "Vacuna",
                column: "UsuarioCarnet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vacuna");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
