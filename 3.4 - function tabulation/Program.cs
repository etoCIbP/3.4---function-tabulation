using System;

namespace _3._4___function_tabulation
{
    class Program
    {
        static void Main(string[] args)
        {

            // 3.4 Высокий уровень
            for (double x=-2; x<=2; x+=0.4)
            {
                double y = 0;
                    if (x>0)
                    //Решение
                {
                    double S = 0; 
                    for (int k = 1; k <= 3; k++)
                    {
                        S += Math.Pow(x, k) / k;
                    }
                    y = S;
                }
                else
                {
                    Math.Sqrt(5 * (Math.Pow(x, 3)));
                }
                Console.WriteLine("|{0,13:F2}|{1,14:F2}|",x,y);
            }
        }
    }
}
