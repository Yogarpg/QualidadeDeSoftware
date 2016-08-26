using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualidadeDeSoftware
{
    public partial class Form1 : Form
    {
        private double x;
        private double y;
        private double r;
        private int op = -1;
        Operacoes operacoes = new Operacoes();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonRaiz_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(visor.Text);
            r = operacoes.raiz(x);
            visor.Text = String.Format("{0:0.0,0000}", r);
            visor.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(visor.Text.Equals("0"))
            {
                visor.Text = "";
            }
            visor.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (visor.Text.Equals("0"))
            {
                visor.Text = "";
            }
            visor.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (visor.Text.Equals("0"))
            {
                visor.Text = "";
            }
            visor.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (visor.Text.Equals("0"))
            {
                visor.Text = "";
            }
            visor.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (visor.Text.Equals("0"))
            {
                visor.Text = "";
            }
            visor.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (visor.Text.Equals("0"))
            {
                visor.Text = "";
            }
            visor.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (visor.Text.Equals("0"))
            {
                visor.Text = "";
            }
            visor.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (visor.Text.Equals("0"))
            {
                visor.Text = "";
            }
            visor.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (visor.Text.Equals("0"))
            {
                visor.Text = "";
            }
            visor.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (visor.Text.Equals("0"))
            {
                visor.Text = "";
            }
            visor.Text += "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            visor.Text = "0";
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            visor.Text += ",";
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(visor.Text);
            visor.Text = "";
            op = 0;
            visor.Focus();
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            visor.Text = operacoes.igual(op, x, y, r, visor.Text);
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(visor.Text);
            visor.Text = "";
            op = 1;
            visor.Focus();
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(visor.Text);
            visor.Text = "";
            op = 2;
            visor.Focus();
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(visor.Text);
            visor.Text = "";
            op = 3;
            visor.Focus();
        }

        private void buttonPotencia_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(visor.Text);
            visor.Text = "";
            op = 4;
            visor.Focus();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void visor_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void visor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)42 
                && e.KeyChar != (char)43 && e.KeyChar != (char)44 && e.KeyChar != (char)45 && e.KeyChar != (char)47)

            {
                e.Handled=true;
            }
            if(e.KeyChar == (char)13)
            {
                visor.Text = operacoes.igual(op, x, y, r, visor.Text);
            }
        }
    }
}
