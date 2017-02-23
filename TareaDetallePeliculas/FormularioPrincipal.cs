using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TareaDetallePeliculas
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void registroActoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rActores ra = new UI.Registros.rActores();
            ra.Show();
        }

        private void registroPeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rPeliculas rp = new UI.Registros.rPeliculas();
            rp.Show();
        }
    }
}
