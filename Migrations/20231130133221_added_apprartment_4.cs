using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatteoRbProject.Migrations
{
    /// <inheritdoc />
    public partial class added_apprartment_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("24753fad-0fb9-4250-ab3a-07a5038efadc"),
                column: "AppartmentId",
                value: new Guid("cd80e77e-5815-4b4a-8ca7-45bf51dd42d3"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("24753fad-0fb9-4250-ab3a-07a5038efadc"),
                column: "AppartmentId",
                value: new Guid("7201b81b-3d99-4476-ac3c-1f4518b7e9f9"));
        }
    }
}
