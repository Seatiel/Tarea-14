using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace TareaDetallePeliculas.DAL
{
    public class DetallePeliculasDb : DbContext
    {
        public DetallePeliculasDb() : base("ConStr")
        {

        }



    }
}
