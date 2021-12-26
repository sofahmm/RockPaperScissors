using System;
using RockPaperScissors_Core;
namespace rspcon
{
    class Program
    {
        static void Main(string[] args)
        {
            int xodPl = Convert.ToInt32(Console.ReadLine());
            int xodPr = new Random().Next(0, 2);
            Player player = new Player.XodPlayers(xodPl, xodPr, 0, 1, 2);
        }
    }
}
