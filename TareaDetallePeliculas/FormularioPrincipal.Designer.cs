namespace TareaDetallePeliculas
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroActoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroActoresToolStripMenuItem,
            this.registroPeliculasToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroActoresToolStripMenuItem
            // 
            this.registroActoresToolStripMenuItem.Name = "registroActoresToolStripMenuItem";
            this.registroActoresToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.registroActoresToolStripMenuItem.Text = "Registro Actores";
            this.registroActoresToolStripMenuItem.Click += new System.EventHandler(this.registroActoresToolStripMenuItem_Click);
            // 
            // registroPeliculasToolStripMenuItem
            // 
            this.registroPeliculasToolStripMenuItem.Name = "registroPeliculasToolStripMenuItem";
            this.registroPeliculasToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.registroPeliculasToolStripMenuItem.Text = "Registro Peliculas";
            this.registroPeliculasToolStripMenuItem.Click += new System.EventHandler(this.registroPeliculasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaPeliculasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaPeliculasToolStripMenuItem
            // 
            this.consultaPeliculasToolStripMenuItem.Name = "consultaPeliculasToolStripMenuItem";
            this.consultaPeliculasToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.consultaPeliculasToolStripMenuItem.Text = "Consulta Peliculas";
            this.consultaPeliculasToolStripMenuItem.Click += new System.EventHandler(this.consultaPeliculasToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 426);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.Text = "Formulario Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroActoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroPeliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPeliculasToolStripMenuItem;
    }
}

