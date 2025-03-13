namespace Etec.Calculadora.Projeto
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora - Desenvolvimento de Sistemas II");
            //Console.WriteLine(Dividir(20, 10));
            //Console.WriteLine(Multiplicar(20, 10));
            //Console.WriteLine(Subtrair(20, 10));
            //Console.WriteLine(Somar(20, 10));
            //Console.WriteLine(Potenciar(2, 3));

            
            try
            {
                Calculadora calc = new Calculadora();

                Console.WriteLine("10 + 10 = " + calc.Somar(10, 10));

                Console.WriteLine("10 - 10 = " + calc.Subtrair(10, 10));

                Console.WriteLine("10 * 10 = " + calc.Multiplicar(10, 10));

                Console.WriteLine("10 / 10 = " + calc.Dividir(10, 10));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
