using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KupriyanovEA.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double x2, double y1, double y2)
        {
            int dx = (int)Math.Abs(x2 - x1);
            int dy = (int)Math.Abs(y2 - y1);

            if (x1 < 1 || x1 > 8 || x2 < 1 || x2 > 8 || y1 < 1 || y1 > 8 || y2 < 1 || y2 > 8)
            {
                Console.WriteLine("Введены недопустимые значения");
                return false;
            }

            else if (dx == dy)
            {
                Console.WriteLine("Может ли «Слон» с одного поля перейти за один ход на другое? = ");
                return true;
            }
            else 
            {
                Console.WriteLine("Может ли «Слон» с одного поля перейти за один ход на другое? = ");
                return false;
            }

        }
    }
}
