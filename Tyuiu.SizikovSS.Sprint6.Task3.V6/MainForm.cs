using Tyuiu.SizikovSS.Sprint6.Task3.V6.Lib;

namespace Tyuiu.SizikovSS.Sprint6.Task3.V6
{
    public partial class MainForm : Form
    {

        DataService ds = new DataService();

        int[,] matrix = new int[5, 5]{
            { -2, -10, -1, 11, 1 },
            { -15, -9, -4, -15, 18 },
            { -15, 12,  7,  6,  9 },
            { -14,-10, 10, 18, -5 },
            { -1,  7,-19,-19, -4} };


        public void MainForm_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;//Задаём переменную - количество строк
            int columns = matrix.Length / rows;//количество столбцов

            dataGridView_Massive_SSS.ColumnCount = columns;
            dataGridView_Massive_SSS.RowCount = rows;
            //ширина столбцов
            for (int i = 0; i < columns; i++)
            {
                dataGridView_Massive_SSS.Columns[i].Width = 50;
            }

            //задаём сетку данными из массива
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_Massive_SSS.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }

        }


        public MainForm()
        {
            InitializeComponent();

            textBox_Uslovie_SSS.TextAlign = HorizontalAlignment.Left;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button_Info_SSS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент ВШЦТ ТИУ группы РППб-24-1 Сизиков Семён Станиславович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Run_SSS_Click(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0)+1;//Задаём переменную - количество строк
            int columns = matrix.Length / rows;

            int[,] res = ds.Calculate(matrix);

            dataGridView_Massive_SSS.ColumnCount = columns;
            dataGridView_Massive_SSS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView_Massive_SSS.Columns[i].Width = 50;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    dataGridView_Massive_SSS.Rows[i].Cells[j].Value = res[i, j].ToString();
            }

            dataGridView_Massive_SSS.AllowUserToResizeRows = false;
            dataGridView_Massive_SSS.AllowUserToResizeColumns = false;

            dataGridView_Massive_SSS.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn column in dataGridView_Massive_SSS.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

        }
    }
}
