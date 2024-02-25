using System.Data;

namespace TrabajoFinal_Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //boton aceptar, este hace un query a la tabla de usuarios utilizando el valor cuenta tomado del textbox cuenta, luego valida que el password en tel textbox sea igual al valor del registro pass del usuairo
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

        //boton cancelar, pregunta si desea cerrar el programa
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
