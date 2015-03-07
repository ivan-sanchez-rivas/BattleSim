using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class PC
    {
        public int _vida;
        public PC(int vida)
        {
            _vida = vida;
        }
        public int RandomVida()
        {
            int vidaSubida;
            Random vidaR = new Random();
            vidaSubida = vidaR.Next(1, 4);
            if (_vida == 40)
            {
                //Vida llena
            }
            else
            {
                _vida = vidaSubida + _vida;
                return vidaSubida;
            }
            return vidaSubida;

        }
        public int RandomAtaque()
        {
            int ataque;
            Random ataqueR = new Random();
            ataque = ataqueR.Next(0, 7);
            //_vida = _vida - ataque;
            return ataque;
        }
    }
}
