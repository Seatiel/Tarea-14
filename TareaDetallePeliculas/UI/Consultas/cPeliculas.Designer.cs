namespace TareaDetallePeliculas.UI.Consultas
{
    partial class cPeliculas
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
            this.components = new System.ComponentModel.Container();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltartextBox = new System.Windows.Forms.TextBox();
            this.PeliculasdataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltrarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Location = new System.Drawing.Point(458, 34);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltrarcomboBox.TabIndex = 17;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Location = new System.Drawing.Point(607, 21);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(95, 37);
            this.Buscarbutton.TabIndex = 16;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Filtrar:";
            // 
            // FiltartextBox
            // 
            this.FiltartextBox.Location = new System.Drawing.Point(76, 36);
            this.FiltartextBox.Name = "FiltartextBox";
            this.FiltartextBox.Size = new System.Drawing.Size(366, 22);
            this.FiltartextBox.TabIndex = 14;
            // 
            // PeliculasdataGridView
            // 
            this.PeliculasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeliculasdataGridView.Location = new System.Drawing.Point(40, 97);
            this.PeliculasdataGridView.Name = "PeliculasdataGridView";
            this.PeliculasdataGridView.RowTemplate.Height = 24;
            this.PeliculasdataGridView.Size = new System.Drawing.Size(662, 309);
            this.PeliculasdataGridView.TabIndex = 9;
            // 
            // FiltrarerrorProvider
            // 
            this.FiltrarerrorProvider.ContainerControl = this;
            // 
            // cPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 446);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FiltartextBox);
            this.Controls.Add(this.PeliculasdataGridView);
            this.Name = "cPeliculas";
            this.Text = "Consulta Peliculas";
            this.Load += new System.EventHandler(this.cPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltrarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FiltartextBox;
        private System.Windows.Forms.DataGridView PeliculasdataGridView;
        private System.Windows.Forms.ErrorProvider FiltrarerrorProvider;
    }
}