using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crie uma classe abstrata Veiculo com um método abstrato Mover(). Crie duas classes
derivadas de Veiculo: Carro e Moto. Implemente o método Mover() em ambas as
classes para exibir mensagens indicando o movimento do veículo.*/

namespace Lista5_Parte1_Ex2
{
    public class Carro : Veiculo
    {
        public override void Mover() 
        {
            Console.WriteLine("Vrrummm...");
        }
    }
}
