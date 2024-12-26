using Tyuiu.SizikovSS.Sprint6.Task5.V8;
using Tyuiu.SizikovSS.Sprint6.Task5.V8.Lib;

namespace Tyuiu.SizikovSS.Sprint6.Task5.V8
{
    public partial class MainForm : Form
    {
        DataService ds = new DataService();
        string path = Path.Combine(@"C:\Users\simen\source\repos\Tyuiu.SizikovSS.Sprint6\InPutDataFileTask5V8.txt");

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Info_SSS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 5 �������� ������� ���� ��� ������ ����-24-1 ������� ���� �������������.", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Open_SSS_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("���� �� ����������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Run_SSS_Click(object sender, EventArgs e)
        {
            this.chart_Res_SSS.ChartAreas[0].AxisX.Title = "��� �";
            this.chart_Res_SSS.ChartAreas[0].AxisY.Title = "��� Y";

            chart_Res_SSS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView_Mass_SSS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chart_Res_SSS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
    }
}