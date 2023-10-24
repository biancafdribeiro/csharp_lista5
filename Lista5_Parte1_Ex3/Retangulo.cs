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
    public class Retangulo : Forma
    {
        public double area { get; set; }
        public double @base { get; set; }
        public double altura { get; set; }

        public override double CalcularArea()
        {
            area = @base * altura;
            Console.WriteLine($"A área do quadrado é: {area}");
            return area;
        }
    }
}
