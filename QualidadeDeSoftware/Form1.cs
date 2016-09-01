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
        //Variaveis Globais
        private double x = 0;
        private int op = -2; //Opção
        Operacoes operacoes = new Operacoes();

        //Inicializa o Formulário
        public Form1()
        {
            InitializeComponent();
            visor.Focus();
        }

        //Botão 1
        private void button1_Click(object sender, EventArgs e)
        {
            if ((visor.Text.Equals("0")) || (op == -1))
            {
                visor.Text = "";
                op = -2;
            }
            visor.Text += "1";
            visor.Focus();
        }
        //Botão 2
        private void button2_Click(object sender, EventArgs e)
        {
            if ((visor.Text.Equals("0")) || (op == -1))
            {
                visor.Text = "";
                op = -2;
            }
            visor.Text += "2";
            visor.Focus();
        }
        //Botão 3
        private void button3_Click(object sender, EventArgs e)
        {
            if ((visor.Text.Equals("0")) || (op == -1))
            {
                visor.Text = "";
                op = -2;
            }
            visor.Text += "3";
            visor.Focus();
        }
        //Botão 4
        private void button4_Click(object sender, EventArgs e)
        {
            if ((visor.Text.Equals("0")) || (op == -1))
            {
                visor.Text = "";
                op = -2;
            }
            visor.Text += "4";
            visor.Focus();
        }
        //Botão 5
        private void button5_Click(object sender, EventArgs e)
        {
            if ((visor.Text.Equals("0")) || (op == -1))
            {
                visor.Text = "";
                op = -2;
            }
            visor.Text += "5";
            visor.Focus();
        }
        //Botão 6
        private void button6_Click(object sender, EventArgs e)
        {
            if ((visor.Text.Equals("0")) || (op == -1))
            {
                visor.Text = "";
                op = -2;
            }
            visor.Text += "6";
            visor.Focus();
        }
        //Botão 7
        private void button7_Click(object sender, EventArgs e)
        {
            if ((visor.Text.Equals("0")) || (op == -1))
            {
                visor.Text = "";
                op = -2;
            }
            visor.Text += "7";
            visor.Focus();
        }
        //Botão 8
        private void button8_Click(object sender, EventArgs e)
        {
            if ((visor.Text.Equals("0")) || (op == -1))
            {
                visor.Text = "";
                op = -2;
            }
            visor.Text += "8";
            visor.Focus();
        }
        //Botão 9
        private void button9_Click(object sender, EventArgs e)
        {
            if ((visor.Text.Equals("0")) || (op == -1))
            {
                visor.Text = "";
                op = -2;
            }
            visor.Text += "9";
            visor.Focus();
        }
        //Botão 0
        private void button0_Click(object sender, EventArgs e)
        {
            if ((visor.Text.Equals("0")) || (op == -1))
            {
                visor.Text = "";
                op = -2;
            }
            visor.Text += "0";
            visor.Focus();
        }
        //Botão Virgula (,)
        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            visor.Text += ",";
            visor.Focus();
        }
        //Botão de Soma (+)
        private void buttonSoma_Click(object sender, EventArgs e)
        {

            //Verificação se o visor esta vazio
            if (visor.Text == "")
            {
                MessageBox.Show("Digite um número para continuar.");
                visor.Text = "0";
                visor.Focus();
            }
            else
            {

                if (op == -1 || op == -2)
                {
                    x = Convert.ToDouble(visor.Text);
                }
                else
                {
                    x = operacoes.igual(op, x, Convert.ToDouble(visor.Text));
                }
                visor.Text = "";
                op = 0;
                visor.Focus();
            }
        }
        //Botão de Subtração (-)
        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            //Verificação se o visor esta vazio
            if (visor.Text == "")
            {
                MessageBox.Show("Digite um número para continuar.");
                visor.Text = "0";
                visor.Focus();
            }
            else
            {
                if (op == -1 || op == -2)
                {
                    x = Convert.ToDouble(visor.Text);
                }
                else
                {
                    x = operacoes.igual(op, x, Convert.ToDouble(visor.Text));
                }
                visor.Text = "";
                op = 1;
                visor.Focus();
            }
        }
    
        //Botão de Multiplicação (*)
        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            //Verificação se o visor esta vazio
            if (visor.Text == "")
            {
                MessageBox.Show("Digite um número para continuar.");
                visor.Text = "0";
                visor.Focus();
            }
            else
            {
                if (op == -1 || op == -2)
                {
                    x = Convert.ToDouble(visor.Text);
                }
                else
                {
                    x = operacoes.igual(op, x, Convert.ToDouble(visor.Text));
                }
                visor.Text = "";
                op = 2;
                visor.Focus();
            }
        }
        //Botão de Divisão (/)
        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            //Verificação se o visor esta vazio
            if (visor.Text == "")
            {
                MessageBox.Show("Digite um número para continuar.");
                visor.Text = "0";
                visor.Focus();
            }
            else
            {
                if (op == -1 || op == -2)
                {
                    x = Convert.ToDouble(visor.Text);
                }
                else
                {
                    x = operacoes.igual(op, x, Convert.ToDouble(visor.Text));
                }
                visor.Text = "";
                op = 3;
                visor.Focus();
            }
        }
        //Botão de Potência (x^y)
        private void buttonPotencia_Click(object sender, EventArgs e)
        {
            //Verificação se o visor esta vazio
            if (visor.Text == "")
            {
                MessageBox.Show("Digite um número para continuar.");
                visor.Text = "0";
                visor.Focus();
            }
            else
            {
                if (op == -1 || op == -2)
                {
                    x = Convert.ToDouble(visor.Text);
                }
                else
                {
                    x = operacoes.igual(op, x, Convert.ToDouble(visor.Text));
                }
                visor.Text = "";
                op = 4;
                visor.Focus();
            }
        }
        //Botão de Raiz Quadrada (√)
        private void buttonRaiz_Click(object sender, EventArgs e)
        {
            //Verificação se o visor esta vazio
            if (visor.Text == "")
            {
                MessageBox.Show("Digite um número para continuar.");
                visor.Text = "0";
                visor.Focus();
            }
            else
            {
                x = Convert.ToDouble(visor.Text);
                x = operacoes.raiz(x);
                int aux = (int)x;
                if (x != aux)
                {
                    visor.Text = String.Format("{0:0.0,0000}", x);
                }
                else
                {
                    visor.Text = aux.ToString();
                }
                visor.Focus();
            }
        }
        //Botão de Igual (=)
        private void buttonIgual_Click(object sender, EventArgs e)
        {

                //Verificação se o visor esta vazio
                if (visor.Text == "")
                {
                    MessageBox.Show("Digite um número para continuar.");
                    visor.Text = "0";
                    visor.Focus();
            }
                else
                {

                    x = operacoes.igual(op, x, Convert.ToDouble(visor.Text));
                int aux = (int)x;
                if (x != aux)
                {
                    visor.Text = String.Format("{0:0.0,0000}", x);
                }
                else
                {
                    visor.Text = aux.ToString();
                }
                op = -1;
                visor.Focus();
            }
        }
        //Botão C (Reset da Calculadora)
        private void buttonC_Click(object sender, EventArgs e)
        {
            visor.Text = "0";
            x = 0;
            op = -2;
            visor.Focus();
        }
        //Evento de Pressionar uma Tecla no Visor
        private void visor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) //Se for um dígito
            {
                if ((visor.Text.Equals("0")) || (op == -1))
                {
                    visor.Text = "";
                    op = -2;
                }
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                //Verifica se o caractere é um número ou a tecla backspace
                e.Handled = true;

                //Verificação se o visor esta vazio
                if (visor.Text == "")
                {
                    MessageBox.Show("Digite um número para continuar.");
                    visor.Text = "0";
                    visor.Focus();
                }
                else
                {

                    if (e.KeyChar == (char)43) //Soma
                    {
                        if (op == -1 || op == -2)
                        {
                            x = Convert.ToDouble(visor.Text);
                        }
                        else
                        {
                            x = operacoes.igual(op, x, Convert.ToDouble(visor.Text));
                        }
                        visor.Text = "";
                        op = 0;
                        
                    }
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar == (char)45) //Subtração
                    {
                        if (op == -1 || op == -2)
                        {
                            x = Convert.ToDouble(visor.Text);
                        }
                        else
                        {
                            x = operacoes.igual(op, x, Convert.ToDouble(visor.Text));
                        }
                        visor.Text = "";
                        op = 1;
                    }
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar == (char)42) //Multiplicação
                    {
                        if (op == -1 || op == -2)
                        {
                            x = Convert.ToDouble(visor.Text);
                        }
                        else
                        {
                            x = operacoes.igual(op, x, Convert.ToDouble(visor.Text));
                        }
                        visor.Text = "";
                        op = 2;
                        
                    }
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar == (char)47) //Divisão
                    {
                        if (op == -1 || op == -2)
                        {
                            x = Convert.ToDouble(visor.Text);
                        }
                        else
                        {
                            x = operacoes.igual(op, x, Convert.ToDouble(visor.Text));
                        }
                        visor.Text = "";
                        op = 3;
                        
                    }
                    
                }
            }

            if (e.KeyChar == (char)13) //Igual
            {
                buttonIgual.Select();
                //Verificação se o visor esta vazio
                if (visor.Text == "")
                {
                    MessageBox.Show("Digite um número para continuar.");
                    visor.Text = "0";
                }
                else
                {
                    x = operacoes.igual(op, x, Convert.ToDouble(visor.Text));
                    int aux = (int)x;
                    if (x != aux)
                    {
                        visor.Text = String.Format("{0:0.0,0000}", x);
                    }
                    else
                    {
                        visor.Text = aux.ToString();
                    }
                    op = -1;
                }
            }
        }

    }
}
