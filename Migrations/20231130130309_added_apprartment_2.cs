using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatteoRbProject.Migrations
{
    /// <inheritdoc />
    public partial class added_apprartment_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appartments",
                columns: new[] { "Id", "AddressId", "AdvertId", "LMNumber", "ObjectNumber", "PropertyId", "QueueRuleId" },
                values: new object[] { new Guid("213c995a-0463-4030-aa10-227b39e989e7"), new Guid("3b915c92-bba9-48d4-84d5-c142f92a4d25"), null, 345612, "9876-5432", new Guid("77113cee-6316-4ed3-8003-9eefa714d0fd"), new Guid("6055f821-bf36-4a3a-981d-3e80236adcb0") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("213c995a-0463-4030-aa10-227b39e989e7"));
        }
    }
}
