using Tyuiu.SizikovSS.Sprint6.Task1.V24.Lib;

namespace Tyuiu.SizikovSS.Sprint6.Task1.V24
{
    public partial class FormMain_SSS : Form
    {
        public FormMain_SSS()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //НЕ ТРОГАТЬ ИНАЧЕ КОД СЛОМАЕТСЯ
        }

        private void button_Info_SSS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент ВШЦТ ТИУ группы РППб-24-1 Сизиков Семён Станиславович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Run_SSS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                //Переменные принимают значения из текстовых блоков
                int Start = Convert.ToInt32(textBox_InputLineStartValue_SSS);
                int Stop = Convert.ToInt32(textBox_InputLineStopValue_SSS);

                string strLine;
                int len = ds.GetMassFunction(Start, Stop).Length;//Длинна получившегося массива

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(Start, Stop);//Получаем значения функции

                //Делаем кепочку шапочку верхушечку
                textBox_OutputBox_SSS.Text = "";
                textBox_OutputBox_SSS.AppendText("+----------+----------+" + Environment.NewLine);
                textBox_OutputBox_SSS.AppendText("|       X        |      f(x)     |" + Environment.NewLine);
                textBox_OutputBox_SSS.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|     {0,4:f1}      |{1,10:f2}   |", Start, valueArray[i]);
                    textBox_OutputBox_SSS.AppendText(strLine + Environment.NewLine);
                    Start++
                }
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
