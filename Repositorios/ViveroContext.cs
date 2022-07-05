using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Dominio.EntidadesNegocio;

namespace Repositorios
{
    public class ViveroContext : DbContext 
    {
        // Agregamos los DbSet de nuestras entidades de negocio a nuestra clase de contexto
        public DbSet<Compra> Compras { get; set; }
        
        
        public DbSet<Importacion> Importaciones { get; set; }
        public DbSet<ItemCompraPlanta> ItemsPlantasCompradas { get; set; }
        public DbSet<Parametros> Parametros { get; set; }
        public DbSet<Planta> Plantas { get; set; }
        public DbSet<Plaza> Plazas { get; set; }
        public DbSet<TipoIluminacion> TiposIluminaciones { get; set; }
        public DbSet<TipoPlanta> TiposPlantas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public ViveroContext(DbContextOptions<ViveroContext> options) : base(options)
        {
       
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //FLUENT API PARA CONFIGURAR COSAS
            
            //modelBuilder.Entity<Autor>().HasMany<AutorPublicacion>().WithOne(ap => ap.Autor);
            //modelBuilder.Entity<Publicacion>().HasMany<AutorPublicacion>().WithOne(ap => ap.Publicacion);
                
            //LO ANTERIOR SE CAMBIÓ POR ESTO PARA CORREGIR LAS FK DUPLICADAS EN LA TABLA AUTORPUBLICACION:
            modelBuilder.Entity<Planta>().HasMany(a => a.ItemsPlantasCompradas).WithOne(ap => ap.planta);
            modelBuilder.Entity<Compra>().HasMany(c => c.ItemsPlantasCompradas).WithOne(ap => ap.compra);
            
            modelBuilder.Entity<ItemCompraPlanta>().HasKey(ap => new { ap.PlantaId, ap.CompraId });
            modelBuilder.Entity<ItemCompraPlanta>().Property(ap => ap.Id).ValueGeneratedOnAdd();
            
            //modelBuilder.Entity<Libro>().HasAlternateKey(l => l.ISBN); //ES UNIQUE ISBN
           
            //ALTERNATIVA A LO ANTERIOR:
            //modelBuilder.Entity<Libro>().HasIndex(l => l.ISBN).IsUnique();
           
            base.OnModelCreating(modelBuilder);
        }

    }
}
