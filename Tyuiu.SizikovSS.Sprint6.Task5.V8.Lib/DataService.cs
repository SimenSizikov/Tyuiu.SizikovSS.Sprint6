using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SizikovSS.Sprint6.Task5.V8.Lib
{
    public class DataService : ISprint6Task5V8
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))//открываем для чтения задаём в переменной
            {
                string line;
                while ((line = reader.ReadLine()) != null) len++;//считаетм кол-во строк в переменной len
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))//открываем для чтения ещё раз
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);//заполняем массив даннымими из файла
                    index++;
                }
            }

            numsArray = numsArray.Where(val => val < 0).ToArray();//оставляем только отрицательные числа

            return numsArray;
        }
    }
}
