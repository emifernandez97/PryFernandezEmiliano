using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryFernandezE
{
    public partial class FrmGalaga : Form
    {
        ClsNave ObjNave; // clase y objeto
        public FrmGalaga()
        {
            InitializeComponent();

            ObjNave = new ClsNave();

            this.KeyPreview = true; //recibe evento del teclado
        }
        
        private void FrmGalaga_KeyDown(object sender, KeyEventArgs e)
        {
            ObjNave.Mover(e, PctNave); //ejecutanddo clase con el objeto creado en el evento tecla
            ObjNave.Disparar(e , PctNave , this);
        }

    }
}
