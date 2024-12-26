using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SizikovSS.Sprint6.Task2.V4.Lib
{
    public class DataService : ISprint6Task2V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++) count++;//Подсчёт длины массива

            double[] mass = new double[count];
            int k = 0;

            for (int x = startValue; x <= stopValue; x++)//перебор иксов в диапазоне
            {
                if (Math.Sin(x) == -2)//проверка деления на ноль
                {
                    mass[k] = 0;
                    continue;
                }

                mass[k] = Math.Round( (5*x + 2.5)/(Math.Sin(x)+2) + 2*x +2 , 2);
                k++;
            }
            return mass;
        }
    }
}
