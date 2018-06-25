using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ojo_de_mosca
{
    class Draw : Form1 //Esta es la clase que va a crear los puntos y dibujar las lineas
    {
        public Draw(int points, double radio, bool parallel, double Width, double Height, Graphics e)
        { //Este constructor es llamado al hacer click en draw en el form1
            this.points = points; //Los puntos que escribio el usuario se guardan en points
            this.radio = radio;   //El radio que va a tener el circulo se guarda tambien
            this.parallel = parallel; //?????
            this.centerX = Width/2;   //Para poder tener el centro del circulo en el centro de la pantalla
            this.centerY = Height/2;  //igual
            if (points % 2 == 0) pair = true; //para saber si es numero par o no
            else pair = false;
            DrawPoints(); //Del numero de puntos se crean coordenadas
            DrawLines(e); //Una vez puestos los puntos en las coordenadas se dibujan
        }

        public void DrawPoints()
        { 
            coordenadaX = new double[points]; //Este array guarda las coordenadas "x" y es del tamano de la cantidad de puntos
            coordenadaY = new double[points]; //Este array guarda las coordenadas "y"
            for (int i = 0; i < points; i++)
            {
                coordenadaX[i] = (radio * Math.Cos(360 / points));
                coordenadaY[i] = (radio * Math.Sin(360 / points));
            }
        }

        public void DrawLines(Graphics Dibujante)
        {
            Pen PlumaParaDibujar = new Pen(Brushes.Black); //Pluma que se va a usar para dibujar lineas
            for (int i = 0; i < points; i++)
            {
                Dibujante.DrawLine(PlumaParaDibujar,Convert.ToSingle(coordenadaX[i]),Convert.ToSingle(coordenadaY[i]),Convert.ToSingle(coordenadaX[i+1]),Convert.ToSingle(coordenadaY[i+1]));
            }
        }

        int points;
        double radio, centerX, centerY;
        double[] coordenadaX, coordenadaY;
        bool parallel, pair;
    }
}
