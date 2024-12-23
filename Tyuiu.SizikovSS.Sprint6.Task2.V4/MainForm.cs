using Tyuiu.SizikovSS.Sprint6.Task2.V4.Lib;

namespace Tyuiu.SizikovSS.Sprint6.Task2.V4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button__Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент ВШЦТ ТИУ группы РППб-24-1 Сизиков Семён Станиславович.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Run_SSS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                this.DataGridView_Output_SSS.Rows.Clear();

                int Start = Convert.ToInt32(textBox_StartValueLine_SSS.Text);
                int Stop = Convert.ToInt32(textBox_StopValueLine_SSS.Text);

                int len = ds.GetMassFunction(Start, Stop).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(Start, Stop);

                this.Chart_Output_SSS.ChartAreas[0].AxisX.Title = "Ось X";
                this.Chart_Output_SSS.ChartAreas[0].AxisY.Title = "Ось Y";


                if (Start > Stop)
                {
                    MessageBox.Show("Конец шага не может быть меньше начала шага.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                for (int i = 0; i < len; i++)
                {
                    this.DataGridView_Output_SSS.Rows.Add(Convert.ToString(Start), Convert.ToString(valueArray[i]));

                    this.Chart_Output_SSS.Series[0].Points.AddXY(Start, valueArray[i]);

                    Start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
