using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4Poli
{
    internal class Serpiente : Elemento
    {
        public Serpiente(int posI, int posF):base(posI,posF)
        {
        }


        public override string ToString()
        {
            return TipoElemento.Serpiente.ToString();
        }


        public override int Evaluar(Jugador jugador)
        {
            if (posFinal == jugador.Posicion) return posInit;
            else return jugador.Posicion;
        }
    }
}
