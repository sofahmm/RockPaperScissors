using System;

namespace RockPaperScissors_Core
{
    public abstract class Player
    {
        protected int xodPlayer;
        protected int xodProtivnika;// = new Random().Next(0, 2);
        public Player (int d, int v)
        {
            xodPlayer = d;
            xodProtivnika = v;
        }

        //0-выиграл
        //1-проиграл
        //2-ничья

        //0-камень
        //1-ножницы
        //2-бумага

        static public Player Won(int q)
        {
            q = 0;
            return Won(q);
        }

        static public Player Victory(int b)
        {
            b = 1;
            return Victory(b);
        }

        static public Player Draw(int d)
        {
            d = 2;
            return Draw(d);
        }
        static public Player XodPlayers(int xodPlayer, int xodProtivnika, int q, int w, int e)
        {
            //q = 0
            //w=1
            //e=2
            //rock
            if (xodPlayer == 0)
            {
                if (xodProtivnika == 0)
                    return Draw(2);
                else if (xodProtivnika == 1)
                    return Won(0);
                else
                    return Victory(1);
            }
            //scissors
            else if (xodPlayer == 1)
            {
                if (xodProtivnika == 0)
                    return Victory(1);
                else if (xodProtivnika == 1)
                    return Draw(2);
                else
                    return Won(0);
            }
            //paper
            else
            {
                if (xodProtivnika == 0)
                    return Won(0);
                else if (xodProtivnika == 1)
                    return Victory(1);
                else
                    return Draw(2);
            }

        }
    }
}
