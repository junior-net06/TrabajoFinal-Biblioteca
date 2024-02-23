using System.Data;

namespace TrabajoFinal_Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUDoperations usuarios = new CRUDoperations();
            DataTable dtusuarios = usuarios.GetUsuario(textBoxLUsuario.Text.Trim());

            //Confirmar si la tabla tiene datos
            if (dtusuarios.Rows.Count > 0)
            {
                DataRow linea = dtusuarios.Rows[0];
                String dbclave = linea["pass"].ToString();
                string txtpass = textBoxLclave.Text.Trim();
                if (txtpass == dbclave)
                {
                    this.Hide();

                    FormPrincipal newdForm = new FormPrincipal();
                    //newChildForm.MdiParent = this;
                    newdForm.Show();
                }
                else
                {
                    MessageBox.Show("Clave incorrecta", "Revise su clave y trate de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Revise y trate de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir de esta aplicacion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
