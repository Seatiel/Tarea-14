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
    public partial class rPeliculas : Form
    {
        Peliculas pelicula;
        public rPeliculas()
        {
            InitializeComponent();
        }

        private void rPeliculas_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            Limpiar();
        }

        private void LlenarCombo()
        {
            List<Actores> lista = ActoresBLL.GetList();
            ActorescomboBox.DataSource = lista;            
            ActorescomboBox.DisplayMember = "ActorNombres";
            ActorescomboBox.ValueMember = "ActorId";
        }

        private void LlenarGrid(Peliculas pelicula)
        {
            PeliculasActoresdataGridView.DataSource = null;
            PeliculasActoresdataGridView.DataSource = pelicula.Actores;
        }

        private Peliculas LlenarClase()
        {
            string categorias = ActorescomboBox.SelectedValue.ToString();
            pelicula.Estrenos = EstrenostextBox.Text;
            pelicula.Descripcion = DescripciontextBox.Text;
            pelicula.Fecha = FechadateTimePicker.Value;
            pelicula.ActorId = Utileria.ToInt(categorias);
            return pelicula;
        }

        private void LlenarCampos(Peliculas pelicula)
        {
            EstrenostextBox.Text = pelicula.Estrenos;
            DescripciontextBox.Text = pelicula.Descripcion;
            FechadateTimePicker.Value = pelicula.Fecha;
            ActorescomboBox.SelectedValue = pelicula.ActorId;
        }

        public void Limpiar()
        {
            pelicula = new Peliculas();

            PeliculasIdtextBox.Clear();
            EstrenostextBox.Clear();
            DescripciontextBox.Clear();
            FechadateTimePicker.Value = DateTime.Today;

            PeliculasActoresdataGridView.DataSource = null;
        }

        public bool Validar()
        {
            bool retorno = true;
            if ((string.IsNullOrEmpty(EstrenostextBox.Text)) || (string.IsNullOrEmpty(DescripciontextBox.Text)))
            {
                EstrenoserrorProvider.SetError(EstrenostextBox, "Debe de ingresar el Estreno.");
                DescripcionerrorProvider.SetError(DescripciontextBox, "Debe de ingresar la Descripcion.");
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
            pelicula = LlenarClase();
            if (!Validar())
            {
                MessageBox.Show("Debe de completar los campos");
            }
            else if (PeliculasBLL.Guardar(pelicula))
            {
                MessageBox.Show("La pelicula se ha Guardado.");
                Limpiar();
            }            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var pelicula = PeliculasBLL.Buscar(Utileria.ToInt(PeliculasIdtextBox.Text));
            if (pelicula != null)
            {
                if (PeliculasBLL.Eliminar(pelicula))
                    MessageBox.Show("La pelicula ha sido eliminada");
            }
            Limpiar();
        }        

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PeliculasIdtextBox.Text))
            {
                var pelicula = PeliculasBLL.Buscar(Utileria.ToInt(PeliculasIdtextBox.Text));
                if (pelicula != null)
                {
                    LlenarCampos(pelicula);
                    LlenarGrid(pelicula);
                }
                else
                {
                    MessageBox.Show("La pelicula no esta creada");
                }
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            var actores = new Actores();

            actores = (Actores)ActorescomboBox.SelectedItem;
            pelicula.Actores.Add(actores);
            LlenarGrid(pelicula);
        }
    }
}
