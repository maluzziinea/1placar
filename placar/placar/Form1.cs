using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace placar
{
    public partial class Form1 : Form
    {
        float segundos;
        float minutos;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo.Text = minutos.ToString()+ ":" + segundos.ToString();
            segundos++;
            if (segundos > 60) { segundos = 0; minutos += 1; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            minutos = 0;
            segundos = 0;
            tempo.Text = minutos.ToString() + ":" + segundos.ToString();
        }

        private void tempo_Click(object sender, EventArgs e)
        {

        }
    }
}
