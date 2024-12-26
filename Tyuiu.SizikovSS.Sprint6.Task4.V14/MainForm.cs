using Tyuiu.SizikovSS.Sprint6.Task4.V14.Lib;

namespace Tyuiu.SizikovSS.Sprint6.Task4.V14
{
    public partial class Form1 : Form
    {

        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент ВШЦТ ТИУ группы РППб-24-1 Сизиков Семён Станиславович.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_Run_SSS_Click(object sender, EventArgs e)
        {

            try
            {
                int Start = Convert.ToInt32(TextBox_StartValue_SSS.Text);
                int Stop = Convert.ToInt32(TextBox_StopValue_SSS.Text);

                if (Start > Stop) MessageBox.Show("Начальное значение не может быть больше конечного", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                int len = ds.GetMassFunction(Start, Stop).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(Start, Stop);

                this.chart_Res_SSS.Titles.Add("График функции");

                this.chart_Res_SSS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart_Res_SSS.ChartAreas[0].AxisY.Title = "Ось Y";

                textBox_Res_SSS.Text = "";

                chart_Res_SSS.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chart_Res_SSS.Series[0].Points.AddXY(Start, valueArray[i]);

                    textBox_Res_SSS.AppendText("X = " + Start + "\tY = " + valueArray[i] + Environment.NewLine);

                    Start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Save_SSS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V14.txt";
                File.WriteAllText(path, textBox_Res_SSS.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();

                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Info_SSS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент ВШЦТ ТИУ группы РППб-24-1 Сизиков Семён Станиславович.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
