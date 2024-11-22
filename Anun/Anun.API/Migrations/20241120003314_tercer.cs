using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anun.API.Migrations
{
    /// <inheritdoc />
    public partial class tercer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnunciosEmpleados_Anuncios_AnuncioId",
                table: "AnunciosEmpleados");

            migrationBuilder.DropForeignKey(
                name: "FK_AnunciosEmpleados_Empleados_EmpleadoId",
                table: "AnunciosEmpleados");

            migrationBuilder.DropForeignKey(
                name: "FK_AnunciosPaginas_Anuncios_AnuncioId",
                table: "AnunciosPaginas");

            migrationBuilder.DropForeignKey(
                name: "FK_AnunciosPaginas_Webs_WebId",
                table: "AnunciosPaginas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnunciosPaginas",
                table: "AnunciosPaginas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnunciosEmpleados",
                table: "AnunciosEmpleados");

            migrationBuilder.RenameTable(
                name: "AnunciosPaginas",
                newName: "AnuncioPagina");

            migrationBuilder.RenameTable(
                name: "AnunciosEmpleados",
                newName: "AnuncioEmpleado");

            migrationBuilder.RenameIndex(
                name: "IX_AnunciosPaginas_WebId",
                table: "AnuncioPagina",
                newName: "IX_AnuncioPagina_WebId");

            migrationBuilder.RenameIndex(
                name: "IX_AnunciosPaginas_AnuncioId",
                table: "AnuncioPagina",
                newName: "IX_AnuncioPagina_AnuncioId");

            migrationBuilder.RenameIndex(
                name: "IX_AnunciosEmpleados_EmpleadoId",
                table: "AnuncioEmpleado",
                newName: "IX_AnuncioEmpleado_EmpleadoId");

            migrationBuilder.RenameIndex(
                name: "IX_AnunciosEmpleados_AnuncioId",
                table: "AnuncioEmpleado",
                newName: "IX_AnuncioEmpleado_AnuncioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnuncioPagina",
                table: "AnuncioPagina",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnuncioEmpleado",
                table: "AnuncioEmpleado",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnuncioEmpleado_Anuncios_AnuncioId",
                table: "AnuncioEmpleado",
                column: "AnuncioId",
                principalTable: "Anuncios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnuncioEmpleado_Empleados_EmpleadoId",
                table: "AnuncioEmpleado",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnuncioPagina_Anuncios_AnuncioId",
                table: "AnuncioPagina",
                column: "AnuncioId",
                principalTable: "Anuncios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnuncioPagina_Webs_WebId",
                table: "AnuncioPagina",
                column: "WebId",
                principalTable: "Webs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnuncioEmpleado_Anuncios_AnuncioId",
                table: "AnuncioEmpleado");

            migrationBuilder.DropForeignKey(
                name: "FK_AnuncioEmpleado_Empleados_EmpleadoId",
                table: "AnuncioEmpleado");

            migrationBuilder.DropForeignKey(
                name: "FK_AnuncioPagina_Anuncios_AnuncioId",
                table: "AnuncioPagina");

            migrationBuilder.DropForeignKey(
                name: "FK_AnuncioPagina_Webs_WebId",
                table: "AnuncioPagina");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnuncioPagina",
                table: "AnuncioPagina");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnuncioEmpleado",
                table: "AnuncioEmpleado");

            migrationBuilder.RenameTable(
                name: "AnuncioPagina",
                newName: "AnunciosPaginas");

            migrationBuilder.RenameTable(
                name: "AnuncioEmpleado",
                newName: "AnunciosEmpleados");

            migrationBuilder.RenameIndex(
                name: "IX_AnuncioPagina_WebId",
                table: "AnunciosPaginas",
                newName: "IX_AnunciosPaginas_WebId");

            migrationBuilder.RenameIndex(
                name: "IX_AnuncioPagina_AnuncioId",
                table: "AnunciosPaginas",
                newName: "IX_AnunciosPaginas_AnuncioId");

            migrationBuilder.RenameIndex(
                name: "IX_AnuncioEmpleado_EmpleadoId",
                table: "AnunciosEmpleados",
                newName: "IX_AnunciosEmpleados_EmpleadoId");

            migrationBuilder.RenameIndex(
                name: "IX_AnuncioEmpleado_AnuncioId",
                table: "AnunciosEmpleados",
                newName: "IX_AnunciosEmpleados_AnuncioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnunciosPaginas",
                table: "AnunciosPaginas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnunciosEmpleados",
                table: "AnunciosEmpleados",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnunciosEmpleados_Anuncios_AnuncioId",
                table: "AnunciosEmpleados",
                column: "AnuncioId",
                principalTable: "Anuncios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnunciosEmpleados_Empleados_EmpleadoId",
                table: "AnunciosEmpleados",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnunciosPaginas_Anuncios_AnuncioId",
                table: "AnunciosPaginas",
                column: "AnuncioId",
                principalTable: "Anuncios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnunciosPaginas_Webs_WebId",
                table: "AnunciosPaginas",
                column: "WebId",
                principalTable: "Webs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
