using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Enemigo
    {
        public int _vida;
        public Enemigo(int vida)
        {
            _vida = vida;
        }
        public void RandomVida()
        {
            int vidaSubida;
            Random vidaR = new Random();
            vidaSubida = vidaR.Next(0, 4);
            if (_vida == 20)
            {
                //Vida llena
            }
            else
            {
                _vida = vidaSubida + _vida;
            }
            
        }
        public int RandomAtaque()
        {
            int ataque;
            Random ataqueR = new Random();
            ataque = ataqueR.Next(0, 8);
            //_vida = _vida - ataque;
            return ataque;
        }
    }
}
