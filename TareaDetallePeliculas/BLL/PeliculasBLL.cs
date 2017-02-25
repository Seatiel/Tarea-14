using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TareaDetallePeliculas.DAL;
using TareaDetallePeliculas.Entidades;

namespace TareaDetallePeliculas.BLL
{
    public class PeliculasBLL
    {
        public static bool Guardar(Peliculas pelicula)
        {
            bool retorno = false;
            using (var db = new DetallePeliculasDb())
            {
                try
                {
                    pelicula = db.Pelicula.Add(pelicula);

                    foreach (var cat in pelicula.Actores)
                    {//para evitar que se inserten de nuevo los estudiantes agregados.
                     //por defecto entity framwork lo ve como entidades nuevas. 
                        db.Entry(cat).State = EntityState.Unchanged;
                    }

                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.ToString());
                    throw;
                }
                return retorno;
            }
        }

        //public static bool Insertar(Peliculas pelicula)
        //{
        //    bool retorno = false;
        //    try
        //    {
        //        using (var db = new MovieDb())
        //        {
        //            if (Buscar(pelicula.UsuarioId) == null)
        //                db.Pelicula.Add(usuario);
        //            else
        //                db.Entry(pelicula).State = EntityState.Modified;

        //            db.SaveChanges();
        //        }
        //        retorno = true;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return retorno;
        //}

        public static bool Eliminar(Peliculas pelicula)
        {
            bool retorno = false;
            using (var db = new DetallePeliculasDb())
            {
                try
                {
                    db.Entry(pelicula).State = EntityState.Deleted;
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }
        }

        public static Peliculas Buscar(int id)
        {
            var pelicula = new Peliculas();
            using (var db = new DetallePeliculasDb())
            {
                try
                {
                    pelicula = db.Pelicula.Find(id);
                    pelicula.Actores.Count();
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.ToString());
                    throw;
                }
                return pelicula;
            }
        }

        public static List<Peliculas> GetList()
        {
            List<Peliculas> lista = new List<Peliculas>();
            using (var db = new DetallePeliculasDb())
            {
                try
                {
                    if (db.Pelicula.ToList().Count > 0)
                    {
                        lista = db.Pelicula.ToList();
                    }
                    else
                    {
                        lista = null;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Peliculas> GetListId(int peliculaId)
        {
            List<Peliculas> lista = new List<Peliculas>();
            using (var db = new DetallePeliculasDb())
            {
                try
                {
                    lista = db.Pelicula.Where(p => p.PeliculaId == peliculaId).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Peliculas> GetListDescripcion(string descripcion)
        {
            List<Peliculas> lista = new List<Peliculas>();
            using (var db = new DetallePeliculasDb())
            {
                try
                {
                    lista = db.Pelicula.Where(p => p.Descripcion == descripcion).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Peliculas> GetListFecha(DateTime desde, DateTime hasta)
        {
            List<Peliculas> lista = new List<Peliculas>();
            using (var db = new DetallePeliculasDb())
            {
                try
                {
                    lista = db.Pelicula.Where(p => p.Fecha >= desde.Date && p.Fecha <= hasta).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        //public static List<Peliculas> GetListNombreActores(string actores)
        //{
        //    List<Peliculas> lista = new List<Peliculas>();
        //    using (var db = new DetallePeliculasDb())
        //    {
        //        try
        //        {
        //            lista = db.Pelicula.Where(p => p. == actores).ToList();
        //        }
        //        catch (Exception)
        //        {

        //            throw;
        //        }
        //        return lista;
        //    }
        //}

    }
}
