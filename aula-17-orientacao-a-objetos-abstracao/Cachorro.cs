using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_17_orientacao_a_objetos_abstracao
{
    public class Cachorro : Animal
    {
        public override void Latir()
        {
            Console.WriteLine("Au au, eu sou um cachorro");
        }
    }
}
