using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MatteoRbProject.Migrations
{
    /// <inheritdoc />
    public partial class seeds_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QueueRules",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("04e694b5-2285-4443-a778-44c6825c5d1d"), "Köregel 49" },
                    { new Guid("06b987e0-17b6-41b9-9d08-f8d2790f9106"), "Köregel 86" },
                    { new Guid("08671ef2-1c11-4ff9-b32f-03e70b575e97"), "Köregel 44" },
                    { new Guid("08be4494-dccb-42e2-89c1-e1870948f6d7"), "Köregel 37" },
                    { new Guid("0ac92777-d319-4812-b465-d0cda30124c4"), "Köregel 2" },
                    { new Guid("0c6f5c50-ad34-4d11-a824-a2cca00335f2"), "Köregel 51" },
                    { new Guid("0de61fba-f055-4ded-a4a6-e723d18403c9"), "Köregel 57" },
                    { new Guid("10e35fd3-4eb1-4201-bd3b-9dd4c581ebb5"), "Köregel 13" },
                    { new Guid("1577c630-b70f-4c4a-8f6e-ec1879c69b61"), "Köregel 5" },
                    { new Guid("173f40de-56fc-4d8b-b774-df46fe4f3e7d"), "Köregel 72" },
                    { new Guid("1c4741a4-f54a-402d-884b-afbecb24e3ca"), "Köregel 69" },
                    { new Guid("1e19f3e1-56ef-4198-9788-c67d7aa86f0d"), "Köregel 53" },
                    { new Guid("1fe465ef-2452-43c3-845e-69840f9bef8b"), "Köregel 96" },
                    { new Guid("209bea85-0fd7-4244-a9a6-8be4d433262e"), "Köregel 84" },
                    { new Guid("211160c7-cf50-441e-9982-7e467ac067db"), "Köregel 27" },
                    { new Guid("2218a0ad-b4dd-4a1b-bdf7-08f773554ab7"), "Köregel 58" },
                    { new Guid("25790cea-85de-480c-9447-00efa7b63899"), "Köregel 24" },
                    { new Guid("28bf7c43-1946-412b-a240-0ea31c0ae2a2"), "Köregel 94" },
                    { new Guid("33facd90-b0b6-4feb-8452-f19647126948"), "Köregel 61" },
                    { new Guid("3586dc13-d20d-4bd9-bb47-387c57aabefb"), "Köregel 52" },
                    { new Guid("394e532d-8355-43ed-9bf2-fb116fc307f7"), "Köregel 42" },
                    { new Guid("3c57f168-bc6f-4e19-9206-e59c482b4c20"), "Köregel 65" },
                    { new Guid("3dcb3720-de06-49f6-8ae9-88eba1873bde"), "Köregel 82" },
                    { new Guid("3fa59497-8d43-4384-8ff0-6915d0504503"), "Köregel 40" },
                    { new Guid("417b8bf6-9855-426b-a9e4-72f58e4338f7"), "Köregel 46" },
                    { new Guid("421454c3-8ff9-468b-b69e-cc8c7106a2ed"), "Köregel 9" },
                    { new Guid("45236cd6-953a-430d-911c-89ed0419fabd"), "Köregel 98" },
                    { new Guid("4ab72c15-be38-46f6-9c12-e13a7c15680c"), "Köregel 4" },
                    { new Guid("5715ab16-e036-4f0c-b1eb-ffccd8a245fd"), "Köregel 20" },
                    { new Guid("583ff23c-8c9a-41a2-be16-a154505be078"), "Köregel 85" },
                    { new Guid("5cda885c-7e58-4034-8bdf-130db37cae4f"), "Köregel 29" },
                    { new Guid("6055f821-bf36-4a3a-981d-3e80236adcb0"), "Köregel 3" },
                    { new Guid("60e2da02-efc8-4b48-9e52-29548c36c377"), "Köregel 100" },
                    { new Guid("62a9708d-448a-4b92-86dd-29d7f973f8f8"), "Köregel 10" },
                    { new Guid("6532aa4d-93c5-498e-bd05-0886835edf0c"), "Köregel 74" },
                    { new Guid("6b058369-ac63-45df-b071-1b8cd76a5523"), "Köregel 55" },
                    { new Guid("6b836c3c-70aa-4f9c-959a-fc3f961e04b2"), "Köregel 36" },
                    { new Guid("6be5d801-e9d1-4577-8cc3-49b8dcc3ac19"), "Köregel 90" },
                    { new Guid("70400a90-918c-4362-a4ed-c518c1b7d906"), "Köregel 75" },
                    { new Guid("70af94b5-82b6-4343-b322-8bed1aae617a"), "Köregel 67" },
                    { new Guid("72b47709-888d-4a0b-bc93-4747c4964731"), "Köregel 45" },
                    { new Guid("733c2caf-4930-4fc0-a0dd-1c394b93d3df"), "Köregel 79" },
                    { new Guid("77b04139-f482-49df-afc1-0c4e4f1189a1"), "Köregel 56" },
                    { new Guid("7c7aa9e0-a0b1-4932-aa0d-f6aa6eb8bf26"), "Köregel 63" },
                    { new Guid("810c56d3-c486-44ac-ab7b-f1c4479c2717"), "Köregel 81" },
                    { new Guid("85abce8a-c40d-4883-9cda-66479511f3a9"), "Köregel 25" },
                    { new Guid("8639a985-d804-4af3-b505-a6983ee8612d"), "Köregel 17" },
                    { new Guid("874efec8-3e04-4bb8-8089-7914dd8b7d5d"), "Köregel 15" },
                    { new Guid("8885d65c-4211-44c8-ba15-8b48425f24f7"), "Köregel 6" },
                    { new Guid("8d239909-68cd-4af3-9907-282476d6a17f"), "Köregel 30" },
                    { new Guid("8dda6bc4-c25a-446d-b576-465f0b9d6d00"), "Köregel 11" },
                    { new Guid("90f77380-a9b4-4b1b-b48a-0404aba4cd07"), "Köregel 62" },
                    { new Guid("93fe9a8d-235c-42f9-9c0c-06b1adbab027"), "Köregel 23" },
                    { new Guid("949a5c00-8573-432c-8e3c-4a5bbe2a11d9"), "Köregel 7" },
                    { new Guid("95ed6957-691c-4ac0-ac92-9e4c6eb5ab04"), "Köregel 76" },
                    { new Guid("96781922-56ac-427a-b95d-f7b91031d053"), "Köregel 18" },
                    { new Guid("97a0ed20-e860-4db1-b092-e6709b09d082"), "Köregel 43" },
                    { new Guid("9aa02117-7045-4633-9297-e8ead75035cf"), "Köregel 1" },
                    { new Guid("9abad73a-8264-4b70-b83b-8dc243853be6"), "Köregel 92" },
                    { new Guid("9c069651-e058-4a66-986f-fd3afe3ed80f"), "Köregel 78" },
                    { new Guid("9c8ba7bb-8a6f-4fd8-96a3-6cad2dfbb806"), "Köregel 95" },
                    { new Guid("a167d7c1-b32e-414a-9bd3-c42c026a5c0f"), "Köregel 73" },
                    { new Guid("a45fef14-fd8e-414c-b89a-05bd899b279b"), "Köregel 71" },
                    { new Guid("a89a18e5-772a-4f95-8655-011802c2f623"), "Köregel 21" },
                    { new Guid("a8dd5527-c3a6-4a2a-a6b8-8a48a1f62291"), "Köregel 31" },
                    { new Guid("af6a129a-4c11-4d3d-9648-5ac1d7f6a87c"), "Köregel 97" },
                    { new Guid("b24217c5-bf15-4c44-adad-a6b1a4954b0c"), "Köregel 87" },
                    { new Guid("b4774e53-1085-4c36-9967-41f94cf1c847"), "Köregel 8" },
                    { new Guid("b58a2425-c102-457f-a1d0-c0ba72476a8f"), "Köregel 34" },
                    { new Guid("b86b2f3e-48c4-42f5-90aa-9aa622d9acdd"), "Köregel 22" },
                    { new Guid("baf6c58c-14f4-4818-bb77-37680f7a5095"), "Köregel 41" },
                    { new Guid("bbd3ef42-c2cd-421e-b56e-0594c8dd8467"), "Köregel 68" },
                    { new Guid("bd3bba39-d9d3-4472-b0b3-7bacd73ad287"), "Köregel 3" },
                    { new Guid("be7e908f-f33e-4b55-8080-fec32e28e9a3"), "Köregel 14" },
                    { new Guid("bed00ae0-7e39-488f-aa9c-a12ecf8b3fbd"), "Köregel 70" },
                    { new Guid("c0757928-1236-4695-9328-d6a630511f65"), "Köregel 77" },
                    { new Guid("c1831627-c34f-48ad-b549-7d19c667e781"), "Köregel 83" },
                    { new Guid("c36a617e-6e88-4c84-b297-bc74fa035184"), "Köregel 38" },
                    { new Guid("c9ec33dc-2ce3-45f3-baba-7568dfc8a845"), "Köregel 1" },
                    { new Guid("ca6e2dd4-c407-4b09-835f-52530a9c9fe9"), "Köregel 48" },
                    { new Guid("cbc8f609-28e0-40cb-af45-9f83b30d1c8e"), "Köregel 54" },
                    { new Guid("cbdb0773-58f6-487f-99ae-3e634bb45378"), "Köregel 19" },
                    { new Guid("d04ca83f-dea4-4870-8bd8-cdc504b15dd8"), "Köregel 80" },
                    { new Guid("d061e0ce-d8fc-43a8-acd3-11657ac01d11"), "Köregel 28" },
                    { new Guid("d3226b26-a9c0-44c7-836e-1d481b7d782f"), "Köregel 89" },
                    { new Guid("d6f405b8-3d22-4b85-bf3e-f5fb0a291f76"), "Köregel 99" },
                    { new Guid("d744d714-3a97-4c88-820d-420f248d923f"), "Köregel 33" },
                    { new Guid("e0b66157-fd2e-4264-a9b8-d6b19bb68678"), "Köregel 91" },
                    { new Guid("e13d1000-4132-484f-bc6f-7eaa960d47de"), "Köregel 50" },
                    { new Guid("e26d168b-0db4-44bd-a22b-c47e9ca38ac4"), "Köregel 66" },
                    { new Guid("e2b30df4-8cb6-475a-a76a-00e1e983c03f"), "Köregel 16" },
                    { new Guid("e3a49177-27e4-4843-b201-f48d7dbb3c9c"), "Köregel 88" },
                    { new Guid("e3f70e90-05b4-4bb4-a599-cd7436645d13"), "Köregel 64" },
                    { new Guid("e6632e38-cbd7-4431-b74f-54ff1dc61c67"), "Köregel 39" },
                    { new Guid("e6d45b39-2c2c-4880-ba9e-ffd3c52c4ebb"), "Köregel 2" },
                    { new Guid("e8ffdec0-467c-43e3-b858-7b5869603d84"), "Köregel 32" },
                    { new Guid("f1316c60-6e87-4639-a17d-e6cd44eb3cdd"), "Köregel 60" },
                    { new Guid("f3fe298f-914b-4e28-847c-dcb62d7c4f4d"), "Köregel 35" },
                    { new Guid("f6134a9f-a9bd-4f14-9c61-25fc4b408765"), "Köregel 93" },
                    { new Guid("f669ae3c-fb09-44b2-98d4-2bfc9a597681"), "Köregel 47" },
                    { new Guid("f782b3b8-ac6d-4f70-b947-90bf5ddd737c"), "Köregel 59" },
                    { new Guid("f95f22cd-412a-48ae-832b-1b31e1a35f65"), "Köregel 12" },
                    { new Guid("fbce9ad2-c9d3-4646-9cd0-071a0e571aa3"), "Köregel 26" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "LMNumber", "ObjectNumber", "QueueRuleId" },
                values: new object[,]
                {
                    { new Guid("018e0164-a8be-45a8-9188-6e38fc7b0049"), 22, "ObjectNumber22", new Guid("b86b2f3e-48c4-42f5-90aa-9aa622d9acdd") },
                    { new Guid("01c2e9e8-c00c-4efd-bfbd-425a1d68c7f7"), 77, "ObjectNumber77", new Guid("c0757928-1236-4695-9328-d6a630511f65") },
                    { new Guid("04ff204a-bc45-44dc-b814-aae8b1f5ca90"), 84, "ObjectNumber84", new Guid("209bea85-0fd7-4244-a9a6-8be4d433262e") },
                    { new Guid("0548ac38-fb56-414b-a7bb-34b388d24fda"), 18, "ObjectNumber18", new Guid("96781922-56ac-427a-b95d-f7b91031d053") },
                    { new Guid("0e0af672-3e59-4ce4-aeee-f21b331cbedf"), 93, "ObjectNumber93", new Guid("f6134a9f-a9bd-4f14-9c61-25fc4b408765") },
                    { new Guid("0eab19a9-f66a-4197-949a-ece2caa43be5"), 95, "ObjectNumber95", new Guid("9c8ba7bb-8a6f-4fd8-96a3-6cad2dfbb806") },
                    { new Guid("0efa2bb5-f3a0-48e5-84e4-260c723a6ea2"), 31, "ObjectNumber31", new Guid("a8dd5527-c3a6-4a2a-a6b8-8a48a1f62291") },
                    { new Guid("0f27d0cc-93a5-41c3-89e4-d08dc30f3694"), 74, "ObjectNumber74", new Guid("6532aa4d-93c5-498e-bd05-0886835edf0c") },
                    { new Guid("0f564446-2820-4641-a6c5-2fc14cfb5a7f"), 73, "ObjectNumber73", new Guid("a167d7c1-b32e-414a-9bd3-c42c026a5c0f") },
                    { new Guid("10ee3493-0203-44b4-a696-6ce4b4b60bc2"), 76, "ObjectNumber76", new Guid("95ed6957-691c-4ac0-ac92-9e4c6eb5ab04") },
                    { new Guid("111a70a6-ada3-4e11-9dbd-627cab46c20e"), 9, "ObjectNumber9", new Guid("421454c3-8ff9-468b-b69e-cc8c7106a2ed") },
                    { new Guid("1565c576-0b4f-4254-9b92-5235b00160d7"), 16, "ObjectNumber16", new Guid("e2b30df4-8cb6-475a-a76a-00e1e983c03f") },
                    { new Guid("185ad2c0-5b81-4c7d-acd8-aea73c975678"), 87, "ObjectNumber87", new Guid("b24217c5-bf15-4c44-adad-a6b1a4954b0c") },
                    { new Guid("1869dd80-1931-4220-8037-be8d33d4c937"), 50, "ObjectNumber50", new Guid("e13d1000-4132-484f-bc6f-7eaa960d47de") },
                    { new Guid("1ef18407-9ee2-46cb-91d4-a37c4149c58a"), 94, "ObjectNumber94", new Guid("28bf7c43-1946-412b-a240-0ea31c0ae2a2") },
                    { new Guid("1f1465e6-455f-42c4-a354-0d5a2b33bb9f"), 46, "ObjectNumber46", new Guid("417b8bf6-9855-426b-a9e4-72f58e4338f7") },
                    { new Guid("1fd0b382-5097-45f6-9894-d39a5ed2b214"), 83, "ObjectNumber83", new Guid("c1831627-c34f-48ad-b549-7d19c667e781") },
                    { new Guid("201aa1bd-262c-46f4-b7c2-2f2d719ce594"), 48, "ObjectNumber48", new Guid("ca6e2dd4-c407-4b09-835f-52530a9c9fe9") },
                    { new Guid("25267bbb-b782-4120-90fb-42b5783fa1f7"), 97, "ObjectNumber97", new Guid("af6a129a-4c11-4d3d-9648-5ac1d7f6a87c") },
                    { new Guid("255fadf6-824f-46ee-96ba-37873e36d50b"), 82, "ObjectNumber82", new Guid("3dcb3720-de06-49f6-8ae9-88eba1873bde") },
                    { new Guid("2832d5f0-5ebe-4d8a-9e4d-9377b4b9bde6"), 43, "ObjectNumber43", new Guid("97a0ed20-e860-4db1-b092-e6709b09d082") },
                    { new Guid("2cc1789f-6974-4e5a-9f41-275abdff7db7"), 15, "ObjectNumber15", new Guid("874efec8-3e04-4bb8-8089-7914dd8b7d5d") },
                    { new Guid("34c08e67-22df-44bd-b6f0-e248b158b27e"), 32, "ObjectNumber32", new Guid("e8ffdec0-467c-43e3-b858-7b5869603d84") },
                    { new Guid("35ab7183-5c5d-4322-8d06-bf5538944fcb"), 45, "ObjectNumber45", new Guid("72b47709-888d-4a0b-bc93-4747c4964731") },
                    { new Guid("371f4e36-3b3a-494c-90d9-f9edb241875a"), 17, "ObjectNumber17", new Guid("8639a985-d804-4af3-b505-a6983ee8612d") },
                    { new Guid("3a8a0634-bd3a-4102-b43a-37293dd03640"), 90, "ObjectNumber90", new Guid("6be5d801-e9d1-4577-8cc3-49b8dcc3ac19") },
                    { new Guid("3ad50a9d-7db7-4d55-9d6c-24d39bc6ea10"), 29, "ObjectNumber29", new Guid("5cda885c-7e58-4034-8bdf-130db37cae4f") },
                    { new Guid("3e741619-63e8-458e-b746-9196675790e6"), 33, "ObjectNumber33", new Guid("d744d714-3a97-4c88-820d-420f248d923f") },
                    { new Guid("3f7e804c-2fdd-480f-8c30-4b04efe6b1e5"), 78, "ObjectNumber78", new Guid("9c069651-e058-4a66-986f-fd3afe3ed80f") },
                    { new Guid("47297899-b466-41e6-8707-f3874a435d1c"), 61, "ObjectNumber61", new Guid("33facd90-b0b6-4feb-8452-f19647126948") },
                    { new Guid("47a42ad6-c83f-4891-b48c-7114086d64eb"), 10, "ObjectNumber10", new Guid("62a9708d-448a-4b92-86dd-29d7f973f8f8") },
                    { new Guid("47a68fe2-cf37-463e-942b-49df237546d2"), 28, "ObjectNumber28", new Guid("d061e0ce-d8fc-43a8-acd3-11657ac01d11") },
                    { new Guid("488198be-adb2-4082-8e4b-8577de525262"), 71, "ObjectNumber71", new Guid("a45fef14-fd8e-414c-b89a-05bd899b279b") },
                    { new Guid("492ead94-2740-48a5-9c6c-78cedc0ddaa9"), 47, "ObjectNumber47", new Guid("f669ae3c-fb09-44b2-98d4-2bfc9a597681") },
                    { new Guid("4d4fa242-a3d3-4c79-8600-73f189efe9c9"), 7, "ObjectNumber7", new Guid("949a5c00-8573-432c-8e3c-4a5bbe2a11d9") },
                    { new Guid("4f4a7502-b199-43da-8964-798fca0bed02"), 100, "ObjectNumber100", new Guid("60e2da02-efc8-4b48-9e52-29548c36c377") },
                    { new Guid("50802b4a-b9f3-42b5-86f2-72bf31b8020c"), 51, "ObjectNumber51", new Guid("0c6f5c50-ad34-4d11-a824-a2cca00335f2") },
                    { new Guid("5801311e-ee54-47bd-9b93-18e45dcbf803"), 41, "ObjectNumber41", new Guid("baf6c58c-14f4-4818-bb77-37680f7a5095") },
                    { new Guid("5cda4284-9a37-4829-8e7a-79bf48c75362"), 39, "ObjectNumber39", new Guid("e6632e38-cbd7-4431-b74f-54ff1dc61c67") },
                    { new Guid("5eba581f-1428-4630-bc95-f3e1b6ae02ca"), 123456, "1234-5678", new Guid("9aa02117-7045-4633-9297-e8ead75035cf") },
                    { new Guid("60852f97-7cfd-443b-b5d5-90799f377f2b"), 99, "ObjectNumber99", new Guid("d6f405b8-3d22-4b85-bf3e-f5fb0a291f76") },
                    { new Guid("6128c816-581b-451e-a372-380afe214b87"), 53, "ObjectNumber53", new Guid("1e19f3e1-56ef-4198-9788-c67d7aa86f0d") },
                    { new Guid("61876048-d9b4-4462-bb73-cad0fbcb7c8e"), 23, "ObjectNumber23", new Guid("93fe9a8d-235c-42f9-9c0c-06b1adbab027") },
                    { new Guid("64d61a87-884f-4d96-99cf-bca559aa759a"), 3, "ObjectNumber3", new Guid("bd3bba39-d9d3-4472-b0b3-7bacd73ad287") },
                    { new Guid("65a84d51-542b-4142-b62e-2a41389c0fd9"), 49, "ObjectNumber49", new Guid("04e694b5-2285-4443-a778-44c6825c5d1d") },
                    { new Guid("6b6b4fb0-0591-4984-bccf-dad882bf78b0"), 11, "ObjectNumber11", new Guid("8dda6bc4-c25a-446d-b576-465f0b9d6d00") },
                    { new Guid("6e0936e9-4919-444a-83fd-d404f89880ab"), 72, "ObjectNumber72", new Guid("173f40de-56fc-4d8b-b774-df46fe4f3e7d") },
                    { new Guid("71e31428-907f-42fd-98d8-45d2fa8963b0"), 38, "ObjectNumber38", new Guid("c36a617e-6e88-4c84-b297-bc74fa035184") },
                    { new Guid("72afcbf9-0685-4b47-9232-ead42f0a2504"), 8, "ObjectNumber8", new Guid("b4774e53-1085-4c36-9967-41f94cf1c847") },
                    { new Guid("738fd426-8cbb-406c-9490-edb0a1f28099"), 88, "ObjectNumber88", new Guid("e3a49177-27e4-4843-b201-f48d7dbb3c9c") },
                    { new Guid("77113cee-6316-4ed3-8003-9eefa714d0fd"), 234561, "8765-4321", new Guid("e6d45b39-2c2c-4880-ba9e-ffd3c52c4ebb") },
                    { new Guid("79c1e98b-a78e-4262-9e96-f8dd48b3a70d"), 42, "ObjectNumber42", new Guid("394e532d-8355-43ed-9bf2-fb116fc307f7") },
                    { new Guid("7d42e87d-62a8-4125-b105-abfa55d6b8b6"), 80, "ObjectNumber80", new Guid("d04ca83f-dea4-4870-8bd8-cdc504b15dd8") },
                    { new Guid("7dce2f61-d516-47f1-8ce4-a42be76e6893"), 81, "ObjectNumber81", new Guid("810c56d3-c486-44ac-ab7b-f1c4479c2717") },
                    { new Guid("7ec1d871-eda7-4c8f-9364-e150c6ecf964"), 26, "ObjectNumber26", new Guid("fbce9ad2-c9d3-4646-9cd0-071a0e571aa3") },
                    { new Guid("83b908c5-8cd1-4347-ba21-2525781633b7"), 59, "ObjectNumber59", new Guid("f782b3b8-ac6d-4f70-b947-90bf5ddd737c") },
                    { new Guid("84a9cb58-0e2e-41ee-9491-9fd9c66961e2"), 5, "ObjectNumber5", new Guid("1577c630-b70f-4c4a-8f6e-ec1879c69b61") },
                    { new Guid("8556e4e8-5f80-45b5-9f17-0fa09ff965c5"), 13, "ObjectNumber13", new Guid("10e35fd3-4eb1-4201-bd3b-9dd4c581ebb5") },
                    { new Guid("88d0f32f-a6e8-4b59-8a5c-86cc43f820af"), 6, "ObjectNumber6", new Guid("8885d65c-4211-44c8-ba15-8b48425f24f7") },
                    { new Guid("88df6afd-82d0-4790-bb49-1b189f9fd5d8"), 35, "ObjectNumber35", new Guid("f3fe298f-914b-4e28-847c-dcb62d7c4f4d") },
                    { new Guid("8ae80374-e67c-4087-9780-78ce18d9f26b"), 63, "ObjectNumber63", new Guid("7c7aa9e0-a0b1-4932-aa0d-f6aa6eb8bf26") },
                    { new Guid("8f2e3885-1384-4267-9b32-531dd3a2ac0a"), 34, "ObjectNumber34", new Guid("b58a2425-c102-457f-a1d0-c0ba72476a8f") },
                    { new Guid("9086598c-a91a-4370-b9c0-d87e5af86a2b"), 79, "ObjectNumber79", new Guid("733c2caf-4930-4fc0-a0dd-1c394b93d3df") },
                    { new Guid("91548d99-a557-4422-8280-a5857c85fa1f"), 60, "ObjectNumber60", new Guid("f1316c60-6e87-4639-a17d-e6cd44eb3cdd") },
                    { new Guid("9173c8ae-5211-4677-a36b-ab3a60380674"), 4, "ObjectNumber4", new Guid("4ab72c15-be38-46f6-9c12-e13a7c15680c") },
                    { new Guid("98cf088d-7266-4dbc-b210-ad9dcf63f4da"), 25, "ObjectNumber25", new Guid("85abce8a-c40d-4883-9cda-66479511f3a9") },
                    { new Guid("98df1ed4-74fc-4285-90aa-32785b444b34"), 21, "ObjectNumber21", new Guid("a89a18e5-772a-4f95-8655-011802c2f623") },
                    { new Guid("9a4c9521-4297-470a-8674-da194933753f"), 62, "ObjectNumber62", new Guid("90f77380-a9b4-4b1b-b48a-0404aba4cd07") },
                    { new Guid("9e29b3ec-63f0-4b99-9d9d-d50da43b951b"), 57, "ObjectNumber57", new Guid("0de61fba-f055-4ded-a4a6-e723d18403c9") },
                    { new Guid("a086b006-5adb-4c10-974c-4ead08fcaee4"), 56, "ObjectNumber56", new Guid("77b04139-f482-49df-afc1-0c4e4f1189a1") },
                    { new Guid("a184d9e2-1679-45e3-888e-2623f25aa6db"), 54, "ObjectNumber54", new Guid("cbc8f609-28e0-40cb-af45-9f83b30d1c8e") },
                    { new Guid("a3883238-1a10-415c-87f0-704473ec1304"), 68, "ObjectNumber68", new Guid("bbd3ef42-c2cd-421e-b56e-0594c8dd8467") },
                    { new Guid("a7842dd8-ce6a-428f-ab81-6f52752f0ed3"), 64, "ObjectNumber64", new Guid("e3f70e90-05b4-4bb4-a599-cd7436645d13") },
                    { new Guid("a9442cdd-dcfe-4050-9e0b-9c095520abb0"), 70, "ObjectNumber70", new Guid("bed00ae0-7e39-488f-aa9c-a12ecf8b3fbd") },
                    { new Guid("abdb7250-b651-44e3-9169-b53dd20dd91a"), 86, "ObjectNumber86", new Guid("06b987e0-17b6-41b9-9d08-f8d2790f9106") },
                    { new Guid("acad94ff-d851-4e4f-baff-6bc2904a5b52"), 40, "ObjectNumber40", new Guid("3fa59497-8d43-4384-8ff0-6915d0504503") },
                    { new Guid("b186ac54-20f7-4049-9a0a-7af63a89c23a"), 91, "ObjectNumber91", new Guid("e0b66157-fd2e-4264-a9b8-d6b19bb68678") },
                    { new Guid("b2950442-2aa6-450d-8d58-8a3124a599f5"), 52, "ObjectNumber52", new Guid("3586dc13-d20d-4bd9-bb47-387c57aabefb") },
                    { new Guid("b75ed543-7c13-4122-bd0d-b25eb6ae87f7"), 1, "ObjectNumber1", new Guid("c9ec33dc-2ce3-45f3-baba-7568dfc8a845") },
                    { new Guid("bb764df7-8d5d-469e-b7d4-e81c0ebdefd7"), 75, "ObjectNumber75", new Guid("70400a90-918c-4362-a4ed-c518c1b7d906") },
                    { new Guid("bc98d803-b2c0-46eb-939d-abfb4b9cd855"), 67, "ObjectNumber67", new Guid("70af94b5-82b6-4343-b322-8bed1aae617a") },
                    { new Guid("c063aae7-e5d0-45e6-bf63-49cef87a16b0"), 19, "ObjectNumber19", new Guid("cbdb0773-58f6-487f-99ae-3e634bb45378") },
                    { new Guid("c2e78631-0c88-4229-aeab-fc27fab9682f"), 24, "ObjectNumber24", new Guid("25790cea-85de-480c-9447-00efa7b63899") },
                    { new Guid("c4adfa34-16b2-4578-93e8-335690c6a465"), 92, "ObjectNumber92", new Guid("9abad73a-8264-4b70-b83b-8dc243853be6") },
                    { new Guid("c91fe89e-1087-4cbc-8025-572b6ff1ab58"), 2, "ObjectNumber2", new Guid("0ac92777-d319-4812-b465-d0cda30124c4") },
                    { new Guid("cb90ae97-7e0f-406e-a543-34595c6b477b"), 69, "ObjectNumber69", new Guid("1c4741a4-f54a-402d-884b-afbecb24e3ca") },
                    { new Guid("d05f8209-67e8-4e7d-8dbe-b6accafe7a7b"), 98, "ObjectNumber98", new Guid("45236cd6-953a-430d-911c-89ed0419fabd") },
                    { new Guid("d1829ce4-74ad-448d-b5fe-df5c3c90ce75"), 89, "ObjectNumber89", new Guid("d3226b26-a9c0-44c7-836e-1d481b7d782f") },
                    { new Guid("d2011010-2ee9-426b-acbf-e5d9c54bd89e"), 27, "ObjectNumber27", new Guid("211160c7-cf50-441e-9982-7e467ac067db") },
                    { new Guid("d3151a7e-93c5-4e1d-8049-7d582259d788"), 58, "ObjectNumber58", new Guid("2218a0ad-b4dd-4a1b-bdf7-08f773554ab7") },
                    { new Guid("d36de261-6b13-474d-910e-13824d27fa63"), 65, "ObjectNumber65", new Guid("3c57f168-bc6f-4e19-9206-e59c482b4c20") },
                    { new Guid("d8906712-f8ed-4c24-9a66-1390c1ebf808"), 12, "ObjectNumber12", new Guid("f95f22cd-412a-48ae-832b-1b31e1a35f65") },
                    { new Guid("d8a7d1c3-31bb-474d-9b5a-c87d1cd07c9c"), 55, "ObjectNumber55", new Guid("6b058369-ac63-45df-b071-1b8cd76a5523") },
                    { new Guid("da2412f5-143f-46b9-a077-67773ba4b1c0"), 96, "ObjectNumber96", new Guid("1fe465ef-2452-43c3-845e-69840f9bef8b") },
                    { new Guid("daa016e6-2ec5-42ea-ae96-b4c49e638c16"), 30, "ObjectNumber30", new Guid("8d239909-68cd-4af3-9907-282476d6a17f") },
                    { new Guid("dc69538b-3542-4177-bb33-498a2c4b3a91"), 345612, "9876-5432", new Guid("6055f821-bf36-4a3a-981d-3e80236adcb0") },
                    { new Guid("e3567842-f65e-4937-915b-9febd0a89b63"), 20, "ObjectNumber20", new Guid("5715ab16-e036-4f0c-b1eb-ffccd8a245fd") },
                    { new Guid("e752f5aa-4563-425a-9cb1-b4e493e2533e"), 37, "ObjectNumber37", new Guid("08be4494-dccb-42e2-89c1-e1870948f6d7") },
                    { new Guid("ea93a71b-cd19-4694-8047-38fbdf54e323"), 66, "ObjectNumber66", new Guid("e26d168b-0db4-44bd-a22b-c47e9ca38ac4") },
                    { new Guid("f14ece19-5e98-4541-8d1c-596596a443ff"), 85, "ObjectNumber85", new Guid("583ff23c-8c9a-41a2-be16-a154505be078") },
                    { new Guid("f44c808f-a1b5-4535-81e9-51ab2a762492"), 44, "ObjectNumber44", new Guid("08671ef2-1c11-4ff9-b32f-03e70b575e97") },
                    { new Guid("fd677cf2-844c-4397-9867-39ca92e75246"), 14, "ObjectNumber14", new Guid("be7e908f-f33e-4b55-8080-fec32e28e9a3") },
                    { new Guid("fef297e2-b20f-42cf-a644-28282ddf422d"), 36, "ObjectNumber36", new Guid("6b836c3c-70aa-4f9c-959a-fc3f961e04b2") }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "County", "Number", "NumberAffix", "PostalCode", "PropertyId", "Street" },
                values: new object[,]
                {
                    { new Guid("013fa90b-eaf9-4800-9afd-a9d34a82f8b8"), "City60", "County60", 60, "Affix60", "PostalCode60", new Guid("91548d99-a557-4422-8280-a5857c85fa1f"), "Street60" },
                    { new Guid("02397dec-bc2b-4c9b-bf55-f4cff82cab0c"), "City23", "County23", 23, "Affix23", "PostalCode23", new Guid("61876048-d9b4-4462-bb73-cad0fbcb7c8e"), "Street23" },
                    { new Guid("055e7e37-aaf2-428f-9339-a8935728cce9"), "City28", "County28", 28, "Affix28", "PostalCode28", new Guid("47a68fe2-cf37-463e-942b-49df237546d2"), "Street28" },
                    { new Guid("062a51ed-14d5-4f2f-bd83-26c0ae2ce919"), "City41", "County41", 41, "Affix41", "PostalCode41", new Guid("5801311e-ee54-47bd-9b93-18e45dcbf803"), "Street41" },
                    { new Guid("0a1120e6-58eb-4ab9-b283-d3f1d65d1135"), "City68", "County68", 68, "Affix68", "PostalCode68", new Guid("a3883238-1a10-415c-87f0-704473ec1304"), "Street68" },
                    { new Guid("0b06e800-bf7c-4d65-b00f-722f2280f5b9"), "Kristianstad", "Skåne", 18, "E", "291 30", new Guid("77113cee-6316-4ed3-8003-9eefa714d0fd"), "Blekingevägen" },
                    { new Guid("0d2d5dc7-f8d4-4303-a6b8-d46f5b6c7c37"), "City94", "County94", 94, "Affix94", "PostalCode94", new Guid("1ef18407-9ee2-46cb-91d4-a37c4149c58a"), "Street94" },
                    { new Guid("10077da3-e2f8-455c-abec-f3dbbec474a6"), "City82", "County82", 82, "Affix82", "PostalCode82", new Guid("255fadf6-824f-46ee-96ba-37873e36d50b"), "Street82" },
                    { new Guid("17904c24-97be-4bc0-9683-f410a86e81f2"), "City2", "County2", 2, "Affix2", "PostalCode2", new Guid("c91fe89e-1087-4cbc-8025-572b6ff1ab58"), "Street2" },
                    { new Guid("1b74c56a-01a5-4178-9bc1-6d29cda21284"), "City12", "County12", 12, "Affix12", "PostalCode12", new Guid("d8906712-f8ed-4c24-9a66-1390c1ebf808"), "Street12" },
                    { new Guid("1b95b7da-d76f-4250-aeb8-1ae8b09af2c0"), "City80", "County80", 80, "Affix80", "PostalCode80", new Guid("7d42e87d-62a8-4125-b105-abfa55d6b8b6"), "Street80" },
                    { new Guid("1cb50361-c189-4738-a666-f6f4098e131e"), "City70", "County70", 70, "Affix70", "PostalCode70", new Guid("a9442cdd-dcfe-4050-9e0b-9c095520abb0"), "Street70" },
                    { new Guid("1ddd9867-6a22-44c6-ada2-d13c91ed589e"), "City81", "County81", 81, "Affix81", "PostalCode81", new Guid("7dce2f61-d516-47f1-8ce4-a42be76e6893"), "Street81" },
                    { new Guid("1f3ddc93-2613-4a78-bb84-d415c5580ebf"), "City87", "County87", 87, "Affix87", "PostalCode87", new Guid("185ad2c0-5b81-4c7d-acd8-aea73c975678"), "Street87" },
                    { new Guid("20176077-ff0a-4eb9-a36a-ac32568c9237"), "City45", "County45", 45, "Affix45", "PostalCode45", new Guid("35ab7183-5c5d-4322-8d06-bf5538944fcb"), "Street45" },
                    { new Guid("22d5cb8e-2042-4657-a9ea-78a92b27c9a7"), "City58", "County58", 58, "Affix58", "PostalCode58", new Guid("d3151a7e-93c5-4e1d-8049-7d582259d788"), "Street58" },
                    { new Guid("2bbe93b4-312f-4429-8194-635439f74a2f"), "City3", "County3", 3, "Affix3", "PostalCode3", new Guid("64d61a87-884f-4d96-99cf-bca559aa759a"), "Street3" },
                    { new Guid("2cc96c6f-2cdc-4571-9b75-0db79cb16cfe"), "City92", "County92", 92, "Affix92", "PostalCode92", new Guid("c4adfa34-16b2-4578-93e8-335690c6a465"), "Street92" },
                    { new Guid("2f5eac3a-258e-4b8c-9ed8-0f1cc54e27de"), "City76", "County76", 76, "Affix76", "PostalCode76", new Guid("10ee3493-0203-44b4-a696-6ce4b4b60bc2"), "Street76" },
                    { new Guid("32e593ea-0f73-46c5-b3d4-87cbaed47b54"), "City64", "County64", 64, "Affix64", "PostalCode64", new Guid("a7842dd8-ce6a-428f-ab81-6f52752f0ed3"), "Street64" },
                    { new Guid("33deb16c-6810-4e78-826d-1e6cbf83644e"), "City77", "County77", 77, "Affix77", "PostalCode77", new Guid("01c2e9e8-c00c-4efd-bfbd-425a1d68c7f7"), "Street77" },
                    { new Guid("34be234a-b0de-4a67-9bbf-43878d01fe61"), "City91", "County91", 91, "Affix91", "PostalCode91", new Guid("b186ac54-20f7-4049-9a0a-7af63a89c23a"), "Street91" },
                    { new Guid("35243ed4-a4d3-42d5-ac2b-d21f67266c3e"), "City46", "County46", 46, "Affix46", "PostalCode46", new Guid("1f1465e6-455f-42c4-a354-0d5a2b33bb9f"), "Street46" },
                    { new Guid("38a092d1-f889-4b0a-8a2d-5cbc1dd85ce4"), "City75", "County75", 75, "Affix75", "PostalCode75", new Guid("bb764df7-8d5d-469e-b7d4-e81c0ebdefd7"), "Street75" },
                    { new Guid("3b4f4b57-67b8-4307-a1cb-cc3cc5f363b9"), "City90", "County90", 90, "Affix90", "PostalCode90", new Guid("3a8a0634-bd3a-4102-b43a-37293dd03640"), "Street90" },
                    { new Guid("3b521757-802a-4d96-99ce-827490cfb268"), "City50", "County50", 50, "Affix50", "PostalCode50", new Guid("1869dd80-1931-4220-8037-be8d33d4c937"), "Street50" },
                    { new Guid("3b915c92-bba9-48d4-84d5-c142f92a4d25"), "Kristianstad", "Skåne", 7, "B", "291 21", new Guid("dc69538b-3542-4177-bb33-498a2c4b3a91"), "Kanalgatan" },
                    { new Guid("409e42f6-79a8-4978-b34c-d2376ed4db94"), "City34", "County34", 34, "Affix34", "PostalCode34", new Guid("8f2e3885-1384-4267-9b32-531dd3a2ac0a"), "Street34" },
                    { new Guid("41e55712-126a-4ca6-91d3-3e096e77c9f3"), "City32", "County32", 32, "Affix32", "PostalCode32", new Guid("34c08e67-22df-44bd-b6f0-e248b158b27e"), "Street32" },
                    { new Guid("444dfb7d-8244-4260-8a79-ff04c6099b79"), "City20", "County20", 20, "Affix20", "PostalCode20", new Guid("e3567842-f65e-4937-915b-9febd0a89b63"), "Street20" },
                    { new Guid("4f367d14-6b81-4b00-8067-4b7049b05d30"), "City99", "County99", 99, "Affix99", "PostalCode99", new Guid("60852f97-7cfd-443b-b5d5-90799f377f2b"), "Street99" },
                    { new Guid("4ff2815b-e2a6-4c90-b81d-906640a9cd8d"), "City27", "County27", 27, "Affix27", "PostalCode27", new Guid("d2011010-2ee9-426b-acbf-e5d9c54bd89e"), "Street27" },
                    { new Guid("51034e00-fd6d-4b4c-a113-a2399c8b33b9"), "City49", "County49", 49, "Affix49", "PostalCode49", new Guid("65a84d51-542b-4142-b62e-2a41389c0fd9"), "Street49" },
                    { new Guid("51ea9169-f03f-468f-9f13-58cda97564de"), "City15", "County15", 15, "Affix15", "PostalCode15", new Guid("2cc1789f-6974-4e5a-9f41-275abdff7db7"), "Street15" },
                    { new Guid("54258afe-f342-4f88-89d1-4644b37679b8"), "City86", "County86", 86, "Affix86", "PostalCode86", new Guid("abdb7250-b651-44e3-9169-b53dd20dd91a"), "Street86" },
                    { new Guid("5823d3e2-2a6a-4986-99d8-2a6b3e00a16b"), "City69", "County69", 69, "Affix69", "PostalCode69", new Guid("cb90ae97-7e0f-406e-a543-34595c6b477b"), "Street69" },
                    { new Guid("5d014d45-7b83-4aef-9c2a-cd26a17ad076"), "City29", "County29", 29, "Affix29", "PostalCode29", new Guid("3ad50a9d-7db7-4d55-9d6c-24d39bc6ea10"), "Street29" },
                    { new Guid("627ee412-37e9-4132-9f9a-a191bfac9af7"), "City13", "County13", 13, "Affix13", "PostalCode13", new Guid("8556e4e8-5f80-45b5-9f17-0fa09ff965c5"), "Street13" },
                    { new Guid("68742f71-ece8-41c7-8549-732d7a4035df"), "City72", "County72", 72, "Affix72", "PostalCode72", new Guid("6e0936e9-4919-444a-83fd-d404f89880ab"), "Street72" },
                    { new Guid("689b5891-ba6e-40c1-9109-0d9594e00a83"), "City93", "County93", 93, "Affix93", "PostalCode93", new Guid("0e0af672-3e59-4ce4-aeee-f21b331cbedf"), "Street93" },
                    { new Guid("6b9070a7-cee7-4021-8e93-a4190ecaccaa"), "City17", "County17", 17, "Affix17", "PostalCode17", new Guid("371f4e36-3b3a-494c-90d9-f9edb241875a"), "Street17" },
                    { new Guid("6ba22b8d-4131-4304-916e-dbf7d4a5ee8f"), "City5", "County5", 5, "Affix5", "PostalCode5", new Guid("84a9cb58-0e2e-41ee-9491-9fd9c66961e2"), "Street5" },
                    { new Guid("6ba49605-cf3a-49c2-985a-212b03a988bc"), "City62", "County62", 62, "Affix62", "PostalCode62", new Guid("9a4c9521-4297-470a-8674-da194933753f"), "Street62" },
                    { new Guid("6bdaa7f2-e776-4400-8506-42ae2f5b8567"), "City51", "County51", 51, "Affix51", "PostalCode51", new Guid("50802b4a-b9f3-42b5-86f2-72bf31b8020c"), "Street51" },
                    { new Guid("6cc8bdd6-dbbd-4606-93b6-2f108f4fb093"), "City18", "County18", 18, "Affix18", "PostalCode18", new Guid("0548ac38-fb56-414b-a7bb-34b388d24fda"), "Street18" },
                    { new Guid("6cfe00cb-210c-4b8b-adbf-607069a403ac"), "City9", "County9", 9, "Affix9", "PostalCode9", new Guid("111a70a6-ada3-4e11-9dbd-627cab46c20e"), "Street9" },
                    { new Guid("6d09fecb-569a-4dcf-ab87-0b79c3ccac02"), "City53", "County53", 53, "Affix53", "PostalCode53", new Guid("6128c816-581b-451e-a372-380afe214b87"), "Street53" },
                    { new Guid("6d0ca51f-23af-4f39-adb7-34cceb74b142"), "City8", "County8", 8, "Affix8", "PostalCode8", new Guid("72afcbf9-0685-4b47-9232-ead42f0a2504"), "Street8" },
                    { new Guid("6d5b35b6-f6ef-45ec-8b0b-b2a098f66bd8"), "City26", "County26", 26, "Affix26", "PostalCode26", new Guid("7ec1d871-eda7-4c8f-9364-e150c6ecf964"), "Street26" },
                    { new Guid("6fbe2ab3-865c-4a1e-a313-a30867525a4f"), "City67", "County67", 67, "Affix67", "PostalCode67", new Guid("bc98d803-b2c0-46eb-939d-abfb4b9cd855"), "Street67" },
                    { new Guid("717149d9-8e19-4fd0-bd5f-16e9856cf474"), "City42", "County42", 42, "Affix42", "PostalCode42", new Guid("79c1e98b-a78e-4262-9e96-f8dd48b3a70d"), "Street42" },
                    { new Guid("7d07a40b-fa13-4235-86b9-0d9f193d2da9"), "City63", "County63", 63, "Affix63", "PostalCode63", new Guid("8ae80374-e67c-4087-9780-78ce18d9f26b"), "Street63" },
                    { new Guid("7f8316cb-eb2d-4371-9373-9e32b52548a6"), "City95", "County95", 95, "Affix95", "PostalCode95", new Guid("0eab19a9-f66a-4197-949a-ece2caa43be5"), "Street95" },
                    { new Guid("7fd1259e-16c3-4950-b5f9-76f6589b1320"), "City84", "County84", 84, "Affix84", "PostalCode84", new Guid("04ff204a-bc45-44dc-b814-aae8b1f5ca90"), "Street84" },
                    { new Guid("84f81c34-d149-4b3d-aead-c18175b93e29"), "City44", "County44", 44, "Affix44", "PostalCode44", new Guid("f44c808f-a1b5-4535-81e9-51ab2a762492"), "Street44" },
                    { new Guid("874a59f2-152c-445d-ba40-aabc32a947bc"), "City71", "County71", 71, "Affix71", "PostalCode71", new Guid("488198be-adb2-4082-8e4b-8577de525262"), "Street71" },
                    { new Guid("87da7c56-4263-4a73-8b36-9d8279def455"), "City36", "County36", 36, "Affix36", "PostalCode36", new Guid("fef297e2-b20f-42cf-a644-28282ddf422d"), "Street36" },
                    { new Guid("88438316-b32c-4410-8677-a51f54b4f9ac"), "City19", "County19", 19, "Affix19", "PostalCode19", new Guid("c063aae7-e5d0-45e6-bf63-49cef87a16b0"), "Street19" },
                    { new Guid("8d56fcc7-a016-4168-965a-e565aec196e0"), "City96", "County96", 96, "Affix96", "PostalCode96", new Guid("da2412f5-143f-46b9-a077-67773ba4b1c0"), "Street96" },
                    { new Guid("8e592218-4acd-4c2b-8fd5-8e237bd0d6d1"), "City37", "County37", 37, "Affix37", "PostalCode37", new Guid("e752f5aa-4563-425a-9cb1-b4e493e2533e"), "Street37" },
                    { new Guid("8e754995-917e-433e-b898-7ef580f21ad7"), "City22", "County22", 22, "Affix22", "PostalCode22", new Guid("018e0164-a8be-45a8-9188-6e38fc7b0049"), "Street22" },
                    { new Guid("90c61fb3-f887-45fc-8dbc-188347b0e9d9"), "City74", "County74", 74, "Affix74", "PostalCode74", new Guid("0f27d0cc-93a5-41c3-89e4-d08dc30f3694"), "Street74" },
                    { new Guid("94e8c374-8463-4c31-97ab-1d8faeab7006"), "City1", "County1", 1, "Affix1", "PostalCode1", new Guid("b75ed543-7c13-4122-bd0d-b25eb6ae87f7"), "Street1" },
                    { new Guid("95bab15c-8476-4f88-83e3-a4541b4b41da"), "City83", "County83", 83, "Affix83", "PostalCode83", new Guid("1fd0b382-5097-45f6-9894-d39a5ed2b214"), "Street83" },
                    { new Guid("982268e5-d06a-4453-8f15-1c38169cd0a1"), "City16", "County16", 16, "Affix16", "PostalCode16", new Guid("1565c576-0b4f-4254-9b92-5235b00160d7"), "Street16" },
                    { new Guid("9a2804a5-2c2a-47c5-86d7-7d518ea1733d"), "City11", "County11", 11, "Affix11", "PostalCode11", new Guid("6b6b4fb0-0591-4984-bccf-dad882bf78b0"), "Street11" },
                    { new Guid("9abae042-a328-4a3e-a5f2-34aee402e0e9"), "City100", "County100", 100, "Affix100", "PostalCode100", new Guid("4f4a7502-b199-43da-8964-798fca0bed02"), "Street100" },
                    { new Guid("9aca83b4-cd05-4cdf-ae47-80636465558f"), "City48", "County48", 48, "Affix48", "PostalCode48", new Guid("201aa1bd-262c-46f4-b7c2-2f2d719ce594"), "Street48" },
                    { new Guid("9c281f99-5f95-443f-b9ac-833a83ce381d"), "City24", "County24", 24, "Affix24", "PostalCode24", new Guid("c2e78631-0c88-4229-aeab-fc27fab9682f"), "Street24" },
                    { new Guid("a3082af0-7b1c-4c0f-8daa-4c3e5753129d"), "City39", "County39", 39, "Affix39", "PostalCode39", new Guid("5cda4284-9a37-4829-8e7a-79bf48c75362"), "Street39" },
                    { new Guid("a4611326-da5e-48dd-a8ed-bcf03b7618dd"), "City59", "County59", 59, "Affix59", "PostalCode59", new Guid("83b908c5-8cd1-4347-ba21-2525781633b7"), "Street59" },
                    { new Guid("a4619a8d-1a43-4b84-aa1e-e02da987072e"), "City6", "County6", 6, "Affix6", "PostalCode6", new Guid("88d0f32f-a6e8-4b59-8a5c-86cc43f820af"), "Street6" },
                    { new Guid("a6fa3d08-ea59-42df-954c-fa950c9eae55"), "City21", "County21", 21, "Affix21", "PostalCode21", new Guid("98df1ed4-74fc-4285-90aa-32785b444b34"), "Street21" },
                    { new Guid("a80b0758-900b-4a10-a487-7595f28bcdf7"), "City79", "County79", 79, "Affix79", "PostalCode79", new Guid("9086598c-a91a-4370-b9c0-d87e5af86a2b"), "Street79" },
                    { new Guid("aaa0c6e1-30d5-40ad-bcc3-b3c9c77a0914"), "City98", "County98", 98, "Affix98", "PostalCode98", new Guid("d05f8209-67e8-4e7d-8dbe-b6accafe7a7b"), "Street98" },
                    { new Guid("ab0794f2-5df3-4061-8328-b2d112a13f0d"), "City38", "County38", 38, "Affix38", "PostalCode38", new Guid("71e31428-907f-42fd-98d8-45d2fa8963b0"), "Street38" },
                    { new Guid("acec9be6-6710-48df-a432-9a6d92e411ee"), "City56", "County56", 56, "Affix56", "PostalCode56", new Guid("a086b006-5adb-4c10-974c-4ead08fcaee4"), "Street56" },
                    { new Guid("b1e70dd0-5bad-4ef1-8945-ff03ca919baa"), "Kristianstad", "Skåne", 12, "C", "291 50", new Guid("5eba581f-1428-4630-bc95-f3e1b6ae02ca"), "Snapphanevägen" },
                    { new Guid("b4fdb859-7d19-4772-ace3-60748f121e9b"), "City52", "County52", 52, "Affix52", "PostalCode52", new Guid("b2950442-2aa6-450d-8d58-8a3124a599f5"), "Street52" },
                    { new Guid("be90d8d7-4c86-4a2a-9fa6-2a7515038cbf"), "City89", "County89", 89, "Affix89", "PostalCode89", new Guid("d1829ce4-74ad-448d-b5fe-df5c3c90ce75"), "Street89" },
                    { new Guid("c2974612-5312-4498-bdbd-f342bce78334"), "City4", "County4", 4, "Affix4", "PostalCode4", new Guid("9173c8ae-5211-4677-a36b-ab3a60380674"), "Street4" },
                    { new Guid("c55be2cb-c0aa-4c01-9298-5919a67508f3"), "City78", "County78", 78, "Affix78", "PostalCode78", new Guid("3f7e804c-2fdd-480f-8c30-4b04efe6b1e5"), "Street78" },
                    { new Guid("c623a7c8-783b-44d3-a526-611ac77b9ec0"), "City55", "County55", 55, "Affix55", "PostalCode55", new Guid("d8a7d1c3-31bb-474d-9b5a-c87d1cd07c9c"), "Street55" },
                    { new Guid("c911d7c2-fe1f-40e3-9e33-db7753d17804"), "City54", "County54", 54, "Affix54", "PostalCode54", new Guid("a184d9e2-1679-45e3-888e-2623f25aa6db"), "Street54" },
                    { new Guid("cc7c5b4e-563f-42c3-97c5-e215ffdd0d3d"), "City35", "County35", 35, "Affix35", "PostalCode35", new Guid("88df6afd-82d0-4790-bb49-1b189f9fd5d8"), "Street35" },
                    { new Guid("ce3b8db3-72f7-4223-a4f3-59d4c8fe1918"), "City7", "County7", 7, "Affix7", "PostalCode7", new Guid("4d4fa242-a3d3-4c79-8600-73f189efe9c9"), "Street7" },
                    { new Guid("d051404a-cc0c-4adb-8aaf-97ed68b80590"), "City10", "County10", 10, "Affix10", "PostalCode10", new Guid("47a42ad6-c83f-4891-b48c-7114086d64eb"), "Street10" },
                    { new Guid("d25df32d-7b79-4fcb-b123-175781e7cff0"), "City43", "County43", 43, "Affix43", "PostalCode43", new Guid("2832d5f0-5ebe-4d8a-9e4d-9377b4b9bde6"), "Street43" },
                    { new Guid("d3371a33-0301-49f3-860b-5786ccee7c05"), "City66", "County66", 66, "Affix66", "PostalCode66", new Guid("ea93a71b-cd19-4694-8047-38fbdf54e323"), "Street66" },
                    { new Guid("d8e34a5a-9fca-4579-b750-95826f8a3c36"), "City33", "County33", 33, "Affix33", "PostalCode33", new Guid("3e741619-63e8-458e-b746-9196675790e6"), "Street33" },
                    { new Guid("e2bf559a-f4b2-45b3-af84-b9371119ea22"), "City47", "County47", 47, "Affix47", "PostalCode47", new Guid("492ead94-2740-48a5-9c6c-78cedc0ddaa9"), "Street47" },
                    { new Guid("e61593ae-3c04-461a-a79d-1e5cf1719bb5"), "City30", "County30", 30, "Affix30", "PostalCode30", new Guid("daa016e6-2ec5-42ea-ae96-b4c49e638c16"), "Street30" },
                    { new Guid("e7c788a9-4f83-4d6a-8c1d-1c44b91ca869"), "City97", "County97", 97, "Affix97", "PostalCode97", new Guid("25267bbb-b782-4120-90fb-42b5783fa1f7"), "Street97" },
                    { new Guid("f0ed1981-742c-4210-ace4-13c30e2a3985"), "City88", "County88", 88, "Affix88", "PostalCode88", new Guid("738fd426-8cbb-406c-9490-edb0a1f28099"), "Street88" },
                    { new Guid("f4310135-70af-4b06-8374-d1fc38f41ccb"), "City65", "County65", 65, "Affix65", "PostalCode65", new Guid("d36de261-6b13-474d-910e-13824d27fa63"), "Street65" },
                    { new Guid("f4cea2ba-8e20-4326-b76e-7472134b84c8"), "City85", "County85", 85, "Affix85", "PostalCode85", new Guid("f14ece19-5e98-4541-8d1c-596596a443ff"), "Street85" },
                    { new Guid("f847274f-e14c-4e3a-8ef5-11aebdc530e2"), "City40", "County40", 40, "Affix40", "PostalCode40", new Guid("acad94ff-d851-4e4f-baff-6bc2904a5b52"), "Street40" },
                    { new Guid("fbc7ca73-53fe-4544-b5c7-0db19c287c19"), "City25", "County25", 25, "Affix25", "PostalCode25", new Guid("98cf088d-7266-4dbc-b210-ad9dcf63f4da"), "Street25" },
                    { new Guid("fc11979f-8483-4cd9-b5f1-387e874a6f51"), "City57", "County57", 57, "Affix57", "PostalCode57", new Guid("9e29b3ec-63f0-4b99-9d9d-d50da43b951b"), "Street57" },
                    { new Guid("fc7254d4-46ef-4c97-bc68-0dc082f9c51c"), "City31", "County31", 31, "Affix31", "PostalCode31", new Guid("0efa2bb5-f3a0-48e5-84e4-260c723a6ea2"), "Street31" },
                    { new Guid("fca0995b-80b1-434d-8d2a-1d9f751e5b1e"), "City61", "County61", 61, "Affix61", "PostalCode61", new Guid("47297899-b466-41e6-8707-f3874a435d1c"), "Street61" },
                    { new Guid("ff7bb48f-7905-4fd4-b524-cd330d07f62b"), "City14", "County14", 14, "Affix14", "PostalCode14", new Guid("fd677cf2-844c-4397-9867-39ca92e75246"), "Street14" },
                    { new Guid("ffb1b02d-b552-4992-9fe9-a5c98e10f98f"), "City73", "County73", 73, "Affix73", "PostalCode73", new Guid("0f564446-2820-4641-a6c5-2fc14cfb5a7f"), "Street73" }
                });

            migrationBuilder.InsertData(
                table: "Appartments",
                columns: new[] { "Id", "AddressId", "AdvertId", "LMNumber", "ObjectNumber", "PropertyId", "QueueRuleId" },
                values: new object[,]
                {
                    { new Guid("03987f25-fb84-4ab9-a35e-fc101251bdff"), new Guid("e2bf559a-f4b2-45b3-af84-b9371119ea22"), new Guid("dcb0bf87-f672-4119-b0df-42288a440ddd"), 47, "ObjectNumber47", new Guid("492ead94-2740-48a5-9c6c-78cedc0ddaa9"), new Guid("f669ae3c-fb09-44b2-98d4-2bfc9a597681") },
                    { new Guid("0506d95b-99c5-42e4-b6a4-4987668627b0"), new Guid("c2974612-5312-4498-bdbd-f342bce78334"), new Guid("6cd21d87-995a-4e42-a308-be1e03252545"), 4, "ObjectNumber4", new Guid("9173c8ae-5211-4677-a36b-ab3a60380674"), new Guid("4ab72c15-be38-46f6-9c12-e13a7c15680c") },
                    { new Guid("068444ac-d349-4ca2-bf31-e45b3e2f92bb"), new Guid("6b9070a7-cee7-4021-8e93-a4190ecaccaa"), new Guid("d3ed39a2-e9d3-44b6-8aa7-86c893e5d007"), 17, "ObjectNumber17", new Guid("371f4e36-3b3a-494c-90d9-f9edb241875a"), new Guid("8639a985-d804-4af3-b505-a6983ee8612d") },
                    { new Guid("0c2f8d1f-dd11-4df2-8a9a-6077290baae1"), new Guid("9c281f99-5f95-443f-b9ac-833a83ce381d"), new Guid("96de96b0-640d-482b-817f-7d962f3c8f33"), 24, "ObjectNumber24", new Guid("c2e78631-0c88-4229-aeab-fc27fab9682f"), new Guid("25790cea-85de-480c-9447-00efa7b63899") },
                    { new Guid("0dd3f3ab-74dd-469f-adfd-18830e94eb7d"), new Guid("17904c24-97be-4bc0-9683-f410a86e81f2"), new Guid("e3d40c7f-cdba-4f67-818c-7d490e8adc32"), 2, "ObjectNumber2", new Guid("c91fe89e-1087-4cbc-8025-572b6ff1ab58"), new Guid("0ac92777-d319-4812-b465-d0cda30124c4") },
                    { new Guid("14cd7698-66de-4043-8fd6-a5e5e033438d"), new Guid("ce3b8db3-72f7-4223-a4f3-59d4c8fe1918"), new Guid("4b4e5b68-7bfa-40f4-84e4-3f1d2e995b2d"), 7, "ObjectNumber7", new Guid("4d4fa242-a3d3-4c79-8600-73f189efe9c9"), new Guid("949a5c00-8573-432c-8e3c-4a5bbe2a11d9") },
                    { new Guid("186958af-3dcc-442d-8cbd-5c33674b8f1b"), new Guid("88438316-b32c-4410-8677-a51f54b4f9ac"), new Guid("1045918b-4078-49e0-895a-82fe06c26b98"), 19, "ObjectNumber19", new Guid("c063aae7-e5d0-45e6-bf63-49cef87a16b0"), new Guid("cbdb0773-58f6-487f-99ae-3e634bb45378") },
                    { new Guid("1925ef51-c453-4f86-aff8-8e164b8af0bd"), new Guid("d051404a-cc0c-4adb-8aaf-97ed68b80590"), new Guid("485be465-99b8-48cc-9917-d084d1949557"), 10, "ObjectNumber10", new Guid("47a42ad6-c83f-4891-b48c-7114086d64eb"), new Guid("62a9708d-448a-4b92-86dd-29d7f973f8f8") },
                    { new Guid("1af6d694-b2fe-4d13-90b2-8aeec8d3692a"), new Guid("d25df32d-7b79-4fcb-b123-175781e7cff0"), new Guid("d1f4f139-d3c6-4fe7-a3d3-43140e48cdb3"), 43, "ObjectNumber43", new Guid("2832d5f0-5ebe-4d8a-9e4d-9377b4b9bde6"), new Guid("97a0ed20-e860-4db1-b092-e6709b09d082") },
                    { new Guid("20f20e6c-305e-4ab5-b9b6-fc54683fe171"), new Guid("a80b0758-900b-4a10-a487-7595f28bcdf7"), new Guid("89c22122-0531-48e4-88af-ab44eb7b0d81"), 79, "ObjectNumber79", new Guid("9086598c-a91a-4370-b9c0-d87e5af86a2b"), new Guid("733c2caf-4930-4fc0-a0dd-1c394b93d3df") },
                    { new Guid("213c995a-0463-4030-aa10-227b39e989e7"), new Guid("3b915c92-bba9-48d4-84d5-c142f92a4d25"), null, 345612, "9876-5432", new Guid("77113cee-6316-4ed3-8003-9eefa714d0fd"), new Guid("6055f821-bf36-4a3a-981d-3e80236adcb0") },
                    { new Guid("2157c218-ea30-4c3c-b305-c1586d6da54a"), new Guid("35243ed4-a4d3-42d5-ac2b-d21f67266c3e"), new Guid("66d373e8-93f3-40d2-9cce-f1de2d414818"), 46, "ObjectNumber46", new Guid("1f1465e6-455f-42c4-a354-0d5a2b33bb9f"), new Guid("417b8bf6-9855-426b-a9e4-72f58e4338f7") },
                    { new Guid("253879ed-713f-44e1-9240-73b8ce780aa4"), new Guid("1f3ddc93-2613-4a78-bb84-d415c5580ebf"), new Guid("b23a7fed-b4b9-42d0-98dd-5e6596628032"), 87, "ObjectNumber87", new Guid("185ad2c0-5b81-4c7d-acd8-aea73c975678"), new Guid("b24217c5-bf15-4c44-adad-a6b1a4954b0c") },
                    { new Guid("26b86c9f-c07e-4151-bb17-b9018cc9e57e"), new Guid("d8e34a5a-9fca-4579-b750-95826f8a3c36"), new Guid("74f01103-9df4-4b5f-bfa4-c403518702f8"), 33, "ObjectNumber33", new Guid("3e741619-63e8-458e-b746-9196675790e6"), new Guid("d744d714-3a97-4c88-820d-420f248d923f") },
                    { new Guid("26d2294c-ba02-4faa-b3c4-e6c50e57c744"), new Guid("38a092d1-f889-4b0a-8a2d-5cbc1dd85ce4"), new Guid("12a82468-cd0c-4caa-b521-eca9a04a5d15"), 75, "ObjectNumber75", new Guid("bb764df7-8d5d-469e-b7d4-e81c0ebdefd7"), new Guid("70400a90-918c-4362-a4ed-c518c1b7d906") },
                    { new Guid("2709acab-f933-4559-8a56-baf7f3fabaf1"), new Guid("062a51ed-14d5-4f2f-bd83-26c0ae2ce919"), new Guid("fa28b197-6d63-4b63-8907-399c595072b9"), 41, "ObjectNumber41", new Guid("5801311e-ee54-47bd-9b93-18e45dcbf803"), new Guid("baf6c58c-14f4-4818-bb77-37680f7a5095") },
                    { new Guid("2719b397-5f9f-4769-99c6-86ecdacf6f51"), new Guid("8e592218-4acd-4c2b-8fd5-8e237bd0d6d1"), new Guid("4ae334d1-768a-4a06-bebf-c4f370ca7ccf"), 37, "ObjectNumber37", new Guid("e752f5aa-4563-425a-9cb1-b4e493e2533e"), new Guid("08be4494-dccb-42e2-89c1-e1870948f6d7") },
                    { new Guid("2847fb1c-fdd2-4eeb-b4c5-d81c4a577791"), new Guid("6ba49605-cf3a-49c2-985a-212b03a988bc"), new Guid("2ac630d8-8b0d-47e0-b7de-56c9dd9768ff"), 62, "ObjectNumber62", new Guid("9a4c9521-4297-470a-8674-da194933753f"), new Guid("90f77380-a9b4-4b1b-b48a-0404aba4cd07") },
                    { new Guid("290c550f-57e3-422d-afbf-af957f1a78a8"), new Guid("1cb50361-c189-4738-a666-f6f4098e131e"), new Guid("062f93e5-9c35-4f5e-a9c7-6b4df37a649f"), 70, "ObjectNumber70", new Guid("a9442cdd-dcfe-4050-9e0b-9c095520abb0"), new Guid("bed00ae0-7e39-488f-aa9c-a12ecf8b3fbd") },
                    { new Guid("29b0d278-8b72-4965-a55e-6fd87a79ca7f"), new Guid("4f367d14-6b81-4b00-8067-4b7049b05d30"), new Guid("fe6b5334-96da-49e0-abc7-ce98a568824e"), 99, "ObjectNumber99", new Guid("60852f97-7cfd-443b-b5d5-90799f377f2b"), new Guid("d6f405b8-3d22-4b85-bf3e-f5fb0a291f76") },
                    { new Guid("2f7e3781-249b-43f9-a304-e7bfe97ce804"), new Guid("6cc8bdd6-dbbd-4606-93b6-2f108f4fb093"), new Guid("555adc5a-0eb3-4aed-bab2-729837176d13"), 18, "ObjectNumber18", new Guid("0548ac38-fb56-414b-a7bb-34b388d24fda"), new Guid("96781922-56ac-427a-b95d-f7b91031d053") },
                    { new Guid("31cafa80-66e8-4802-bff6-b41848e515b2"), new Guid("1ddd9867-6a22-44c6-ada2-d13c91ed589e"), new Guid("e1cff222-e321-4480-aecb-4343a31bbf9e"), 81, "ObjectNumber81", new Guid("7dce2f61-d516-47f1-8ce4-a42be76e6893"), new Guid("810c56d3-c486-44ac-ab7b-f1c4479c2717") },
                    { new Guid("384b15d9-35ec-4272-92ff-0616e4f72bc6"), new Guid("fc11979f-8483-4cd9-b5f1-387e874a6f51"), new Guid("72492eb5-a95c-4e03-92ef-83de19a5ee90"), 57, "ObjectNumber57", new Guid("9e29b3ec-63f0-4b99-9d9d-d50da43b951b"), new Guid("0de61fba-f055-4ded-a4a6-e723d18403c9") },
                    { new Guid("3ac6ea24-2b36-48b8-8811-d34476f0caca"), new Guid("34be234a-b0de-4a67-9bbf-43878d01fe61"), new Guid("7db2cb85-59e0-454a-bd81-0d9eb8152cc4"), 91, "ObjectNumber91", new Guid("b186ac54-20f7-4049-9a0a-7af63a89c23a"), new Guid("e0b66157-fd2e-4264-a9b8-d6b19bb68678") },
                    { new Guid("3b3d5d9a-6ecb-41f9-bcd7-e9427e3272d7"), new Guid("3b521757-802a-4d96-99ce-827490cfb268"), new Guid("1fd325c8-3a2a-48f3-bd1e-80b7b75bd1c1"), 50, "ObjectNumber50", new Guid("1869dd80-1931-4220-8037-be8d33d4c937"), new Guid("e13d1000-4132-484f-bc6f-7eaa960d47de") },
                    { new Guid("3c27f32a-2133-43a9-b390-fed5926d66a2"), new Guid("84f81c34-d149-4b3d-aead-c18175b93e29"), new Guid("c85ed558-2753-489b-b27b-1b0d2ec8a784"), 44, "ObjectNumber44", new Guid("f44c808f-a1b5-4535-81e9-51ab2a762492"), new Guid("08671ef2-1c11-4ff9-b32f-03e70b575e97") },
                    { new Guid("3c2c83d7-edc2-4433-8c9a-c1d6a2f153fa"), new Guid("1b95b7da-d76f-4250-aeb8-1ae8b09af2c0"), new Guid("b4092091-bfb0-4845-aff7-25102663e5ba"), 80, "ObjectNumber80", new Guid("7d42e87d-62a8-4125-b105-abfa55d6b8b6"), new Guid("d04ca83f-dea4-4870-8bd8-cdc504b15dd8") },
                    { new Guid("43ca1bf2-04c7-48ca-a692-19efdc7738aa"), new Guid("9abae042-a328-4a3e-a5f2-34aee402e0e9"), new Guid("3490e361-b4dd-4bed-b91b-00b0d293a1f5"), 100, "ObjectNumber100", new Guid("4f4a7502-b199-43da-8964-798fca0bed02"), new Guid("60e2da02-efc8-4b48-9e52-29548c36c377") },
                    { new Guid("4748363e-cef1-4e2c-bf3e-bdac87cb6494"), new Guid("a4619a8d-1a43-4b84-aa1e-e02da987072e"), new Guid("3910f085-4870-4875-be1f-e7cc798b5cfc"), 6, "ObjectNumber6", new Guid("88d0f32f-a6e8-4b59-8a5c-86cc43f820af"), new Guid("8885d65c-4211-44c8-ba15-8b48425f24f7") },
                    { new Guid("487b7c5a-26c2-478f-99b4-9ecd150bf5c2"), new Guid("f0ed1981-742c-4210-ace4-13c30e2a3985"), new Guid("ddfa721d-9fc5-432b-aad8-60f28117e3eb"), 88, "ObjectNumber88", new Guid("738fd426-8cbb-406c-9490-edb0a1f28099"), new Guid("e3a49177-27e4-4843-b201-f48d7dbb3c9c") },
                    { new Guid("4962345b-e0d1-44ee-bfbd-4162dc403dab"), new Guid("54258afe-f342-4f88-89d1-4644b37679b8"), new Guid("11c7bef7-7741-4dd5-aa8e-8ac8c5301cca"), 86, "ObjectNumber86", new Guid("abdb7250-b651-44e3-9169-b53dd20dd91a"), new Guid("06b987e0-17b6-41b9-9d08-f8d2790f9106") },
                    { new Guid("499fa113-f634-4a17-b30d-bf4e0ffb7569"), new Guid("94e8c374-8463-4c31-97ab-1d8faeab7006"), new Guid("74ab8ae1-9fc7-492d-86c8-7bf765f1fb51"), 1, "ObjectNumber1", new Guid("b75ed543-7c13-4122-bd0d-b25eb6ae87f7"), new Guid("c9ec33dc-2ce3-45f3-baba-7568dfc8a845") },
                    { new Guid("4a474f2b-0061-45c6-8f0b-23d953c549e5"), new Guid("aaa0c6e1-30d5-40ad-bcc3-b3c9c77a0914"), new Guid("5185cd0c-2d12-4d9f-b165-3f50e4c74367"), 98, "ObjectNumber98", new Guid("d05f8209-67e8-4e7d-8dbe-b6accafe7a7b"), new Guid("45236cd6-953a-430d-911c-89ed0419fabd") },
                    { new Guid("4ddcfda3-6d64-476d-a579-fc94450dde0e"), new Guid("fc7254d4-46ef-4c97-bc68-0dc082f9c51c"), new Guid("72b6a217-72b2-4e48-a023-f7072beb7937"), 31, "ObjectNumber31", new Guid("0efa2bb5-f3a0-48e5-84e4-260c723a6ea2"), new Guid("a8dd5527-c3a6-4a2a-a6b8-8a48a1f62291") },
                    { new Guid("4f0d7cc4-41fd-4f2a-ad57-2b7cc0db5df8"), new Guid("7fd1259e-16c3-4950-b5f9-76f6589b1320"), new Guid("bb21a316-ebff-42ac-b872-8dbdc25621e6"), 84, "ObjectNumber84", new Guid("04ff204a-bc45-44dc-b814-aae8b1f5ca90"), new Guid("209bea85-0fd7-4244-a9a6-8be4d433262e") },
                    { new Guid("507497af-8c07-49d6-aa71-97485bdc5664"), new Guid("689b5891-ba6e-40c1-9109-0d9594e00a83"), new Guid("d52f605c-4da9-4c5f-bbcd-4a0acdaaa36b"), 93, "ObjectNumber93", new Guid("0e0af672-3e59-4ce4-aeee-f21b331cbedf"), new Guid("f6134a9f-a9bd-4f14-9c61-25fc4b408765") },
                    { new Guid("578a6940-eede-485e-9561-0c5dd6f2b499"), new Guid("5d014d45-7b83-4aef-9c2a-cd26a17ad076"), new Guid("afef5ef4-ce37-4612-bd62-9d63a8a993cf"), 29, "ObjectNumber29", new Guid("3ad50a9d-7db7-4d55-9d6c-24d39bc6ea10"), new Guid("5cda885c-7e58-4034-8bdf-130db37cae4f") },
                    { new Guid("58cee606-0e1c-42d2-b7e9-9dc1dd57cf42"), new Guid("055e7e37-aaf2-428f-9339-a8935728cce9"), new Guid("c71ce016-987f-4e57-bea4-0f32bf76dd80"), 28, "ObjectNumber28", new Guid("47a68fe2-cf37-463e-942b-49df237546d2"), new Guid("d061e0ce-d8fc-43a8-acd3-11657ac01d11") },
                    { new Guid("58d85811-70c7-46b8-82e7-92ba195e7cd3"), new Guid("33deb16c-6810-4e78-826d-1e6cbf83644e"), new Guid("816d7e49-c15c-48da-ae3b-29e71a777ef2"), 77, "ObjectNumber77", new Guid("01c2e9e8-c00c-4efd-bfbd-425a1d68c7f7"), new Guid("c0757928-1236-4695-9328-d6a630511f65") },
                    { new Guid("59345086-b13e-4d24-8955-c71de4441b6f"), new Guid("8d56fcc7-a016-4168-965a-e565aec196e0"), new Guid("44cb27e6-a60a-43fd-a7c7-9064699e6abd"), 96, "ObjectNumber96", new Guid("da2412f5-143f-46b9-a077-67773ba4b1c0"), new Guid("1fe465ef-2452-43c3-845e-69840f9bef8b") },
                    { new Guid("59766959-02d9-4c87-b411-8698a7be5fe5"), new Guid("e7c788a9-4f83-4d6a-8c1d-1c44b91ca869"), new Guid("f6cae55a-58c5-4c85-a138-b33f10ebf70b"), 97, "ObjectNumber97", new Guid("25267bbb-b782-4120-90fb-42b5783fa1f7"), new Guid("af6a129a-4c11-4d3d-9648-5ac1d7f6a87c") },
                    { new Guid("5f39aa6a-1f5f-4469-98db-7a98ee86aaed"), new Guid("013fa90b-eaf9-4800-9afd-a9d34a82f8b8"), new Guid("3075ca0f-4c8c-4a1a-b290-ed247f99672f"), 60, "ObjectNumber60", new Guid("91548d99-a557-4422-8280-a5857c85fa1f"), new Guid("f1316c60-6e87-4639-a17d-e6cd44eb3cdd") },
                    { new Guid("60b2a0ed-65bb-4499-8df8-007ceedbe891"), new Guid("fca0995b-80b1-434d-8d2a-1d9f751e5b1e"), new Guid("eda5ac9f-7a5d-4576-b0ef-7b9c854da142"), 61, "ObjectNumber61", new Guid("47297899-b466-41e6-8707-f3874a435d1c"), new Guid("33facd90-b0b6-4feb-8452-f19647126948") },
                    { new Guid("616fa6d1-8da1-488c-91f5-bd1ed0d1a54d"), new Guid("a3082af0-7b1c-4c0f-8daa-4c3e5753129d"), new Guid("afc2b7a9-2bf2-4202-9357-b68b7a196679"), 39, "ObjectNumber39", new Guid("5cda4284-9a37-4829-8e7a-79bf48c75362"), new Guid("e6632e38-cbd7-4431-b74f-54ff1dc61c67") },
                    { new Guid("61e15752-00f0-4065-ae39-f070b0cfe6e0"), new Guid("4ff2815b-e2a6-4c90-b81d-906640a9cd8d"), new Guid("d8f3f81d-7d15-48ba-a6c1-f46f40399cde"), 27, "ObjectNumber27", new Guid("d2011010-2ee9-426b-acbf-e5d9c54bd89e"), new Guid("211160c7-cf50-441e-9982-7e467ac067db") },
                    { new Guid("632a3822-a27a-44c0-a433-574f1d7cdf8b"), new Guid("cc7c5b4e-563f-42c3-97c5-e215ffdd0d3d"), new Guid("a9b94b3c-6a60-43cd-a141-6dacd9740247"), 35, "ObjectNumber35", new Guid("88df6afd-82d0-4790-bb49-1b189f9fd5d8"), new Guid("f3fe298f-914b-4e28-847c-dcb62d7c4f4d") },
                    { new Guid("67ad64df-3402-405a-bde9-66664ec9f539"), new Guid("1b74c56a-01a5-4178-9bc1-6d29cda21284"), new Guid("99b6d9b6-b5d2-4079-a6ff-db00cdcf018d"), 12, "ObjectNumber12", new Guid("d8906712-f8ed-4c24-9a66-1390c1ebf808"), new Guid("f95f22cd-412a-48ae-832b-1b31e1a35f65") },
                    { new Guid("67e97730-fc27-4739-bba7-ea79c9fa2da8"), new Guid("95bab15c-8476-4f88-83e3-a4541b4b41da"), new Guid("9ebba8b5-56cb-4bc8-86a0-26bdd237cc5b"), 83, "ObjectNumber83", new Guid("1fd0b382-5097-45f6-9894-d39a5ed2b214"), new Guid("c1831627-c34f-48ad-b549-7d19c667e781") },
                    { new Guid("68abfd36-d114-4c86-8801-40d797f8e866"), new Guid("b4fdb859-7d19-4772-ace3-60748f121e9b"), new Guid("032bde09-a19e-4de6-9cda-be1ed6fb437d"), 52, "ObjectNumber52", new Guid("b2950442-2aa6-450d-8d58-8a3124a599f5"), new Guid("3586dc13-d20d-4bd9-bb47-387c57aabefb") },
                    { new Guid("6ac20920-cd7d-430f-a7f6-b03b80c3266b"), new Guid("e61593ae-3c04-461a-a79d-1e5cf1719bb5"), new Guid("ee2fc237-3772-4564-83d8-fe87e9fe0860"), 30, "ObjectNumber30", new Guid("daa016e6-2ec5-42ea-ae96-b4c49e638c16"), new Guid("8d239909-68cd-4af3-9907-282476d6a17f") },
                    { new Guid("6ed4b4cd-31d9-4c59-a4f2-9352255c9997"), new Guid("7d07a40b-fa13-4235-86b9-0d9f193d2da9"), new Guid("d7657b3d-e0a4-4d7f-b5e5-a12f33bfb866"), 63, "ObjectNumber63", new Guid("8ae80374-e67c-4087-9780-78ce18d9f26b"), new Guid("7c7aa9e0-a0b1-4932-aa0d-f6aa6eb8bf26") },
                    { new Guid("6fcc063f-3a52-473c-a7a0-13a930522011"), new Guid("51ea9169-f03f-468f-9f13-58cda97564de"), new Guid("0f1247e4-ca93-4039-86f7-5580913177ed"), 15, "ObjectNumber15", new Guid("2cc1789f-6974-4e5a-9f41-275abdff7db7"), new Guid("874efec8-3e04-4bb8-8089-7914dd8b7d5d") },
                    { new Guid("70c30746-6225-4743-bcf9-a927caa46d55"), new Guid("874a59f2-152c-445d-ba40-aabc32a947bc"), new Guid("a4417437-faad-42d2-b80d-af1932a9d4bb"), 71, "ObjectNumber71", new Guid("488198be-adb2-4082-8e4b-8577de525262"), new Guid("a45fef14-fd8e-414c-b89a-05bd899b279b") },
                    { new Guid("7201b81b-3d99-4476-ac3c-1f4518b7e9f9"), new Guid("b1e70dd0-5bad-4ef1-8945-ff03ca919baa"), null, 345612, "9876-5432", new Guid("5eba581f-1428-4630-bc95-f3e1b6ae02ca"), new Guid("9aa02117-7045-4633-9297-e8ead75035cf") },
                    { new Guid("725d5bb6-2ce8-484b-89d2-72e7a4cca0c0"), new Guid("2cc96c6f-2cdc-4571-9b75-0db79cb16cfe"), new Guid("dd108185-f16b-4363-b426-5a407a9a39b7"), 92, "ObjectNumber92", new Guid("c4adfa34-16b2-4578-93e8-335690c6a465"), new Guid("9abad73a-8264-4b70-b83b-8dc243853be6") },
                    { new Guid("72b63350-e1b3-4856-8fe3-98ec8146bd6d"), new Guid("d3371a33-0301-49f3-860b-5786ccee7c05"), new Guid("4ec25301-b536-41ff-bad5-a00c9e6506f1"), 66, "ObjectNumber66", new Guid("ea93a71b-cd19-4694-8047-38fbdf54e323"), new Guid("e26d168b-0db4-44bd-a22b-c47e9ca38ac4") },
                    { new Guid("734ff18a-7098-4bac-8eca-3252f18316e2"), new Guid("02397dec-bc2b-4c9b-bf55-f4cff82cab0c"), new Guid("d818e21e-f58a-443a-847f-3048420cb580"), 23, "ObjectNumber23", new Guid("61876048-d9b4-4462-bb73-cad0fbcb7c8e"), new Guid("93fe9a8d-235c-42f9-9c0c-06b1adbab027") },
                    { new Guid("73c57b1b-8a3d-482f-a778-5e4fbc2aa326"), new Guid("3b4f4b57-67b8-4307-a1cb-cc3cc5f363b9"), new Guid("9dc95207-6cfc-460e-9b6f-9e6bc6c613cb"), 90, "ObjectNumber90", new Guid("3a8a0634-bd3a-4102-b43a-37293dd03640"), new Guid("6be5d801-e9d1-4577-8cc3-49b8dcc3ac19") },
                    { new Guid("744810d5-e2f2-4ebf-85c5-e7b19e2ccece"), new Guid("a6fa3d08-ea59-42df-954c-fa950c9eae55"), new Guid("a57010ea-b537-4dee-b883-cdcc926b132d"), 21, "ObjectNumber21", new Guid("98df1ed4-74fc-4285-90aa-32785b444b34"), new Guid("a89a18e5-772a-4f95-8655-011802c2f623") },
                    { new Guid("7a64819c-2d28-45f2-bbb8-ecceb70ce36c"), new Guid("f4310135-70af-4b06-8374-d1fc38f41ccb"), new Guid("4f71ca27-43c1-40c9-8bec-d8a00afe986d"), 65, "ObjectNumber65", new Guid("d36de261-6b13-474d-910e-13824d27fa63"), new Guid("3c57f168-bc6f-4e19-9206-e59c482b4c20") },
                    { new Guid("7a7d06e7-e90c-49da-8b4d-db0df7c44680"), new Guid("20176077-ff0a-4eb9-a36a-ac32568c9237"), new Guid("cf983cfc-fabc-4363-9624-f894d9523a60"), 45, "ObjectNumber45", new Guid("35ab7183-5c5d-4322-8d06-bf5538944fcb"), new Guid("72b47709-888d-4a0b-bc93-4747c4964731") },
                    { new Guid("880793bf-8265-4156-ad8b-8af52c023c16"), new Guid("2bbe93b4-312f-4429-8194-635439f74a2f"), new Guid("8a427596-14b8-44cb-ad9d-154d2cebf868"), 3, "ObjectNumber3", new Guid("64d61a87-884f-4d96-99cf-bca559aa759a"), new Guid("bd3bba39-d9d3-4472-b0b3-7bacd73ad287") },
                    { new Guid("88f9fc13-7b9a-469e-9061-5c81cb114cb7"), new Guid("6ba22b8d-4131-4304-916e-dbf7d4a5ee8f"), new Guid("5e6b80ac-6428-4cbc-9af2-8e79af31f303"), 5, "ObjectNumber5", new Guid("84a9cb58-0e2e-41ee-9491-9fd9c66961e2"), new Guid("1577c630-b70f-4c4a-8f6e-ec1879c69b61") },
                    { new Guid("9504eb0b-0da6-484e-82bc-2b18b312dcbe"), new Guid("f4cea2ba-8e20-4326-b76e-7472134b84c8"), new Guid("d6115473-25e1-4cc7-9b9f-7c84bd773590"), 85, "ObjectNumber85", new Guid("f14ece19-5e98-4541-8d1c-596596a443ff"), new Guid("583ff23c-8c9a-41a2-be16-a154505be078") },
                    { new Guid("95900811-64a8-4062-8943-bc2738e26643"), new Guid("717149d9-8e19-4fd0-bd5f-16e9856cf474"), new Guid("750d6205-2f49-4bcd-9762-bfda32efd2f2"), 42, "ObjectNumber42", new Guid("79c1e98b-a78e-4262-9e96-f8dd48b3a70d"), new Guid("394e532d-8355-43ed-9bf2-fb116fc307f7") },
                    { new Guid("96b0cccc-b20a-4dad-ab46-1511118fda27"), new Guid("627ee412-37e9-4132-9f9a-a191bfac9af7"), new Guid("986c13a2-67e5-4534-aaa1-89c06506b179"), 13, "ObjectNumber13", new Guid("8556e4e8-5f80-45b5-9f17-0fa09ff965c5"), new Guid("10e35fd3-4eb1-4201-bd3b-9dd4c581ebb5") },
                    { new Guid("9731d2e6-ee63-460f-89db-ed2e774d7d7e"), new Guid("0a1120e6-58eb-4ab9-b283-d3f1d65d1135"), new Guid("afecd6ed-eb8c-4f74-ad86-19f65087388f"), 68, "ObjectNumber68", new Guid("a3883238-1a10-415c-87f0-704473ec1304"), new Guid("bbd3ef42-c2cd-421e-b56e-0594c8dd8467") },
                    { new Guid("9a2d50bc-947a-420a-a2c1-d2aa3ad81556"), new Guid("6fbe2ab3-865c-4a1e-a313-a30867525a4f"), new Guid("a8a86705-3c79-4f9f-8b81-c970ad835fa9"), 67, "ObjectNumber67", new Guid("bc98d803-b2c0-46eb-939d-abfb4b9cd855"), new Guid("70af94b5-82b6-4343-b322-8bed1aae617a") },
                    { new Guid("9d94422e-a8cd-441b-9cf2-1e7d0537c592"), new Guid("32e593ea-0f73-46c5-b3d4-87cbaed47b54"), new Guid("f24d840b-ed19-44c9-b452-b410798e546f"), 64, "ObjectNumber64", new Guid("a7842dd8-ce6a-428f-ab81-6f52752f0ed3"), new Guid("e3f70e90-05b4-4bb4-a599-cd7436645d13") },
                    { new Guid("a0d6f56d-ded8-4f3a-8891-0ac2a489ea30"), new Guid("8e754995-917e-433e-b898-7ef580f21ad7"), new Guid("3690454d-6a08-4291-a30d-e233ef8d0c6a"), 22, "ObjectNumber22", new Guid("018e0164-a8be-45a8-9188-6e38fc7b0049"), new Guid("b86b2f3e-48c4-42f5-90aa-9aa622d9acdd") },
                    { new Guid("a1832f69-7099-4ec7-b706-672d5d4ba5c4"), new Guid("444dfb7d-8244-4260-8a79-ff04c6099b79"), new Guid("13ca2be0-ba38-40ce-be23-c83f9d4ab65e"), 20, "ObjectNumber20", new Guid("e3567842-f65e-4937-915b-9febd0a89b63"), new Guid("5715ab16-e036-4f0c-b1eb-ffccd8a245fd") },
                    { new Guid("a23ad4e4-8f0a-4c70-81e2-f80935a85e09"), new Guid("c55be2cb-c0aa-4c01-9298-5919a67508f3"), new Guid("d7d57d7c-b184-4161-9d38-b27c0b8ce713"), 78, "ObjectNumber78", new Guid("3f7e804c-2fdd-480f-8c30-4b04efe6b1e5"), new Guid("9c069651-e058-4a66-986f-fd3afe3ed80f") },
                    { new Guid("a7814ea7-d298-48b5-bf8e-79ee8bac8073"), new Guid("0d2d5dc7-f8d4-4303-a6b8-d46f5b6c7c37"), new Guid("b33a29e8-fd20-4b70-a4ec-e1a5ebc7584c"), 94, "ObjectNumber94", new Guid("1ef18407-9ee2-46cb-91d4-a37c4149c58a"), new Guid("28bf7c43-1946-412b-a240-0ea31c0ae2a2") },
                    { new Guid("a80ce2e2-8321-4c6b-b35f-f7d19a8205c3"), new Guid("be90d8d7-4c86-4a2a-9fa6-2a7515038cbf"), new Guid("2006b9f7-c0aa-42f8-8d81-ab34e77bae71"), 89, "ObjectNumber89", new Guid("d1829ce4-74ad-448d-b5fe-df5c3c90ce75"), new Guid("d3226b26-a9c0-44c7-836e-1d481b7d782f") },
                    { new Guid("ac2e9d39-5a4e-4c5e-b13f-d539f46b2870"), new Guid("68742f71-ece8-41c7-8549-732d7a4035df"), new Guid("5fb3cf8d-0c98-4da7-bcc7-9e760e1e14e2"), 72, "ObjectNumber72", new Guid("6e0936e9-4919-444a-83fd-d404f89880ab"), new Guid("173f40de-56fc-4d8b-b774-df46fe4f3e7d") },
                    { new Guid("b312b706-92d6-4d1f-8226-3c7f63c56ea6"), new Guid("ffb1b02d-b552-4992-9fe9-a5c98e10f98f"), new Guid("a8de50ce-c542-4dc1-aa0e-07b8904ef266"), 73, "ObjectNumber73", new Guid("0f564446-2820-4641-a6c5-2fc14cfb5a7f"), new Guid("a167d7c1-b32e-414a-9bd3-c42c026a5c0f") },
                    { new Guid("b3863e81-5ce5-4fce-a864-00b067670953"), new Guid("6bdaa7f2-e776-4400-8506-42ae2f5b8567"), new Guid("7ec30467-57a7-42fc-b9f3-e0bdfa6fb881"), 51, "ObjectNumber51", new Guid("50802b4a-b9f3-42b5-86f2-72bf31b8020c"), new Guid("0c6f5c50-ad34-4d11-a824-a2cca00335f2") },
                    { new Guid("bb79d3ed-5e49-4520-ad13-a2bc601436bf"), new Guid("6cfe00cb-210c-4b8b-adbf-607069a403ac"), new Guid("fc267d08-3c21-4e70-aed4-2c39fdd509bd"), 9, "ObjectNumber9", new Guid("111a70a6-ada3-4e11-9dbd-627cab46c20e"), new Guid("421454c3-8ff9-468b-b69e-cc8c7106a2ed") },
                    { new Guid("bbb6ae5b-a08d-4571-9005-49e02ff72c14"), new Guid("5823d3e2-2a6a-4986-99d8-2a6b3e00a16b"), new Guid("030960ae-f3ec-47d5-a589-6ce30764e20a"), 69, "ObjectNumber69", new Guid("cb90ae97-7e0f-406e-a543-34595c6b477b"), new Guid("1c4741a4-f54a-402d-884b-afbecb24e3ca") },
                    { new Guid("c0cc8a9d-e505-4430-91fe-72068f990963"), new Guid("2f5eac3a-258e-4b8c-9ed8-0f1cc54e27de"), new Guid("a94befc9-980c-4216-98ea-eee76d08fafb"), 76, "ObjectNumber76", new Guid("10ee3493-0203-44b4-a696-6ce4b4b60bc2"), new Guid("95ed6957-691c-4ac0-ac92-9e4c6eb5ab04") },
                    { new Guid("c3382e54-fb82-44ca-bc8b-3bae9438dd7a"), new Guid("10077da3-e2f8-455c-abec-f3dbbec474a6"), new Guid("9bc5f34f-ed8d-4428-b1cf-43a994ad6bee"), 82, "ObjectNumber82", new Guid("255fadf6-824f-46ee-96ba-37873e36d50b"), new Guid("3dcb3720-de06-49f6-8ae9-88eba1873bde") },
                    { new Guid("c62d1687-fd38-478f-8ec6-c9d3ea48bed8"), new Guid("6d5b35b6-f6ef-45ec-8b0b-b2a098f66bd8"), new Guid("a67b8240-0428-4fca-9fc6-c22c7bdef9cc"), 26, "ObjectNumber26", new Guid("7ec1d871-eda7-4c8f-9364-e150c6ecf964"), new Guid("fbce9ad2-c9d3-4646-9cd0-071a0e571aa3") },
                    { new Guid("c93e2c29-d31a-4e51-af1b-5a2471326bef"), new Guid("f847274f-e14c-4e3a-8ef5-11aebdc530e2"), new Guid("412aaa08-d100-460d-8e4e-b65fb07915f5"), 40, "ObjectNumber40", new Guid("acad94ff-d851-4e4f-baff-6bc2904a5b52"), new Guid("3fa59497-8d43-4384-8ff0-6915d0504503") },
                    { new Guid("c9b266ba-abaa-4e1c-b094-ed14e3815003"), new Guid("c623a7c8-783b-44d3-a526-611ac77b9ec0"), new Guid("7bf95ffb-2cea-4d5c-824e-077acc6a9219"), 55, "ObjectNumber55", new Guid("d8a7d1c3-31bb-474d-9b5a-c87d1cd07c9c"), new Guid("6b058369-ac63-45df-b071-1b8cd76a5523") },
                    { new Guid("ca5df4ed-6357-4e4d-b0cf-038b303aa7aa"), new Guid("ab0794f2-5df3-4061-8328-b2d112a13f0d"), new Guid("4f522d3f-e727-4a15-af26-e9f190979f79"), 38, "ObjectNumber38", new Guid("71e31428-907f-42fd-98d8-45d2fa8963b0"), new Guid("c36a617e-6e88-4c84-b297-bc74fa035184") },
                    { new Guid("cd80e77e-5815-4b4a-8ca7-45bf51dd42d3"), new Guid("0b06e800-bf7c-4d65-b00f-722f2280f5b9"), new Guid("1b8c7aee-fcf2-45c7-8c96-ef0325f441f5"), 345612, "9876-5432", new Guid("77113cee-6316-4ed3-8003-9eefa714d0fd"), new Guid("e6d45b39-2c2c-4880-ba9e-ffd3c52c4ebb") },
                    { new Guid("d0a0aa4b-75cd-4cdb-aadd-fda128929eb4"), new Guid("41e55712-126a-4ca6-91d3-3e096e77c9f3"), new Guid("56223d49-37cd-4782-811e-0ffc8cdae285"), 32, "ObjectNumber32", new Guid("34c08e67-22df-44bd-b6f0-e248b158b27e"), new Guid("e8ffdec0-467c-43e3-b858-7b5869603d84") },
                    { new Guid("d0e86b23-5548-4eda-8397-7d1f7475e2b2"), new Guid("87da7c56-4263-4a73-8b36-9d8279def455"), new Guid("0082588d-ca56-4005-b42e-404aef373695"), 36, "ObjectNumber36", new Guid("fef297e2-b20f-42cf-a644-28282ddf422d"), new Guid("6b836c3c-70aa-4f9c-959a-fc3f961e04b2") },
                    { new Guid("d23aad6e-edba-4c34-a442-2d2c9bbb3437"), new Guid("9aca83b4-cd05-4cdf-ae47-80636465558f"), new Guid("af91c867-2ee7-4134-aea1-fc5de8b3648a"), 48, "ObjectNumber48", new Guid("201aa1bd-262c-46f4-b7c2-2f2d719ce594"), new Guid("ca6e2dd4-c407-4b09-835f-52530a9c9fe9") },
                    { new Guid("d49acdc3-1853-4ac3-bcdd-3f51a2a17877"), new Guid("7f8316cb-eb2d-4371-9373-9e32b52548a6"), new Guid("72e0dedd-283c-48a0-a643-8b6a5c14ca35"), 95, "ObjectNumber95", new Guid("0eab19a9-f66a-4197-949a-ece2caa43be5"), new Guid("9c8ba7bb-8a6f-4fd8-96a3-6cad2dfbb806") },
                    { new Guid("d54dc200-9d0a-4862-98a0-977c15f1e149"), new Guid("acec9be6-6710-48df-a432-9a6d92e411ee"), new Guid("3b6ad04d-c9f4-4084-8921-66028732505b"), 56, "ObjectNumber56", new Guid("a086b006-5adb-4c10-974c-4ead08fcaee4"), new Guid("77b04139-f482-49df-afc1-0c4e4f1189a1") },
                    { new Guid("e0504c9b-cded-4179-b6ac-716f1e70ebf1"), new Guid("6d0ca51f-23af-4f39-adb7-34cceb74b142"), new Guid("ae6533fd-e648-44e3-8b33-136440d30617"), 8, "ObjectNumber8", new Guid("72afcbf9-0685-4b47-9232-ead42f0a2504"), new Guid("b4774e53-1085-4c36-9967-41f94cf1c847") },
                    { new Guid("e22218fb-0d3b-4eb6-98b6-ae2b7cbc8a5c"), new Guid("51034e00-fd6d-4b4c-a113-a2399c8b33b9"), new Guid("a918219c-38ea-4b1a-a5ec-039d1b073c7b"), 49, "ObjectNumber49", new Guid("65a84d51-542b-4142-b62e-2a41389c0fd9"), new Guid("04e694b5-2285-4443-a778-44c6825c5d1d") },
                    { new Guid("e243ace2-227c-48f5-8b24-1796c4e4f30a"), new Guid("6d09fecb-569a-4dcf-ab87-0b79c3ccac02"), new Guid("bb13c80e-9cba-4792-a4c9-e0ebac2cf202"), 53, "ObjectNumber53", new Guid("6128c816-581b-451e-a372-380afe214b87"), new Guid("1e19f3e1-56ef-4198-9788-c67d7aa86f0d") },
                    { new Guid("e8c86f59-138d-43c6-a12c-592598f4cc4a"), new Guid("ff7bb48f-7905-4fd4-b524-cd330d07f62b"), new Guid("1b879f06-8b37-4084-89af-7cb4295de64a"), 14, "ObjectNumber14", new Guid("fd677cf2-844c-4397-9867-39ca92e75246"), new Guid("be7e908f-f33e-4b55-8080-fec32e28e9a3") },
                    { new Guid("ece3fa86-78ee-49e9-a12e-26c7ae3aa73e"), new Guid("a4611326-da5e-48dd-a8ed-bcf03b7618dd"), new Guid("00748b43-86b0-4a9b-986d-6107d2ee8947"), 59, "ObjectNumber59", new Guid("83b908c5-8cd1-4347-ba21-2525781633b7"), new Guid("f782b3b8-ac6d-4f70-b947-90bf5ddd737c") },
                    { new Guid("efd9b9d6-23d2-4de9-968b-d1fe7319fefe"), new Guid("982268e5-d06a-4453-8f15-1c38169cd0a1"), new Guid("0414dd39-7e77-45c9-aaf1-c5cb0962ba8a"), 16, "ObjectNumber16", new Guid("1565c576-0b4f-4254-9b92-5235b00160d7"), new Guid("e2b30df4-8cb6-475a-a76a-00e1e983c03f") },
                    { new Guid("f0975958-5623-4382-976e-5778cac52702"), new Guid("9a2804a5-2c2a-47c5-86d7-7d518ea1733d"), new Guid("1bdd591f-ff69-47a6-a204-219cfe61b345"), 11, "ObjectNumber11", new Guid("6b6b4fb0-0591-4984-bccf-dad882bf78b0"), new Guid("8dda6bc4-c25a-446d-b576-465f0b9d6d00") },
                    { new Guid("f60ea345-8bee-4aad-88dd-e42a4918f807"), new Guid("409e42f6-79a8-4978-b34c-d2376ed4db94"), new Guid("dd391e1f-d04d-4439-ba53-b117eef8b8e5"), 34, "ObjectNumber34", new Guid("8f2e3885-1384-4267-9b32-531dd3a2ac0a"), new Guid("b58a2425-c102-457f-a1d0-c0ba72476a8f") },
                    { new Guid("fc3228aa-6ad8-4592-959e-638815315f4e"), new Guid("c911d7c2-fe1f-40e3-9e33-db7753d17804"), new Guid("cf999537-ce56-4c49-97b6-b2e04f340376"), 54, "ObjectNumber54", new Guid("a184d9e2-1679-45e3-888e-2623f25aa6db"), new Guid("cbc8f609-28e0-40cb-af45-9f83b30d1c8e") },
                    { new Guid("fc39e248-bce8-4507-a406-16217b70e602"), new Guid("22d5cb8e-2042-4657-a9ea-78a92b27c9a7"), new Guid("15cd1f59-bbab-4f9e-a9b2-f72fdf3962d8"), 58, "ObjectNumber58", new Guid("d3151a7e-93c5-4e1d-8049-7d582259d788"), new Guid("2218a0ad-b4dd-4a1b-bdf7-08f773554ab7") },
                    { new Guid("fe06ee63-a6e8-489d-a06e-52a7de2b1aca"), new Guid("fbc7ca73-53fe-4544-b5c7-0db19c287c19"), new Guid("425c1d1e-76bd-44b9-b44c-4accb88fb3b4"), 25, "ObjectNumber25", new Guid("98cf088d-7266-4dbc-b210-ad9dcf63f4da"), new Guid("85abce8a-c40d-4883-9cda-66479511f3a9") },
                    { new Guid("fea6a376-5cf7-483c-b2b9-ac0ea7e7d0f7"), new Guid("90c61fb3-f887-45fc-8dbc-188347b0e9d9"), new Guid("4f5ba68a-03a7-4570-be3e-857d407400f0"), 74, "ObjectNumber74", new Guid("0f27d0cc-93a5-41c3-89e4-d08dc30f3694"), new Guid("6532aa4d-93c5-498e-bd05-0886835edf0c") }
                });

            migrationBuilder.InsertData(
                table: "Adverts",
                columns: new[] { "Id", "AdvertText", "AppartmentId", "PublishedAt", "RentalDate" },
                values: new object[,]
                {
                    { new Guid("00748b43-86b0-4a9b-986d-6107d2ee8947"), "AdvertText59", new Guid("ece3fa86-78ee-49e9-a12e-26c7ae3aa73e"), null, null },
                    { new Guid("0082588d-ca56-4005-b42e-404aef373695"), "AdvertText36", new Guid("d0e86b23-5548-4eda-8397-7d1f7475e2b2"), null, null },
                    { new Guid("030960ae-f3ec-47d5-a589-6ce30764e20a"), "AdvertText69", new Guid("bbb6ae5b-a08d-4571-9005-49e02ff72c14"), null, null },
                    { new Guid("032bde09-a19e-4de6-9cda-be1ed6fb437d"), "AdvertText52", new Guid("68abfd36-d114-4c86-8801-40d797f8e866"), null, null },
                    { new Guid("0414dd39-7e77-45c9-aaf1-c5cb0962ba8a"), "AdvertText16", new Guid("efd9b9d6-23d2-4de9-968b-d1fe7319fefe"), null, null },
                    { new Guid("062f93e5-9c35-4f5e-a9c7-6b4df37a649f"), "AdvertText70", new Guid("290c550f-57e3-422d-afbf-af957f1a78a8"), null, null },
                    { new Guid("0f1247e4-ca93-4039-86f7-5580913177ed"), "AdvertText15", new Guid("6fcc063f-3a52-473c-a7a0-13a930522011"), null, null },
                    { new Guid("1045918b-4078-49e0-895a-82fe06c26b98"), "AdvertText19", new Guid("186958af-3dcc-442d-8cbd-5c33674b8f1b"), null, null },
                    { new Guid("11c7bef7-7741-4dd5-aa8e-8ac8c5301cca"), "AdvertText86", new Guid("4962345b-e0d1-44ee-bfbd-4162dc403dab"), null, null },
                    { new Guid("12a82468-cd0c-4caa-b521-eca9a04a5d15"), "AdvertText75", new Guid("26d2294c-ba02-4faa-b3c4-e6c50e57c744"), null, null },
                    { new Guid("13ca2be0-ba38-40ce-be23-c83f9d4ab65e"), "AdvertText20", new Guid("a1832f69-7099-4ec7-b706-672d5d4ba5c4"), null, null },
                    { new Guid("15cd1f59-bbab-4f9e-a9b2-f72fdf3962d8"), "AdvertText58", new Guid("fc39e248-bce8-4507-a406-16217b70e602"), null, null },
                    { new Guid("1b879f06-8b37-4084-89af-7cb4295de64a"), "AdvertText14", new Guid("e8c86f59-138d-43c6-a12c-592598f4cc4a"), null, null },
                    { new Guid("1bdd591f-ff69-47a6-a204-219cfe61b345"), "AdvertText11", new Guid("f0975958-5623-4382-976e-5778cac52702"), null, null },
                    { new Guid("1fd325c8-3a2a-48f3-bd1e-80b7b75bd1c1"), "AdvertText50", new Guid("3b3d5d9a-6ecb-41f9-bcd7-e9427e3272d7"), null, null },
                    { new Guid("2006b9f7-c0aa-42f8-8d81-ab34e77bae71"), "AdvertText89", new Guid("a80ce2e2-8321-4c6b-b35f-f7d19a8205c3"), null, null },
                    { new Guid("24753fad-0fb9-4250-ab3a-07a5038efadc"), "Detta är den fetaste lägenheten på marknaden. Inga djur, inga rökare, inga människor!", new Guid("cd80e77e-5815-4b4a-8ca7-45bf51dd42d3"), null, null },
                    { new Guid("2ac630d8-8b0d-47e0-b7de-56c9dd9768ff"), "AdvertText62", new Guid("2847fb1c-fdd2-4eeb-b4c5-d81c4a577791"), null, null },
                    { new Guid("3075ca0f-4c8c-4a1a-b290-ed247f99672f"), "AdvertText60", new Guid("5f39aa6a-1f5f-4469-98db-7a98ee86aaed"), null, null },
                    { new Guid("3490e361-b4dd-4bed-b91b-00b0d293a1f5"), "AdvertText100", new Guid("43ca1bf2-04c7-48ca-a692-19efdc7738aa"), null, null },
                    { new Guid("3690454d-6a08-4291-a30d-e233ef8d0c6a"), "AdvertText22", new Guid("a0d6f56d-ded8-4f3a-8891-0ac2a489ea30"), null, null },
                    { new Guid("3910f085-4870-4875-be1f-e7cc798b5cfc"), "AdvertText6", new Guid("4748363e-cef1-4e2c-bf3e-bdac87cb6494"), null, null },
                    { new Guid("3b6ad04d-c9f4-4084-8921-66028732505b"), "AdvertText56", new Guid("d54dc200-9d0a-4862-98a0-977c15f1e149"), null, null },
                    { new Guid("412aaa08-d100-460d-8e4e-b65fb07915f5"), "AdvertText40", new Guid("c93e2c29-d31a-4e51-af1b-5a2471326bef"), null, null },
                    { new Guid("425c1d1e-76bd-44b9-b44c-4accb88fb3b4"), "AdvertText25", new Guid("fe06ee63-a6e8-489d-a06e-52a7de2b1aca"), null, null },
                    { new Guid("44cb27e6-a60a-43fd-a7c7-9064699e6abd"), "AdvertText96", new Guid("59345086-b13e-4d24-8955-c71de4441b6f"), null, null },
                    { new Guid("485be465-99b8-48cc-9917-d084d1949557"), "AdvertText10", new Guid("1925ef51-c453-4f86-aff8-8e164b8af0bd"), null, null },
                    { new Guid("4ae334d1-768a-4a06-bebf-c4f370ca7ccf"), "AdvertText37", new Guid("2719b397-5f9f-4769-99c6-86ecdacf6f51"), null, null },
                    { new Guid("4b4e5b68-7bfa-40f4-84e4-3f1d2e995b2d"), "AdvertText7", new Guid("14cd7698-66de-4043-8fd6-a5e5e033438d"), null, null },
                    { new Guid("4ec25301-b536-41ff-bad5-a00c9e6506f1"), "AdvertText66", new Guid("72b63350-e1b3-4856-8fe3-98ec8146bd6d"), null, null },
                    { new Guid("4f522d3f-e727-4a15-af26-e9f190979f79"), "AdvertText38", new Guid("ca5df4ed-6357-4e4d-b0cf-038b303aa7aa"), null, null },
                    { new Guid("4f5ba68a-03a7-4570-be3e-857d407400f0"), "AdvertText74", new Guid("fea6a376-5cf7-483c-b2b9-ac0ea7e7d0f7"), null, null },
                    { new Guid("4f71ca27-43c1-40c9-8bec-d8a00afe986d"), "AdvertText65", new Guid("7a64819c-2d28-45f2-bbb8-ecceb70ce36c"), null, null },
                    { new Guid("5185cd0c-2d12-4d9f-b165-3f50e4c74367"), "AdvertText98", new Guid("4a474f2b-0061-45c6-8f0b-23d953c549e5"), null, null },
                    { new Guid("555adc5a-0eb3-4aed-bab2-729837176d13"), "AdvertText18", new Guid("2f7e3781-249b-43f9-a304-e7bfe97ce804"), null, null },
                    { new Guid("56223d49-37cd-4782-811e-0ffc8cdae285"), "AdvertText32", new Guid("d0a0aa4b-75cd-4cdb-aadd-fda128929eb4"), null, null },
                    { new Guid("5e6b80ac-6428-4cbc-9af2-8e79af31f303"), "AdvertText5", new Guid("88f9fc13-7b9a-469e-9061-5c81cb114cb7"), null, null },
                    { new Guid("5fb3cf8d-0c98-4da7-bcc7-9e760e1e14e2"), "AdvertText72", new Guid("ac2e9d39-5a4e-4c5e-b13f-d539f46b2870"), null, null },
                    { new Guid("66d373e8-93f3-40d2-9cce-f1de2d414818"), "AdvertText46", new Guid("2157c218-ea30-4c3c-b305-c1586d6da54a"), null, null },
                    { new Guid("6cd21d87-995a-4e42-a308-be1e03252545"), "AdvertText4", new Guid("0506d95b-99c5-42e4-b6a4-4987668627b0"), null, null },
                    { new Guid("72492eb5-a95c-4e03-92ef-83de19a5ee90"), "AdvertText57", new Guid("384b15d9-35ec-4272-92ff-0616e4f72bc6"), null, null },
                    { new Guid("72b6a217-72b2-4e48-a023-f7072beb7937"), "AdvertText31", new Guid("4ddcfda3-6d64-476d-a579-fc94450dde0e"), null, null },
                    { new Guid("72e0dedd-283c-48a0-a643-8b6a5c14ca35"), "AdvertText95", new Guid("d49acdc3-1853-4ac3-bcdd-3f51a2a17877"), null, null },
                    { new Guid("74ab8ae1-9fc7-492d-86c8-7bf765f1fb51"), "AdvertText1", new Guid("499fa113-f634-4a17-b30d-bf4e0ffb7569"), null, null },
                    { new Guid("74f01103-9df4-4b5f-bfa4-c403518702f8"), "AdvertText33", new Guid("26b86c9f-c07e-4151-bb17-b9018cc9e57e"), null, null },
                    { new Guid("750d6205-2f49-4bcd-9762-bfda32efd2f2"), "AdvertText42", new Guid("95900811-64a8-4062-8943-bc2738e26643"), null, null },
                    { new Guid("7bf95ffb-2cea-4d5c-824e-077acc6a9219"), "AdvertText55", new Guid("c9b266ba-abaa-4e1c-b094-ed14e3815003"), null, null },
                    { new Guid("7db2cb85-59e0-454a-bd81-0d9eb8152cc4"), "AdvertText91", new Guid("3ac6ea24-2b36-48b8-8811-d34476f0caca"), null, null },
                    { new Guid("7ec30467-57a7-42fc-b9f3-e0bdfa6fb881"), "AdvertText51", new Guid("b3863e81-5ce5-4fce-a864-00b067670953"), null, null },
                    { new Guid("816d7e49-c15c-48da-ae3b-29e71a777ef2"), "AdvertText77", new Guid("58d85811-70c7-46b8-82e7-92ba195e7cd3"), null, null },
                    { new Guid("89c22122-0531-48e4-88af-ab44eb7b0d81"), "AdvertText79", new Guid("20f20e6c-305e-4ab5-b9b6-fc54683fe171"), null, null },
                    { new Guid("8a427596-14b8-44cb-ad9d-154d2cebf868"), "AdvertText3", new Guid("880793bf-8265-4156-ad8b-8af52c023c16"), null, null },
                    { new Guid("96de96b0-640d-482b-817f-7d962f3c8f33"), "AdvertText24", new Guid("0c2f8d1f-dd11-4df2-8a9a-6077290baae1"), null, null },
                    { new Guid("986c13a2-67e5-4534-aaa1-89c06506b179"), "AdvertText13", new Guid("96b0cccc-b20a-4dad-ab46-1511118fda27"), null, null },
                    { new Guid("99b6d9b6-b5d2-4079-a6ff-db00cdcf018d"), "AdvertText12", new Guid("67ad64df-3402-405a-bde9-66664ec9f539"), null, null },
                    { new Guid("9bc5f34f-ed8d-4428-b1cf-43a994ad6bee"), "AdvertText82", new Guid("c3382e54-fb82-44ca-bc8b-3bae9438dd7a"), null, null },
                    { new Guid("9dc95207-6cfc-460e-9b6f-9e6bc6c613cb"), "AdvertText90", new Guid("73c57b1b-8a3d-482f-a778-5e4fbc2aa326"), null, null },
                    { new Guid("9ebba8b5-56cb-4bc8-86a0-26bdd237cc5b"), "AdvertText83", new Guid("67e97730-fc27-4739-bba7-ea79c9fa2da8"), null, null },
                    { new Guid("a4417437-faad-42d2-b80d-af1932a9d4bb"), "AdvertText71", new Guid("70c30746-6225-4743-bcf9-a927caa46d55"), null, null },
                    { new Guid("a57010ea-b537-4dee-b883-cdcc926b132d"), "AdvertText21", new Guid("744810d5-e2f2-4ebf-85c5-e7b19e2ccece"), null, null },
                    { new Guid("a67b8240-0428-4fca-9fc6-c22c7bdef9cc"), "AdvertText26", new Guid("c62d1687-fd38-478f-8ec6-c9d3ea48bed8"), null, null },
                    { new Guid("a8a86705-3c79-4f9f-8b81-c970ad835fa9"), "AdvertText67", new Guid("9a2d50bc-947a-420a-a2c1-d2aa3ad81556"), null, null },
                    { new Guid("a8de50ce-c542-4dc1-aa0e-07b8904ef266"), "AdvertText73", new Guid("b312b706-92d6-4d1f-8226-3c7f63c56ea6"), null, null },
                    { new Guid("a918219c-38ea-4b1a-a5ec-039d1b073c7b"), "AdvertText49", new Guid("e22218fb-0d3b-4eb6-98b6-ae2b7cbc8a5c"), null, null },
                    { new Guid("a94befc9-980c-4216-98ea-eee76d08fafb"), "AdvertText76", new Guid("c0cc8a9d-e505-4430-91fe-72068f990963"), null, null },
                    { new Guid("a9b94b3c-6a60-43cd-a141-6dacd9740247"), "AdvertText35", new Guid("632a3822-a27a-44c0-a433-574f1d7cdf8b"), null, null },
                    { new Guid("ae6533fd-e648-44e3-8b33-136440d30617"), "AdvertText8", new Guid("e0504c9b-cded-4179-b6ac-716f1e70ebf1"), null, null },
                    { new Guid("af91c867-2ee7-4134-aea1-fc5de8b3648a"), "AdvertText48", new Guid("d23aad6e-edba-4c34-a442-2d2c9bbb3437"), null, null },
                    { new Guid("afc2b7a9-2bf2-4202-9357-b68b7a196679"), "AdvertText39", new Guid("616fa6d1-8da1-488c-91f5-bd1ed0d1a54d"), null, null },
                    { new Guid("afecd6ed-eb8c-4f74-ad86-19f65087388f"), "AdvertText68", new Guid("9731d2e6-ee63-460f-89db-ed2e774d7d7e"), null, null },
                    { new Guid("afef5ef4-ce37-4612-bd62-9d63a8a993cf"), "AdvertText29", new Guid("578a6940-eede-485e-9561-0c5dd6f2b499"), null, null },
                    { new Guid("b23a7fed-b4b9-42d0-98dd-5e6596628032"), "AdvertText87", new Guid("253879ed-713f-44e1-9240-73b8ce780aa4"), null, null },
                    { new Guid("b33a29e8-fd20-4b70-a4ec-e1a5ebc7584c"), "AdvertText94", new Guid("a7814ea7-d298-48b5-bf8e-79ee8bac8073"), null, null },
                    { new Guid("b4092091-bfb0-4845-aff7-25102663e5ba"), "AdvertText80", new Guid("3c2c83d7-edc2-4433-8c9a-c1d6a2f153fa"), null, null },
                    { new Guid("bb13c80e-9cba-4792-a4c9-e0ebac2cf202"), "AdvertText53", new Guid("e243ace2-227c-48f5-8b24-1796c4e4f30a"), null, null },
                    { new Guid("bb21a316-ebff-42ac-b872-8dbdc25621e6"), "AdvertText84", new Guid("4f0d7cc4-41fd-4f2a-ad57-2b7cc0db5df8"), null, null },
                    { new Guid("c71ce016-987f-4e57-bea4-0f32bf76dd80"), "AdvertText28", new Guid("58cee606-0e1c-42d2-b7e9-9dc1dd57cf42"), null, null },
                    { new Guid("c85ed558-2753-489b-b27b-1b0d2ec8a784"), "AdvertText44", new Guid("3c27f32a-2133-43a9-b390-fed5926d66a2"), null, null },
                    { new Guid("cf983cfc-fabc-4363-9624-f894d9523a60"), "AdvertText45", new Guid("7a7d06e7-e90c-49da-8b4d-db0df7c44680"), null, null },
                    { new Guid("cf999537-ce56-4c49-97b6-b2e04f340376"), "AdvertText54", new Guid("fc3228aa-6ad8-4592-959e-638815315f4e"), null, null },
                    { new Guid("d1f4f139-d3c6-4fe7-a3d3-43140e48cdb3"), "AdvertText43", new Guid("1af6d694-b2fe-4d13-90b2-8aeec8d3692a"), null, null },
                    { new Guid("d3ed39a2-e9d3-44b6-8aa7-86c893e5d007"), "AdvertText17", new Guid("068444ac-d349-4ca2-bf31-e45b3e2f92bb"), null, null },
                    { new Guid("d52f605c-4da9-4c5f-bbcd-4a0acdaaa36b"), "AdvertText93", new Guid("507497af-8c07-49d6-aa71-97485bdc5664"), null, null },
                    { new Guid("d6115473-25e1-4cc7-9b9f-7c84bd773590"), "AdvertText85", new Guid("9504eb0b-0da6-484e-82bc-2b18b312dcbe"), null, null },
                    { new Guid("d7657b3d-e0a4-4d7f-b5e5-a12f33bfb866"), "AdvertText63", new Guid("6ed4b4cd-31d9-4c59-a4f2-9352255c9997"), null, null },
                    { new Guid("d7d57d7c-b184-4161-9d38-b27c0b8ce713"), "AdvertText78", new Guid("a23ad4e4-8f0a-4c70-81e2-f80935a85e09"), null, null },
                    { new Guid("d818e21e-f58a-443a-847f-3048420cb580"), "AdvertText23", new Guid("734ff18a-7098-4bac-8eca-3252f18316e2"), null, null },
                    { new Guid("d8f3f81d-7d15-48ba-a6c1-f46f40399cde"), "AdvertText27", new Guid("61e15752-00f0-4065-ae39-f070b0cfe6e0"), null, null },
                    { new Guid("dcb0bf87-f672-4119-b0df-42288a440ddd"), "AdvertText47", new Guid("03987f25-fb84-4ab9-a35e-fc101251bdff"), null, null },
                    { new Guid("dd108185-f16b-4363-b426-5a407a9a39b7"), "AdvertText92", new Guid("725d5bb6-2ce8-484b-89d2-72e7a4cca0c0"), null, null },
                    { new Guid("dd391e1f-d04d-4439-ba53-b117eef8b8e5"), "AdvertText34", new Guid("f60ea345-8bee-4aad-88dd-e42a4918f807"), null, null },
                    { new Guid("ddfa721d-9fc5-432b-aad8-60f28117e3eb"), "AdvertText88", new Guid("487b7c5a-26c2-478f-99b4-9ecd150bf5c2"), null, null },
                    { new Guid("e1cff222-e321-4480-aecb-4343a31bbf9e"), "AdvertText81", new Guid("31cafa80-66e8-4802-bff6-b41848e515b2"), null, null },
                    { new Guid("e3d40c7f-cdba-4f67-818c-7d490e8adc32"), "AdvertText2", new Guid("0dd3f3ab-74dd-469f-adfd-18830e94eb7d"), null, null },
                    { new Guid("eda5ac9f-7a5d-4576-b0ef-7b9c854da142"), "AdvertText61", new Guid("60b2a0ed-65bb-4499-8df8-007ceedbe891"), null, null },
                    { new Guid("ee2fc237-3772-4564-83d8-fe87e9fe0860"), "AdvertText30", new Guid("6ac20920-cd7d-430f-a7f6-b03b80c3266b"), null, null },
                    { new Guid("f24d840b-ed19-44c9-b452-b410798e546f"), "AdvertText64", new Guid("9d94422e-a8cd-441b-9cf2-1e7d0537c592"), null, null },
                    { new Guid("f6cae55a-58c5-4c85-a138-b33f10ebf70b"), "AdvertText97", new Guid("59766959-02d9-4c87-b411-8698a7be5fe5"), null, null },
                    { new Guid("fa28b197-6d63-4b63-8907-399c595072b9"), "AdvertText41", new Guid("2709acab-f933-4559-8a56-baf7f3fabaf1"), null, null },
                    { new Guid("fc267d08-3c21-4e70-aed4-2c39fdd509bd"), "AdvertText9", new Guid("bb79d3ed-5e49-4520-ad13-a2bc601436bf"), null, null },
                    { new Guid("fe6b5334-96da-49e0-abc7-ce98a568824e"), "AdvertText99", new Guid("29b0d278-8b72-4965-a55e-6fd87a79ca7f"), null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("00748b43-86b0-4a9b-986d-6107d2ee8947"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("0082588d-ca56-4005-b42e-404aef373695"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("030960ae-f3ec-47d5-a589-6ce30764e20a"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("032bde09-a19e-4de6-9cda-be1ed6fb437d"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("0414dd39-7e77-45c9-aaf1-c5cb0962ba8a"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("062f93e5-9c35-4f5e-a9c7-6b4df37a649f"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("0f1247e4-ca93-4039-86f7-5580913177ed"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("1045918b-4078-49e0-895a-82fe06c26b98"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("11c7bef7-7741-4dd5-aa8e-8ac8c5301cca"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("12a82468-cd0c-4caa-b521-eca9a04a5d15"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("13ca2be0-ba38-40ce-be23-c83f9d4ab65e"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("15cd1f59-bbab-4f9e-a9b2-f72fdf3962d8"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("1b879f06-8b37-4084-89af-7cb4295de64a"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("1bdd591f-ff69-47a6-a204-219cfe61b345"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("1fd325c8-3a2a-48f3-bd1e-80b7b75bd1c1"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("2006b9f7-c0aa-42f8-8d81-ab34e77bae71"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("24753fad-0fb9-4250-ab3a-07a5038efadc"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("2ac630d8-8b0d-47e0-b7de-56c9dd9768ff"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("3075ca0f-4c8c-4a1a-b290-ed247f99672f"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("3490e361-b4dd-4bed-b91b-00b0d293a1f5"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("3690454d-6a08-4291-a30d-e233ef8d0c6a"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("3910f085-4870-4875-be1f-e7cc798b5cfc"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("3b6ad04d-c9f4-4084-8921-66028732505b"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("412aaa08-d100-460d-8e4e-b65fb07915f5"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("425c1d1e-76bd-44b9-b44c-4accb88fb3b4"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("44cb27e6-a60a-43fd-a7c7-9064699e6abd"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("485be465-99b8-48cc-9917-d084d1949557"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("4ae334d1-768a-4a06-bebf-c4f370ca7ccf"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("4b4e5b68-7bfa-40f4-84e4-3f1d2e995b2d"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("4ec25301-b536-41ff-bad5-a00c9e6506f1"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("4f522d3f-e727-4a15-af26-e9f190979f79"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("4f5ba68a-03a7-4570-be3e-857d407400f0"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("4f71ca27-43c1-40c9-8bec-d8a00afe986d"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("5185cd0c-2d12-4d9f-b165-3f50e4c74367"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("555adc5a-0eb3-4aed-bab2-729837176d13"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("56223d49-37cd-4782-811e-0ffc8cdae285"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("5e6b80ac-6428-4cbc-9af2-8e79af31f303"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("5fb3cf8d-0c98-4da7-bcc7-9e760e1e14e2"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("66d373e8-93f3-40d2-9cce-f1de2d414818"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("6cd21d87-995a-4e42-a308-be1e03252545"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("72492eb5-a95c-4e03-92ef-83de19a5ee90"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("72b6a217-72b2-4e48-a023-f7072beb7937"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("72e0dedd-283c-48a0-a643-8b6a5c14ca35"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("74ab8ae1-9fc7-492d-86c8-7bf765f1fb51"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("74f01103-9df4-4b5f-bfa4-c403518702f8"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("750d6205-2f49-4bcd-9762-bfda32efd2f2"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("7bf95ffb-2cea-4d5c-824e-077acc6a9219"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("7db2cb85-59e0-454a-bd81-0d9eb8152cc4"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("7ec30467-57a7-42fc-b9f3-e0bdfa6fb881"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("816d7e49-c15c-48da-ae3b-29e71a777ef2"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("89c22122-0531-48e4-88af-ab44eb7b0d81"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("8a427596-14b8-44cb-ad9d-154d2cebf868"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("96de96b0-640d-482b-817f-7d962f3c8f33"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("986c13a2-67e5-4534-aaa1-89c06506b179"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("99b6d9b6-b5d2-4079-a6ff-db00cdcf018d"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("9bc5f34f-ed8d-4428-b1cf-43a994ad6bee"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("9dc95207-6cfc-460e-9b6f-9e6bc6c613cb"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("9ebba8b5-56cb-4bc8-86a0-26bdd237cc5b"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("a4417437-faad-42d2-b80d-af1932a9d4bb"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("a57010ea-b537-4dee-b883-cdcc926b132d"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("a67b8240-0428-4fca-9fc6-c22c7bdef9cc"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("a8a86705-3c79-4f9f-8b81-c970ad835fa9"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("a8de50ce-c542-4dc1-aa0e-07b8904ef266"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("a918219c-38ea-4b1a-a5ec-039d1b073c7b"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("a94befc9-980c-4216-98ea-eee76d08fafb"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("a9b94b3c-6a60-43cd-a141-6dacd9740247"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("ae6533fd-e648-44e3-8b33-136440d30617"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("af91c867-2ee7-4134-aea1-fc5de8b3648a"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("afc2b7a9-2bf2-4202-9357-b68b7a196679"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("afecd6ed-eb8c-4f74-ad86-19f65087388f"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("afef5ef4-ce37-4612-bd62-9d63a8a993cf"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("b23a7fed-b4b9-42d0-98dd-5e6596628032"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("b33a29e8-fd20-4b70-a4ec-e1a5ebc7584c"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("b4092091-bfb0-4845-aff7-25102663e5ba"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("bb13c80e-9cba-4792-a4c9-e0ebac2cf202"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("bb21a316-ebff-42ac-b872-8dbdc25621e6"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("c71ce016-987f-4e57-bea4-0f32bf76dd80"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("c85ed558-2753-489b-b27b-1b0d2ec8a784"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("cf983cfc-fabc-4363-9624-f894d9523a60"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("cf999537-ce56-4c49-97b6-b2e04f340376"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("d1f4f139-d3c6-4fe7-a3d3-43140e48cdb3"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("d3ed39a2-e9d3-44b6-8aa7-86c893e5d007"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("d52f605c-4da9-4c5f-bbcd-4a0acdaaa36b"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("d6115473-25e1-4cc7-9b9f-7c84bd773590"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("d7657b3d-e0a4-4d7f-b5e5-a12f33bfb866"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("d7d57d7c-b184-4161-9d38-b27c0b8ce713"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("d818e21e-f58a-443a-847f-3048420cb580"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("d8f3f81d-7d15-48ba-a6c1-f46f40399cde"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("dcb0bf87-f672-4119-b0df-42288a440ddd"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("dd108185-f16b-4363-b426-5a407a9a39b7"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("dd391e1f-d04d-4439-ba53-b117eef8b8e5"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("ddfa721d-9fc5-432b-aad8-60f28117e3eb"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("e1cff222-e321-4480-aecb-4343a31bbf9e"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("e3d40c7f-cdba-4f67-818c-7d490e8adc32"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("eda5ac9f-7a5d-4576-b0ef-7b9c854da142"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("ee2fc237-3772-4564-83d8-fe87e9fe0860"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("f24d840b-ed19-44c9-b452-b410798e546f"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("f6cae55a-58c5-4c85-a138-b33f10ebf70b"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("fa28b197-6d63-4b63-8907-399c595072b9"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("fc267d08-3c21-4e70-aed4-2c39fdd509bd"));

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: new Guid("fe6b5334-96da-49e0-abc7-ce98a568824e"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("213c995a-0463-4030-aa10-227b39e989e7"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("7201b81b-3d99-4476-ac3c-1f4518b7e9f9"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("3b915c92-bba9-48d4-84d5-c142f92a4d25"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b1e70dd0-5bad-4ef1-8945-ff03ca919baa"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("03987f25-fb84-4ab9-a35e-fc101251bdff"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("0506d95b-99c5-42e4-b6a4-4987668627b0"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("068444ac-d349-4ca2-bf31-e45b3e2f92bb"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("0c2f8d1f-dd11-4df2-8a9a-6077290baae1"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("0dd3f3ab-74dd-469f-adfd-18830e94eb7d"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("14cd7698-66de-4043-8fd6-a5e5e033438d"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("186958af-3dcc-442d-8cbd-5c33674b8f1b"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("1925ef51-c453-4f86-aff8-8e164b8af0bd"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("1af6d694-b2fe-4d13-90b2-8aeec8d3692a"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("20f20e6c-305e-4ab5-b9b6-fc54683fe171"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("2157c218-ea30-4c3c-b305-c1586d6da54a"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("253879ed-713f-44e1-9240-73b8ce780aa4"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("26b86c9f-c07e-4151-bb17-b9018cc9e57e"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("26d2294c-ba02-4faa-b3c4-e6c50e57c744"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("2709acab-f933-4559-8a56-baf7f3fabaf1"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("2719b397-5f9f-4769-99c6-86ecdacf6f51"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("2847fb1c-fdd2-4eeb-b4c5-d81c4a577791"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("290c550f-57e3-422d-afbf-af957f1a78a8"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("29b0d278-8b72-4965-a55e-6fd87a79ca7f"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("2f7e3781-249b-43f9-a304-e7bfe97ce804"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("31cafa80-66e8-4802-bff6-b41848e515b2"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("384b15d9-35ec-4272-92ff-0616e4f72bc6"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("3ac6ea24-2b36-48b8-8811-d34476f0caca"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("3b3d5d9a-6ecb-41f9-bcd7-e9427e3272d7"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("3c27f32a-2133-43a9-b390-fed5926d66a2"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("3c2c83d7-edc2-4433-8c9a-c1d6a2f153fa"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("43ca1bf2-04c7-48ca-a692-19efdc7738aa"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("4748363e-cef1-4e2c-bf3e-bdac87cb6494"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("487b7c5a-26c2-478f-99b4-9ecd150bf5c2"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("4962345b-e0d1-44ee-bfbd-4162dc403dab"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("499fa113-f634-4a17-b30d-bf4e0ffb7569"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("4a474f2b-0061-45c6-8f0b-23d953c549e5"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("4ddcfda3-6d64-476d-a579-fc94450dde0e"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("4f0d7cc4-41fd-4f2a-ad57-2b7cc0db5df8"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("507497af-8c07-49d6-aa71-97485bdc5664"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("578a6940-eede-485e-9561-0c5dd6f2b499"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("58cee606-0e1c-42d2-b7e9-9dc1dd57cf42"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("58d85811-70c7-46b8-82e7-92ba195e7cd3"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("59345086-b13e-4d24-8955-c71de4441b6f"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("59766959-02d9-4c87-b411-8698a7be5fe5"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("5f39aa6a-1f5f-4469-98db-7a98ee86aaed"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("60b2a0ed-65bb-4499-8df8-007ceedbe891"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("616fa6d1-8da1-488c-91f5-bd1ed0d1a54d"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("61e15752-00f0-4065-ae39-f070b0cfe6e0"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("632a3822-a27a-44c0-a433-574f1d7cdf8b"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("67ad64df-3402-405a-bde9-66664ec9f539"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("67e97730-fc27-4739-bba7-ea79c9fa2da8"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("68abfd36-d114-4c86-8801-40d797f8e866"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("6ac20920-cd7d-430f-a7f6-b03b80c3266b"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("6ed4b4cd-31d9-4c59-a4f2-9352255c9997"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("6fcc063f-3a52-473c-a7a0-13a930522011"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("70c30746-6225-4743-bcf9-a927caa46d55"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("725d5bb6-2ce8-484b-89d2-72e7a4cca0c0"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("72b63350-e1b3-4856-8fe3-98ec8146bd6d"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("734ff18a-7098-4bac-8eca-3252f18316e2"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("73c57b1b-8a3d-482f-a778-5e4fbc2aa326"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("744810d5-e2f2-4ebf-85c5-e7b19e2ccece"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("7a64819c-2d28-45f2-bbb8-ecceb70ce36c"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("7a7d06e7-e90c-49da-8b4d-db0df7c44680"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("880793bf-8265-4156-ad8b-8af52c023c16"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("88f9fc13-7b9a-469e-9061-5c81cb114cb7"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("9504eb0b-0da6-484e-82bc-2b18b312dcbe"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("95900811-64a8-4062-8943-bc2738e26643"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("96b0cccc-b20a-4dad-ab46-1511118fda27"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("9731d2e6-ee63-460f-89db-ed2e774d7d7e"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("9a2d50bc-947a-420a-a2c1-d2aa3ad81556"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("9d94422e-a8cd-441b-9cf2-1e7d0537c592"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("a0d6f56d-ded8-4f3a-8891-0ac2a489ea30"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("a1832f69-7099-4ec7-b706-672d5d4ba5c4"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("a23ad4e4-8f0a-4c70-81e2-f80935a85e09"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("a7814ea7-d298-48b5-bf8e-79ee8bac8073"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("a80ce2e2-8321-4c6b-b35f-f7d19a8205c3"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("ac2e9d39-5a4e-4c5e-b13f-d539f46b2870"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("b312b706-92d6-4d1f-8226-3c7f63c56ea6"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("b3863e81-5ce5-4fce-a864-00b067670953"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("bb79d3ed-5e49-4520-ad13-a2bc601436bf"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("bbb6ae5b-a08d-4571-9005-49e02ff72c14"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("c0cc8a9d-e505-4430-91fe-72068f990963"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("c3382e54-fb82-44ca-bc8b-3bae9438dd7a"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("c62d1687-fd38-478f-8ec6-c9d3ea48bed8"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("c93e2c29-d31a-4e51-af1b-5a2471326bef"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("c9b266ba-abaa-4e1c-b094-ed14e3815003"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("ca5df4ed-6357-4e4d-b0cf-038b303aa7aa"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("cd80e77e-5815-4b4a-8ca7-45bf51dd42d3"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("d0a0aa4b-75cd-4cdb-aadd-fda128929eb4"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("d0e86b23-5548-4eda-8397-7d1f7475e2b2"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("d23aad6e-edba-4c34-a442-2d2c9bbb3437"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("d49acdc3-1853-4ac3-bcdd-3f51a2a17877"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("d54dc200-9d0a-4862-98a0-977c15f1e149"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("e0504c9b-cded-4179-b6ac-716f1e70ebf1"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("e22218fb-0d3b-4eb6-98b6-ae2b7cbc8a5c"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("e243ace2-227c-48f5-8b24-1796c4e4f30a"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("e8c86f59-138d-43c6-a12c-592598f4cc4a"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("ece3fa86-78ee-49e9-a12e-26c7ae3aa73e"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("efd9b9d6-23d2-4de9-968b-d1fe7319fefe"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("f0975958-5623-4382-976e-5778cac52702"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("f60ea345-8bee-4aad-88dd-e42a4918f807"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("fc3228aa-6ad8-4592-959e-638815315f4e"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("fc39e248-bce8-4507-a406-16217b70e602"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("fe06ee63-a6e8-489d-a06e-52a7de2b1aca"));

            migrationBuilder.DeleteData(
                table: "Appartments",
                keyColumn: "Id",
                keyValue: new Guid("fea6a376-5cf7-483c-b2b9-ac0ea7e7d0f7"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("013fa90b-eaf9-4800-9afd-a9d34a82f8b8"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("02397dec-bc2b-4c9b-bf55-f4cff82cab0c"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("055e7e37-aaf2-428f-9339-a8935728cce9"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("062a51ed-14d5-4f2f-bd83-26c0ae2ce919"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("0a1120e6-58eb-4ab9-b283-d3f1d65d1135"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("0b06e800-bf7c-4d65-b00f-722f2280f5b9"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("0d2d5dc7-f8d4-4303-a6b8-d46f5b6c7c37"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("10077da3-e2f8-455c-abec-f3dbbec474a6"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("17904c24-97be-4bc0-9683-f410a86e81f2"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("1b74c56a-01a5-4178-9bc1-6d29cda21284"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("1b95b7da-d76f-4250-aeb8-1ae8b09af2c0"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("1cb50361-c189-4738-a666-f6f4098e131e"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("1ddd9867-6a22-44c6-ada2-d13c91ed589e"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("1f3ddc93-2613-4a78-bb84-d415c5580ebf"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("20176077-ff0a-4eb9-a36a-ac32568c9237"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("22d5cb8e-2042-4657-a9ea-78a92b27c9a7"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2bbe93b4-312f-4429-8194-635439f74a2f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2cc96c6f-2cdc-4571-9b75-0db79cb16cfe"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2f5eac3a-258e-4b8c-9ed8-0f1cc54e27de"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("32e593ea-0f73-46c5-b3d4-87cbaed47b54"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("33deb16c-6810-4e78-826d-1e6cbf83644e"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("34be234a-b0de-4a67-9bbf-43878d01fe61"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("35243ed4-a4d3-42d5-ac2b-d21f67266c3e"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("38a092d1-f889-4b0a-8a2d-5cbc1dd85ce4"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("3b4f4b57-67b8-4307-a1cb-cc3cc5f363b9"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("3b521757-802a-4d96-99ce-827490cfb268"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("409e42f6-79a8-4978-b34c-d2376ed4db94"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("41e55712-126a-4ca6-91d3-3e096e77c9f3"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("444dfb7d-8244-4260-8a79-ff04c6099b79"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4f367d14-6b81-4b00-8067-4b7049b05d30"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4ff2815b-e2a6-4c90-b81d-906640a9cd8d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("51034e00-fd6d-4b4c-a113-a2399c8b33b9"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("51ea9169-f03f-468f-9f13-58cda97564de"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("54258afe-f342-4f88-89d1-4644b37679b8"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5823d3e2-2a6a-4986-99d8-2a6b3e00a16b"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5d014d45-7b83-4aef-9c2a-cd26a17ad076"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("627ee412-37e9-4132-9f9a-a191bfac9af7"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("68742f71-ece8-41c7-8549-732d7a4035df"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("689b5891-ba6e-40c1-9109-0d9594e00a83"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6b9070a7-cee7-4021-8e93-a4190ecaccaa"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6ba22b8d-4131-4304-916e-dbf7d4a5ee8f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6ba49605-cf3a-49c2-985a-212b03a988bc"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6bdaa7f2-e776-4400-8506-42ae2f5b8567"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6cc8bdd6-dbbd-4606-93b6-2f108f4fb093"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6cfe00cb-210c-4b8b-adbf-607069a403ac"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6d09fecb-569a-4dcf-ab87-0b79c3ccac02"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6d0ca51f-23af-4f39-adb7-34cceb74b142"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6d5b35b6-f6ef-45ec-8b0b-b2a098f66bd8"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("6fbe2ab3-865c-4a1e-a313-a30867525a4f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("717149d9-8e19-4fd0-bd5f-16e9856cf474"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("7d07a40b-fa13-4235-86b9-0d9f193d2da9"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("7f8316cb-eb2d-4371-9373-9e32b52548a6"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("7fd1259e-16c3-4950-b5f9-76f6589b1320"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("84f81c34-d149-4b3d-aead-c18175b93e29"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("874a59f2-152c-445d-ba40-aabc32a947bc"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("87da7c56-4263-4a73-8b36-9d8279def455"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("88438316-b32c-4410-8677-a51f54b4f9ac"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8d56fcc7-a016-4168-965a-e565aec196e0"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8e592218-4acd-4c2b-8fd5-8e237bd0d6d1"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8e754995-917e-433e-b898-7ef580f21ad7"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("90c61fb3-f887-45fc-8dbc-188347b0e9d9"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("94e8c374-8463-4c31-97ab-1d8faeab7006"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("95bab15c-8476-4f88-83e3-a4541b4b41da"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("982268e5-d06a-4453-8f15-1c38169cd0a1"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9a2804a5-2c2a-47c5-86d7-7d518ea1733d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9abae042-a328-4a3e-a5f2-34aee402e0e9"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9aca83b4-cd05-4cdf-ae47-80636465558f"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9c281f99-5f95-443f-b9ac-833a83ce381d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a3082af0-7b1c-4c0f-8daa-4c3e5753129d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a4611326-da5e-48dd-a8ed-bcf03b7618dd"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a4619a8d-1a43-4b84-aa1e-e02da987072e"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a6fa3d08-ea59-42df-954c-fa950c9eae55"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a80b0758-900b-4a10-a487-7595f28bcdf7"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("aaa0c6e1-30d5-40ad-bcc3-b3c9c77a0914"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ab0794f2-5df3-4061-8328-b2d112a13f0d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("acec9be6-6710-48df-a432-9a6d92e411ee"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b4fdb859-7d19-4772-ace3-60748f121e9b"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("be90d8d7-4c86-4a2a-9fa6-2a7515038cbf"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("c2974612-5312-4498-bdbd-f342bce78334"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("c55be2cb-c0aa-4c01-9298-5919a67508f3"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("c623a7c8-783b-44d3-a526-611ac77b9ec0"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("c911d7c2-fe1f-40e3-9e33-db7753d17804"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("cc7c5b4e-563f-42c3-97c5-e215ffdd0d3d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ce3b8db3-72f7-4223-a4f3-59d4c8fe1918"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d051404a-cc0c-4adb-8aaf-97ed68b80590"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d25df32d-7b79-4fcb-b123-175781e7cff0"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d3371a33-0301-49f3-860b-5786ccee7c05"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d8e34a5a-9fca-4579-b750-95826f8a3c36"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("e2bf559a-f4b2-45b3-af84-b9371119ea22"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("e61593ae-3c04-461a-a79d-1e5cf1719bb5"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("e7c788a9-4f83-4d6a-8c1d-1c44b91ca869"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f0ed1981-742c-4210-ace4-13c30e2a3985"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f4310135-70af-4b06-8374-d1fc38f41ccb"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f4cea2ba-8e20-4326-b76e-7472134b84c8"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("f847274f-e14c-4e3a-8ef5-11aebdc530e2"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("fbc7ca73-53fe-4544-b5c7-0db19c287c19"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("fc11979f-8483-4cd9-b5f1-387e874a6f51"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("fc7254d4-46ef-4c97-bc68-0dc082f9c51c"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("fca0995b-80b1-434d-8d2a-1d9f751e5b1e"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ff7bb48f-7905-4fd4-b524-cd330d07f62b"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ffb1b02d-b552-4992-9fe9-a5c98e10f98f"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("5eba581f-1428-4630-bc95-f3e1b6ae02ca"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("dc69538b-3542-4177-bb33-498a2c4b3a91"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("018e0164-a8be-45a8-9188-6e38fc7b0049"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("01c2e9e8-c00c-4efd-bfbd-425a1d68c7f7"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("04ff204a-bc45-44dc-b814-aae8b1f5ca90"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("0548ac38-fb56-414b-a7bb-34b388d24fda"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("0e0af672-3e59-4ce4-aeee-f21b331cbedf"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("0eab19a9-f66a-4197-949a-ece2caa43be5"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("0efa2bb5-f3a0-48e5-84e4-260c723a6ea2"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("0f27d0cc-93a5-41c3-89e4-d08dc30f3694"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("0f564446-2820-4641-a6c5-2fc14cfb5a7f"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("10ee3493-0203-44b4-a696-6ce4b4b60bc2"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("111a70a6-ada3-4e11-9dbd-627cab46c20e"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("1565c576-0b4f-4254-9b92-5235b00160d7"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("185ad2c0-5b81-4c7d-acd8-aea73c975678"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("1869dd80-1931-4220-8037-be8d33d4c937"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("1ef18407-9ee2-46cb-91d4-a37c4149c58a"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("1f1465e6-455f-42c4-a354-0d5a2b33bb9f"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("1fd0b382-5097-45f6-9894-d39a5ed2b214"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("201aa1bd-262c-46f4-b7c2-2f2d719ce594"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("25267bbb-b782-4120-90fb-42b5783fa1f7"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("255fadf6-824f-46ee-96ba-37873e36d50b"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("2832d5f0-5ebe-4d8a-9e4d-9377b4b9bde6"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("2cc1789f-6974-4e5a-9f41-275abdff7db7"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("34c08e67-22df-44bd-b6f0-e248b158b27e"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("35ab7183-5c5d-4322-8d06-bf5538944fcb"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("371f4e36-3b3a-494c-90d9-f9edb241875a"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("3a8a0634-bd3a-4102-b43a-37293dd03640"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("3ad50a9d-7db7-4d55-9d6c-24d39bc6ea10"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("3e741619-63e8-458e-b746-9196675790e6"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("3f7e804c-2fdd-480f-8c30-4b04efe6b1e5"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("47297899-b466-41e6-8707-f3874a435d1c"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("47a42ad6-c83f-4891-b48c-7114086d64eb"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("47a68fe2-cf37-463e-942b-49df237546d2"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("488198be-adb2-4082-8e4b-8577de525262"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("492ead94-2740-48a5-9c6c-78cedc0ddaa9"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("4d4fa242-a3d3-4c79-8600-73f189efe9c9"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("4f4a7502-b199-43da-8964-798fca0bed02"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("50802b4a-b9f3-42b5-86f2-72bf31b8020c"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("5801311e-ee54-47bd-9b93-18e45dcbf803"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("5cda4284-9a37-4829-8e7a-79bf48c75362"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("60852f97-7cfd-443b-b5d5-90799f377f2b"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("6128c816-581b-451e-a372-380afe214b87"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("61876048-d9b4-4462-bb73-cad0fbcb7c8e"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("64d61a87-884f-4d96-99cf-bca559aa759a"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("65a84d51-542b-4142-b62e-2a41389c0fd9"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("6b6b4fb0-0591-4984-bccf-dad882bf78b0"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("6e0936e9-4919-444a-83fd-d404f89880ab"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("71e31428-907f-42fd-98d8-45d2fa8963b0"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("72afcbf9-0685-4b47-9232-ead42f0a2504"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("738fd426-8cbb-406c-9490-edb0a1f28099"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("77113cee-6316-4ed3-8003-9eefa714d0fd"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("79c1e98b-a78e-4262-9e96-f8dd48b3a70d"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("7d42e87d-62a8-4125-b105-abfa55d6b8b6"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("7dce2f61-d516-47f1-8ce4-a42be76e6893"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("7ec1d871-eda7-4c8f-9364-e150c6ecf964"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("83b908c5-8cd1-4347-ba21-2525781633b7"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("84a9cb58-0e2e-41ee-9491-9fd9c66961e2"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("8556e4e8-5f80-45b5-9f17-0fa09ff965c5"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("88d0f32f-a6e8-4b59-8a5c-86cc43f820af"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("88df6afd-82d0-4790-bb49-1b189f9fd5d8"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("8ae80374-e67c-4087-9780-78ce18d9f26b"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("8f2e3885-1384-4267-9b32-531dd3a2ac0a"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("9086598c-a91a-4370-b9c0-d87e5af86a2b"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("91548d99-a557-4422-8280-a5857c85fa1f"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("9173c8ae-5211-4677-a36b-ab3a60380674"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("98cf088d-7266-4dbc-b210-ad9dcf63f4da"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("98df1ed4-74fc-4285-90aa-32785b444b34"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("9a4c9521-4297-470a-8674-da194933753f"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("9e29b3ec-63f0-4b99-9d9d-d50da43b951b"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("a086b006-5adb-4c10-974c-4ead08fcaee4"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("a184d9e2-1679-45e3-888e-2623f25aa6db"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("a3883238-1a10-415c-87f0-704473ec1304"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("a7842dd8-ce6a-428f-ab81-6f52752f0ed3"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("a9442cdd-dcfe-4050-9e0b-9c095520abb0"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("abdb7250-b651-44e3-9169-b53dd20dd91a"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("acad94ff-d851-4e4f-baff-6bc2904a5b52"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("b186ac54-20f7-4049-9a0a-7af63a89c23a"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("b2950442-2aa6-450d-8d58-8a3124a599f5"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("b75ed543-7c13-4122-bd0d-b25eb6ae87f7"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("bb764df7-8d5d-469e-b7d4-e81c0ebdefd7"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("bc98d803-b2c0-46eb-939d-abfb4b9cd855"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("c063aae7-e5d0-45e6-bf63-49cef87a16b0"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("c2e78631-0c88-4229-aeab-fc27fab9682f"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("c4adfa34-16b2-4578-93e8-335690c6a465"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("c91fe89e-1087-4cbc-8025-572b6ff1ab58"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("cb90ae97-7e0f-406e-a543-34595c6b477b"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("d05f8209-67e8-4e7d-8dbe-b6accafe7a7b"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("d1829ce4-74ad-448d-b5fe-df5c3c90ce75"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("d2011010-2ee9-426b-acbf-e5d9c54bd89e"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("d3151a7e-93c5-4e1d-8049-7d582259d788"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("d36de261-6b13-474d-910e-13824d27fa63"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("d8906712-f8ed-4c24-9a66-1390c1ebf808"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("d8a7d1c3-31bb-474d-9b5a-c87d1cd07c9c"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("da2412f5-143f-46b9-a077-67773ba4b1c0"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("daa016e6-2ec5-42ea-ae96-b4c49e638c16"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("e3567842-f65e-4937-915b-9febd0a89b63"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("e752f5aa-4563-425a-9cb1-b4e493e2533e"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("ea93a71b-cd19-4694-8047-38fbdf54e323"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("f14ece19-5e98-4541-8d1c-596596a443ff"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("f44c808f-a1b5-4535-81e9-51ab2a762492"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("fd677cf2-844c-4397-9867-39ca92e75246"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("fef297e2-b20f-42cf-a644-28282ddf422d"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("6055f821-bf36-4a3a-981d-3e80236adcb0"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("9aa02117-7045-4633-9297-e8ead75035cf"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("04e694b5-2285-4443-a778-44c6825c5d1d"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("06b987e0-17b6-41b9-9d08-f8d2790f9106"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("08671ef2-1c11-4ff9-b32f-03e70b575e97"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("08be4494-dccb-42e2-89c1-e1870948f6d7"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("0ac92777-d319-4812-b465-d0cda30124c4"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("0c6f5c50-ad34-4d11-a824-a2cca00335f2"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("0de61fba-f055-4ded-a4a6-e723d18403c9"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("10e35fd3-4eb1-4201-bd3b-9dd4c581ebb5"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("1577c630-b70f-4c4a-8f6e-ec1879c69b61"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("173f40de-56fc-4d8b-b774-df46fe4f3e7d"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("1c4741a4-f54a-402d-884b-afbecb24e3ca"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("1e19f3e1-56ef-4198-9788-c67d7aa86f0d"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("1fe465ef-2452-43c3-845e-69840f9bef8b"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("209bea85-0fd7-4244-a9a6-8be4d433262e"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("211160c7-cf50-441e-9982-7e467ac067db"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("2218a0ad-b4dd-4a1b-bdf7-08f773554ab7"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("25790cea-85de-480c-9447-00efa7b63899"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("28bf7c43-1946-412b-a240-0ea31c0ae2a2"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("33facd90-b0b6-4feb-8452-f19647126948"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("3586dc13-d20d-4bd9-bb47-387c57aabefb"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("394e532d-8355-43ed-9bf2-fb116fc307f7"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("3c57f168-bc6f-4e19-9206-e59c482b4c20"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("3dcb3720-de06-49f6-8ae9-88eba1873bde"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("3fa59497-8d43-4384-8ff0-6915d0504503"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("417b8bf6-9855-426b-a9e4-72f58e4338f7"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("421454c3-8ff9-468b-b69e-cc8c7106a2ed"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("45236cd6-953a-430d-911c-89ed0419fabd"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("4ab72c15-be38-46f6-9c12-e13a7c15680c"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("5715ab16-e036-4f0c-b1eb-ffccd8a245fd"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("583ff23c-8c9a-41a2-be16-a154505be078"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("5cda885c-7e58-4034-8bdf-130db37cae4f"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("60e2da02-efc8-4b48-9e52-29548c36c377"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("62a9708d-448a-4b92-86dd-29d7f973f8f8"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("6532aa4d-93c5-498e-bd05-0886835edf0c"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("6b058369-ac63-45df-b071-1b8cd76a5523"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("6b836c3c-70aa-4f9c-959a-fc3f961e04b2"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("6be5d801-e9d1-4577-8cc3-49b8dcc3ac19"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("70400a90-918c-4362-a4ed-c518c1b7d906"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("70af94b5-82b6-4343-b322-8bed1aae617a"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("72b47709-888d-4a0b-bc93-4747c4964731"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("733c2caf-4930-4fc0-a0dd-1c394b93d3df"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("77b04139-f482-49df-afc1-0c4e4f1189a1"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("7c7aa9e0-a0b1-4932-aa0d-f6aa6eb8bf26"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("810c56d3-c486-44ac-ab7b-f1c4479c2717"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("85abce8a-c40d-4883-9cda-66479511f3a9"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("8639a985-d804-4af3-b505-a6983ee8612d"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("874efec8-3e04-4bb8-8089-7914dd8b7d5d"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("8885d65c-4211-44c8-ba15-8b48425f24f7"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("8d239909-68cd-4af3-9907-282476d6a17f"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("8dda6bc4-c25a-446d-b576-465f0b9d6d00"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("90f77380-a9b4-4b1b-b48a-0404aba4cd07"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("93fe9a8d-235c-42f9-9c0c-06b1adbab027"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("949a5c00-8573-432c-8e3c-4a5bbe2a11d9"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("95ed6957-691c-4ac0-ac92-9e4c6eb5ab04"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("96781922-56ac-427a-b95d-f7b91031d053"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("97a0ed20-e860-4db1-b092-e6709b09d082"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("9abad73a-8264-4b70-b83b-8dc243853be6"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("9c069651-e058-4a66-986f-fd3afe3ed80f"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("9c8ba7bb-8a6f-4fd8-96a3-6cad2dfbb806"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("a167d7c1-b32e-414a-9bd3-c42c026a5c0f"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("a45fef14-fd8e-414c-b89a-05bd899b279b"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("a89a18e5-772a-4f95-8655-011802c2f623"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("a8dd5527-c3a6-4a2a-a6b8-8a48a1f62291"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("af6a129a-4c11-4d3d-9648-5ac1d7f6a87c"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("b24217c5-bf15-4c44-adad-a6b1a4954b0c"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("b4774e53-1085-4c36-9967-41f94cf1c847"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("b58a2425-c102-457f-a1d0-c0ba72476a8f"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("b86b2f3e-48c4-42f5-90aa-9aa622d9acdd"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("baf6c58c-14f4-4818-bb77-37680f7a5095"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("bbd3ef42-c2cd-421e-b56e-0594c8dd8467"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("bd3bba39-d9d3-4472-b0b3-7bacd73ad287"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("be7e908f-f33e-4b55-8080-fec32e28e9a3"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("bed00ae0-7e39-488f-aa9c-a12ecf8b3fbd"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("c0757928-1236-4695-9328-d6a630511f65"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("c1831627-c34f-48ad-b549-7d19c667e781"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("c36a617e-6e88-4c84-b297-bc74fa035184"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("c9ec33dc-2ce3-45f3-baba-7568dfc8a845"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("ca6e2dd4-c407-4b09-835f-52530a9c9fe9"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("cbc8f609-28e0-40cb-af45-9f83b30d1c8e"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("cbdb0773-58f6-487f-99ae-3e634bb45378"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("d04ca83f-dea4-4870-8bd8-cdc504b15dd8"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("d061e0ce-d8fc-43a8-acd3-11657ac01d11"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("d3226b26-a9c0-44c7-836e-1d481b7d782f"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("d6f405b8-3d22-4b85-bf3e-f5fb0a291f76"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("d744d714-3a97-4c88-820d-420f248d923f"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("e0b66157-fd2e-4264-a9b8-d6b19bb68678"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("e13d1000-4132-484f-bc6f-7eaa960d47de"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("e26d168b-0db4-44bd-a22b-c47e9ca38ac4"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("e2b30df4-8cb6-475a-a76a-00e1e983c03f"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("e3a49177-27e4-4843-b201-f48d7dbb3c9c"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("e3f70e90-05b4-4bb4-a599-cd7436645d13"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("e6632e38-cbd7-4431-b74f-54ff1dc61c67"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("e6d45b39-2c2c-4880-ba9e-ffd3c52c4ebb"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("e8ffdec0-467c-43e3-b858-7b5869603d84"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("f1316c60-6e87-4639-a17d-e6cd44eb3cdd"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("f3fe298f-914b-4e28-847c-dcb62d7c4f4d"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("f6134a9f-a9bd-4f14-9c61-25fc4b408765"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("f669ae3c-fb09-44b2-98d4-2bfc9a597681"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("f782b3b8-ac6d-4f70-b947-90bf5ddd737c"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("f95f22cd-412a-48ae-832b-1b31e1a35f65"));

            migrationBuilder.DeleteData(
                table: "QueueRules",
                keyColumn: "Id",
                keyValue: new Guid("fbce9ad2-c9d3-4646-9cd0-071a0e571aa3"));
        }
    }
}
