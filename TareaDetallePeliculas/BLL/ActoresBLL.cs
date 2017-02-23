using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TareaDetallePeliculas.DAL;
using TareaDetallePeliculas.Entidades;

namespace TareaDetallePeliculas.BLL
{
    public class ActoresBLL
    {
        public static bool Guardar(Actores actor)
        {
            bool retorno = false;
            using (var db = new DetallePeliculasDb())
            {
                try
                {
                    db.Actores.Add(actor);
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {
                    throw;
                }
                return retorno;
            }
            //todo: es mejor retornar el mismo objeto guardado.
            //bool retorno = false;
            //using (var repositorio = new Repositorio<Categorias>())
            //{
            //    //todo: validar que el nombre de categoria no exista

            //    retorno = repositorio.Guardar(categoria) != null;
            //}

            //return retorno;
        }

        public static bool Eliminar(Actores categoria)
        {
            bool retorno = false;
            using (var db = new DetallePeliculasDb())
            {
                try
                {
                    db.Entry(categoria).State = EntityState.Deleted;
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

        public static Actores Buscar(int id)
        {
            var actor = new Actores();
            using (var db = new DetallePeliculasDb())
            {
                try
                {
                    actor = db.Actores.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                return actor;
            }
        }

        public static List<Actores> GetList()
        {
            List<Actores> lista = new List<Actores>();
            using (var db = new DetallePeliculasDb())
            {
                try
                {
                    lista = db.Actores.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

    }
}
