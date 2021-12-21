using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PermisoSystem.Api.Migrations
{
    public partial class _20211220_AddingDataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permiso",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TipoPermiso",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreEmpleado",
                table: "Permiso",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApellidosEmpleado",
                table: "Permiso",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TipoPermiso",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "NombreEmpleado",
                table: "Permiso",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ApellidosEmpleado",
                table: "Permiso",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Permiso",
                columns: new[] { "Id", "ApellidosEmpleado", "FechaPermiso", "NombreEmpleado", "TipoPermisoId" },
                values: new object[] { 1, "Ruiz", new DateTime(2021, 12, 20, 14, 13, 55, 577, DateTimeKind.Local).AddTicks(6239), "Wildo", 1 });

            migrationBuilder.InsertData(
                table: "Permiso",
                columns: new[] { "Id", "ApellidosEmpleado", "FechaPermiso", "NombreEmpleado", "TipoPermisoId" },
                values: new object[] { 2, "Ruiz", new DateTime(2021, 12, 20, 14, 13, 55, 578, DateTimeKind.Local).AddTicks(9343), "Carolina", 1 });
        }
    }
}
