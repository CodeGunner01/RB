using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMENSG
{

    public partial class Form1 : Form
    {
        Matriz x1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = new Matriz();

        }



        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.CargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox5.Text = x1.Descargar();
        }


        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = x1.Descargar();
        }




        //PREGUNTA 1

        private void pregunta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.SegmentarColumnasParImpar();
            textBox6.Text = x1.Descargar();
        }

        //PREGUNTA 2
        private void pregunta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.Ejercicio2();
            textBox6.Text = x1.Descargar();
        }


    }
}
