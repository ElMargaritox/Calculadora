using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1 Instance { get; set; }
        private float Num1, Num2;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;


        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "x";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float resultado = 0;
            if (textBox1.Text.Contains("+"))
            {
                string[] palabras = textBox1.Text.Split('+');
                Num1 = float.Parse(palabras[0]);
                Num2 = float.Parse(palabras[1]);
                resultado = Num1 + Num2;
            }
            else if (textBox1.Text.Contains("-"))
            {
                string[] palabras = textBox1.Text.Split('-');
                Num1 = float.Parse(palabras[0]);
                Num2 = float.Parse(palabras[1]);
                 resultado = Num1 - Num2;
            }
            else if (textBox1.Text.Contains("x"))
            {
                string[] palabras = textBox1.Text.Split('x');
                Num1 = float.Parse(palabras[0]);
                Num2 = float.Parse(palabras[1]);
                resultado = Num1 * Num2;
            }
            else if (textBox1.Text.Contains("/"))
            {
                string[] palabras = textBox1.Text.Split('/');
                Num1 = float.Parse(palabras[0]);
                Num2 = float.Parse(palabras[1]);
                resultado = Num1 / Num2;
            }

            if(resultado.ToString() == "∞")
            {
                textBox1.Text = "ERROR";
                ThreadPool.QueueUserWorkItem(delegate (object i)
                {
                    Thread.Sleep(2000);
                    textBox1.Text = null;
                    textBox1.Focus();
                });
            }
            else
            {
                textBox2.Text = textBox2.Text = textBox2.Text + string.Format("{0} = {1}", textBox1.Text, resultado) + Environment.NewLine;
                textBox1.Text = null;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
    }
}
