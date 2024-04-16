using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PryFernandezE
{
    internal class ClsNave
    {

        //Propiedades

        Timer TimerDisparo = new Timer();

        //Constructor

        public ClsNave() 
        {
            TimerDisparo.Interval = 20;
            TimerDisparo.Tick += TimerDisparo_Tick;
        }

        //Metodos

        public void Mover(KeyEventArgs e, PictureBox Nave) 
        {
            PictureBox PctNave = new PictureBox(); //Objeto por lo que voy a trabajar, se instancia en memoria.
            PctNave = Nave;//Objeto
            int paso = 25; // Cuánto se moverá la imagen en cada pulsación de te

            // Cambiar la posición de la imagen según la tecla presionada
            switch (e.KeyCode)
            {

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

        public List<PictureBox> ListaDisparo = new List<PictureBox>(); // lista para almacenar los diparos
        void Disparo( PictureBox Nave , FrmGalaga FrmGalaga)  //funcion
        {
            PictureBox PctDisparo = new PictureBox(); //Objeto por lo que voy a trabajar, se instancia en memoria.
            PctDisparo.Image = PryFernandezE.Properties.Resources.DisparoNave1;
            PctDisparo.Size = new Size( 30, 30);
            PctDisparo.Location = new Point( Nave.Location.X + 40 , 370 );
            FrmGalaga.Controls.Add( PctDisparo );
            PctDisparo.SizeMode = PictureBoxSizeMode.StretchImage;
            PctDisparo.BringToFront();

            ListaDisparo.Add(PctDisparo);
            TimerDisparo.Start();

        }
        public void TimerDisparo_Tick(object sender, EventArgs e) //metodo  de tiempo de movimiento
        {
            foreach (var Disparo in ListaDisparo.ToList())
            {
                Disparo.Top -= 10;
                if (Disparo.Top <= 0) 
                {
                    ListaDisparo.Remove(Disparo);
                    if (Disparo.Parent != null)
                    {
                        Disparo.Parent.Controls.Remove(Disparo);
                    }
                    Disparo.Dispose();
                }
            }
            
        }

    }
}
