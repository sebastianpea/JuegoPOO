using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_de_Laboratorio
{
    internal class Mago : Personaje
    {
        public Mago() : base("Mago", 80, 25, 20, 0.5)
        {
        }

        public override int Atacar()
        {
            return Ataque + 4;
        }

        public override int Curar()
        {
            return Curacion;
        }

    }
}
