using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SizikovSS.Sprint6.Task6.V26.Lib
{
    public class DataService : ISprint6Task6V26
    {
        public string CollectTextFromFile(string str, string path)
        {
            string stringValues = File.ReadAllText(path); //взяли путь
            string result = "";

            // Разделяем строку на отдельные строки по символу новой строки
            string[] lines = stringValues.Split(new[] { '\n' }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                // Разделяем строку на слова по пробелам
                string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                // Если есть слова в строке
                if (words.Length > 0)
                {
                    // Добавляем последнее слово к результату
                    result += words[words.Length - 1] + " ";
                }
                
            }

            return result = result.TrimEnd();
        }
    }
}
