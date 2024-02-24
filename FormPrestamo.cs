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

        public int id_libro = 0;
        public int id_estudiante = 0;

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

        private void FormPrestamo_Load(object sender, EventArgs e)
        {
            CRUDoperations estudiantes = new CRUDoperations();
            DataTable dtestudiantes = estudiantes.GetAllEstudiantes();
            comboBox2.DataSource = dtestudiantes;
            comboBox2.DisplayMember = "Matricula";

            //load datagrird
            load_datagrid();
        }

        private void load_datagrid()
        {
            CRUDoperations prestamo = new CRUDoperations();
            DataTable drprestamo = prestamo.GetAllPrestamos();
            dataGridView1.DataSource = drprestamo;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            load_datagrid();
            int days = Convert.ToInt32(numericUpDown1.Value);
            DateTime fecha_salida = DateTime.Now;
            DateTime fecha_devolucion = fecha_salida.AddDays(days);

            
            if (comboBox1.SelectedIndex != -1)
            {
                DataRowView selectedRow = comboBox1.SelectedItem as DataRowView;

                if (selectedRow != null)
                {
                    id_libro = Convert.ToInt32(selectedRow["Id_libros"]);
                }
            }

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
