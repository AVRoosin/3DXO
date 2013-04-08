using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    public class Game
    {
        private Player Pl1;             //Игрок 1
        private Player Pl2;             //Игрок 2
        private Comb[] Rows;            //Все возможные линейные комбинации точек
        private Place[, ,] Cube;           //Игровое поле
        //     private bool started;           //игра начата
        private bool finished;          //игра окончена
        public int YPos;                //служебная переменная
        public int CurrCol;                //служебная переменная
        public UInt64 WinningRow;         // сюда запишем собранный ряд после победы одного из игроков

        public Game()
        {
            //           started = true;
            finished = false;
            Pl1 = new Player(1);
            Pl2 = new Player(2);
            Cube = new Place[4, 4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        int num = (i + 1) * 100 + (j + 1) * 10 + (k + 1);
                        Cube[i, j, k] = new Place(num);
                        if (j == 0)
                        {
                            Cube[i, j, k].SetAvailable();
                        }
                    }
                }
            }
            //==============инициализация рядов=====================
            Rows = new Comb[76];
            //--------------XY.Init---------------------------------
            int rownum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Rows[rownum] = new Comb();
                    for (int k = 0; k < 4; k++)
                    {
                        Rows[rownum].Row[k] = (i + 1) * 100 + (j + 1) * 10 + (k + 1);
                        Cube[i, j, k].WriteLine(rownum);
                    }
                    rownum++;
                }
            }
            //--------------XZ.Init---------------------------------
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Rows[rownum] = new Comb();
                    for (int j = 0; j < 4; j++)
                    {
                        Rows[rownum].Row[j] = (i + 1) * 100 + (j + 1) * 10 + (k + 1);
                        Cube[i, j, k].WriteLine(rownum);
                    }
                    rownum++;
                }
            }
            //--------------YZ.Init---------------------------------
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Rows[rownum] = new Comb();
                    for (int i = 0; i < 4; i++)
                    {
                        Rows[rownum].Row[i] = (i + 1) * 100 + (j + 1) * 10 + (k + 1);
                        Cube[i, j, k].WriteLine(rownum);
                    }
                    rownum++;
                }
            }
            //-------------XZ.diagonal.Init-------------------------
            for (int j = 0; j < 4; j++)
            {
                Rows[rownum] = new Comb();
                for (int i = 0; i < 4; i++)
                {
                    Rows[rownum].Row[i] = (i + 1) * 100 + (j + 1) * 10 + (i + 1);
                    Cube[i, j, i].WriteLine(rownum);
                }
                rownum++;
            }
            for (int j = 0; j < 4; j++)
            {
                Rows[rownum] = new Comb();
                for (int i = 0; i < 4; i++)
                {
                    Rows[rownum].Row[i] = (i + 1) * 100 + (j + 1) * 10 + (3 - i + 1);
                    Cube[i, j, 3 - i].WriteLine(rownum);
                }
                rownum++;
            }
            //-------------XY.diagonal.Init-------------------------
            for (int j = 0; j < 4; j++)
            {
                Rows[rownum] = new Comb();
                for (int i = 0; i < 4; i++)
                {
                    Rows[rownum].Row[i] = (i + 1) * 100 + (i + 1) * 10 + (j + 1);
                    Cube[i, i, j].WriteLine(rownum);
                }
                rownum++;
            }
            for (int j = 0; j < 4; j++)
            {
                Rows[rownum] = new Comb();
                for (int i = 0; i < 4; i++)
                {
                    Rows[rownum].Row[i] = (i + 1) * 100 + (3 - i + 1) * 10 + (j + 1);
                    Cube[i, 3 - i, j].WriteLine(rownum);
                }
                rownum++;
            }
            //-------------YZ.diagonal.Init-------------------------
            for (int j = 0; j < 4; j++)
            {
                Rows[rownum] = new Comb();
                for (int i = 0; i < 4; i++)
                {
                    Rows[rownum].Row[i] = (j + 1) * 100 + (i + 1) * 10 + (i + 1);
                    Cube[j, i, i].WriteLine(rownum);
                }
                rownum++;
            }
            for (int j = 0; j < 4; j++)
            {
                Rows[rownum] = new Comb();
                for (int i = 0; i < 4; i++)
                {
                    Rows[rownum].Row[i] = (j + 1) * 100 + (3 - i + 1) * 10 + (i + 1);
                    Cube[j, 3 - i, i].WriteLine(rownum);
                }
                rownum++;
            }
            //-------------XYZ.diagonal.Init-------------------------
            Rows[rownum] = new Comb();
            for (int i = 0; i < 4; i++)
            {
                Rows[rownum].Row[i] = (i + 1) * 100 + (i + 1) * 10 + (i + 1);
                Cube[i, i, i].WriteLine(rownum);
            }
            rownum++;

            Rows[rownum] = new Comb();
            for (int i = 0; i < 4; i++)
            {
                Rows[rownum].Row[i] = (3 - i + 1) * 100 + (i + 1) * 10 + (i + 1);
                Cube[3 - i, i, i].WriteLine(rownum);
            }
            rownum++;

            Rows[rownum] = new Comb();
            for (int i = 0; i < 4; i++)
            {
                Rows[rownum].Row[i] = (i + 1) * 100 + (3 - i + 1) * 10 + (i + 1);
                Cube[i, 3 - i, i].WriteLine(rownum);
            }
            rownum++;

            Rows[rownum] = new Comb();
            for (int i = 0; i < 4; i++)
            {
                Rows[rownum].Row[i] = (i + 1) * 100 + (i + 1) * 10 + (3 - i + 1);
                Cube[i, i, 3 - i].WriteLine(rownum);
            }
            //==========конец инициализации===========================
            Pl1.Turn = true;
        }
        protected bool TryWin(Place N)
        {
            bool flag = false;
            int l = N.Lines.Length;
            int i = 0;
            while (i < l && flag == false)
            {
                flag = Rows[N.Lines[i]].IsWon();
                if (flag == true)
                {
                    WinningRow = Rows[N.Lines[i]].ConvertRowToInt();
                }
                i++;
            }
            return flag;
        }

        public UInt64 GetWinningRowNumber()
        { return WinningRow;}

        //public int ConvertRowToInt(Comb ConvertingRow)
        //{
        //    int ConvertedInt=0;
        //    int Multiplier=1000;
        //    for(int i=0; i<3; i+=2)
        //    {
        //      ConvertedInt=ConvertingRow[i]+ConvertingRow[i+1]*Multiplier;
        //      Multiplier=Multiplier*1000;
        //    }
        //    return ConvertedInt;
        //}

        public int DoTurn(int X, int Z)
        {
            if (Cube[X, 3, Z].Occup == false)
            {
                int RwN, i = 3;
                bool flag = false;
                while (flag != true)
                {
                    if (Cube[X, i, Z].Available == true)
                    {
                        flag = true;
                    }
                    else
                    {
                        i--;
                    }
                }
                YPos = i;
                if (Pl1.Turn == true)
                {
                    CurrCol = 1;
                    Cube[X, i, Z].Col = 1;
                    Cube[X, i, Z].Available = false;
                    Cube[X, i, Z].Occup = true;
                    if (i != 3)
                    {
                        Cube[X, i + 1, Z].Available = true;
                    }
                    for (RwN = 0; RwN < Cube[X, i, Z].Lines.Length; RwN++)
                    {
                        Rows[Cube[X, i, Z].Lines[RwN]].AddPlace(1);
                    }
                    if (TryWin(Cube[X, i, Z]) == true)
                    {
                        finished = true;
                        Pl1.Won();
                    }
                    else
                    {
                        Pl1.Turn = false;
                        Pl2.Turn = true;
                    }
                }
                else
                {
                    CurrCol = 2;
                    Cube[X, i, Z].Col = 2;
                    Cube[X, i, Z].Available = false;
                    Cube[X, i, Z].Occup = true;
                    if (i != 3)
                    {
                        Cube[X, i + 1, Z].Available = true;
                    }
                    for (RwN = 0; RwN < Cube[X, i, Z].Lines.Length; RwN++)
                    {
                        Rows[Cube[X, i, Z].Lines[RwN]].AddPlace(2);
                    }
                    if (TryWin(Cube[X, i, Z]) == true)
                    {
                        finished = true;
                        Pl2.Won();
                    }
                    else
                    {
                        Pl2.Turn = false;
                        Pl1.Turn = true;
                    }
                }
                if (finished == true)
                {

                    if (Pl1.IsWon() == true)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
