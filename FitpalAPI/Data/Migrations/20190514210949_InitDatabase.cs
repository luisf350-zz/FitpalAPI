using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitpalAPI.Data.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoEntrenamientos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEntrenamientos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TipoEntrenamientos",
                columns: new[] { "Id", "FechaCreacion", "Nombre" },
                values: new object[,]
                {
                    { new Guid("bfa9c715-79c4-48dd-91fb-59c3d65e746d"), new DateTime(2019, 5, 14, 16, 9, 48, 610, DateTimeKind.Local).AddTicks(5135), "Acroyoga" },
                    { new Guid("1002f2ee-d8f6-45c2-bdef-e2afd5229001"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4269), "Jiu Jitsu Brasilero" },
                    { new Guid("bbd40883-8bf3-4dd6-a5f8-5c881bdddfbd"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4291), "Karate" },
                    { new Guid("7fa30c8c-f558-4f7b-a2e1-9d1b345aa557"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4312), "Kids" },
                    { new Guid("2870eebc-697b-4e0a-8c92-15817f5ae49f"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4338), "Levantamiento de pesas" },
                    { new Guid("4bf8a457-0efe-47ac-b932-2165712c9253"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4363), "Lucha Olímpica" },
                    { new Guid("c6139892-7ebf-498f-a900-df0296be0359"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4384), "Muay Thai - Kick Boxing" },
                    { new Guid("d2845a3d-1a0a-4366-a837-e8f3a32445b6"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4246), "Indoor Cycling" },
                    { new Guid("8b8edc14-fe3c-45c5-9556-5bf66aadabdc"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4406), "Natación" },
                    { new Guid("ec0e08fc-c0df-449d-89b2-d6944c65d059"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4449), "Power plate" },
                    { new Guid("8c28b79c-0e03-4029-9759-8d99a176be05"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4470), "Sauna/Turco" },
                    { new Guid("0a48cf19-7a3a-4a70-8dfa-8cfa84652a80"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4491), "Spinning" },
                    { new Guid("02512d2c-b241-459b-842e-eb15ad1faaac"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4517), "Tenis" },
                    { new Guid("370a8aee-b8ab-4051-8a01-e736602bbad4"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4541), "Valoración Física" },
                    { new Guid("5bd46f30-43dd-4530-a669-d4e5a0632f4f"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4564), "Weight Lifting" },
                    { new Guid("af87fceb-9eaf-47f9-aa7c-4ab6381d93fe"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4427), "Pilates" },
                    { new Guid("06096371-66ef-4e33-93f4-0db7fa942c26"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4225), "HIIT" },
                    { new Guid("7bc4de6e-11c6-452a-a663-308d4ce24cf8"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4204), "Gym time" },
                    { new Guid("b88b481b-3be9-44e9-8bc5-99f25374f333"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4180), "Golfito" },
                    { new Guid("1fce60ac-801c-4c63-ad6f-1ad5bb1bc4a1"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(3562), "Aeroyoga" },
                    { new Guid("c394e6fc-3c60-4bc2-9cfe-e63d2068fdda"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(3730), "Artes Marciales" },
                    { new Guid("300fc523-5b27-4cb7-a48f-9b69f0eab5f7"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(3756), "Baile/Danza" },
                    { new Guid("ddca972d-6c9f-4e68-af06-1bcceb886a8a"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(3778), "Barre" },
                    { new Guid("1fc660c4-8101-4976-ba67-49651a93e6f7"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(3911), "Bienestar" },
                    { new Guid("d12ebc3f-dff2-4c3a-8506-9bc3d8b8739a"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(3934), "Boxeo" },
                    { new Guid("bca308b9-3325-4643-8fc8-0bfc382e94a4"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(3972), "Complementa tu entrenamiento!" },
                    { new Guid("b7c717b2-d9ee-4755-926b-e379899ba36e"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(3995), "Crossfit" },
                    { new Guid("1e3ea8ab-8e16-43a2-9d00-bf82fb6ea410"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4021), "Crosstraining" },
                    { new Guid("f6a3298a-b5f8-4299-893d-5c3f47e23158"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4043), "Deportes" },
                    { new Guid("ee128988-182c-4e11-8b62-d97fcd1f30e9"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4066), "EMS" },
                    { new Guid("3b626613-40e8-4aae-b7e3-602043847def"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4087), "Entrenamiento personalizado" },
                    { new Guid("1e1d5687-6cb6-46e3-a3d2-f57ad2f089d5"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4110), "Esferokinosis®" },
                    { new Guid("51d589d5-e439-46da-81d8-afec27b117e5"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4131), "Funcional" },
                    { new Guid("954e918a-40e1-4423-8d33-11417d5ea209"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4157), "Gimnasia Rítmica Expresiva" },
                    { new Guid("682965b5-6014-4da5-82c7-9a340a63972d"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4659), "Yoga" },
                    { new Guid("64672e68-22dd-43c8-8d68-a5cc3d938f29"), new DateTime(2019, 5, 14, 16, 9, 48, 613, DateTimeKind.Local).AddTicks(4681), "Yoga pilates" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "TipoEntrenamientos");
        }
    }
}
