namespace TrabajoFinal_Biblioteca
{
    partial class FormInventario
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
            panel1 = new Panel();
            textBoxIisbn = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            buttonIactualizar = new Button();
            buttonIborrar = new Button();
            buttonIinsertar = new Button();
            buttonIbuscar = new Button();
            textBoxIeditora = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            textBoxIbuscar = new TextBox();
            textBoxIautor = new TextBox();
            label5 = new Label();
            label3 = new Label();
            textBoxItitulo = new TextBox();
            label2 = new Label();
            textBoxIid = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxIisbn);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(buttonIactualizar);
            panel1.Controls.Add(buttonIborrar);
            panel1.Controls.Add(buttonIinsertar);
            panel1.Controls.Add(buttonIbuscar);
            panel1.Controls.Add(textBoxIeditora);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxIbuscar);
            panel1.Controls.Add(textBoxIautor);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxItitulo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxIid);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 153);
            panel1.TabIndex = 0;
            // 
            // textBoxIisbn
            // 
            textBoxIisbn.Location = new Point(426, 56);
            textBoxIisbn.Name = "textBoxIisbn";
            textBoxIisbn.Size = new Size(118, 27);
            textBoxIisbn.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(170, 54);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // buttonIactualizar
            // 
            buttonIactualizar.Font = new Font("Segoe UI", 11.25F);
            buttonIactualizar.Location = new Point(484, 105);
            buttonIactualizar.Name = "buttonIactualizar";
            buttonIactualizar.Size = new Size(90, 27);
            buttonIactualizar.TabIndex = 11;
            buttonIactualizar.Text = "Actualizar";
            buttonIactualizar.UseVisualStyleBackColor = true;
            buttonIactualizar.Click += buttonIactualizar_Click;
            // 
            // buttonIborrar
            // 
            buttonIborrar.Font = new Font("Segoe UI", 11.25F);
            buttonIborrar.Location = new Point(403, 105);
            buttonIborrar.Name = "buttonIborrar";
            buttonIborrar.Size = new Size(75, 27);
            buttonIborrar.TabIndex = 10;
            buttonIborrar.Text = "Borrar";
            buttonIborrar.UseVisualStyleBackColor = true;
            buttonIborrar.Click += buttonIborrar_Click;
            // 
            // buttonIinsertar
            // 
            buttonIinsertar.Font = new Font("Segoe UI", 11.25F);
            buttonIinsertar.Location = new Point(322, 105);
            buttonIinsertar.Name = "buttonIinsertar";
            buttonIinsertar.Size = new Size(75, 27);
            buttonIinsertar.TabIndex = 9;
            buttonIinsertar.Text = "Insertar";
            buttonIinsertar.UseVisualStyleBackColor = true;
            buttonIinsertar.Click += buttonIinsertar_Click;
            // 
            // buttonIbuscar
            // 
            buttonIbuscar.Font = new Font("Segoe UI", 11.25F);
            buttonIbuscar.Location = new Point(241, 105);
            buttonIbuscar.Name = "buttonIbuscar";
            buttonIbuscar.Size = new Size(75, 27);
            buttonIbuscar.TabIndex = 8;
            buttonIbuscar.Text = "Buscar";
            buttonIbuscar.UseVisualStyleBackColor = true;
            buttonIbuscar.Click += buttonIbuscar_Click;
            // 
            // textBoxIeditora
            // 
            textBoxIeditora.Font = new Font("Segoe UI", 11.25F);
            textBoxIeditora.Location = new Point(567, 13);
            textBoxIeditora.Name = "textBoxIeditora";
            textBoxIeditora.Size = new Size(146, 27);
            textBoxIeditora.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(12, 61);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 3;
            label6.Text = "Fecha de publicacion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(501, 15);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 3;
            label7.Text = "Editora:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(376, 59);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = "ISBN:";
            // 
            // textBoxIbuscar
            // 
            textBoxIbuscar.Font = new Font("Segoe UI", 11.25F);
            textBoxIbuscar.Location = new Point(110, 105);
            textBoxIbuscar.Name = "textBoxIbuscar";
            textBoxIbuscar.Size = new Size(118, 27);
            textBoxIbuscar.TabIndex = 7;
            // 
            // textBoxIautor
            // 
            textBoxIautor.Location = new Point(377, 13);
            textBoxIautor.Name = "textBoxIautor";
            textBoxIautor.Size = new Size(118, 27);
            textBoxIautor.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(12, 108);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 4;
            label5.Text = "Buscar ISBN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(322, 16);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Autor:";
            // 
            // textBoxItitulo
            // 
            textBoxItitulo.Location = new Point(154, 12);
            textBoxItitulo.Name = "textBoxItitulo";
            textBoxItitulo.Size = new Size(162, 27);
            textBoxItitulo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(99, 16);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Titulo:";
            // 
            // textBoxIid
            // 
            textBoxIid.Enabled = false;
            textBoxIid.Font = new Font("Segoe UI", 11.25F);
            textBoxIid.Location = new Point(45, 12);
            textBoxIid.Name = "textBoxIid";
            textBoxIid.Size = new Size(48, 27);
            textBoxIid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 7;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(728, 447);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(728, 447);
            dataGridView1.TabIndex = 0;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInventario";
            Text = "Inventario";
            Load += FormInventario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonIactualizar;
        private Button buttonIborrar;
        private Button buttonIinsertar;
        private Button buttonIbuscar;
        private TextBox textBoxIeditora;
        private Label label4;
        private TextBox textBoxIbuscar;
        private TextBox textBoxIautor;
        private Label label5;
        private Label label3;
        private TextBox textBoxItitulo;
        private Label label2;
        private TextBox textBoxIid;
        private Label label1;
        private TextBox textBoxIisbn;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private DataGridView dataGridView1;
    }
}