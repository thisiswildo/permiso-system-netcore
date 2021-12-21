using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PermisoSystem.Api.Migrations
{
    public partial class _20211220_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoPermiso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPermiso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(nullable: true),
                    ApellidosEmpleado = table.Column<string>(nullable: true),
                    TipoPermisoId = table.Column<int>(nullable: false),
                    FechaPermiso = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permiso_TipoPermiso_TipoPermisoId",
                        column: x => x.TipoPermisoId,
                        principalTable: "TipoPermiso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TipoPermiso",
                columns: new[] { "Id", "Descripcion" },
                values: new object[] { 1, "Enfermedad" });

            migrationBuilder.InsertData(
                table: "TipoPermiso",
                columns: new[] { "Id", "Descripcion" },
                values: new object[] { 2, "Diligencias" });

            migrationBuilder.InsertData(
                table: "TipoPermiso",
                columns: new[] { "Id", "Descripcion" },
                values: new object[] { 3, "Otros" });

            migrationBuilder.InsertData(
                table: "Permiso",
                columns: new[] { "Id", "ApellidosEmpleado", "FechaPermiso", "NombreEmpleado", "TipoPermisoId" },
                values: new object[] { 1, "Ruiz", new DateTime(2021, 12, 20, 14, 13, 55, 577, DateTimeKind.Local).AddTicks(6239), "Wildo", 1 });

            migrationBuilder.InsertData(
                table: "Permiso",
                columns: new[] { "Id", "ApellidosEmpleado", "FechaPermiso", "NombreEmpleado", "TipoPermisoId" },
                values: new object[] { 2, "Ruiz", new DateTime(2021, 12, 20, 14, 13, 55, 578, DateTimeKind.Local).AddTicks(9343), "Carolina", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_TipoPermisoId",
                table: "Permiso",
                column: "TipoPermisoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "TipoPermiso");
        }
    }
}
