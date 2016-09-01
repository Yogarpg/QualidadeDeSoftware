using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualidadeDeSoftware
{
    class Operacoes
    {
        public double soma(double x, double y)
        {
            return x + y;
        }
        public double subtracao(double x, double y)
        {
            return x - y;
        }
        public double multiplacao(double x, double y)
        {
            return x * y;
        }
        public double divisao(double x, double y)
        {
            return x / y;
        }
        public double potencia(double x, double y)
        {
            return Math.Pow(x, y);
        }
        public double raiz(double x)
        {
            double y = 2;
            return Math.Pow(x, 1 / y);
        }
        public double igual(int op, double x, double y)
        {
            double r = 0; //Resultado
            switch (op)
            {
                //Soma
                case 0:
                    r = this.soma(x, y);
                    break;
                //Subtração
                case 1:
                    r = this.subtracao(x, y);
                    break;
                //Multiplicação
                case 2:
                    r = this.multiplacao(x, y);
                    break;
                //Divisão
                case 3:
                    if(y == 0)
                    {
                        MessageBox.Show("Não é possível dividir por zero!");
                        return 0;
                    }
                    r = this.divisao(x, y);
                    break;
                //Potência
                case 4:
                    r = this.potencia(x, y);
                    break;
                default:
                    break;
            }
            return r;
        }
    }
}
