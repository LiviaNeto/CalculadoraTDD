using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora("31/03/2025");

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Subtrair(15, 5);
            calc.Multiplicar(5, 6);

            var lista = calc.Historico();

            Console.WriteLine("Histórico detalhado:");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}


