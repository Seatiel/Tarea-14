using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TareaDetallePeliculas.Entidades
{
    public class Peliculas
    {
        [Key]

        public int PeliculaId { get; set; }
        public string Estrenos { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

    }
}
