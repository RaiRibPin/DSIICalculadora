using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.Calculadora.Projeto
{
    class Calculadora
    {
        public double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public double Dividir(double valor1, double valor2)
        {
            if (valor2 == 0)
            {
                throw new ArgumentException("Não é possível dividir por zero");
            }
            return valor1 / valor2;
        }
    }
}
