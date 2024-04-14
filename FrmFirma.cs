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
    public partial class FrmFirma : Form
    {
        public FrmFirma()
        {
            InitializeComponent();
        }
        public bool Click = false;
        Point PreviusPoint;

        private void PctFirma_MouseDown(object sender, MouseEventArgs e)
        {
            Click = true;
            PreviusPoint = e.Location;

        }

        private void PctFirma_MouseUp(object sender, MouseEventArgs e)
        {
            Click = false;
        }

        private void PctFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (Click == true)
            {
                using (Graphics g = PctFirma.CreateGraphics())
                {
                    using (Pen p = new Pen(Color.Black, 4))
                    {
                        g.DrawLine(p, PreviusPoint, e.Location);
                        PreviusPoint = e.Location;
                    }
                }
            }
        }
    }
}
