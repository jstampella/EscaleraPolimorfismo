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
    public partial class Form1 : Form
    {
        Tablero juego;
        int limitJugadores = 4;
        int jugadorH = 1;
        int jugadorM = 1;
        JugadorForm jugadorForm = new JugadorForm();
        public Form1()
        {
            InitializeComponent();
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

        private void numericUpDown1_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Right || e.Button == System.Windows.Forms.MouseButtons.Left)
            //{
            //    NumericUpDown np = null;
            //    NumericUpDown np2 = null;
            //    if (((NumericUpDown)sender).Name == "inpHum")
            //        np = (NumericUpDown)sender;
            //    else
            //    {
            //        np2 = (NumericUpDown)sender;
            //    }

            //    if (jugadorH + jugadorM + 1 <= limitJugadores)
            //        if (np != null)
            //            jugadorH = Convert.ToInt16(np.Value);
            //        else
            //        {
            //            jugadorM = Convert.ToInt16(np2.Value);
            //        }
            //    else
            //    {
            //        MessageBox.Show("Limite maximo 4 en total");
            //        if (np != null)
            //            np.Value = jugadorH;
            //        else
            //        {
            //            np2.Value = jugadorM;
            //        }
            //    }
            //}
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
    }
}
