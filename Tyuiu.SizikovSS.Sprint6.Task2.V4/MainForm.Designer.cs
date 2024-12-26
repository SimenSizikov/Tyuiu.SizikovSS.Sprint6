namespace Tyuiu.SizikovSS.Sprint6.Task2.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox_Uslovie_SSS = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            groupBox_Output_SSS = new GroupBox();
            Chart_Output_SSS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            DataGridView_Output_SSS = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            textBox_Result_SSS = new TextBox();
            groupBox_Input_SSS = new GroupBox();
            textBox_StopValueLine_SSS = new TextBox();
            textBox_StopValue_SSS = new TextBox();
            textBox_StartValueLine_SSS = new TextBox();
            textBox_StartValue_SSS = new TextBox();
            button_ = new Button();
            button_Run_SSS = new Button();
            groupBox_Uslovie_SSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox_Output_SSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Chart_Output_SSS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Output_SSS).BeginInit();
            groupBox_Input_SSS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Uslovie_SSS
            // 
            groupBox_Uslovie_SSS.Controls.Add(pictureBox1);
            groupBox_Uslovie_SSS.Controls.Add(textBox1);
            groupBox_Uslovie_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox_Uslovie_SSS.Location = new Point(12, 12);
            groupBox_Uslovie_SSS.Name = "groupBox_Uslovie_SSS";
            groupBox_Uslovie_SSS.Size = new Size(507, 498);
            groupBox_Uslovie_SSS.TabIndex = 0;
            groupBox_Uslovie_SSS.TabStop = false;
            groupBox_Uslovie_SSS.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 414);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(3, 30);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(500, 378);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox_Output_SSS
            // 
            groupBox_Output_SSS.Controls.Add(Chart_Output_SSS);
            groupBox_Output_SSS.Controls.Add(DataGridView_Output_SSS);
            groupBox_Output_SSS.Controls.Add(textBox_Result_SSS);
            groupBox_Output_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox_Output_SSS.Location = new Point(525, 26);
            groupBox_Output_SSS.Name = "groupBox_Output_SSS";
            groupBox_Output_SSS.Size = new Size(725, 635);
            groupBox_Output_SSS.TabIndex = 2;
            groupBox_Output_SSS.TabStop = false;
            groupBox_Output_SSS.Text = "Вывод данных";
            // 
            // Chart_Output_SSS
            // 
            chartArea1.Name = "ChartArea1";
            Chart_Output_SSS.ChartAreas.Add(chartArea1);
            Chart_Output_SSS.Location = new Point(229, 85);
            Chart_Output_SSS.Margin = new Padding(3, 4, 3, 4);
            Chart_Output_SSS.Name = "Chart_Output_SSS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            Chart_Output_SSS.Series.Add(series1);
            Chart_Output_SSS.Size = new Size(490, 543);
            Chart_Output_SSS.TabIndex = 7;
            Chart_Output_SSS.Text = "График функции";
            // 
            // DataGridView_Output_SSS
            // 
            DataGridView_Output_SSS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Output_SSS.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            DataGridView_Output_SSS.Location = new Point(16, 85);
            DataGridView_Output_SSS.Margin = new Padding(3, 4, 3, 4);
            DataGridView_Output_SSS.Name = "DataGridView_Output_SSS";
            DataGridView_Output_SSS.ReadOnly = true;
            DataGridView_Output_SSS.RowHeadersVisible = false;
            DataGridView_Output_SSS.RowHeadersWidth = 51;
            DataGridView_Output_SSS.ScrollBars = ScrollBars.Vertical;
            DataGridView_Output_SSS.Size = new Size(207, 543);
            DataGridView_Output_SSS.TabIndex = 2;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 90;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 90;
            // 
            // textBox_Result_SSS
            // 
            textBox_Result_SSS.BackColor = SystemColors.Control;
            textBox_Result_SSS.BorderStyle = BorderStyle.None;
            textBox_Result_SSS.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Result_SSS.Location = new Point(16, 47);
            textBox_Result_SSS.Name = "textBox_Result_SSS";
            textBox_Result_SSS.ReadOnly = true;
            textBox_Result_SSS.Size = new Size(125, 31);
            textBox_Result_SSS.TabIndex = 1;
            textBox_Result_SSS.Text = "Результат";
            // 
            // groupBox_Input_SSS
            // 
            groupBox_Input_SSS.BackColor = SystemColors.Control;
            groupBox_Input_SSS.Controls.Add(textBox_StopValueLine_SSS);
            groupBox_Input_SSS.Controls.Add(textBox_StopValue_SSS);
            groupBox_Input_SSS.Controls.Add(textBox_StartValueLine_SSS);
            groupBox_Input_SSS.Controls.Add(textBox_StartValue_SSS);
            groupBox_Input_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox_Input_SSS.Location = new Point(15, 516);
            groupBox_Input_SSS.Name = "groupBox_Input_SSS";
            groupBox_Input_SSS.Size = new Size(302, 145);
            groupBox_Input_SSS.TabIndex = 3;
            groupBox_Input_SSS.TabStop = false;
            groupBox_Input_SSS.Text = "Ввод данных";
            // 
            // textBox_StopValueLine_SSS
            // 
            textBox_StopValueLine_SSS.Location = new Point(155, 87);
            textBox_StopValueLine_SSS.Name = "textBox_StopValueLine_SSS";
            textBox_StopValueLine_SSS.Size = new Size(125, 34);
            textBox_StopValueLine_SSS.TabIndex = 3;
            // 
            // textBox_StopValue_SSS
            // 
            textBox_StopValue_SSS.BackColor = SystemColors.Control;
            textBox_StopValue_SSS.BorderStyle = BorderStyle.None;
            textBox_StopValue_SSS.Location = new Point(155, 54);
            textBox_StopValue_SSS.Name = "textBox_StopValue_SSS";
            textBox_StopValue_SSS.ReadOnly = true;
            textBox_StopValue_SSS.Size = new Size(125, 27);
            textBox_StopValue_SSS.TabIndex = 2;
            textBox_StopValue_SSS.Text = "Старт шага:";
            // 
            // textBox_StartValueLine_SSS
            // 
            textBox_StartValueLine_SSS.Location = new Point(1, 87);
            textBox_StartValueLine_SSS.Name = "textBox_StartValueLine_SSS";
            textBox_StartValueLine_SSS.Size = new Size(125, 34);
            textBox_StartValueLine_SSS.TabIndex = 1;
            // 
            // textBox_StartValue_SSS
            // 
            textBox_StartValue_SSS.BackColor = SystemColors.Control;
            textBox_StartValue_SSS.BorderStyle = BorderStyle.None;
            textBox_StartValue_SSS.Location = new Point(6, 54);
            textBox_StartValue_SSS.Name = "textBox_StartValue_SSS";
            textBox_StartValue_SSS.ReadOnly = true;
            textBox_StartValue_SSS.Size = new Size(125, 27);
            textBox_StartValue_SSS.TabIndex = 0;
            textBox_StartValue_SSS.Text = "Старт шага:";
            // 
            // button_
            // 
            button_.BackColor = SystemColors.Info;
            button_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_.Location = new Point(323, 615);
            button_.Name = "button_";
            button_.Size = new Size(196, 46);
            button_.TabIndex = 4;
            button_.Text = "Инфо";
            button_.UseVisualStyleBackColor = false;
            button_.Click += button__Click;
            // 
            // button_Run_SSS
            // 
            button_Run_SSS.BackColor = Color.FromArgb(192, 255, 192);
            button_Run_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Run_SSS.Location = new Point(323, 529);
            button_Run_SSS.Name = "button_Run_SSS";
            button_Run_SSS.Size = new Size(196, 80);
            button_Run_SSS.TabIndex = 5;
            button_Run_SSS.Text = "Выполнить";
            button_Run_SSS.UseVisualStyleBackColor = false;
            button_Run_SSS.Click += button_Run_SSS_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(button_Run_SSS);
            Controls.Add(button_);
            Controls.Add(groupBox_Input_SSS);
            Controls.Add(groupBox_Output_SSS);
            Controls.Add(groupBox_Uslovie_SSS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 4 | Cизиков С.С.";
            Load += MainForm_Load;
            groupBox_Uslovie_SSS.ResumeLayout(false);
            groupBox_Uslovie_SSS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox_Output_SSS.ResumeLayout(false);
            groupBox_Output_SSS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Chart_Output_SSS).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Output_SSS).EndInit();
            groupBox_Input_SSS.ResumeLayout(false);
            groupBox_Input_SSS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Uslovie_SSS;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private GroupBox groupBox_Output_SSS;
        private TextBox textBox_Result_SSS;
        private DataGridView DataGridView_Output_SSS;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Output_SSS;
        private GroupBox groupBox_Input_SSS;
        private TextBox textBox_StopValueLine_SSS;
        private TextBox textBox_StopValue_SSS;
        private TextBox textBox_StartValueLine_SSS;
        private TextBox textBox_StartValue_SSS;
        private Button button_;
        private Button button_Run_SSS;
    }
}
