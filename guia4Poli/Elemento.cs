using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4Poli
{
    public enum TipoElemento
    {
        Escalera, Serpiente
    }
    abstract internal class Elemento
    {
        protected int posInit;
        protected int posFinal;

        public Elemento(int posInit, int posFinal)
        {
            this.posInit = posInit;
            this.posFinal = posFinal;
        }
        abstract public int Evaluar(Jugador jugador);
    }
}
