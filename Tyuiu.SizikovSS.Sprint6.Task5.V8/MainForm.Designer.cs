namespace Tyuiu.SizikovSS.Sprint6.Task5.V8
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox_Uslovie = new GroupBox();
            textBox_Uslovie_SSS = new TextBox();
            groupBox_Output_SSS = new GroupBox();
            chart_Res_SSS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView_Mass_SSS = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            button_Open_SSS = new Button();
            button_Info_SSS = new Button();
            Button_Run_SSS = new Button();
            groupBox_Uslovie.SuspendLayout();
            groupBox_Output_SSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_Res_SSS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Mass_SSS).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Uslovie
            // 
            groupBox_Uslovie.Controls.Add(textBox_Uslovie_SSS);
            groupBox_Uslovie.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox_Uslovie.Location = new Point(12, 12);
            groupBox_Uslovie.Name = "groupBox_Uslovie";
            groupBox_Uslovie.Size = new Size(812, 141);
            groupBox_Uslovie.TabIndex = 0;
            groupBox_Uslovie.TabStop = false;
            groupBox_Uslovie.Text = "Условие";
            // 
            // textBox_Uslovie_SSS
            // 
            textBox_Uslovie_SSS.BackColor = SystemColors.ControlLight;
            textBox_Uslovie_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Uslovie_SSS.Location = new Point(0, 30);
            textBox_Uslovie_SSS.Multiline = true;
            textBox_Uslovie_SSS.Name = "textBox_Uslovie_SSS";
            textBox_Uslovie_SSS.Size = new Size(806, 99);
            textBox_Uslovie_SSS.TabIndex = 0;
            textBox_Uslovie_SSS.Text = resources.GetString("textBox_Uslovie_SSS.Text");
            // 
            // groupBox_Output_SSS
            // 
            groupBox_Output_SSS.Controls.Add(chart_Res_SSS);
            groupBox_Output_SSS.Controls.Add(dataGridView_Mass_SSS);
            groupBox_Output_SSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox_Output_SSS.Location = new Point(12, 159);
            groupBox_Output_SSS.Name = "groupBox_Output_SSS";
            groupBox_Output_SSS.Size = new Size(812, 549);
            groupBox_Output_SSS.TabIndex = 1;
            groupBox_Output_SSS.TabStop = false;
            groupBox_Output_SSS.Text = "Вывод данных";
            // 
            // chart_Res_SSS
            // 
            chart_Res_SSS.BackColor = Color.Gainsboro;
            chartArea1.Name = "ChartArea1";
            chart_Res_SSS.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chart_Res_SSS.Legends.Add(legend1);
            chart_Res_SSS.Location = new Point(167, 32);
            chart_Res_SSS.Name = "chart_Res_SSS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_Res_SSS.Series.Add(series1);
            chart_Res_SSS.Size = new Size(635, 506);
            chart_Res_SSS.TabIndex = 2;
            chart_Res_SSS.Text = "chart1";
            // 
            // dataGridView_Mass_SSS
            // 
            dataGridView_Mass_SSS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Mass_SSS.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridView_Mass_SSS.Location = new Point(6, 31);
            dataGridView_Mass_SSS.Margin = new Padding(3, 4, 3, 4);
            dataGridView_Mass_SSS.Name = "dataGridView_Mass_SSS";
            dataGridView_Mass_SSS.ReadOnly = true;
            dataGridView_Mass_SSS.RowHeadersVisible = false;
            dataGridView_Mass_SSS.RowHeadersWidth = 51;
            dataGridView_Mass_SSS.Size = new Size(144, 511);
            dataGridView_Mass_SSS.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 70;
            // 
            // button_Open_SSS
            // 
            button_Open_SSS.BackColor = SystemColors.GradientInactiveCaption;
            button_Open_SSS.Font = new Font("Segoe UI", 11F);
            button_Open_SSS.Location = new Point(830, 191);
            button_Open_SSS.Margin = new Padding(3, 4, 3, 4);
            button_Open_SSS.Name = "button_Open_SSS";
            button_Open_SSS.Size = new Size(142, 89);
            button_Open_SSS.TabIndex = 12;
            button_Open_SSS.TabStop = false;
            button_Open_SSS.Text = "Открыть";
            button_Open_SSS.UseVisualStyleBackColor = false;
            button_Open_SSS.Click += button_Open_SSS_Click;
            // 
            // button_Info_SSS
            // 
            button_Info_SSS.BackColor = SystemColors.Info;
            button_Info_SSS.Font = new Font("Segoe UI", 11F);
            button_Info_SSS.Location = new Point(830, 300);
            button_Info_SSS.Margin = new Padding(3, 4, 3, 4);
            button_Info_SSS.Name = "button_Info_SSS";
            button_Info_SSS.Size = new Size(142, 87);
            button_Info_SSS.TabIndex = 13;
            button_Info_SSS.TabStop = false;
            button_Info_SSS.Text = "Справка";
            button_Info_SSS.UseVisualStyleBackColor = false;
            button_Info_SSS.Click += button_Info_SSS_Click;
            // 
            // Button_Run_SSS
            // 
            Button_Run_SSS.BackColor = Color.FromArgb(192, 255, 192);
            Button_Run_SSS.Font = new Font("Segoe UI", 11F);
            Button_Run_SSS.Location = new Point(830, 405);
            Button_Run_SSS.Margin = new Padding(3, 4, 3, 4);
            Button_Run_SSS.Name = "Button_Run_SSS";
            Button_Run_SSS.Size = new Size(142, 87);
            Button_Run_SSS.TabIndex = 14;
            Button_Run_SSS.TabStop = false;
            Button_Run_SSS.Text = "Выполнить";
            Button_Run_SSS.UseVisualStyleBackColor = false;
            Button_Run_SSS.Click += Button_Run_SSS_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 720);
            Controls.Add(Button_Run_SSS);
            Controls.Add(button_Info_SSS);
            Controls.Add(button_Open_SSS);
            Controls.Add(groupBox_Output_SSS);
            Controls.Add(groupBox_Uslovie);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Спринт 6 | Таск 5 | Вариант 8 | Cизиков С.С.";
            groupBox_Uslovie.ResumeLayout(false);
            groupBox_Uslovie.PerformLayout();
            groupBox_Output_SSS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_Res_SSS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Mass_SSS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Uslovie;
        private TextBox textBox_Uslovie_SSS;
        private GroupBox groupBox_Output_SSS;
        private DataGridView dataGridView_Mass_SSS;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Res_SSS;
        private Button button_Open_SSS;
        private Button button_Info_SSS;
        private Button Button_Run_SSS;
    }
}
