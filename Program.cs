using System;

namespace ParouImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplicacao();
        }
        static void Aplicacao()
        {
            Console.WriteLine("Insira o numero para o teste: ");
            double numero = double.Parse(Console.ReadLine());

            double teste = numero % 2;
            double raiz = Math.Sqrt(numero);
            double quadrado = Math.Pow(numero, 2);
            if (teste == 0)
            {
                Console.WriteLine("O numero é par");
                Console.WriteLine($"A raiz quadrada do numero é {raiz}");
            }
            else
            {
                Console.WriteLine("O numero é impar");
                Console.WriteLine($"o seu numero elevado ao quadrado é {quadrado}");
            };
        }

    }

}