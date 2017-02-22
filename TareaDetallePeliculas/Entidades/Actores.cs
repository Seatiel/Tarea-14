using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TareaDetallePeliculas.Entidades
{
    public class Actores
    {
        [Key]
        public int ActorId { get; set; }

        public string Nombres { get; set; }



    }
}
