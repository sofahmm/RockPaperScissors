using System;

namespace RPS_draft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер, который соответствует фигуре, которой вы хотите сходить:");
            Console.WriteLine("Камень - 1");
            Console.WriteLine("Ножницы - 2");
            Console.WriteLine("Бумага - 3");

            int xod = Convert.ToInt32(Console.ReadLine());


            //Камень - 1
            //Ножницы - 2
            //Бумага - 3


            Random p = new Random();
            int protivnik = p.Next(0, 2);
            Console.WriteLine(protivnik);

            if (xod == 1)
            {
                if (protivnik == 2)
                    Console.WriteLine("Вы проиграли!");
                else
                    Console.WriteLine("Вы выиграли!");
            }
            else if (xod == 2)
            {
                if (protivnik == 0)
                    Console.WriteLine("Вы проиграли!");
                else
                    Console.WriteLine("Вы выиграли!");
            }
            else if (xod == 3)
            {
                if (protivnik == 1)
                    Console.WriteLine("Вы проиграли!");
                else
                    Console.WriteLine("Вы выиграли!");
            }
        }
    }
}
