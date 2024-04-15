using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace PryFernandezE
{
    internal class ClsNave
    {
     
        public void Mover(KeyEventArgs e, PictureBox Nave) 
        {
            PictureBox PctNave = new PictureBox(); //Objeto por lo que voy a trabajar, se instancia en memoria.
            PctNave = Nave;//Objeto
            int paso = 25; // Cuánto se moverá la imagen en cada pulsación de te

            // Cambiar la posición de la imagen según la tecla presionada
            switch (e.KeyCode)
            {
                case Keys.Up:
                    PctNave.Top -= paso;
                    break;
                case Keys.Down:
                    PctNave.Top += paso;
                    break;
                case Keys.Left:
                    PctNave.Left -= paso;
                    break;
                case Keys.Right:
                    PctNave.Left += paso;
                    break;
            }
        }

        public void Disparar (KeyEventArgs e, PictureBox Nave, FrmGalaga FrmGalaga) //metodo 
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    Disparo(Nave , FrmGalaga);
                    break;

            }
        }

        void Disparo( PictureBox Nave , FrmGalaga FrmGalaga)  //funcion
        {
            PictureBox PctDisparo = new PictureBox(); //Objeto por lo que voy a trabajar, se instancia en memoria.
            PctDisparo.Image = PryFernandezE.Properties.Resources.DisparoNave1;
            PctDisparo.Size = new Size( 70, 70);
            PctDisparo.Location = new Point( Nave.Location.X , 370 );
            FrmGalaga.Controls.Add( PctDisparo );
            PctDisparo.SizeMode = PictureBoxSizeMode.StretchImage;
            PctDisparo.BringToFront();

        }

    }
}
