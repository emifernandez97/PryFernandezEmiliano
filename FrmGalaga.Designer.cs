namespace PryFernandezE
{
    partial class FrmGalaga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGalaga));
            pictureBox1 = new PictureBox();
            PctNave = new PictureBox();
            PctNaveEnemigaUno = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PctNave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PctNaveEnemigaUno).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 452);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PctNave
            // 
            PctNave.BackColor = Color.Transparent;
            PctNave.Image = Properties.Resources._1213123213213videojuego_nave_espacial_thumbnail_removebg_preview;
            PctNave.Location = new Point(349, 353);
            PctNave.Name = "PctNave";
            PctNave.Size = new Size(107, 87);
            PctNave.SizeMode = PictureBoxSizeMode.StretchImage;
            PctNave.TabIndex = 1;
            PctNave.TabStop = false;
            // 
            // PctNaveEnemigaUno
            // 
            PctNaveEnemigaUno.BackColor = Color.Transparent;
            PctNaveEnemigaUno.Image = (Image)resources.GetObject("PctNaveEnemigaUno.Image");
            PctNaveEnemigaUno.Location = new Point(328, 12);
            PctNaveEnemigaUno.Name = "PctNaveEnemigaUno";
            PctNaveEnemigaUno.Size = new Size(170, 87);
            PctNaveEnemigaUno.SizeMode = PictureBoxSizeMode.StretchImage;
            PctNaveEnemigaUno.TabIndex = 2;
            PctNaveEnemigaUno.TabStop = false;
            // 
            // FrmGalaga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 452);
            Controls.Add(PctNave);
            Controls.Add(PctNaveEnemigaUno);
            Controls.Add(pictureBox1);
            Name = "FrmGalaga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Galaga";
            KeyDown += FrmGalaga_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PctNave).EndInit();
            ((System.ComponentModel.ISupportInitialize)PctNaveEnemigaUno).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox PctNave;
        private PictureBox PctNaveEnemigaUno;
    }
}