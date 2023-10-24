using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crie uma classe abstrata chamada Forma com um método abstrato CalcularArea(). Crie
duas classes derivadas de Forma: Circulo e Retangulo. Implemente o método
CalcularArea() em ambas as classes para calcular a área correspondente.*/

namespace Lista5_Parte1_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Insira o raio do círculo: ");
            double raio = double.Parse( Console.ReadLine() );

            Circulo circulo = new Circulo();
            circulo.raio = raio;
            circulo.CalcularArea();

            Console.WriteLine($"Insira a base do retângulo: ");
            double @base = double.Parse( Console.ReadLine() );
            Console.WriteLine($"Insira a altura do retângulo: ");
            double altura = double.Parse( Console.ReadLine() );

            Retangulo retangulo = new Retangulo();
            retangulo.altura = altura; //atribuindo os valores às propriedades
            retangulo.@base = @base;
            retangulo.CalcularArea();

            Console.ReadKey();

        }
    }
}
