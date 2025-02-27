namespace Etec.Calculadora.Projeto
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora - Desenvolvimento de Sistemas II");
                Console.WriteLine(Dividir(20, 10));
                Console.WriteLine(Multiplicar(20, 10));
                Console.WriteLine(Subtrair(20, 10));
                Console.WriteLine(Somar(20, 10));
                Console.WriteLine(Potenciar(2, 3));
        }

        static double Somar(double valor1, double valor2) 
        {
            return valor1 + valor2;    
        }

        static double Subtrair(double valor1, double valor2) 
        {
            return valor1 - valor2;
        }

        static double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        static double Dividir(double valor1, double valor2)
        {
            return valor1 / valor2;
        }

        static double Potenciar(double valor1, double valor2)
        {
            return Math.Pow(valor1, valor2);
        }
    }
}
