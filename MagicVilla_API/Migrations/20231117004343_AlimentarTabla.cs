using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "Nombre", "Tarifa", "metrosCuadrados", "ocupantes" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa", new DateTime(2023, 11, 16, 18, 43, 43, 176, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 11, 16, 18, 43, 43, 176, DateTimeKind.Local).AddTicks(7822), "", "Emmanuel", 100.0, 40, 3 },
                    { 2, "", "Detalle de la Villa11", new DateTime(2023, 11, 16, 18, 43, 43, 176, DateTimeKind.Local).AddTicks(7826), new DateTime(2023, 11, 16, 18, 43, 43, 176, DateTimeKind.Local).AddTicks(7827), "", "Dana", 150.0, 50, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
