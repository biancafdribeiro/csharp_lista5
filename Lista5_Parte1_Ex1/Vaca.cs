using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crie uma classe abstrata chamada Animal com um método abstrato EmitirSom(). Crie
três classes derivadas de Animal: Cachorro, Gato e Vaca. Implemente o método
EmitirSom() em cada classe para que cada animal emita um som diferente.*/

namespace Lista5_Parte1_Ex1
{
    public class Vaca : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Muuuuu!");
        }
    }
}
