namespace PryFernandezE
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuPrincipal = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            firmaToolStripMenuItem = new ToolStripMenuItem();
            juegoToolStripMenuItem = new ToolStripMenuItem();
            MenuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPrincipal
            // 
            MenuPrincipal.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            MenuPrincipal.Location = new Point(0, 0);
            MenuPrincipal.Name = "MenuPrincipal";
            MenuPrincipal.Size = new Size(800, 24);
            MenuPrincipal.TabIndex = 0;
            MenuPrincipal.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { firmaToolStripMenuItem, juegoToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // firmaToolStripMenuItem
            // 
            firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            firmaToolStripMenuItem.Size = new Size(105, 22);
            firmaToolStripMenuItem.Text = "Firma";
            // 
            // juegoToolStripMenuItem
            // 
            juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            juegoToolStripMenuItem.Size = new Size(105, 22);
            juegoToolStripMenuItem.Text = "Juego";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuPrincipal);
            MainMenuStrip = MenuPrincipal;
            Name = "FrmPrincipal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            MenuPrincipal.ResumeLayout(false);
            MenuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuPrincipal;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem firmaToolStripMenuItem;
        private ToolStripMenuItem juegoToolStripMenuItem;
    }
}
