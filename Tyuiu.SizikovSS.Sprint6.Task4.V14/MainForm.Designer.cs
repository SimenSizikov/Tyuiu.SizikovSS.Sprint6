namespace Tyuiu.SizikovSS.Sprint6.Task4.V14
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox_Uslovie_SSS = new GroupBox();
            pictureBox_Uslovie_SSS = new PictureBox();
            textBox_Uslovie_SSS = new TextBox();
            GroupBox_Input_SSS = new GroupBox();
            TextBox_StopValue_SSS = new TextBox();
            TextBox_Stop_SSS = new TextBox();
            TextBox_StartValue_SSS = new TextBox();
            TextBox_Start_SSS = new TextBox();
            GroupBox_Output_SSS = new GroupBox();
            textBox_Res_SSS = new TextBox();
            chart_Res_SSS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            TextBox_Result_SSS = new TextBox();
            Button_Run_SSS = new Button();
            Button_Save_SSS = new Button();
            Button_Info_SSS = new Button();
            groupBox_Uslovie_SSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Uslovie_SSS).BeginInit();
            GroupBox_Input_SSS.SuspendLayout();
            GroupBox_Output_SSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_Res_SSS).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Uslovie_SSS
            // 
            groupBox_Uslovie_SSS.Controls.Add(pictureBox_Uslovie_SSS);
            groupBox_Uslovie_SSS.Controls.Add(textBox_Uslovie_SSS);
            groupBox_Uslovie_SSS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox_Uslovie_SSS.Location = new Point(12, 12);
            groupBox_Uslovie_SSS.Name = "groupBox_Uslovie_SSS";
            groupBox_Uslovie_SSS.Size = new Size(546, 433);
            groupBox_Uslovie_SSS.TabIndex = 0;
            groupBox_Uslovie_SSS.TabStop = false;
            groupBox_Uslovie_SSS.Text = "Условие ";
            // 
            // pictureBox_Uslovie_SSS
            // 
            pictureBox_Uslovie_SSS.Image = (Image)resources.GetObject("pictureBox_Uslovie_SSS.Image");
            pictureBox_Uslovie_SSS.Location = new Point(0, 325);
            pictureBox_Uslovie_SSS.Name = "pictureBox_Uslovie_SSS";
            pictureBox_Uslovie_SSS.Size = new Size(465, 62);
            pictureBox_Uslovie_SSS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Uslovie_SSS.TabIndex = 1;
            pictureBox_Uslovie_SSS.TabStop = false;
            // 
            // textBox_Uslovie_SSS
            // 
            textBox_Uslovie_SSS.BackColor = SystemColors.Control;
            textBox_Uslovie_SSS.BorderStyle = BorderStyle.FixedSingle;
            textBox_Uslovie_SSS.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Uslovie_SSS.Location = new Point(6, 26);
            textBox_Uslovie_SSS.Multiline = true;
            textBox_Uslovie_SSS.Name = "textBox_Uslovie_SSS";
            textBox_Uslovie_SSS.Size = new Size(534, 268);
            textBox_Uslovie_SSS.TabIndex = 0;
            textBox_Uslovie_SSS.Text = resources.GetString("textBox_Uslovie_SSS.Text");
            // 
            // GroupBox_Input_SSS
            // 
            GroupBox_Input_SSS.Controls.Add(TextBox_StopValue_SSS);
            GroupBox_Input_SSS.Controls.Add(TextBox_Stop_SSS);
            GroupBox_Input_SSS.Controls.Add(TextBox_StartValue_SSS);
            GroupBox_Input_SSS.Controls.Add(TextBox_Start_SSS);
            GroupBox_Input_SSS.Font = new Font("Segoe UI", 11F);
            GroupBox_Input_SSS.Location = new Point(18, 448);
            GroupBox_Input_SSS.Margin = new Padding(3, 4, 3, 4);
            GroupBox_Input_SSS.Name = "GroupBox_Input_SSS";
            GroupBox_Input_SSS.Padding = new Padding(3, 4, 3, 4);
            GroupBox_Input_SSS.Size = new Size(351, 137);
            GroupBox_Input_SSS.TabIndex = 7;
            GroupBox_Input_SSS.TabStop = false;
            GroupBox_Input_SSS.Text = "Ввод данных";
            // 
            // TextBox_StopValue_SSS
            // 
            TextBox_StopValue_SSS.Location = new Point(194, 82);
            TextBox_StopValue_SSS.Margin = new Padding(3, 4, 3, 4);
            TextBox_StopValue_SSS.Name = "TextBox_StopValue_SSS";
            TextBox_StopValue_SSS.Size = new Size(146, 32);
            TextBox_StopValue_SSS.TabIndex = 7;
            TextBox_StopValue_SSS.TabStop = false;
            // 
            // TextBox_Stop_SSS
            // 
            TextBox_Stop_SSS.BorderStyle = BorderStyle.None;
            TextBox_Stop_SSS.Location = new Point(194, 49);
            TextBox_Stop_SSS.Margin = new Padding(3, 4, 3, 4);
            TextBox_Stop_SSS.Name = "TextBox_Stop_SSS";
            TextBox_Stop_SSS.ReadOnly = true;
            TextBox_Stop_SSS.Size = new Size(114, 25);
            TextBox_Stop_SSS.TabIndex = 6;
            TextBox_Stop_SSS.TabStop = false;
            TextBox_Stop_SSS.Text = "Конец шага:";
            // 
            // TextBox_StartValue_SSS
            // 
            TextBox_StartValue_SSS.Location = new Point(17, 84);
            TextBox_StartValue_SSS.Margin = new Padding(3, 4, 3, 4);
            TextBox_StartValue_SSS.Name = "TextBox_StartValue_SSS";
            TextBox_StartValue_SSS.Size = new Size(145, 32);
            TextBox_StartValue_SSS.TabIndex = 5;
            TextBox_StartValue_SSS.TabStop = false;
            // 
            // TextBox_Start_SSS
            // 
            TextBox_Start_SSS.BorderStyle = BorderStyle.None;
            TextBox_Start_SSS.Location = new Point(17, 49);
            TextBox_Start_SSS.Margin = new Padding(3, 4, 3, 4);
            TextBox_Start_SSS.Name = "TextBox_Start_SSS";
            TextBox_Start_SSS.ReadOnly = true;
            TextBox_Start_SSS.Size = new Size(114, 25);
            TextBox_Start_SSS.TabIndex = 4;
            TextBox_Start_SSS.TabStop = false;
            TextBox_Start_SSS.Text = "Старт шага:";
            // 
            // GroupBox_Output_SSS
            // 
            GroupBox_Output_SSS.Controls.Add(textBox_Res_SSS);
            GroupBox_Output_SSS.Controls.Add(chart_Res_SSS);
            GroupBox_Output_SSS.Controls.Add(TextBox_Result_SSS);
            GroupBox_Output_SSS.Font = new Font("Segoe UI", 11F);
            GroupBox_Output_SSS.Location = new Point(564, 38);
            GroupBox_Output_SSS.Margin = new Padding(3, 4, 3, 4);
            GroupBox_Output_SSS.Name = "GroupBox_Output_SSS";
            GroupBox_Output_SSS.Padding = new Padding(3, 4, 3, 4);
            GroupBox_Output_SSS.Size = new Size(697, 547);
            GroupBox_Output_SSS.TabIndex = 8;
            GroupBox_Output_SSS.TabStop = false;
            GroupBox_Output_SSS.Text = "Вывод данных";
            // 
            // textBox_Res_SSS
            // 
            textBox_Res_SSS.BackColor = SystemColors.ControlLight;
            textBox_Res_SSS.BorderStyle = BorderStyle.FixedSingle;
            textBox_Res_SSS.Location = new Point(6, 81);
            textBox_Res_SSS.Multiline = true;
            textBox_Res_SSS.Name = "textBox_Res_SSS";
            textBox_Res_SSS.Size = new Size(202, 459);
            textBox_Res_SSS.TabIndex = 8;
            // 
            // chart_Res_SSS
            // 
            chartArea1.Name = "ChartArea1";
            chart_Res_SSS.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chart_Res_SSS.Legends.Add(legend1);
            chart_Res_SSS.Location = new Point(214, 32);
            chart_Res_SSS.Name = "chart_Res_SSS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_Res_SSS.Series.Add(series1);
            chart_Res_SSS.Size = new Size(477, 508);
            chart_Res_SSS.TabIndex = 7;
            chart_Res_SSS.Text = "chart1";
            // 
            // TextBox_Result_SSS
            // 
            TextBox_Result_SSS.BorderStyle = BorderStyle.None;
            TextBox_Result_SSS.Location = new Point(7, 35);
            TextBox_Result_SSS.Margin = new Padding(3, 4, 3, 4);
            TextBox_Result_SSS.Name = "TextBox_Result_SSS";
            TextBox_Result_SSS.ReadOnly = true;
            TextBox_Result_SSS.Size = new Size(89, 25);
            TextBox_Result_SSS.TabIndex = 5;
            TextBox_Result_SSS.TabStop = false;
            TextBox_Result_SSS.Text = "Результат:";
            // 
            // Button_Run_SSS
            // 
            Button_Run_SSS.BackColor = Color.FromArgb(192, 255, 192);
            Button_Run_SSS.Font = new Font("Segoe UI", 11F);
            Button_Run_SSS.Location = new Point(375, 461);
            Button_Run_SSS.Margin = new Padding(3, 4, 3, 4);
            Button_Run_SSS.Name = "Button_Run_SSS";
            Button_Run_SSS.Size = new Size(183, 36);
            Button_Run_SSS.TabIndex = 9;
            Button_Run_SSS.TabStop = false;
            Button_Run_SSS.Text = "Выполнить";
            Button_Run_SSS.UseVisualStyleBackColor = false;
            Button_Run_SSS.Click += Button_Run_SSS_Click;
            // 
            // Button_Save_SSS
            // 
            Button_Save_SSS.BackColor = SystemColors.ActiveCaption;
            Button_Save_SSS.Font = new Font("Segoe UI", 11F);
            Button_Save_SSS.Location = new Point(375, 505);
            Button_Save_SSS.Margin = new Padding(3, 4, 3, 4);
            Button_Save_SSS.Name = "Button_Save_SSS";
            Button_Save_SSS.Size = new Size(183, 36);
            Button_Save_SSS.TabIndex = 11;
            Button_Save_SSS.TabStop = false;
            Button_Save_SSS.Text = "Сохранить";
            Button_Save_SSS.UseVisualStyleBackColor = false;
            Button_Save_SSS.Click += Button_Save_SSS_Click;
            // 
            // Button_Info_SSS
            // 
            Button_Info_SSS.BackColor = SystemColors.Info;
            Button_Info_SSS.Font = new Font("Segoe UI", 11F);
            Button_Info_SSS.Location = new Point(375, 549);
            Button_Info_SSS.Margin = new Padding(3, 4, 3, 4);
            Button_Info_SSS.Name = "Button_Info_SSS";
            Button_Info_SSS.Size = new Size(183, 36);
            Button_Info_SSS.TabIndex = 12;
            Button_Info_SSS.TabStop = false;
            Button_Info_SSS.Text = "Справка";
            Button_Info_SSS.UseVisualStyleBackColor = false;
            Button_Info_SSS.Click += Button_Info_SSS_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 593);
            Controls.Add(Button_Info_SSS);
            Controls.Add(Button_Save_SSS);
            Controls.Add(Button_Run_SSS);
            Controls.Add(GroupBox_Output_SSS);
            Controls.Add(GroupBox_Input_SSS);
            Controls.Add(groupBox_Uslovie_SSS);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 14 | Cизиков С.С.";
            groupBox_Uslovie_SSS.ResumeLayout(false);
            groupBox_Uslovie_SSS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Uslovie_SSS).EndInit();
            GroupBox_Input_SSS.ResumeLayout(false);
            GroupBox_Input_SSS.PerformLayout();
            GroupBox_Output_SSS.ResumeLayout(false);
            GroupBox_Output_SSS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_Res_SSS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Uslovie_SSS;
        private TextBox textBox_Uslovie_SSS;
        private PictureBox pictureBox_Uslovie_SSS;
        private GroupBox GroupBox_Input_SSS;
        private TextBox TextBox_StopValue_SSS;
        private TextBox TextBox_Stop_SSS;
        private TextBox TextBox_StartValue_SSS;
        private TextBox TextBox_Start_SSS;
        private GroupBox GroupBox_Output_SSS;
        private TextBox TextBox_Result_SSS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Res_SSS;
        private Button Button_Run_SSS;
        private Button Button_Save_SSS;
        private Button Button_Info_SSS;
        private TextBox textBox_Res_SSS;
    }
}
