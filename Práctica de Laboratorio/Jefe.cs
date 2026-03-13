using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_de_Laboratorio
{
    public class Jefe: Personaje
    {
            public Jefe() : base("Jefe", 200, 20, 0, 0.3)
            {
            }

            public override int Atacar()
            {
                return Ataque + 20;
            }
    }
}
