﻿namespace Nueva_Biblioteca
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.btnLimpiarRepo = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnBuscarLector = new System.Windows.Forms.Button();
            this.txtBuscarLector = new System.Windows.Forms.TextBox();
            this.lbBuscarLector = new System.Windows.Forms.Label();
            this.cbReporte = new System.Windows.Forms.ComboBox();
            this.lbTipoReporte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbReportes = new System.Windows.Forms.Label();
            this.lbCerrar = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnLimpiarRepo
            // 
            this.btnLimpiarRepo.BackColor = System.Drawing.Color.Red;
            this.btnLimpiarRepo.Enabled = false;
            this.btnLimpiarRepo.FlatAppearance.BorderSize = 0;
            this.btnLimpiarRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarRepo.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarRepo.Image")));
            this.btnLimpiarRepo.Location = new System.Drawing.Point(923, 175);
            this.btnLimpiarRepo.Name = "btnLimpiarRepo";
            this.btnLimpiarRepo.Size = new System.Drawing.Size(41, 37);
            this.btnLimpiarRepo.TabIndex = 40;
            this.btnLimpiarRepo.UseVisualStyleBackColor = false;
            this.btnLimpiarRepo.Click += new System.EventHandler(this.btnLimpiarRepo_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGenerar.Enabled = false;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(923, 120);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(41, 37);
            this.btnGenerar.TabIndex = 39;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnBuscarLector
            // 
            this.btnBuscarLector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(174)))));
            this.btnBuscarLector.FlatAppearance.BorderSize = 0;
            this.btnBuscarLector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLector.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLector.Location = new System.Drawing.Point(812, 147);
            this.btnBuscarLector.Name = "btnBuscarLector";
            this.btnBuscarLector.Size = new System.Drawing.Size(94, 29);
            this.btnBuscarLector.TabIndex = 38;
            this.btnBuscarLector.Text = "Buscar";
            this.btnBuscarLector.UseVisualStyleBackColor = false;
            this.btnBuscarLector.Visible = false;
            this.btnBuscarLector.Click += new System.EventHandler(this.btnBuscarLector_Click);
            // 
            // txtBuscarLector
            // 
            this.txtBuscarLector.Enabled = false;
            this.txtBuscarLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarLector.Location = new System.Drawing.Point(409, 147);
            this.txtBuscarLector.Name = "txtBuscarLector";
            this.txtBuscarLector.Size = new System.Drawing.Size(397, 29);
            this.txtBuscarLector.TabIndex = 37;
            this.txtBuscarLector.Visible = false;
            this.txtBuscarLector.TextChanged += new System.EventHandler(this.txtBuscarLector_TextChanged);
            // 
            // lbBuscarLector
            // 
            this.lbBuscarLector.AutoSize = true;
            this.lbBuscarLector.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbBuscarLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscarLector.Location = new System.Drawing.Point(405, 120);
            this.lbBuscarLector.Name = "lbBuscarLector";
            this.lbBuscarLector.Size = new System.Drawing.Size(54, 20);
            this.lbBuscarLector.TabIndex = 36;
            this.lbBuscarLector.Text = "Lector";
            this.lbBuscarLector.Visible = false;
            // 
            // cbReporte
            // 
            this.cbReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReporte.FormattingEnabled = true;
            this.cbReporte.Items.AddRange(new object[] {
            "Prestamos por lector",
            "Libro con mayor numero de prestamos",
            "Lector mas frecuente",
            "Top 5 Libros mas prestados"});
            this.cbReporte.Location = new System.Drawing.Point(65, 145);
            this.cbReporte.Name = "cbReporte";
            this.cbReporte.Size = new System.Drawing.Size(338, 32);
            this.cbReporte.TabIndex = 35;
            this.cbReporte.SelectedIndexChanged += new System.EventHandler(this.cbReporte_SelectedIndexChanged);
            // 
            // lbTipoReporte
            // 
            this.lbTipoReporte.AutoSize = true;
            this.lbTipoReporte.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoReporte.Location = new System.Drawing.Point(61, 120);
            this.lbTipoReporte.Name = "lbTipoReporte";
            this.lbTipoReporte.Size = new System.Drawing.Size(123, 20);
            this.lbTipoReporte.TabIndex = 34;
            this.lbTipoReporte.Text = "Tipo de Reporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(826, 50, 111, 400);
            this.label1.Size = new System.Drawing.Size(937, 463);
            this.label1.TabIndex = 33;
            // 
            // lbReportes
            // 
            this.lbReportes.AutoSize = true;
            this.lbReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(174)))));
            this.lbReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReportes.ForeColor = System.Drawing.Color.White;
            this.lbReportes.Location = new System.Drawing.Point(40, 63);
            this.lbReportes.Margin = new System.Windows.Forms.Padding(0);
            this.lbReportes.Name = "lbReportes";
            this.lbReportes.Padding = new System.Windows.Forms.Padding(8, 8, 850, 8);
            this.lbReportes.Size = new System.Drawing.Size(941, 36);
            this.lbReportes.TabIndex = 32;
            this.lbReportes.Text = "Reportes";
            // 
            // lbCerrar
            // 
            this.lbCerrar.AutoSize = true;
            this.lbCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(174)))));
            this.lbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCerrar.Location = new System.Drawing.Point(949, 73);
            this.lbCerrar.Name = "lbCerrar";
            this.lbCerrar.Size = new System.Drawing.Size(15, 15);
            this.lbCerrar.TabIndex = 42;
            this.lbCerrar.Text = "X";
            // 
            // pnlReportes
            // 
            this.pnlReportes.BackColor = System.Drawing.Color.White;
            this.pnlReportes.Location = new System.Drawing.Point(44, 233);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(934, 333);
            this.pnlReportes.TabIndex = 43;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 628);
            this.Controls.Add(this.pnlReportes);
            this.Controls.Add(this.lbCerrar);
            this.Controls.Add(this.btnLimpiarRepo);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnBuscarLector);
            this.Controls.Add(this.txtBuscarLector);
            this.Controls.Add(this.lbBuscarLector);
            this.Controls.Add(this.cbReporte);
            this.Controls.Add(this.lbTipoReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbReportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpiarRepo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnBuscarLector;
        public System.Windows.Forms.TextBox txtBuscarLector;
        private System.Windows.Forms.Label lbBuscarLector;
        public System.Windows.Forms.ComboBox cbReporte;
        private System.Windows.Forms.Label lbTipoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbReportes;
        private System.Windows.Forms.Label lbCerrar;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Panel pnlReportes;
    }
}