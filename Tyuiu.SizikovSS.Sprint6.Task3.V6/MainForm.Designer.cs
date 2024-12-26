namespace Tyuiu.SizikovSS.Sprint6.Task3.V6
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox_Uslovie_SSS = new GroupBox();
            pictureBox_Uslovie_SSS = new PictureBox();
            textBox_Uslovie_SSS = new TextBox();
            groupBox_Output_SSS = new GroupBox();
            dataGridView_Massive_SSS = new DataGridView();
            button_Run_SSS = new Button();
            button_Info_SSS = new Button();
            groupBox_Uslovie_SSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Uslovie_SSS).BeginInit();
            groupBox_Output_SSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Massive_SSS).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Uslovie_SSS
            // 
            groupBox_Uslovie_SSS.Controls.Add(pictureBox_Uslovie_SSS);
            groupBox_Uslovie_SSS.Controls.Add(textBox_Uslovie_SSS);
            groupBox_Uslovie_SSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox_Uslovie_SSS.Location = new Point(12, 12);
            groupBox_Uslovie_SSS.Name = "groupBox_Uslovie_SSS";
            groupBox_Uslovie_SSS.Size = new Size(305, 426);
            groupBox_Uslovie_SSS.TabIndex = 0;
            groupBox_Uslovie_SSS.TabStop = false;
            groupBox_Uslovie_SSS.Text = "Условие";
            // 
            // pictureBox_Uslovie_SSS
            // 
            pictureBox_Uslovie_SSS.Image = (Image)resources.GetObject("pictureBox_Uslovie_SSS.Image");
            pictureBox_Uslovie_SSS.Location = new Point(3, 244);
            pictureBox_Uslovie_SSS.Name = "pictureBox_Uslovie_SSS";
            pictureBox_Uslovie_SSS.Size = new Size(172, 173);
            pictureBox_Uslovie_SSS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Uslovie_SSS.TabIndex = 1;
            pictureBox_Uslovie_SSS.TabStop = false;
            // 
            // textBox_Uslovie_SSS
            // 
            textBox_Uslovie_SSS.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Uslovie_SSS.Location = new Point(3, 27);
            textBox_Uslovie_SSS.Multiline = true;
            textBox_Uslovie_SSS.Name = "textBox_Uslovie_SSS";
            textBox_Uslovie_SSS.Size = new Size(296, 211);
            textBox_Uslovie_SSS.TabIndex = 0;
            textBox_Uslovie_SSS.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в третьей строке на 0.";
            // 
            // groupBox_Output_SSS
            // 
            groupBox_Output_SSS.Controls.Add(dataGridView_Massive_SSS);
            groupBox_Output_SSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox_Output_SSS.Location = new Point(323, 24);
            groupBox_Output_SSS.Name = "groupBox_Output_SSS";
            groupBox_Output_SSS.Size = new Size(341, 354);
            groupBox_Output_SSS.TabIndex = 1;
            groupBox_Output_SSS.TabStop = false;
            groupBox_Output_SSS.Text = "Вывод данных";
            // 
            // dataGridView_Massive_SSS
            // 
            dataGridView_Massive_SSS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Massive_SSS.Location = new Point(6, 38);
            dataGridView_Massive_SSS.Name = "dataGridView_Massive_SSS";
            dataGridView_Massive_SSS.RowHeadersWidth = 51;
            dataGridView_Massive_SSS.Size = new Size(329, 310);
            dataGridView_Massive_SSS.TabIndex = 0;
            // 
            // button_Run_SSS
            // 
            button_Run_SSS.BackColor = Color.FromArgb(192, 255, 192);
            button_Run_SSS.FlatStyle = FlatStyle.Flat;
            button_Run_SSS.Location = new Point(495, 384);
            button_Run_SSS.Name = "button_Run_SSS";
            button_Run_SSS.Size = new Size(169, 55);
            button_Run_SSS.TabIndex = 4;
            button_Run_SSS.Text = "Выполнить";
            button_Run_SSS.UseVisualStyleBackColor = false;
            button_Run_SSS.Click += button_Run_SSS_Click;
            // 
            // button_Info_SSS
            // 
            button_Info_SSS.BackColor = SystemColors.ButtonFace;
            button_Info_SSS.Location = new Point(323, 384);
            button_Info_SSS.Name = "button_Info_SSS";
            button_Info_SSS.Size = new Size(169, 55);
            button_Info_SSS.TabIndex = 5;
            button_Info_SSS.Text = "Справка";
            button_Info_SSS.UseVisualStyleBackColor = false;
            button_Info_SSS.Click += button_Info_SSS_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 450);
            Controls.Add(button_Info_SSS);
            Controls.Add(button_Run_SSS);
            Controls.Add(groupBox_Output_SSS);
            Controls.Add(groupBox_Uslovie_SSS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Спринт 6 | Таск 3 | Вариант 4 | Cизиков С.С.";
            Load += MainForm_Load;
            groupBox_Uslovie_SSS.ResumeLayout(false);
            groupBox_Uslovie_SSS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Uslovie_SSS).EndInit();
            groupBox_Output_SSS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Massive_SSS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Uslovie_SSS;
        private TextBox textBox_Uslovie_SSS;
        private PictureBox pictureBox_Uslovie_SSS;
        private GroupBox groupBox_Output_SSS;
        private Button button_Run_SSS;
        private DataGridView dataGridView_Massive_SSS;
        private Button button_Info_SSS;
    }
}
