using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TareaDetallePeliculas.UI.Consultas
{
    public partial class cPeliculas : Form
    {
        public cPeliculas()
        {
            InitializeComponent();
        }

        private void cPeliculas_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(FiltartextBox.Text))
            {
                FiltrarerrorProvider.SetError(FiltartextBox, "Por favor llenar campos.");
                return true;
            }
            return false;
        }

        public void LlenarCombo()
        {
            FiltrarcomboBox.Items.Insert(0, "Todos");
            FiltrarcomboBox.Items.Insert(1, "Actores");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Todos";
        }

        public void FiltrarOpcion()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                PeliculasdataGridView.DataSource = BLL.PeliculasBLL.GetList();
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                //PeliculasdataGridView.DataSource = BLL.ActoresBLL.GetListNombre();
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            FiltrarOpcion();
        }


    }
}
