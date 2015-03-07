using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim
{
    public partial class Form1 : Form
    {
        PC jugador = new PC(40);
        Enemigo enemigo = new Enemigo(40);
        int turn = 0;
        public Form1()
        {
            InitializeComponent();
            lbl_vidaEnemigo.Text = enemigo._vida.ToString();
            lbl_vidaPC.Text = jugador._vida.ToString();
        }

        private void btn_atacar_Click(object sender, EventArgs e)
        {
           int ataque = jugador.RandomAtaque();
           enemigo._vida = enemigo._vida - ataque;
           lbl_vidaEnemigo.Text = enemigo._vida.ToString();
           lbl_infoAtaquePC.Text = "Has atacado al enemigo con: " + ataque + " puntos.";
           turn++;
           tmr_battletimer.Start();
        }

        private void btn_subirVida_Click(object sender, EventArgs e)
        {
            int vidaJugador = jugador.RandomVida();
            lbl_vidaPC.Text = jugador._vida.ToString();
            lbl_infoAtaquePC.Text = "Te has subido: " + vidaJugador + " puntos.";
            turn++;
            tmr_battletimer.Start();
        }

        private void tmr_battletimer_Tick(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                tmr_battletimer.Stop();
                Check();
                btn_atacar.Enabled = true;
                btn_subirVida.Enabled = true;
            }
            else
            {
                tmr_battletimer.Start();
                Check();
                btn_atacar.Enabled = false;
                btn_subirVida.Enabled = false;

                if (enemigo._vida >= 33)
                    EnemigoAtaque();
                else if (enemigo._vida >= 29 && enemigo._vida < 33)
                    EnemigoVida();
                else if (enemigo._vida >= 23 && enemigo._vida <= 28)
                    EnemigoAtaque();
                else if (enemigo._vida >= 20 && enemigo._vida <= 22)
                    EnemigoVida();
                else if (enemigo._vida >= 15 && enemigo._vida <= 19)
                    EnemigoAtaque();
                else if (enemigo._vida >= 11 && enemigo._vida <= 14)
                    EnemigoVida();
                else if (enemigo._vida >= 7 && enemigo._vida <= 10)
                    EnemigoAtaque();
                else
                    EnemigoVida();
                turn++;
            }
        }
        public void Check()
        {
            if (jugador._vida <= 0)
                MessageBox.Show("Perdiste");
            else if (enemigo._vida <= 0 && jugador._vida <= 0)
                MessageBox.Show("Empate");
            else if (enemigo._vida <= 0)
                MessageBox.Show("Ganaste");
        }
        public void EnemigoAtaque()
        {
            int ataqueEnemigo = enemigo.RandomAtaque();
            jugador._vida = jugador._vida - ataqueEnemigo;
            lbl_infoAtaquePC.Text = "Te han atacado con: " + ataqueEnemigo + " puntos.";
            lbl_vidaPC.Text = jugador._vida.ToString();
        }
        public void EnemigoVida()
        {
            int vidaEnemigo = enemigo.RandomVida();
            lbl_infoAtaquePC.Text = "El enemigo se ha subido " + vidaEnemigo + " puntos.";
            lbl_vidaEnemigo.Text = enemigo._vida.ToString();
        }
    }
}
