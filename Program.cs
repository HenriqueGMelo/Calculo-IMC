using System;

namespace Calculo_de_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua altura utilizando ',' (ex: 1,58): ");
            float altura = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            float peso = (float) Convert.ToDouble(Console.ReadLine());

            float resultado = peso / (altura * altura);

            Console.WriteLine("O seu IMC é de: " + Math.Round(resultado, 2));

            if (resultado <= 17)
            {
                Console.WriteLine("Muito abaixo do peso ");
            }
            else if (resultado > 17 && resultado <= 18.49)
            {
                Console.WriteLine("Abaixo do peso ");
            }
            else if (resultado > 18.5 && resultado <= 24.99)
            {
                Console.WriteLine("Peso normal ");
            }
            else if (resultado > 25 && resultado <= 29.99)
            {
                Console.WriteLine("Acima do peso ");
            }
            else if (resultado > 30 && resultado <= 34.99)
            {
                Console.WriteLine("Obesidade I ");
            }
            else if (resultado > 35 && resultado <= 39.99)
            {
                Console.WriteLine("Obesidade II (Severa) ");
            }
            else if (resultado > 40)
            {
                Console.WriteLine("Obesidade III (Mórbita) ");
            }
        }
    }
}
