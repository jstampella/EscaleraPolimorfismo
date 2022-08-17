using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4Poli
{
    internal class Escalera : Elemento
    {
        public Escalera(int posI, int posF) : base(posI, posF)
        {
        }


        public override string ToString()
        {
            return TipoElemento.Escalera.ToString();
        }


        public override int Evaluar(Jugador jugador)
        {
            if (posInit == jugador.Posicion) return posFinal;
            else return jugador.Posicion;
        }
    }
}
