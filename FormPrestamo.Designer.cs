namespace TrabajoFinal_Biblioteca
{
    partial class FormPrestamo
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
            tabControl1 = new TabControl();
            btnPbuscar = new TabPage();
            label1 = new Label();
            listView1 = new ListView();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            button3 = new Button();
            button4 = new Button();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            btnPbuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(btnPbuscar);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // btnPbuscar
            // 
            btnPbuscar.Controls.Add(label1);
            btnPbuscar.Controls.Add(listView1);
            btnPbuscar.Controls.Add(pictureBox1);
            btnPbuscar.Controls.Add(button2);
            btnPbuscar.Controls.Add(button1);
            btnPbuscar.Controls.Add(textBox1);
            btnPbuscar.Location = new Point(4, 24);
            btnPbuscar.Name = "btnPbuscar";
            btnPbuscar.Padding = new Padding(3);
            btnPbuscar.Size = new Size(792, 422);
            btnPbuscar.TabIndex = 0;
            btnPbuscar.Text = "Consultar Disponibilidad";
            btnPbuscar.UseVisualStyleBackColor = true;
            btnPbuscar.Click += btnPbuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 374);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 5;
            label1.Text = "Estado del lbro...";
            // 
            // listView1
            // 
            listView1.Location = new Point(30, 157);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 243);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_pointing_magnifying_glass_1024x1024;
            pictureBox1.Location = new Point(134, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(439, 363);
            button2.Name = "button2";
            button2.Size = new Size(177, 37);
            button2.TabIndex = 2;
            button2.Text = "Ir al Formulario de Préstamos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(395, 53);
            button1.Name = "button1";
            button1.Size = new Size(100, 37);
            button1.TabIndex = 2;
            button1.Text = "Buscar libro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 53);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 37);
            textBox1.TabIndex = 1;
            textBox1.Tag = "";
            textBox1.UseWaitCursor = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Prestar Libros";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline);
            label2.Location = new Point(105, 31);
            label2.Name = "label2";
            label2.Size = new Size(509, 32);
            label2.TabIndex = 0;
            label2.Text = "Formulario de Solicitud Préstamo de Libros";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 23);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 131);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "ISBN: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 223);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 0;
            label4.Text = "Prestar a: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 215);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(335, 131);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 0;
            label5.Text = "Nombre del libro:";
            label5.Click += this.label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(441, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 1;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 303);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 0;
            label6.Text = "Duración el préstamo: ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(494, 303);
            numericUpDown1.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 383);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 0;
            label7.Text = "Estado del Préstamo...";
            // 
            // button3
            // 
            button3.Location = new Point(253, 379);
            button3.Name = "button3";
            button3.Size = new Size(149, 23);
            button3.TabIndex = 3;
            button3.Text = "Procesar Solicitud";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(465, 383);
            button4.Name = "button4";
            button4.Size = new Size(149, 23);
            button4.TabIndex = 3;
            button4.Text = "Ver Fecha de Retorno";
            button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(335, 218);
            label8.Name = "label8";
            label8.Size = new Size(144, 15);
            label8.TabIndex = 0;
            label8.Text = "Matricular del Solicitante: ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(494, 210);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 1;
            textBox5.TextChanged += textBox4_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 305);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 0;
            label9.Text = "Teléfono:";
            label9.Click += label9_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(112, 303);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 23);
            textBox6.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.contact_form;
            pictureBox2.Location = new Point(8, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // FormPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormPrestamo";
            Text = "FormPrestamo";
            tabControl1.ResumeLayout(false);
            btnPbuscar.ResumeLayout(false);
            btnPbuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage btnPbuscar;
        private TabPage tabPage2;
        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private ListView listView1;
        private Label label1;
        private Button button2;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Button button4;
        private Button button3;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private PictureBox pictureBox2;
    }
}