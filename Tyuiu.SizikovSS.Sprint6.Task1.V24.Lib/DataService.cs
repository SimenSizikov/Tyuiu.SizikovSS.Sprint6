using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SizikovSS.Sprint6.Task1.V24.Lib
{
    public class DataService : ISprint6Task1V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++) count++;//Подсчёт длины массива

            double[] mass = new double[count];
            int k = 0;

            for (int x = startValue; x <= stopValue; x++)//перебор иксов в диапазоне
            {
                if (x == -1.7)//проверка деления на ноль
                {
                    mass[k] = 0;
                    continue;
                }

                mass[k] = Math.Round( Math.Sin(x)/(x+1.7)-Math.Cos(x)*(4*x)-6 , 2);
                k++;
            }
            return mass;
        }
    }
}
