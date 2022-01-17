using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockPaperScissors_Core;

//неиспользуемые using

namespace RSP_API.Service
{
    public class GameService
    {
        static List<Figure> figures { get; }
        static int nextId = 3;  //magic numbers
        static GameService()
        {
            figures = new List<Figure>
            {
                new Figure
                {
                    ID = 1,
                    Name = 2,
                    Opponent = 0
                }
            };
        }
        public static List<Figure> GetAll() => figures;
        public static Figure Get(int ID) => figures.FirstOrDefault(f => f.ID == ID);
        public static void Add (Figure figure)
        {
            figure.ID = nextId++;
            figures.Add(figure);
        }
        public static void Delete (int id)
        {
            var figure = Get(id);
            if (figure is null)
                return; // неправильная обработка ошибок
            figures.Remove(figure);
        }
        public static void Update(Figure figure)
        {
            var index = figures.FindIndex(f => f.ID == figure.ID);
            if (index == -1)
                return; //// неправильная обработка ошибок
            figures[index] = figure;
        }
    }
}
