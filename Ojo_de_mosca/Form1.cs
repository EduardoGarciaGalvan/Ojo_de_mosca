using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ojo_de_mosca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            points = (int)Points.Value;
            radio = Math.Truncate((double)Radio.Value*1000)/1000;
            parallel = Parallel.Checked;
            Draw figura = new Draw(points, radio, parallel, pictureBox1.Width, pictureBox1.Height);
            Start.Enabled = true;
        }
    }
}
