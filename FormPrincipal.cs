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

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prestarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrestamo newChildForm = new FormPrestamo();
            newChildForm.MdiParent = this;
            newChildForm.Show();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCuentas newChildForm = new FormCuentas();
            newChildForm.MdiParent = this;
            newChildForm.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

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
