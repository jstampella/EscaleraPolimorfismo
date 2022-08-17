using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4Poli
{
    internal class PolimorfisGamer
    {
        protected bool haFinalizado = false;
        protected Jugador[] jugadores;
        public readonly int cantJuegadores;
        public readonly Color[] colores = new Color[4];
        protected ArrayList ganadores = new ArrayList();

        #region Constructor
        public PolimorfisGamer(int countJug, string[] nombres)
        {
            cantJuegadores = countJug;
            jugadores = new Jugador[countJug];
            int maquinas = countJug - nombres.Length;
            CrearColores();
            int tmp = 0; ;
            for (int i = 0; i < countJug; i++)
            {
                if (i < maquinas)
                {
                    jugadores[i] = new Jugador("Maquina (" + (i + 1) + ")");
                }
                else
                {
                    jugadores[i] = new Jugador(nombres[tmp]);
                    tmp++;
                }
            }
        }
        #endregion

        #region Propiedades
        public bool HaFinalizado
        {
            get { return haFinalizado; }
        }

        public Jugador[] ListarJugadores
        {
            get { return jugadores; }
        }

        public ArrayList Ganadores
        {
            get { return ganadores; }
        }
        #endregion

        #region Metodos
        private void CrearColores()
        {
            colores[0] = Color.FromArgb(204, 0, 0);
            colores[1] = Color.FromArgb(204, 204, 0);
            colores[2] = Color.FromArgb(0, 102, 204);
            colores[3] = Color.FromArgb(0, 255, 0);
        }
        public virtual bool JugarRonda()
        {
            if (!haFinalizado)
            {
                for (int i = 0; i < cantJuegadores; i++)
                {
                    if (!jugadores[i].Hallegado)
                    {
                        jugadores[i].Mover();
                        int dado = jugadores[i].Avance;
                        if ((dado + jugadores[i].Posicion) <= 100)
                        {
                            jugadores[i].Avanzar();
                            if (jugadores[i].Posicion == 100) ganadores.Add(jugadores[i]);
                        }
                    }
                    else { jugadores[i].ElementoAfectado = null; }
                }
                if (ganadores.Count == cantJuegadores - 1) haFinalizado = true;
            }
            return haFinalizado;
        }
        #endregion
    }
}
