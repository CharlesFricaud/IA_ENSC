using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace IA_Navigation
{
    class Dessin
    {

        public static void TraceSegment(double x1, double y1, double x2, double y2, PictureBox Pic)
        {
            //Trace un segment rouge entre les deux points, sur l'image fournie
            Pen penred = new Pen(Color.Red);
            Graphics g = Pic.CreateGraphics();
            g.DrawLine(penred, new Point((int)x1, Pic.Height - (int)y1), new Point((int)x2, Pic.Height - (int)y2));
        }

        public static void TracePoint(double x1, double y1, PictureBox Pic)
        {
            //Trace un point rouge aux coordonnées données sur l'image fournie
            Pen penred = new Pen(Color.Red);
            Graphics g = Pic.CreateGraphics();
            g.DrawRectangle(penred, (float)(x1 + 0.5), (float)(Pic.Height - (int)y1 - 0.5), 1, 1);

        }
    }
}
