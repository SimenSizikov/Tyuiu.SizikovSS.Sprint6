using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SizikovSS.Sprint6.Task4.V14.Lib
{
    public class DataService : ISprint6Task4V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            for (int i = startValue; i <= stopValue; i++) count++;

            double[] mass = new double[count];
            int k = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) == -1)
                {
                    mass[k] = 0;
                    continue;
                }

                mass[k] = Math.Round( 2*x - 4 + (2*x-1)/(Math.Sin(x)+1), 2);
                k++;
            }
            return mass;
        }
    }
}
