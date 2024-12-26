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

        private void button_Info_SSS_Click(object sender, EventArgs e) //����������� ���������
        {
            MessageBox.Show("���� 0 �������� ������� ���� ��� ������ ����-24-1 ������� ���� �������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Run_SSS_Click(object sender, EventArgs e) //������ "�������" ��������� �����
        {
            DataService ds = new DataService();
            try//���� ������ ��������� �������� ���� �����, ����������� ����� ds.Calculate
            {
                textBox_OutputLineY_SSS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox_InputLineX_SSS.Text)));
            }
            catch//� ������ ������ ����� ����� ����������� ���������
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
