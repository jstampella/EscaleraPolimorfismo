using System;
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
    public enum Niveles
    {
        Basico, Avanzado
    }
    public partial class Form1 : Form
    {

        Tablero juego;
        int limitJugadores = 4;
        int jugadorH = 1;
        int jugadorM = 1;
        int mapa = 0;
        public static Bitmap[] mapas = new Bitmap[3];
        JugadorForm jugadorForm = new JugadorForm();
        public Form1()
        {
            InitializeComponent();
            mapas[0] = Properties.Resources.backgroundBasic;
            mapas[1] = Properties.Resources.background;
            mapas[2] = Properties.Resources.background2;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string[] nombres = new string[jugadorH];
            bool cancelJuego = false;

            int count = 0;
            while (count < jugadorH)
            {
                jugadorForm.txtNombre.Text = "";
                jugadorForm.title.Text = "Jugador: " + (count + 1);
                if (jugadorForm.ShowDialog() == DialogResult.OK)
                {
                    nombres[count] = jugadorForm.txtNombre.Text;
                    count++;
                }
                else
                {
                    cancelJuego = true;
                    break;
                }
            }
            if (!cancelJuego)
            {
                int cantJugadores = jugadorH + jugadorM;
                juego = new Tablero(cantJugadores, nombres, mapa);
                this.Hide();
                while (juego.ShowDialog() == DialogResult.OK)
                {
                    juego = new Tablero(cantJugadores, nombres,mapa);
                }
                this.Show();
            }
        }


        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            jugadorH = Convert.ToInt16(inpHum.Value);
            jugadorM = Convert.ToInt16(inpMaq.Value);
            if (jugadorH + jugadorM> limitJugadores)
            {
                MessageBox.Show("Limite maximo 4 en total");
                if (((NumericUpDown)sender).Name == "inpHum")
                {
                    inpHum.Value = jugadorH - 1;
                }
                else
                {
                    inpMaq.Value = jugadorM - 1;
                }
            }
        }


        private void inpMaq_ValueChanged(object sender, EventArgs e)
        {
            jugadorH = Convert.ToInt16(inpHum.Value);
            jugadorM = Convert.ToInt16(inpMaq.Value);
            if (jugadorH + jugadorM > limitJugadores)
            {
                MessageBox.Show("Limite maximo 4 en total");
                if (((NumericUpDown)sender).Name == "inpHum")
                {
                    inpHum.Value = jugadorH - 1;
                }
                else
                {
                    inpMaq.Value = jugadorM - 1;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbNivel.Items.Add(Niveles.Basico.ToString());
            cbNivel.Items.Add(Niveles.Avanzado.ToString());
            cbNivel.SelectedIndex = 0;
            panelGraf.BackgroundImage = mapas[mapa];
        }

        private void cbNivel_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbNivel.SelectedIndex == 1)
            {
                btnTablero.Visible = true;
                mapa = 1;
                panelGraf.BackgroundImage = mapas[1];
            }
            else
            {
                mapa = 0;
                btnTablero.Visible = false;
            }
        }

        private void btnTablero_Click(object sender, EventArgs e)
        {
            if(panelGraf.BackgroundImage == mapas[1])
            {
                mapa = 2;
                panelGraf.BackgroundImage = mapas[2];
            }
            else
            {
                mapa = 1;
                panelGraf.BackgroundImage = mapas[1];
            }
        }
    }
}
