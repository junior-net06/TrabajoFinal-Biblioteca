namespace TrabajoFinal_Biblioteca
{
    partial class FormPrincipal
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
            menuStrip1 = new MenuStrip();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            administrarToolStripMenuItem = new ToolStripMenuItem();
            prestarLibrosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inventarioToolStripMenuItem, administrarToolStripMenuItem, prestarLibrosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(72, 20);
            inventarioToolStripMenuItem.Text = "&Inventario";
            inventarioToolStripMenuItem.Click += inventarioToolStripMenuItem_Click;
            // 
            // administrarToolStripMenuItem
            // 
            administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            administrarToolStripMenuItem.Size = new Size(100, 20);
            administrarToolStripMenuItem.Text = "&Administracion";
            administrarToolStripMenuItem.Click += administrarToolStripMenuItem_Click;
            // 
            // prestarLibrosToolStripMenuItem
            // 
            prestarLibrosToolStripMenuItem.Name = "prestarLibrosToolStripMenuItem";
            prestarLibrosToolStripMenuItem.Size = new Size(87, 20);
            prestarLibrosToolStripMenuItem.Text = "&Prestar libros";
            prestarLibrosToolStripMenuItem.Click += prestarLibrosToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipal";
            Text = "Gestion Biblioteca";
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem administrarToolStripMenuItem;
        private ToolStripMenuItem prestarLibrosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}