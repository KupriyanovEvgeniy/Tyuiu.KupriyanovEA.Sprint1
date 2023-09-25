using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KupriyanovEA.Sprint1.Task4.V3.Lib
{
    public class DataService : ISprint1Task4V3
    {
        public double Calculate(double x, double y)
        {
            if (x - y == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
                return 0;
            }
            else
            {
                var res = Math.Round(Math.Sqrt(x * 3) / Math.Pow(x - y, 2), 3);
                Console.WriteLine("sqrt(x*3)/(x-y)^2 = ");
                return res;
            }
            
        }
    }
}
