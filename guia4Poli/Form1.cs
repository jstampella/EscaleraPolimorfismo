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
        Bitmap[] mapas = new Bitmap[3];
        JugadorForm jugadorForm = new JugadorForm();
        public Form1()
        {
            InitializeComponent();
            mapas[0] = Properties.Resources.background2;
            mapas[1] = Properties.Resources.background;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string[] nombres = new string[jugadorH];
            bool cancelJuego = false;

            int count = 0;
            while (count < jugadorM)
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
                juego = new Tablero(cantJugadores, nombres);
                this.Hide();
                while (juego.ShowDialog() == DialogResult.OK)
                {
                    juego = new Tablero(cantJugadores, nombres);
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
            panelGraf.BackgroundImage = mapas[0];
        }

        private void cbNivel_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbNivel.SelectedIndex == 1)
            {
                btnTablero.Visible = true;
            }
            else
            {
                btnTablero.Visible = false;
            }
        }

        private void btnTablero_Click(object sender, EventArgs e)
        {
            if(panelGraf.BackgroundImage == mapas[0])
            {
                panelGraf.BackgroundImage = mapas[1];
            }
            else
            {
                panelGraf.BackgroundImage = mapas[0];
            }
        }
    }
}
