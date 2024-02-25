namespace TrabajoFinal_Biblioteca
{
    partial class FormCuentas
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
            Usuarios = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            buttonABactualizar = new Button();
            buttonABborrar = new Button();
            buttonABinsertar = new Button();
            buttonABbuscar = new Button();
            textBoxABpass = new TextBox();
            label4 = new Label();
            textBoxABbuscarCuenta = new TextBox();
            textBoxABcuenta = new TextBox();
            label5 = new Label();
            label3 = new Label();
            textBoxABnombre = new TextBox();
            label2 = new Label();
            textBoxABid = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            dataGridView2 = new DataGridView();
            panel3 = new Panel();
            maskedTextBoxAEbuscar = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBoxAEdireccion = new TextBox();
            label11 = new Label();
            textBoxAEmatricula = new TextBox();
            label6 = new Label();
            textBoxAEapellido = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBoxAEnombre = new TextBox();
            label9 = new Label();
            textBoxAEid = new TextBox();
            label10 = new Label();
            Usuarios.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Usuarios
            // 
            Usuarios.Controls.Add(tabPage1);
            Usuarios.Controls.Add(tabPage2);
            Usuarios.Dock = DockStyle.Fill;
            Usuarios.Location = new Point(0, 0);
            Usuarios.Name = "Usuarios";
            Usuarios.SelectedIndex = 0;
            Usuarios.Size = new Size(800, 450);
            Usuarios.TabIndex = 0;
            Usuarios.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Administrar usuarios";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 313);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(786, 313);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonABactualizar);
            panel1.Controls.Add(buttonABborrar);
            panel1.Controls.Add(buttonABinsertar);
            panel1.Controls.Add(buttonABbuscar);
            panel1.Controls.Add(textBoxABpass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxABbuscarCuenta);
            panel1.Controls.Add(textBoxABcuenta);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxABnombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxABid);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 103);
            panel1.TabIndex = 0;
            // 
            // buttonABactualizar
            // 
            buttonABactualizar.Font = new Font("Segoe UI", 11.25F);
            buttonABactualizar.Location = new Point(482, 61);
            buttonABactualizar.Name = "buttonABactualizar";
            buttonABactualizar.Size = new Size(75, 27);
            buttonABactualizar.TabIndex = 2;
            buttonABactualizar.Text = "Actualizar";
            buttonABactualizar.UseVisualStyleBackColor = true;
            buttonABactualizar.Click += buttonABactualizar_Click;
            // 
            // buttonABborrar
            // 
            buttonABborrar.Font = new Font("Segoe UI", 11.25F);
            buttonABborrar.Location = new Point(401, 61);
            buttonABborrar.Name = "buttonABborrar";
            buttonABborrar.Size = new Size(75, 27);
            buttonABborrar.TabIndex = 2;
            buttonABborrar.Text = "Borrar";
            buttonABborrar.UseVisualStyleBackColor = true;
            buttonABborrar.Click += buttonABborrar_Click;
            // 
            // buttonABinsertar
            // 
            buttonABinsertar.Font = new Font("Segoe UI", 11.25F);
            buttonABinsertar.Location = new Point(320, 61);
            buttonABinsertar.Name = "buttonABinsertar";
            buttonABinsertar.Size = new Size(75, 27);
            buttonABinsertar.TabIndex = 2;
            buttonABinsertar.Text = "Insertar";
            buttonABinsertar.UseVisualStyleBackColor = true;
            buttonABinsertar.Click += buttonABinsertar_Click;
            // 
            // buttonABbuscar
            // 
            buttonABbuscar.Font = new Font("Segoe UI", 11.25F);
            buttonABbuscar.Location = new Point(239, 61);
            buttonABbuscar.Name = "buttonABbuscar";
            buttonABbuscar.Size = new Size(75, 27);
            buttonABbuscar.TabIndex = 2;
            buttonABbuscar.Text = "Buscar";
            buttonABbuscar.UseVisualStyleBackColor = true;
            buttonABbuscar.Click += buttonABbuscar_Click;
            // 
            // textBoxABpass
            // 
            textBoxABpass.Font = new Font("Segoe UI", 11.25F);
            textBoxABpass.Location = new Point(593, 17);
            textBoxABpass.Name = "textBoxABpass";
            textBoxABpass.PasswordChar = '*';
            textBoxABpass.Size = new Size(146, 27);
            textBoxABpass.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(514, 16);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 0;
            label4.Text = "Password:";
            // 
            // textBoxABbuscarCuenta
            // 
            textBoxABbuscarCuenta.Font = new Font("Segoe UI", 11.25F);
            textBoxABbuscarCuenta.Location = new Point(108, 61);
            textBoxABbuscarCuenta.Name = "textBoxABbuscarCuenta";
            textBoxABbuscarCuenta.Size = new Size(118, 27);
            textBoxABbuscarCuenta.TabIndex = 1;
            // 
            // textBoxABcuenta
            // 
            textBoxABcuenta.Location = new Point(390, 17);
            textBoxABcuenta.Name = "textBoxABcuenta";
            textBoxABcuenta.Size = new Size(118, 23);
            textBoxABcuenta.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(5, 64);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 0;
            label5.Text = "Buscar cuenta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(326, 16);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 0;
            label3.Text = "Cuenta:";
            // 
            // textBoxABnombre
            // 
            textBoxABnombre.Location = new Point(158, 17);
            textBoxABnombre.Name = "textBoxABnombre";
            textBoxABnombre.Size = new Size(162, 23);
            textBoxABnombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(85, 16);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // textBoxABid
            // 
            textBoxABid.Enabled = false;
            textBoxABid.Font = new Font("Segoe UI", 11.25F);
            textBoxABid.Location = new Point(32, 13);
            textBoxABid.Name = "textBoxABid";
            textBoxABid.Size = new Size(48, 27);
            textBoxABid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(5, 16);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Administrar Estuadiantes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 123);
            panel4.Name = "panel4";
            panel4.Size = new Size(786, 296);
            panel4.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(786, 296);
            dataGridView2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(maskedTextBoxAEbuscar);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(textBoxAEdireccion);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(textBoxAEmatricula);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBoxAEapellido);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBoxAEnombre);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(textBoxAEid);
            panel3.Controls.Add(label10);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(786, 120);
            panel3.TabIndex = 0;
            // 
            // maskedTextBoxAEbuscar
            // 
            maskedTextBoxAEbuscar.Location = new Point(131, 84);
            maskedTextBoxAEbuscar.Mask = "000000000";
            maskedTextBoxAEbuscar.Name = "maskedTextBoxAEbuscar";
            maskedTextBoxAEbuscar.Size = new Size(155, 23);
            maskedTextBoxAEbuscar.TabIndex = 5;
            maskedTextBoxAEbuscar.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F);
            button1.Location = new Point(535, 80);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 9;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F);
            button2.Location = new Point(454, 80);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 8;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F);
            button3.Location = new Point(373, 80);
            button3.Name = "button3";
            button3.Size = new Size(75, 27);
            button3.TabIndex = 7;
            button3.Text = "Insertar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11.25F);
            button4.Location = new Point(292, 80);
            button4.Name = "button4";
            button4.Size = new Size(75, 27);
            button4.TabIndex = 6;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxAEdireccion
            // 
            textBoxAEdireccion.Font = new Font("Segoe UI", 11.25F);
            textBoxAEdireccion.Location = new Point(82, 36);
            textBoxAEdireccion.Name = "textBoxAEdireccion";
            textBoxAEdireccion.Size = new Size(436, 27);
            textBoxAEdireccion.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.Location = new Point(2, 39);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 3;
            label11.Text = "Direccion:";
            // 
            // textBoxAEmatricula
            // 
            textBoxAEmatricula.Font = new Font("Segoe UI", 11.25F);
            textBoxAEmatricula.Location = new Point(604, 3);
            textBoxAEmatricula.Name = "textBoxAEmatricula";
            textBoxAEmatricula.Size = new Size(146, 27);
            textBoxAEmatricula.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(524, 6);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 3;
            label6.Text = "Matricula:";
            // 
            // textBoxAEapellido
            // 
            textBoxAEapellido.Location = new Point(400, 7);
            textBoxAEapellido.Name = "textBoxAEapellido";
            textBoxAEapellido.Size = new Size(118, 23);
            textBoxAEapellido.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(4, 83);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 4;
            label7.Text = "Buscar Matricula:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(325, 6);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 5;
            label8.Text = "Apellido:";
            // 
            // textBoxAEnombre
            // 
            textBoxAEnombre.Location = new Point(157, 7);
            textBoxAEnombre.Name = "textBoxAEnombre";
            textBoxAEnombre.Size = new Size(162, 23);
            textBoxAEnombre.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(84, 6);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 6;
            label9.Text = "Nombre:";
            // 
            // textBoxAEid
            // 
            textBoxAEid.Enabled = false;
            textBoxAEid.Font = new Font("Segoe UI", 11.25F);
            textBoxAEid.Location = new Point(31, 3);
            textBoxAEid.Name = "textBoxAEid";
            textBoxAEid.Size = new Size(48, 27);
            textBoxAEid.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.Location = new Point(4, 7);
            label10.Name = "label10";
            label10.Size = new Size(27, 20);
            label10.TabIndex = 7;
            label10.Text = "ID:";
            // 
            // FormCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Usuarios);
            Name = "FormCuentas";
            Text = "FormCuentas";
            WindowState = FormWindowState.Maximized;
            Load += FormCuentas_Load;
            Usuarios.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Usuarios;
        private TabPage tabPage1;
        private Panel panel1;
        private TabPage tabPage2;
        private TextBox textBoxABpass;
        private Label label4;
        private TextBox textBoxABbuscarCuenta;
        private TextBox textBoxABcuenta;
        private Label label5;
        private Label label3;
        private TextBox textBoxABnombre;
        private Label label2;
        private TextBox textBoxABid;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button buttonABactualizar;
        private Button buttonABborrar;
        private Button buttonABinsertar;
        private Button buttonABbuscar;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBoxAEmatricula;
        private Label label6;
        private TextBox textBoxAEapellido;
        private Label label7;
        private Label label8;
        private TextBox textBoxAEnombre;
        private Label label9;
        private TextBox textBoxAEid;
        private Label label10;
        private Panel panel4;
        private DataGridView dataGridView2;
        private TextBox textBoxAEdireccion;
        private Label label11;
        private MaskedTextBox maskedTextBoxAEbuscar;
    }
}