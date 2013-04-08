using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    public class Place
    {
        //private int x, y, z;                        //координаты в массиве
        public int n;                              // номер места в массиве
        public bool Available;                        // можно ли занимать данное место (первоначально свободна только нижняя грань. Затем становятся доступными места над поставленными точками)
        public bool Occup;                            // наличие/отсутствие крестика/нолика в данной точке
        public int Col;                            // Чёрный или белый
        public int[] Lines;                          //номера рядов, в которые входит точка
        private int linenum;                          //служебная переменная

        public Place(int N)                      //конструктор класса. Вводится номер точки в массиве от 1 до 64. Сначала растёт х, потом у, потом z
        {
            n = N;
            Available = false;
            Occup = false;
            Col = 0;
            Lines = new int[Len()];
            linenum = 0;
        }
        public void WriteLine(int pos)
        {
            Lines[linenum] = pos;
            linenum++;
        }

        public void SetAvailable()
        {
            Available = true;
        }

        public void SetBulb(bool White)
        {
            if(Available==true)
            {
                int N;
                if(White==true)
                {
                    N = 1;
                }
                else
                {
                    N = 2;
                }
                Occup = true;
                Col = N;
            }
        }
        public void SetOccup()
        {
            if(Available==true)
            {
                Occup = true;
                Available = false;
            }
        }
        public void SetFree()
        {
            Occup = false;
        }
        private int Len()                     //определяем количество комбинаций, в которые может входить данная точка
    {
        int ch=n;
        int s, d, e;
            s = ch/100;
            d = ch/10-s*10;
            e = ch - s*100 - d*10;
            if((s==2||s==3) && (d==2||d==3) && (e==2||e==3))
            {
                return 7;
            }
            else
            {
                if((s==1||s==4) && (d==1||d==4) && (e==1||e==4))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
    }
    }
}


