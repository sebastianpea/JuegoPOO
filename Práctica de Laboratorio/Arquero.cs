using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_de_Laboratorio
{
    public class Arquero: Personaje
    {
        public Arquero() : base("Arquero", 100, 18, 10, 0.5)
        {
        }
        public override int Atacar()
        {
            return Ataque + 3;
        }

        public override int Curar()
        {
            return Curacion;
        }
    }
}
