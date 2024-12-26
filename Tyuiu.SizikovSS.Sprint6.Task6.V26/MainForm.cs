using Tyuiu.SizikovSS.Sprint6.Task6.V26.Lib;

namespace Tyuiu.SizikovSS.Sprint6.Task6.V26
{
    public partial class MainForm : Form
    {
        DataService ds = new DataService();

        string fileContent;
        string path;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Open_SSS_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\"; // Начальная директория
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите текстовый файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;

                    // Чтение файла
                    fileContent = File.ReadAllText(path);
                    textBoxIn.Text = fileContent; // Отображение содержимого в textBoxIn
                }
            }
        }

        private void button_Conver_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileContent))
            {
                MessageBox.Show("Сначала откройте файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Вывод результата
            textBoxOut.Text = ds.CollectTextFromFile(fileContent, path);
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
