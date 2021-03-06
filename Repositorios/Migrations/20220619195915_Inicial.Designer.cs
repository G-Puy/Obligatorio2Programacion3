// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositorios;

namespace Repositorios.Migrations
{
    [DbContext(typeof(ViveroContext))]
    [Migration("20220619195915_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.EntidadesNegocio.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MontoImpuestosAplicados")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecioTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Compras");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Compra");
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.CuidadosPlanta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadFrecRiego")
                        .HasColumnType("int");

                    b.Property<decimal>("Temperatura")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TipoIluminacionId")
                        .HasColumnType("int");

                    b.Property<string>("UnidadFrecRiego")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TipoIluminacionId");

                    b.ToTable("CuidadosPlanta");
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.Foto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreFoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlantaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlantaId");

                    b.ToTable("Foto");
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.ItemCompraPlanta", b =>
                {
                    b.Property<int>("PlantaId")
                        .HasColumnType("int");

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Unidades")
                        .HasColumnType("int");

                    b.HasKey("PlantaId", "CompraId");

                    b.HasIndex("CompraId");

                    b.ToTable("ItemsPlantasCompradas");
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.Parametros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescParametro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoParametro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValorParametro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parametros");
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.Planta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<int?>("CuidadosPlantaId")
                        .HasColumnType("int");

                    b.Property<string>("DescripcionPlanta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCientifico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombresVulgares")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoAmbiente")
                        .HasColumnType("int");

                    b.Property<int?>("TipoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CuidadosPlantaId");

                    b.HasIndex("TipoId");

                    b.ToTable("Plantas");
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.TipoIluminacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreTipoIluminacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposIluminaciones");
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.TipoPlanta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescTipoPlanta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomTipoPlanta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposPlantas");
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsAutenticado")
                        .HasColumnType("bit");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.Importacion", b =>
                {
                    b.HasBaseType("Dominio.EntidadesNegocio.Compra");

                    b.Property<string>("DescripcionSanitaria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsDeAmericaDelSur")
                        .HasColumnType("bit");

                    b.Property<decimal>("TasaArancelaria")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TasaBasica")
                        .HasColumnType("decimal(18,2)");

                    b.HasDiscriminator().HasValue("Importacion");
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.Plaza", b =>
                {
                    b.HasBaseType("Dominio.EntidadesNegocio.Compra");

                    b.Property<decimal>("CostoFlete")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TasaIva")
                        .HasColumnType("decimal(18,2)");

                    b.HasDiscriminator().HasValue("Plaza");
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.CuidadosPlanta", b =>
                {
                    b.HasOne("Dominio.EntidadesNegocio.TipoIluminacion", "TipoIluminacion")
                        .WithMany()
                        .HasForeignKey("TipoIluminacionId");
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.Foto", b =>
                {
                    b.HasOne("Dominio.EntidadesNegocio.Planta", null)
                        .WithMany("FotosDePlanta")
                        .HasForeignKey("PlantaId");
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.ItemCompraPlanta", b =>
                {
                    b.HasOne("Dominio.EntidadesNegocio.Compra", "compra")
                        .WithMany("ItemsPlantasCompradas")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.EntidadesNegocio.Planta", "planta")
                        .WithMany("ItemsPlantasCompradas")
                        .HasForeignKey("PlantaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.EntidadesNegocio.Planta", b =>
                {
                    b.HasOne("Dominio.EntidadesNegocio.CuidadosPlanta", "CuidadosPlanta")
                        .WithMany()
                        .HasForeignKey("CuidadosPlantaId");

                    b.HasOne("Dominio.EntidadesNegocio.TipoPlanta", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId");
                });
#pragma warning restore 612, 618
        }
    }
}
