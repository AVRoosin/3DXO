using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    class Comb
    {
        public int[] Row;                  //линейная комбинация точек. В массив запичываются их номера
        //private int n;                      // номер ряда
        private bool free;                  //"чистый ряд" (т.е. все точки одного цвета)
        private int free_quan;              // количество свободных яцеек
        private int Col;                    // "цвет" ряда (если чистый)
        //private int RowRank;                // для ИИ (определяет "опасность" и заполнение данного ряда в игре)

        public Comb()
        {
            Row=new int[4];
            free = true;
            free_quan = 4;
            Col = 0;
        }

        public bool IsWon()
        {
            return (free_quan == 0 && free == true);
        }

        public void AddPlace(int col)
        {
            free_quan--;
            if(Col==0)
            {
                Col = col;
            }
            else
            {
                if(Col!=col)
                {
                    Col = -1;
                    free = false;
                }
            }
        }
        public UInt64 ConvertRowToInt()
        {
            UInt64 ConvertedInt = 0;
            UInt64 Multiplier = 1;
            UInt64 row=0;
            for(int i=0; i<Row.Length; i++)
            {
                row=System.Convert.ToUInt64(Row[i]);
                ConvertedInt = ConvertedInt+row * Multiplier;
              Multiplier=Multiplier*1000;
            }
            return ConvertedInt;
        }
        //public void GetNewEl(int Clr )
        //protected int CountRowRank()
    }
}
