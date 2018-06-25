using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ojo_de_mosca
{
    class Draw : Form1
    {
        public Draw(int points, double radio, bool parallel, double Width, double Height)
        {
            this.points = points;
            this.radio = radio;
            this.parallel = parallel;
            this.centerX = Width/2;
            this.centerY = Height/2;
            if (points % 2 == 0) pair = true;
            else pair = false;
            DrawPoints();
            DrawLines();
        }

        public void DrawPoints()
        {
            coordenadaX = new double[points];
            coordenadaY = new double[points];
            for (int i = 0; i < points; i++)
            {
                coordenadaX[i] = (radio * Math.Cos(360 / points));
                coordenadaY[i] = (radio * Math.Sin(360 / points));
            }
        }

        public void DrawLines()
        {
            for (int i = 0; i < points; i++)
            {

            }
        }

        int points;
        double radio, centerX, centerY;
        double[] coordenadaX, coordenadaY;
        bool parallel, pair;
    }
}
