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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            listView1 = new ListView();
            label1 = new Label();
            button2 = new Button();
            tabControl1.SuspendLayout();
            btnPbuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Prestar Libro";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(30, 157);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 243);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
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
            // button2
            // 
            button2.Location = new Point(439, 363);
            button2.Name = "button2";
            button2.Size = new Size(177, 37);
            button2.TabIndex = 2;
            button2.Text = "Ir al Formulario de Préstamo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
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
    }
}