using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorios.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCompra = table.Column<DateTime>(nullable: false),
                    MontoImpuestosAplicados = table.Column<decimal>(nullable: false),
                    PrecioTotal = table.Column<decimal>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    TasaBasica = table.Column<decimal>(nullable: true),
                    EsDeAmericaDelSur = table.Column<bool>(nullable: true),
                    TasaArancelaria = table.Column<decimal>(nullable: true),
                    DescripcionSanitaria = table.Column<string>(nullable: true),
                    TasaIva = table.Column<decimal>(nullable: true),
                    CostoFlete = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoParametro = table.Column<string>(nullable: true),
                    DescParametro = table.Column<string>(nullable: true),
                    ValorParametro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposIluminaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoIluminacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIluminaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposPlantas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomTipoPlanta = table.Column<string>(nullable: false),
                    DescTipoPlanta = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPlantas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Pass = table.Column<string>(nullable: false),
                    EsAutenticado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuidadosPlanta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIluminacionId = table.Column<int>(nullable: true),
                    CantidadFrecRiego = table.Column<int>(nullable: false),
                    UnidadFrecRiego = table.Column<string>(nullable: true),
                    Temperatura = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuidadosPlanta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuidadosPlanta_TiposIluminaciones_TipoIluminacionId",
                        column: x => x.TipoIluminacionId,
                        principalTable: "TiposIluminaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plantas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoId = table.Column<int>(nullable: true),
                    NombreCientifico = table.Column<string>(nullable: false),
                    NombresVulgares = table.Column<string>(nullable: false),
                    DescripcionPlanta = table.Column<string>(nullable: false),
                    CuidadosPlantaId = table.Column<int>(nullable: true),
                    TipoAmbiente = table.Column<int>(nullable: false),
                    Altura = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plantas_CuidadosPlanta_CuidadosPlantaId",
                        column: x => x.CuidadosPlantaId,
                        principalTable: "CuidadosPlanta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plantas_TiposPlantas_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TiposPlantas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Foto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreFoto = table.Column<string>(nullable: false),
                    PlantaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foto_Plantas_PlantaId",
                        column: x => x.PlantaId,
                        principalTable: "Plantas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemsPlantasCompradas",
                columns: table => new
                {
                    PlantaId = table.Column<int>(nullable: false),
                    CompraId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unidades = table.Column<int>(nullable: false),
                    PrecioUnitario = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsPlantasCompradas", x => new { x.PlantaId, x.CompraId });
                    table.ForeignKey(
                        name: "FK_ItemsPlantasCompradas_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemsPlantasCompradas_Plantas_PlantaId",
                        column: x => x.PlantaId,
                        principalTable: "Plantas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CuidadosPlanta_TipoIluminacionId",
                table: "CuidadosPlanta",
                column: "TipoIluminacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Foto_PlantaId",
                table: "Foto",
                column: "PlantaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsPlantasCompradas_CompraId",
                table: "ItemsPlantasCompradas",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Plantas_CuidadosPlantaId",
                table: "Plantas",
                column: "CuidadosPlantaId");

            migrationBuilder.CreateIndex(
                name: "IX_Plantas_TipoId",
                table: "Plantas",
                column: "TipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foto");

            migrationBuilder.DropTable(
                name: "ItemsPlantasCompradas");

            migrationBuilder.DropTable(
                name: "Parametros");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Plantas");

            migrationBuilder.DropTable(
                name: "CuidadosPlanta");

            migrationBuilder.DropTable(
                name: "TiposPlantas");

            migrationBuilder.DropTable(
                name: "TiposIluminaciones");
        }
    }
}
