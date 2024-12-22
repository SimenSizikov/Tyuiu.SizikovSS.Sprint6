using System.Drawing.Text;

using Tyuiu.SizikovSS.Sprint6.Task0.V22.Lib;

namespace Tyuiu.SizikovSS.Sprint6.Task0.V22
{
    public partial class MainForm_SSS : Form
    {
        public MainForm_SSS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Info_SSS_Click(object sender, EventArgs e) //Всплывающее сообщение
        {
            MessageBox.Show("Таск 0 выполнил студент ВШЦТ ТИУ группы РППб-24-1 Сизиков Семён Станиславович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Run_SSS_Click(object sender, EventArgs e) //Кнопка "Вывести" триггерит метод
        {
            DataService ds = new DataService();
            try//окно вывода принимает значение окна ввода, прогнанного через ds.Calculate
            {
                textBox_OutputLineY_SSS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox_InputLineX_SSS.Text)));
            }
            catch//В случае ошибки ввода выдаём всплывающее сообщение
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
