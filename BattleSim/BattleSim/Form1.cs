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
        PC jugador = new PC(20);
        Enemigo enemigo = new Enemigo(20);
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
           turn++;
           tmr_battletimer.Start();
        }

        private void btn_subirVida_Click(object sender, EventArgs e)
        {
            jugador.RandomVida();
            lbl_vidaPC.Text = jugador._vida.ToString();
            turn++;
            tmr_battletimer.Start();
        }

        private void tmr_battletimer_Tick(object sender, EventArgs e)
        {
            if (turn % 2 == 0)
            {
                tmr_battletimer.Stop();
            }
            else
            {
                tmr_battletimer.Start();
                int ataqueEnemigo = enemigo.RandomAtaque();
                jugador._vida = jugador._vida - ataqueEnemigo;
                lbl_vidaPC.Text = jugador._vida.ToString();
                turn++;
            }
        }
    }
}
