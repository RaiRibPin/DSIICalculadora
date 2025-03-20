using Etec.FP.Negocios;

namespace Etec
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Calculadora - Desenvolvimento de Sistemas II");
        
                Calculadora calc = new Calculadora();

                Console.WriteLine("10 + 10 = " + calc.Somar(10, 10));

                Console.WriteLine("10 - 10 = " + calc.Subtrair(10, 10));

                Console.WriteLine("10 * 10 = " + calc.Multiplicar(10, 10));

                Console.WriteLine("10 / 10 = " + calc.Dividir(10, 10));
        }
    }
}
