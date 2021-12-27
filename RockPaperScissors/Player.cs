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

        //static public int Won(int q)
        //{
        //    return 0;
        //}

        //static public int Victory(int b)
        //{
        //    return 1;
        //}

        //static public int Draw(int d)
        //{
        //    return 2;
        //}
        static public int XodPlayers(int xodPlayer, int xodProtivnika)
        {
            //rock
            if (xodPlayer == 0)
            {
                if (xodProtivnika == 0)
                    return 1;
                else if (xodProtivnika == 1)
                    return 0;
                else
                    return 2;
            }
            //scissors
            else if (xodPlayer == 1)
            {
                if (xodProtivnika == 0)
                    return 1;
                else if (xodProtivnika == 1)
                    return 2;
                else
                    return 0;
            }
            //paper
            else
            {
                if (xodProtivnika == 0)
                    return 0;
                else if (xodProtivnika == 1)
                    return 1;
                else
                    return 2;
            }
        }
    }

    public class Figure
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public int Opponent { get; set; }
    }
}
