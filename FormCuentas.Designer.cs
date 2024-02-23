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
            tabPage2 = new TabPage();
            Usuarios.SuspendLayout();
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Usuarios);
            Name = "FormCuentas";
            Text = "FormCuentas";
            Usuarios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl Usuarios;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}