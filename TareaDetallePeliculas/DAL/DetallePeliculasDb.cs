using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TareaDetallePeliculas.Entidades;

namespace TareaDetallePeliculas.DAL
{
    public class DetallePeliculasDb : DbContext
    {
        public DetallePeliculasDb() : base("ConStr")
        {

        }

        public DbSet<Peliculas> Pelicula { get; set; }
        public DbSet<Actores> Actores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actores>()
                .HasMany(actores => actores.Peliculas)
                .WithMany(peliculas => peliculas.Actores)
                .Map(pa => 
                {
                    pa.MapLeftKey("PeliculaId");
                    pa.MapRightKey("ActorId");
                    pa.ToTable("PeliculasActores");
                });
        }

    }
}
