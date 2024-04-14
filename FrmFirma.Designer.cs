namespace PryFernandezE
{
    partial class FrmFirma
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
            PctFirma = new PictureBox();
            BtnLimpiar = new Button();
            BtnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)PctFirma).BeginInit();
            SuspendLayout();
            // 
            // PctFirma
            // 
            PctFirma.BackColor = SystemColors.HighlightText;
            PctFirma.Location = new Point(179, 31);
            PctFirma.Name = "PctFirma";
            PctFirma.Size = new Size(308, 206);
            PctFirma.TabIndex = 0;
            PctFirma.TabStop = false;
            PctFirma.MouseDown += PctFirma_MouseDown;
            PctFirma.MouseMove += PctFirma_MouseMove;
            PctFirma.MouseUp += PctFirma_MouseUp;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(179, 317);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(75, 23);
            BtnLimpiar.TabIndex = 1;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(363, 317);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 2;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnLimpiar);
            Controls.Add(PctFirma);
            Name = "FrmFirma";
            Text = "Firma";
            ((System.ComponentModel.ISupportInitialize)PctFirma).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PctFirma;
        private Button BtnLimpiar;
        private Button BtnGuardar;
    }
}