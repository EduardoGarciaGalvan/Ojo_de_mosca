using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ojo_de_mosca
{
    public partial class Form1 : Form
    {
        public Form1() //Aqui empieza el programa
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        { //Cuando se hace click en dibujar, se ejecuta este evento
            Start.Enabled = false;     //No se
            points = (int)Points.Value; //Se toma el valor de los puntos que se van a dibujar
            radio = Math.Truncate((double)Radio.Value*1000)/1000; //Se define el tamano del radio que va a tener el circulo
            parallel = Parallel.Checked; //??????
            PaintEventArgs f;
            Graphics g = f.Graphics;     //PaintEventArgs e permite tomar el valor e para crear una clase grafica y poder dibujar
            Draw figura = new Draw(points, radio, parallel, pictureBox1.Width, pictureBox1.Height, g);
            //Se crea una clase Draw que se definio en el archivo Draw.cs la cual se inicializa
            //Al inicializarse llama tanto a dibujar puntos como a dibujar lineas
            Start.Enabled = true;       //No se
            
        }
    }
}
