using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SizikovSS.Sprint6.Task3.V6.Lib
{
    public class DataService : ISprint6Task3V6
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 2; i <= 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0) matrix[i, j] = 0;
                }
            }
            return matrix;
        }
    }
}
