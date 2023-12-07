using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MatteoRbProject.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QueueRules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueueRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ObjectNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LMNumber = table.Column<int>(type: "int", nullable: false),
                    QueueRuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_QueueRules_QueueRuleId",
                        column: x => x.QueueRuleId,
                        principalTable: "QueueRules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    NumberAffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appartments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ObjectNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LMNumber = table.Column<int>(type: "int", nullable: false),
                    QueueRuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdvertId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appartments_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appartments_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appartments_QueueRules_QueueRuleId",
                        column: x => x.QueueRuleId,
                        principalTable: "QueueRules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RentalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdvertText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adverts_Appartments_AppartmentId",
                        column: x => x.AppartmentId,
                        principalTable: "Appartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "QueueRules",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6055f821-bf36-4a3a-981d-3e80236adcb0"), "Köregel 3" },
                    { new Guid("9aa02117-7045-4633-9297-e8ead75035cf"), "Köregel 1" },
                    { new Guid("e6d45b39-2c2c-4880-ba9e-ffd3c52c4ebb"), "Köregel 2" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "LMNumber", "ObjectNumber", "QueueRuleId" },
                values: new object[,]
                {
                    { new Guid("5eba581f-1428-4630-bc95-f3e1b6ae02ca"), 123456, "1234-5678", new Guid("9aa02117-7045-4633-9297-e8ead75035cf") },
                    { new Guid("77113cee-6316-4ed3-8003-9eefa714d0fd"), 234561, "8765-4321", new Guid("e6d45b39-2c2c-4880-ba9e-ffd3c52c4ebb") },
                    { new Guid("dc69538b-3542-4177-bb33-498a2c4b3a91"), 345612, "9876-5432", new Guid("6055f821-bf36-4a3a-981d-3e80236adcb0") }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "County", "Number", "NumberAffix", "PostalCode", "PropertyId", "Street" },
                values: new object[,]
                {
                    { new Guid("0b06e800-bf7c-4d65-b00f-722f2280f5b9"), "Kristianstad", "Skåne", 18, "E", "291 30", new Guid("77113cee-6316-4ed3-8003-9eefa714d0fd"), "Blekingevägen" },
                    { new Guid("3b915c92-bba9-48d4-84d5-c142f92a4d25"), "Kristianstad", "Skåne", 7, "B", "291 21", new Guid("dc69538b-3542-4177-bb33-498a2c4b3a91"), "Kanalgatan" },
                    { new Guid("b1e70dd0-5bad-4ef1-8945-ff03ca919baa"), "Kristianstad", "Skåne", 12, "C", "291 50", new Guid("5eba581f-1428-4630-bc95-f3e1b6ae02ca"), "Snapphanevägen" }
                });

            migrationBuilder.InsertData(
                table: "Appartments",
                columns: new[] { "Id", "AddressId", "AdvertId", "LMNumber", "ObjectNumber", "PropertyId", "QueueRuleId" },
                values: new object[] { new Guid("7201b81b-3d99-4476-ac3c-1f4518b7e9f9"), new Guid("b1e70dd0-5bad-4ef1-8945-ff03ca919baa"), new Guid("24753fad-0fb9-4250-ab3a-07a5038efadc"), 345612, "9876-5432", new Guid("5eba581f-1428-4630-bc95-f3e1b6ae02ca"), new Guid("9aa02117-7045-4633-9297-e8ead75035cf") });

            migrationBuilder.InsertData(
                table: "Adverts",
                columns: new[] { "Id", "AdvertText", "AppartmentId", "PublishedAt", "RentalDate" },
                values: new object[] { new Guid("24753fad-0fb9-4250-ab3a-07a5038efadc"), "Detta är den fetaste lägenheten på marknaden. Inga djur, inga rökare, inga människor!", new Guid("7201b81b-3d99-4476-ac3c-1f4518b7e9f9"), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PropertyId",
                table: "Addresses",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_AppartmentId",
                table: "Adverts",
                column: "AppartmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appartments_AddressId",
                table: "Appartments",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Appartments_PropertyId",
                table: "Appartments",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Appartments_QueueRuleId",
                table: "Appartments",
                column: "QueueRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_QueueRuleId",
                table: "Properties",
                column: "QueueRuleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");

            migrationBuilder.DropTable(
                name: "Appartments");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "QueueRules");
        }
    }
}
