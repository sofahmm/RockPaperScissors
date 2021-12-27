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
            Console.WriteLine(Player.XodPlayers(xodPl, xodPr));
            

        }
    }
}
