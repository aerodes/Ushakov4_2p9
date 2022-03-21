using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    public class ClassCVT
    {
        public static void KV(double a, double b, double c, out string messege)
        {
            messege = null;
            if(a == 0)
            {
                LU(b, c, out messege);
            }
            else
            {
                double dis = b * b - 4 * a * c;
                if(dis == 0)
                {
                    messege = $"Дискременант равен нулю, 1 корень: х1 = {-b / 2 / a}";
                }
                else if(dis > 0)
                {
                    messege = $"Дискременант больше нуля, 2 корня: х1 = {-b + Math.Sqrt(dis) / (2 * a)} и х2 = {-b - Math.Sqrt(dis) / (2 * a)}";
                }
                else if(dis < 0)
                {
                    messege = "Дискременант меньше нуля, корней нет";
                }
            }
        }
        public static void LU(double k, double b, out string messege)
        {
            messege = $"Корень равен {-b / k}";
        }
    }
}
