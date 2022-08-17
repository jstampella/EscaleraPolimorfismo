using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4Poli
{
    internal class Jugador
    {
        #region Atributos
        public readonly string nombre;
        private int posicion;
        private int posicionAnt;
        private int avance;
        private Elemento elementoAfectado = null;
        static private Random rnd = new Random();
        private bool haLlegado = false;
        #endregion

        #region Constructor
        public Jugador(string nombre)
        {
            posicion = 0;
            posicionAnt = 0;
            this.nombre = nombre;
        }
        #endregion

        #region Propiedades
        public bool Hallegado
        {
            get { return haLlegado; }
        }

        public int Posicion
        {
            get { return posicion; }
        }

        public int PosicionAnt
        {
            get { return posicionAnt; }
        }

        public int Avance
        {
            get { return avance; }
        }

        public Elemento ElementoAfectado
        {
            get { return elementoAfectado; }
            set { elementoAfectado = value; }
        }

        #endregion

        public void ModificarPosicion(Elemento elemen, int pos)
        {
            elementoAfectado = elemen;
            posicion = pos;
            if (posicion == 100) haLlegado = true;
        }

        #region Metodos
        public void Mover()
        {
            int dado = rnd.Next(1, 7);
            avance = dado;
        }

        public int Avanzar()
        {
            elementoAfectado = null;
            posicionAnt = posicion;
            posicion += avance;
            if (posicion == 100) haLlegado = true;
            return posicion;
        }

        #endregion
    }
}
