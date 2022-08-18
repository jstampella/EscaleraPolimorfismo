using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia4Poli
{
    internal class RealPolimorfisGamer : PolimorfisGamer
    {
        private Elemento[] elementos;
        public RealPolimorfisGamer(int countJug, string[] nombres, int map) : base(countJug, nombres)
        {
            if (map == 2)
                CrearElementos();
            else CrearElementos2();
        }

        private void CrearElementos()
        {
            elementos = new Elemento[8];
            elementos[0] = new Escalera(67, 100);
            elementos[1] = new Escalera(73, 91);
            elementos[2] = new Escalera(19, 66);
            elementos[3] = new Escalera(32, 53);
            elementos[4] = new Serpiente(52, 74);
            elementos[5] = new Serpiente(76, 88);
            elementos[6] = new Serpiente(12, 46);
            elementos[7] = new Serpiente(6, 25);
        }
        private void CrearElementos2()
        {
            elementos = new Elemento[6];
            elementos[0] = new Escalera(5, 32);
            elementos[1] = new Escalera(59, 99);
            elementos[2] = new Escalera(75, 97);
            elementos[3] = new Serpiente(19, 40);
            elementos[4] = new Serpiente(55, 78);
            elementos[5] = new Serpiente(54, 91);
        }
        public override bool JugarRonda()
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
                            ComprobarElementos(jugadores[i]);
                            if (jugadores[i].Posicion == 100) ganadores.Add(jugadores[i]);
                        }
                        else
                        {
                            jugadores[i].ElementoAfectado = null;
                        }
                    }
                    else { jugadores[i].ElementoAfectado = null; }
                }
                if (ganadores.Count == cantJuegadores - 1) haFinalizado = true;
            }
            return haFinalizado;
        }

        private void ComprobarElementos(Jugador jugador)
        {
            int ind = 0;
            int temp = jugador.Posicion;
            while (ind < elementos.Length && jugador.Posicion == temp)
            {
                temp = elementos[ind].Evaluar(jugador);
                if (jugador.Posicion != temp)
                {
                    jugador.ModificarPosicion(elementos[ind], temp);
                }
                ind++;
            }
        }
    }
}
