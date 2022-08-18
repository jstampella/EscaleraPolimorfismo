using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guia4Poli
{
    public partial class Tablero : Form
    {
        private PolimorfisGamer Juego;

        #region Constructor
        public Tablero(int countJug, string[] nombres,int map)
        {
            InitializeComponent();
            tablero2.BackgroundImage = Form1.mapas[map];
            //establece valores para optimizar el parpadeo de los controles
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.DoubleBuffered = true;
            if (map==0)
                Juego = new PolimorfisGamer(countJug, nombres);
            else
                Juego = new RealPolimorfisGamer(countJug, nombres, map);
        }

    //Evitar el parpadeo de los controles
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        #endregion

        private void Tablero_Shown(object sender, EventArgs e)
        {
            panelPuntos.Controls.Clear();
            panelDados.Controls.Clear();
            for (int i = 0; i < Juego.cantJuegadores; i++)
            {
                CrearLabelTitulo(i, Juego.ListarJugadores[i].nombre);
                CrearLabels(i);
            }
        }

        #region Funciones custom
        private void CrearLabels(int i, int pts = 0, int d = 0)
        {
            Label txt = new Label();
            Label dado = new Label();
            Panel pColor = new Panel();
            pColor.Size = new Size(15, 15);
            pColor.BackColor = Juego.colores[i];
            txt.Text = "- " + pts + "pts";
            dado.Text = d.ToString();
            panelPuntos.Controls.Add(txt);
            panelPuntos.Controls.Add(pColor);
            pColor.Location = new Point(5, (i * 30) + 10);
            txt.Location = new Point(20, (i * 30) + 10);
            panelDados.Controls.Add(dado);
            dado.Location = new Point(10, (i * 30) + 10);
        }

        private void CrearLabelTitulo(int pos, string nombre)
        {
            Label txt;
            Panel pColor;
            txt = new Label();
            pColor = new Panel();
            pColor.Size = new Size(15, 15);
            pColor.BackColor = Juego.colores[pos];
            //CambiarColorPanel(pos);
            txt.Text = nombre;
            panelColores.Controls.Add(pColor);
            panelJugador.Controls.Add(txt);
            txt.Location = new Point(10, pos * 25);
            pColor.Location = new Point(10, pos * 25);
        }

        private void CambiarColorPanel(int pos)
        {
            switch (pos + 1)
            {
                case 1:
                    panel1.BackColor = Juego.colores[pos];
                    // panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                    break;
                case 2:
                    panel2.BackColor = Juego.colores[pos];
                    // panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                    break;
                case 3:
                    panel3.BackColor = Juego.colores[pos];
                    // panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                    break;
                case 4:
                    panel4.BackColor = Juego.colores[pos];
                    // panel4.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                    break;
                default:
                    break;
            }
        }

        private void MostrarAfectados()
        {
            Jugador[] jugadores = Juego.ListarJugadores;
            string messa = "";
            foreach (Jugador jugador in jugadores)
            {
                if (jugador.ElementoAfectado != null)
                {
                    messa = String.Format("Jugador {0} afectado por: {1}, posicion: {2} pasa a {3}", jugador.nombre, jugador.ElementoAfectado.ToString(), (jugador.PosicionAnt + jugador.Avance), jugador.Posicion);
                    MessageBox.Show(messa, "Afectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ModificarTamanio()
        {
            Point cuadrado = new Point(tablero2.Size.Width / 10, tablero2.Size.Height / 10);
            int index = 0;
            foreach (Control item in tablero2.Controls)
            {
                if (item is Panel panel)
                {
                    panel.Size = new Size(cuadrado.X - 5, cuadrado.Y - 5);
                    tablero2.Controls.SetChildIndex(panel, index + 1);
                    int index2 = 0;
                    foreach (Control item2 in tablero2.Controls)
                    {
                        if (item != item2 && item.Location == item2.Location)
                        {
                            index2++;
                            tablero2.Controls.SetChildIndex(item2, index2 + 2);
                            item2.Left += 6;
                            item2.Top += 6;
                            item2.Size = new Size(cuadrado.X - (6 * index2), cuadrado.Y - (6 * index2));
                        }
                    }

                }
                index++;
            }
        }

        private void MoverFichas(int i, int posX, int posY)
        {
            Panel Npanel = null;
            Point cuadrado = new Point(tablero2.Size.Width / 10, tablero2.Size.Height / 10);
            switch (i + 1)
            {
                case 1:
                    Npanel = panel1;
                    break;
                case 2:
                    Npanel = panel2;
                    break;
                case 3:
                    Npanel = panel3;
                    break;
                case 4:
                    Npanel = panel4;
                    break;
                default:
                    break;
            }
            if (Npanel != null)
            {
                tablero2.Controls.Add(Npanel);
                Npanel.Size = new Size(cuadrado.X - 5, cuadrado.Y - 5);
                Npanel.Left = (cuadrado.X * posX) + 2;
                Npanel.Top = (cuadrado.Y * posY) + 5;
            }
        }

        private void FinalizarJuego()
        {
            btnNuevaRon.Visible = false;
            ArrayList jugadores = Juego.Ganadores;
            string msg = "";
            int posicion = 0;
            foreach (Jugador jugador in jugadores)
            {
                msg += String.Format("El Ganador {0}: {1}, ", posicion + 1, jugador.nombre);
                posicion++;
            }
            MessageBox.Show(msg, "Ganadores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNuevo.Visible = true;
        }

        #endregion

        #region Acciones de los controles
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnNuevaRon_Click(object sender, EventArgs e)
        {
            panelPuntos.Controls.Clear();
            panelDados.Controls.Clear();
            Juego.JugarRonda();
            Jugador[] jugadores = Juego.ListarJugadores;
            for (int i = 0; i < Juego.cantJuegadores; i++)
            {
                int pos = jugadores[i].Posicion;
                int posY = 9 - ((pos - 1) / 10);
                int posX = ((pos - 1) % 10);
                CrearLabels(i, pos, jugadores[i].Avance);
                // verifica si existe un panel en el row and col
                MoverFichas(i, posX, posY);
            }

            ModificarTamanio();
            MostrarAfectados();
            if(Juego.HaFinalizado) FinalizarJuego();
            if (((Button)sender).Text == "Iniciar Ronda") ((Button)sender).Text = "Proxima Ronda";
        }

        #endregion

        private void btnNuevaRon_MouseHover(object sender, EventArgs e)
        {
            btnNuevaRon.BackgroundImage = Properties.Resources.dados;
        }

        private void btnNuevaRon_MouseLeave(object sender, EventArgs e)
        {
            btnNuevaRon.BackgroundImage = Properties.Resources.dados2;
        }
    }
}
