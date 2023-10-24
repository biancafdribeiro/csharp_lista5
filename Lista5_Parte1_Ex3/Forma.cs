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
    public abstract class Forma
    {
        public abstract double CalcularArea();
    }
}
