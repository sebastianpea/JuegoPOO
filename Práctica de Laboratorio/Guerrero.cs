using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_de_Laboratorio
{
    public class Guerrero: Personaje
    {
        public Guerrero() : base("Guerrero", 120, 15, 5, 0.7)
        {
        }
        public override int Atacar()
        {
            return Ataque + 5;
        }

        public override int Curar()
        {
            return Curacion;
        }
    }
}
