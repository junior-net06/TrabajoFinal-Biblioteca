
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
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBoxPdbuscar = new TextBox();
            comboBox1 = new ComboBox();
            radioButton3 = new RadioButton();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(117, 11);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Autor";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(56, 11);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Titulo";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 47);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 5;
            label1.Text = "Estado del lbro...";
            label1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(291, 36);
            button1.Name = "button1";
            button1.Size = new Size(100, 37);
            button1.TabIndex = 2;
            button1.Text = "Buscar libro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxPdbuscar
            // 
            textBoxPdbuscar.Location = new Point(62, 36);
            textBoxPdbuscar.Multiline = true;
            textBoxPdbuscar.Name = "textBoxPdbuscar";
            textBoxPdbuscar.Size = new Size(223, 37);
            textBoxPdbuscar.TabIndex = 1;
            textBoxPdbuscar.Tag = "";
            textBoxPdbuscar.UseWaitCursor = true;
            textBoxPdbuscar.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(414, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(178, 12);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(64, 19);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "Codigo";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 105);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 12;
            label2.Text = "Estudiante:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(117, 102);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 105);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 12;
            label3.Text = "Cantidad de dias:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(405, 102);
            numericUpDown1.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Location = new Point(14, 138);
            button2.Name = "button2";
            button2.Size = new Size(97, 43);
            button2.TabIndex = 14;
            button2.Text = "Prestar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(138, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 152);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 12;
            label4.Text = "Mensaje";
            label4.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(664, 179);
            dataGridView1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(553, 47);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 12;
            label5.Text = "Mensaje";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(553, 104);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 12;
            label6.Text = "Mensaje";
            // 
            // FormPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 439);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButton3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(radioButton1);
            Controls.Add(textBoxPdbuscar);
            Name = "FormPrestamo";
            Text = "FormPrestamo";
            Load += FormPrestamo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Button button1;
        private TextBox textBoxPdbuscar;
        private PictureBox pictureBox1;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private RadioButton radioButton3;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private TextBox textBox1;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
    }
}