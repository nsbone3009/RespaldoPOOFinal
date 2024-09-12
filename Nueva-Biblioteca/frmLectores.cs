﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nueva_Biblioteca
{
    public partial class frmLectores : Form
    {
        public bool validacion1 = false, validacion2 = false;
        static csLectores claseLector = new csLectores();
        static private frmLectores instancia = null;

        public static frmLectores Formulario()
        {
            if (instancia == null) { instancia = new frmLectores(); }
            return instancia;
        }
        public frmLectores()
        {
            InitializeComponent();
        }
        private void dgvLectores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAgregarOEditarLector frm = new frmAgregarOEditarLector();
            this.AddOwnedForm(frm);
            if (e.ColumnIndex == dgvLectores.Columns[dgvLectores.ColumnCount - 1].Index && e.RowIndex >= 0)
            {
                validacion2 = true;
                frm.identificador = dgvLectores.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm.txtNombre.Text = dgvLectores.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtApellido.Text = dgvLectores.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.txtCorreo.Text = dgvLectores.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (dgvLectores.Rows[e.RowIndex].Cells[3].Value.ToString() == "Activo") { frm.cbEstado.SelectedItem = frm.cbEstado.Items[0]; }
                else { frm.cbEstado.SelectedItem = frm.cbEstado.Items[1]; }
                frm.txtNombre.Enabled = false;
                frm.txtApellido.Enabled = false;
                frm.txtCorreo.Enabled = false;
                frm.cbEstado.Enabled = false;
                frm.ShowDialog();
            }
        }
        private void frmLectores_Load(object sender, EventArgs e)
        {
            claseLector.MostrarLectores(dgvLectores);
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            validacion1 = true;
            frmAgregarOEditarLector frm = new frmAgregarOEditarLector();
            this.AddOwnedForm(frm);
            frm.ShowDialog();
        }
    }
}
