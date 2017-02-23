using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TareaDetallePeliculas.BLL;
using TareaDetallePeliculas.Entidades;

namespace TareaDetallePeliculas.UI.Registros
{
    public partial class rActores : Form
    {
        

        public rActores()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            ActorIdtextBox.Clear();
            ActortextBox.Clear();
        }

        private Actores LlenarClase()
        {
            var actores = new Actores();         
            actores.ActorNombres = ActortextBox.Text;
            return actores;
        }

        public bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(ActortextBox.Text))
            {
                ActorerrorProvider.SetError(ActortextBox, "Debe escribir el nombre del Actor.");
                retorno = false;
            }
            return retorno;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var actores = new Actores();
            actores = LlenarClase();
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los Campos.");
                return;
            }
            else if (ActoresBLL.Guardar(actores))
            {
                MessageBox.Show("Se ha guardado los Actores.");
                Limpiar();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var actores = ActoresBLL.Buscar(Utileria.ToInt(ActorIdtextBox.Text));

            if (actores != null && ActoresBLL.Eliminar(actores))
            {
                MessageBox.Show("La categoria ha sido eliminada");
                Limpiar();
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ActorIdtextBox.Text))
            {
                var actores = ActoresBLL.Buscar(Utileria.ToInt(ActorIdtextBox.Text));                
                if (actores != null)
                {
                    ActortextBox.Text = actores.ActorNombres;
                }
                else
                {
                    MessageBox.Show("El Actor no esta creado");
                }
            }
        }

    }
}
