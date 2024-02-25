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
using System.Xml;

namespace TrabajoFinal_Biblioteca
{
    public partial class FormPrestamo : Form
    {
        public FormPrestamo()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        //declara e inicializa las variable que contendran los id de los libros y estudiantes
        public int id_libro = 0;
        public int id_estudiante = 0;

        //Boton para buscar los libros con un query like, el query ejecutado sera en funcion al radiobutton seleccionado
        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                CRUDoperations libros = new CRUDoperations();
                DataTable dtlibros = libros.GetLibroByName(textBoxPdbuscar.Text.Trim());
                if (dtlibros.Rows.Count > 0)
                {
                    label1.Visible = false;
                    comboBox1.Visible = true;
                    comboBox1.DataSource = dtlibros;
                    comboBox1.DisplayMember = "Titulos";
                }
                else
                {
                    label1.Text = "Sin resultados";
                    label1.Visible = true;
                    comboBox1.DataSource = null;
                    comboBox1.Visible = false;
                    id_libro = 0;
                }
            }
            if (radioButton2.Checked == true)
            {
                CRUDoperations libroS = new CRUDoperations();
                DataTable dtlibroS = libroS.GetLibroByAuthor(textBoxPdbuscar.Text.Trim());
                if (dtlibroS.Rows.Count > 0)
                {
                    comboBox1.Visible = true;
                    label1.Visible = false;
                    comboBox1.DataSource = dtlibroS;
                    comboBox1.DisplayMember = "Titulos";

                }
                else
                {
                    label1.Text = "Sin resultados";
                    label1.Visible = true;
                    comboBox1.DataSource = null;
                    comboBox1.Visible = false;
                    id_libro = 0;
                }
            }
            if (radioButton3.Checked == true)
            {
                CRUDoperations libroC = new CRUDoperations();
                DataTable dtlibroC = libroC.GetLibroByCode(textBoxPdbuscar.Text.Trim());
                if (dtlibroC.Rows.Count > 0)
                {
                    comboBox1.Visible = true;
                    label1.Visible = false;
                    comboBox1.DataSource = dtlibroC;
                    comboBox1.DisplayMember = "Titulos";

                }
                else
                {
                    label1.Text = "Sin resultados";
                    label1.Visible = true;
                    comboBox1.DataSource = null;
                    comboBox1.Visible = false;
                    id_libro = 0;
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPbuscar_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Carga los datos de la tabla estudiante en un combobox y los filtra por matricula, luego carga los datos del datagridview1
        private void FormPrestamo_Load(object sender, EventArgs e)
        {
            CRUDoperations estudiantes = new CRUDoperations();
            DataTable dtestudiantes = estudiantes.GetAllEstudiantes();
            comboBox2.DataSource = dtestudiantes;
            comboBox2.DisplayMember = "Matricula";

            //load datagrird
            load_datagrid();
        }

        //funcion que carga los datos en el datagridview1
        private void load_datagrid()
        {
            CRUDoperations prestamo = new CRUDoperations();
            DataTable drprestamo = prestamo.GetAllPrestamos();
            dataGridView1.DataSource = drprestamo;

        }

        //boton que realiza la insersion de los datos en la tabla prestamo utilizando los valores cargados en introducidos en el form, tambien realiza las validaciones adecuadas.
        private void button2_Click(object sender, EventArgs e)
        {
            load_datagrid();
            int days = Convert.ToInt32(numericUpDown1.Value);
            DateTime fecha_salida = DateTime.Now;
            DateTime fecha_devolucion = fecha_salida.AddDays(days);

            //valida que la informacion concerniente al id del libro este seleccionada en el comboBox1
            if (comboBox1.SelectedIndex != -1)
            {
                DataRowView selectedRow = comboBox1.SelectedItem as DataRowView;

                if (selectedRow != null)
                {
                    id_libro = Convert.ToInt32(selectedRow["Id_libros"]);
                }
            }

            //valida que la informacion concerniente al id del estudiante este seleccionada en el comboBox2
            if (comboBox2.SelectedIndex != -1)
            {
                DataRowView selectedRow = comboBox2.SelectedItem as DataRowView;

                if (selectedRow != null)
                {
                    id_estudiante = Convert.ToInt32(selectedRow["id_estudiantes"]);
                }
            }


            label5.Text = id_libro.ToString();
            label6.Text = id_estudiante.ToString();

            //valida que la fecha de entrega no sea un fin de semana y si lo es, muestra la informacion pertinente en un label
            if (fecha_devolucion.DayOfWeek == DayOfWeek.Saturday || fecha_devolucion.DayOfWeek == DayOfWeek.Sunday)
            {
                label4.Visible = true;
                label4.Text = "El libro sera entregado el proximo Lunes";
            }
            else
            {
                label4.Visible = false; 
                textBox1.Text = fecha_devolucion.ToString();

                load_datagrid();

            }

            //valida que el valor de la variable id_libro contenga algun valor antes proceder a insertar los datos en la BD
            if (id_libro > 0)
            {
                
                CRUDoperations insertarPrestamos = new CRUDoperations();
                insertarPrestamos.InsertPrestamo(id_libro, id_estudiante, fecha_salida, fecha_devolucion);
                MessageBox.Show("Datos insertados correctamente", "Insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Revise revise que haya selecionado un libro y un estudiante", "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
