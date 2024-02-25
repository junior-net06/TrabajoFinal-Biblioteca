using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal_Biblioteca
{
    public partial class FormCuentas : Form
    {
        public FormCuentas()
        {
            InitializeComponent();
        }

        //funcion que carga los datos de la tabla usuarios en el datagridview del form usuarios
        private void load_datagrid()
        {
            CRUDoperations usuarios = new CRUDoperations();
            DataTable dtusuarios = usuarios.GetAllUsuarios();
            dataGridView1.DataSource = dtusuarios;

        }

        //funcion que carga los datos de la tabla estudiantes en el datagridview del form estudiantes
        private void load_datagridEstudiantes()
        {
            CRUDoperations estudiantes = new CRUDoperations();
            DataTable dtestudiantes = estudiantes.GetAllEstudiantes();
            dataGridView2.DataSource = dtestudiantes;

        }

        //llama las funciones que populan los datagrid del form Estudiantes y del form Usuarios
        private void FormCuentas_Load(object sender, EventArgs e)
        {
            load_datagrid();
            load_datagridEstudiantes();
        }

        //funcion para limpiar los controles del formulario Usuario
        private void limpiar_controles()
        {
            textBoxABid.Text = null;
            textBoxABnombre.Text = null;
            textBoxABcuenta.Text = null;
            textBoxABpass.Text = null;
            textBoxABbuscarCuenta.Text = null;
        }

        //Busca los datos de un estudiante en base a su cuenta luego carga los datos en los controles 
        private void buttonABbuscar_Click(object sender, EventArgs e)
        {
            CRUDoperations usuarios = new CRUDoperations();
            DataTable dtusuarios = usuarios.GetUsuario(textBoxABbuscarCuenta.Text.Trim());

            //Confirmar si la tabla tiene datos
            if (dtusuarios.Rows.Count > 0)
            {
                DataRow row = dtusuarios.Rows[0];
                textBoxABid.Text = row["id_usuarios"].ToString();
                textBoxABnombre.Text = row["Nombre"].ToString();
                textBoxABcuenta.Text = row["cuenta"].ToString();
                textBoxABpass.Text = row["pass"].ToString();
            }
            else
            {
                limpiar_controles();
                MessageBox.Show("Revise y trate de nuevo", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //inserta los valores del los controles del form estudiante a la tabla estudiante
        private void buttonABinsertar_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDoperations InsertarUsuarios = new CRUDoperations();
                InsertarUsuarios.InsertUsuario(textBoxABnombre.Text.Trim(), textBoxABcuenta.Text.Trim(), textBoxABpass.Text.Trim());
                load_datagrid();
                limpiar_controles();
                MessageBox.Show("Los datos han sido insertados correctamente", "Insertar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                limpiar_controles();
                MessageBox.Show("Ha ocurrido unrror al guardar,favor reevise y trate de nuevo", "Insertar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Borrar los datos de un estudiante previamente buscado con el boton buscar
        private void buttonABborrar_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDoperations BorrarUsuario = new CRUDoperations();
                BorrarUsuario.DeleteUsuario(Convert.ToInt32(textBoxABid.Text.Trim()));
                limpiar_controles();
                load_datagrid();
                MessageBox.Show("Los datos han sido eliminados correctamente", "Borrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                limpiar_controles();
                MessageBox.Show("Ha ocurrido un error al borrar,favor reevise y trate de nuevo", "Borrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //actualiza los datos de un estudiante previamente buscado con el boton buscar
        private void buttonABactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDoperations ActualizarUsuario = new CRUDoperations();
                ActualizarUsuario.UpdateUsuario(Convert.ToInt32(textBoxABid.Text.Trim()), textBoxABnombre.Text.Trim(), textBoxABcuenta.Text.Trim(), textBoxABpass.Text.Trim());
                limpiar_controles();
                load_datagrid();
                MessageBox.Show("Los datos han sido actualizados correctamente", "Borrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                limpiar_controles();
                MessageBox.Show("Ha ocurrido un error al actualizar,favor reevise y trate de nuevo", "Borrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //funcion para limpiar los controles del form de estudiantes
        private void limpiar_controlesEstudiantes()
        {
            textBoxAEid.Text = null;
            textBoxAEnombre.Text = null;
            textBoxAEapellido.Text = null;
            textBoxAEmatricula.Text = null;
            textBoxAEdireccion.Text = null;
        }

        //Carga el resultado de la busqueda de estudiante y muestra el resultado en los controles del form
        private void button4_Click(object sender, EventArgs e)
        {
            CRUDoperations estudiantes = new CRUDoperations();
            DataTable dtestudiantes = estudiantes.GetEstudiante(maskedTextBoxAEbuscar.Text.Trim());

            //Confirmar si la tabla tiene datos
            if (dtestudiantes.Rows.Count > 0)
            {
                DataRow row = dtestudiantes.Rows[0];
                textBoxAEid.Text = row["id_estudiantes"].ToString();
                textBoxAEnombre.Text = row["nombre"].ToString();
                textBoxAEapellido.Text = row["apellido"].ToString();
                textBoxAEmatricula.Text = row["matricula"].ToString();
                textBoxAEdireccion.Text = row["direccion"].ToString();
            }
            else
            {
                limpiar_controlesEstudiantes();
                MessageBox.Show("Revise y trate de nuevo", "Estuadiante no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Agrega estudiantes a la tabla de estudiantes
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDoperations InsertarEstudiantes = new CRUDoperations();
                InsertarEstudiantes.InsertEstudiante(textBoxAEnombre.Text.Trim(), textBoxAEapellido.Text.Trim(), textBoxAEdireccion.Text.Trim(), textBoxAEmatricula.Text.Trim());
                load_datagridEstudiantes();
                limpiar_controlesEstudiantes();
                MessageBox.Show("Los datos han sido insertados correctamente", "Insertar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                limpiar_controlesEstudiantes();
                MessageBox.Show("Ha ocurrido un error al guardar,favor reevise y trate de nuevo", "Insertar Estuadiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //borrar estudiantes de la tabla utilizando el id_estudiante previamente buscado
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDoperations BorrarEstuadiante = new CRUDoperations();
                BorrarEstuadiante.DeleteEstudiante(Convert.ToInt32(textBoxAEid.Text.Trim()));
                load_datagridEstudiantes();
                limpiar_controlesEstudiantes();
                MessageBox.Show("Los datos han sido eliminados correctamente", "Borrar estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                limpiar_controles();
                MessageBox.Show("Ha ocurrido un error al borrar,favor reevise y trate de nuevo", "Borrar estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //actualizar campos de estudiantes
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDoperations ActualizarEstudiantes = new CRUDoperations();
                ActualizarEstudiantes.UpdateEstudiante(Convert.ToInt32(textBoxAEid.Text.Trim()), textBoxAEnombre.Text.Trim(), textBoxAEapellido.Text.Trim(), textBoxAEdireccion.Text.Trim(), textBoxAEmatricula.Text.Trim());
                limpiar_controlesEstudiantes();
                load_datagridEstudiantes();
                MessageBox.Show("Los datos han sido actualizados correctamente", "Borrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                limpiar_controlesEstudiantes();
                MessageBox.Show("Ha ocurrido un error al actualizar,favor reevise y trate de nuevo", "Borrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
