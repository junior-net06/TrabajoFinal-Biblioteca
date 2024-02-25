using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal_Biblioteca
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        //cargar el datagridview1 cuando el form cargue
        private void FormInventario_Load(object sender, EventArgs e)
        {
            load_datagrid();
        }

        //funcion para cargar la tabla libros en el datagridview1
        private void load_datagrid()
        {
            CRUDoperations inventario = new CRUDoperations();
            DataTable dtinventario = inventario.GetAllLibros();
            dataGridView1.DataSource = dtinventario;

        }

        //funcion para limpiar los controles del form inventario
        private void limpiar_controles()
        {
            textBoxIid.Text = null;
            textBoxItitulo.Text = null;
            textBoxIautor.Text = null;
            textBoxIeditora.Text = null;
            textBoxIisbn.Text = null;
            dateTimePicker1.Text = null;
        }

        //boton para buscar libros utilizando el dato isbn
        private void buttonIbuscar_Click(object sender, EventArgs e)
        {
            CRUDoperations libros = new CRUDoperations();
            DataTable dtlibros = libros.GetLibroByCode(textBoxIbuscar.Text.Trim());

            DateTime time = DateTime.Now;
            //Confirmar si la tabla tiene datos
            if (dtlibros.Rows.Count > 0)
            {
                DataRow row = dtlibros.Rows[0];
                textBoxIid.Text = row["id_libros"].ToString();
                textBoxItitulo.Text = row["titulos"].ToString();
                textBoxIautor.Text = row["autor"].ToString();
                textBoxIeditora.Text = row["editora"].ToString();
                textBoxIisbn.Text = row["ISBN"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row["Fecha_publicacion"]);
                //dateTimePicker1.Value = time;
            }
            else
            {
                limpiar_controles();
                MessageBox.Show("Revise y trate de nuevo", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //inserta los datos de los controles en la tabla libros
        private void buttonIinsertar_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDoperations InsertarLibros = new CRUDoperations();
                InsertarLibros.InsertLibro(textBoxItitulo.Text.Trim(), textBoxIautor.Text.Trim(), textBoxIeditora.Text.Trim(), dateTimePicker1.Value, textBoxIisbn.Text.Trim());
                load_datagrid();
                limpiar_controles();
                MessageBox.Show("Los datos han sido insertados correctamente", "Insertar libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                limpiar_controles();
                MessageBox.Show("Ha ocurrido unrror al guardar,favor reevise y trate de nuevo", "Insertar libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //borra un record previamente buscado de la tabla libros
        private void buttonIborrar_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDoperations BorrarLibro = new CRUDoperations();
                BorrarLibro.DeleteLibro(Convert.ToInt32(textBoxIid.Text.Trim()));
                limpiar_controles();
                load_datagrid();
                MessageBox.Show("Los datos han sido eliminados correctamente", "Borrar libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                limpiar_controles();
                MessageBox.Show("Ha ocurrido un error al borrar,favor reevise y trate de nuevo", "Borrar libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //actualiza un record previamente buscado en la tabla libros
        private void buttonIactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDoperations ActualizarLibro = new CRUDoperations();
                ActualizarLibro.UpdateLibro(Convert.ToInt32(textBoxIid.Text.Trim()), textBoxItitulo.Text.Trim(), textBoxIautor.Text.Trim(), textBoxIeditora.Text.Trim(), dateTimePicker1.Value, textBoxIisbn.Text.Trim());
                limpiar_controles();
                load_datagrid();
                MessageBox.Show("Los datos han sido actualizados correctamente", "Actualizar libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                limpiar_controles();
                MessageBox.Show("Ha ocurrido un error al actualizar,favor reevise y trate de nuevo", "Actualizar libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
