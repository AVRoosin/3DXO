using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    class Player
    {
        private int n;                  //номер игрока
        public bool Turn;              //ход игрока
        private bool Win;               // выигрыш

        public Player(int N)
        {
            n = N;
            Turn = false;
            Win = false;
        }
        protected void TurnOn()
        {
            Turn = true;
        }
        protected void TurnOff()
        {
            Turn = false;
        }
        public void Won()
        {
            Win = true;
        }
        public bool IsWon()
        {
            return Win;
        }
    }
}
