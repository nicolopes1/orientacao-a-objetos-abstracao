using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_17_orientacao_a_objetos_abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            var cachorro = new Cachorro();
            cachorro.Latir();

            Console.Read();
        }
    }
}
