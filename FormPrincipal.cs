using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal_Biblioteca
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        //llama al formulario hijo FormInventario
        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInventario newChildForm = new FormInventario();
            newChildForm.MdiParent = this;
            newChildForm.Show();
        }

        //llama al formulario hijo FormPrestamo
        private void prestarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrestamo newChildForm = new FormPrestamo();
            newChildForm.MdiParent = this;
            newChildForm.Show();
        }

        //llama al formulario hijo FormCuentas
        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCuentas newChildForm = new FormCuentas();
            newChildForm.MdiParent = this;
            newChildForm.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        //Realiza una validacion antes de salir del programa
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir de esta aplicacion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
