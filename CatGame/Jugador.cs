using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatGame
{
    class Jugador
    {
        string nombre;
        int intentos;
        int puntaje;

        public int Intentos { get => intentos; set => intentos = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }

        public Jugador(string nom)
        {
            this.intentos = 9;
            this.puntaje = 0;
            this.nombre = nom;
        }



        




    }
}
