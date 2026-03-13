using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_de_Laboratorio
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }

        public int Curacion { get; set; }

        public double Defensa { get; set; }
        public Personaje(string nombre, int vida, int ataque, int curacion, double defensa)
        {
            Nombre = nombre;
            Vida = vida;
            Ataque = ataque;
            Curacion = curacion;
            Defensa = defensa;
        }
        public virtual int Atacar()
        {
            return Ataque;
        }

        public virtual int Curar()
        {
            return Curacion;
        }

        public virtual double Defender()
        {
            return Defensa;
        }
    }
}
