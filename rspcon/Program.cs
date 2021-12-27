using System;
using RockPaperScissors_Core;
namespace rspcon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру, которой хотите сходить." +
                "0 - камень, " +
                "1 - ножницы, " +
                "2 - бумага, ");
            int xodPl = Convert.ToInt32(Console.ReadLine());
            int xodPr = new Random().Next(0, 3);
            int b = Player.XodPlayers(xodPl, xodPr);
            if(b == 0)
            {
                Console.WriteLine("Вы выиграли!");
            }
            else if (b == 1)
            {
                Console.WriteLine("Вы проиграли!");
            }
            else
            {
                Console.WriteLine("Ничья!");
            }

        }
    }
}
