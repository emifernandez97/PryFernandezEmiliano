using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryFernandezE
{
    internal class ClsNaveEnemiga
    {
        //Propiedades

        public PictureBox PctEnemigo;

        //Constructor

        //Metodos
        public void Mover(FrmGalaga FrmGalaga) 
        {
            PctEnemigo = new PictureBox();
            Random Rnd = new Random();

            Rnd.Next(1 , 3);
            int Randomx = Rnd.Next(0,FrmGalaga.ClientSize.Width - PctEnemigo.Width);
            switch (Rnd.Next(1 ,3) ) 
            {
                case 1:
                    PctEnemigo.Image = PryFernandezE.Properties.Resources.NaveEnemigaUno;
                    break;
            }
            PctEnemigo.BackColor = Color.Black;
            PctEnemigo.Size = new Size(66, 61);
            PctEnemigo.SizeMode = PictureBoxSizeMode.StretchImage;
            PctEnemigo.Location = new Point(Randomx,12);
            FrmGalaga.Controls.Add(PctEnemigo);
            PctEnemigo.BringToFront();
        }

    }
}
