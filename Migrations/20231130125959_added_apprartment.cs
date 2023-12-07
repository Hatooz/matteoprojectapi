using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatteoRbProject.Migrations
{
    /// <inheritdoc />
    public partial class added_apprartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appartments",
                columns: new[] { "Id", "AddressId", "AdvertId", "LMNumber", "ObjectNumber", "PropertyId", "QueueRuleId" },
                values: new object[] { new Guid("cd80e77e-5815-4b4a-8ca7-45bf51dd42d3"), new Guid("0b06e800-bf7c-4d65-b00f-722f2280f5b9"), new Guid("24753fad-0fb9-4250-ab3a-07a5038efadc"), 345612, "9876-5432", new Guid("77113cee-6316-4ed3-8003-9eefa714d0fd"), new Guid("e6d45b39-2c2c-4880-ba9e-ffd3c52c4ebb") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("cd80e77e-5815-4b4a-8ca7-45bf51dd42d3"));
        }
    }
}
