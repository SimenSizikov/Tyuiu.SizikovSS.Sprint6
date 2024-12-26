namespace Tyuiu.SizikovSS.Sprint6.Task1.V24
{
    partial class FormMain_SSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SSS));
            groupBox_Uslovie_SSS = new GroupBox();
            pictureBox_Uslovie_SSS = new PictureBox();
            textBox_Uslovie_SSS = new TextBox();
            groupBox_InputData_SSS = new GroupBox();
            textBox_InputLineStopValue_SSS = new TextBox();
            textBox_InputStopValue_SSS = new TextBox();
            textBox_InputLineStartValue_SSS = new TextBox();
            textBox_InputStartValue_SSS = new TextBox();
            groupBox_OutputData_SSS = new GroupBox();
            textBox_OutputBox_SSS = new TextBox();
            textBox_Result_SSS = new TextBox();
            button_Run_SSS = new Button();
            button_Info_SSS = new Button();
            groupBox_Uslovie_SSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Uslovie_SSS).BeginInit();
            groupBox_InputData_SSS.SuspendLayout();
            groupBox_OutputData_SSS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Uslovie_SSS
            // 
            groupBox_Uslovie_SSS.Controls.Add(pictureBox_Uslovie_SSS);
            groupBox_Uslovie_SSS.Controls.Add(textBox_Uslovie_SSS);
            groupBox_Uslovie_SSS.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox_Uslovie_SSS.Location = new Point(12, 12);
            groupBox_Uslovie_SSS.Name = "groupBox_Uslovie_SSS";
            groupBox_Uslovie_SSS.Size = new Size(559, 286);
            groupBox_Uslovie_SSS.TabIndex = 0;
            groupBox_Uslovie_SSS.TabStop = false;
            groupBox_Uslovie_SSS.Text = "Условие";
            // 
            // pictureBox_Uslovie_SSS
            // 
            pictureBox_Uslovie_SSS.Image = (Image)resources.GetObject("pictureBox_Uslovie_SSS.Image");
            pictureBox_Uslovie_SSS.Location = new Point(6, 185);
            pictureBox_Uslovie_SSS.Name = "pictureBox_Uslovie_SSS";
            pictureBox_Uslovie_SSS.Size = new Size(521, 95);
            pictureBox_Uslovie_SSS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Uslovie_SSS.TabIndex = 1;
            pictureBox_Uslovie_SSS.TabStop = false;
            // 
            // textBox_Uslovie_SSS
            // 
            textBox_Uslovie_SSS.BackColor = SystemColors.Control;
            textBox_Uslovie_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Uslovie_SSS.Location = new Point(6, 29);
            textBox_Uslovie_SSS.Multiline = true;
            textBox_Uslovie_SSS.Name = "textBox_Uslovie_SSS";
            textBox_Uslovie_SSS.ReadOnly = true;
            textBox_Uslovie_SSS.Size = new Size(521, 150);
            textBox_Uslovie_SSS.TabIndex = 0;
            textBox_Uslovie_SSS.Text = resources.GetString("textBox_Uslovie_SSS.Text");
            textBox_Uslovie_SSS.TextChanged += textBox1_TextChanged;
            // 
            // groupBox_InputData_SSS
            // 
            groupBox_InputData_SSS.Controls.Add(textBox_InputLineStopValue_SSS);
            groupBox_InputData_SSS.Controls.Add(textBox_InputStopValue_SSS);
            groupBox_InputData_SSS.Controls.Add(textBox_InputLineStartValue_SSS);
            groupBox_InputData_SSS.Controls.Add(textBox_InputStartValue_SSS);
            groupBox_InputData_SSS.Location = new Point(18, 304);
            groupBox_InputData_SSS.Name = "groupBox_InputData_SSS";
            groupBox_InputData_SSS.Size = new Size(378, 125);
            groupBox_InputData_SSS.TabIndex = 1;
            groupBox_InputData_SSS.TabStop = false;
            groupBox_InputData_SSS.Text = "Ввод данных";
            // 
            // textBox_InputLineStopValue_SSS
            // 
            textBox_InputLineStopValue_SSS.Location = new Point(181, 73);
            textBox_InputLineStopValue_SSS.Name = "textBox_InputLineStopValue_SSS";
            textBox_InputLineStopValue_SSS.Size = new Size(125, 27);
            textBox_InputLineStopValue_SSS.TabIndex = 3;
            // 
            // textBox_InputStopValue_SSS
            // 
            textBox_InputStopValue_SSS.BackColor = SystemColors.Control;
            textBox_InputStopValue_SSS.BorderStyle = BorderStyle.None;
            textBox_InputStopValue_SSS.Location = new Point(181, 40);
            textBox_InputStopValue_SSS.Name = "textBox_InputStopValue_SSS";
            textBox_InputStopValue_SSS.ReadOnly = true;
            textBox_InputStopValue_SSS.Size = new Size(125, 20);
            textBox_InputStopValue_SSS.TabIndex = 2;
            textBox_InputStopValue_SSS.Text = "Конец шага:";
            // 
            // textBox_InputLineStartValue_SSS
            // 
            textBox_InputLineStartValue_SSS.Location = new Point(20, 73);
            textBox_InputLineStartValue_SSS.Name = "textBox_InputLineStartValue_SSS";
            textBox_InputLineStartValue_SSS.Size = new Size(125, 27);
            textBox_InputLineStartValue_SSS.TabIndex = 1;
            // 
            // textBox_InputStartValue_SSS
            // 
            textBox_InputStartValue_SSS.BorderStyle = BorderStyle.None;
            textBox_InputStartValue_SSS.Location = new Point(20, 40);
            textBox_InputStartValue_SSS.Name = "textBox_InputStartValue_SSS";
            textBox_InputStartValue_SSS.ReadOnly = true;
            textBox_InputStartValue_SSS.Size = new Size(125, 20);
            textBox_InputStartValue_SSS.TabIndex = 0;
            textBox_InputStartValue_SSS.Text = "Старт шага:";
            // 
            // groupBox_OutputData_SSS
            // 
            groupBox_OutputData_SSS.Controls.Add(textBox_OutputBox_SSS);
            groupBox_OutputData_SSS.Controls.Add(textBox_Result_SSS);
            groupBox_OutputData_SSS.Location = new Point(577, 12);
            groupBox_OutputData_SSS.Name = "groupBox_OutputData_SSS";
            groupBox_OutputData_SSS.Size = new Size(290, 417);
            groupBox_OutputData_SSS.TabIndex = 2;
            groupBox_OutputData_SSS.TabStop = false;
            groupBox_OutputData_SSS.Text = "Вывод данных";
            // 
            // textBox_OutputBox_SSS
            // 
            textBox_OutputBox_SSS.BackColor = SystemColors.HighlightText;
            textBox_OutputBox_SSS.Location = new Point(6, 65);
            textBox_OutputBox_SSS.Multiline = true;
            textBox_OutputBox_SSS.Name = "textBox_OutputBox_SSS";
            textBox_OutputBox_SSS.ScrollBars = ScrollBars.Vertical;
            textBox_OutputBox_SSS.Size = new Size(278, 346);
            textBox_OutputBox_SSS.TabIndex = 1;
            // 
            // textBox_Result_SSS
            // 
            textBox_Result_SSS.BorderStyle = BorderStyle.None;
            textBox_Result_SSS.Location = new Point(6, 39);
            textBox_Result_SSS.Name = "textBox_Result_SSS";
            textBox_Result_SSS.ReadOnly = true;
            textBox_Result_SSS.Size = new Size(125, 20);
            textBox_Result_SSS.TabIndex = 0;
            textBox_Result_SSS.Text = "Результутат:";
            // 
            // button_Run_SSS
            // 
            button_Run_SSS.BackColor = Color.FromArgb(192, 255, 192);
            button_Run_SSS.FlatStyle = FlatStyle.Flat;
            button_Run_SSS.Location = new Point(408, 313);
            button_Run_SSS.Name = "button_Run_SSS";
            button_Run_SSS.Size = new Size(169, 55);
            button_Run_SSS.TabIndex = 3;
            button_Run_SSS.Text = "Выполнить";
            button_Run_SSS.UseVisualStyleBackColor = false;
            button_Run_SSS.Click += button_Run_SSS_Click;
            // 
            // button_Info_SSS
            // 
            button_Info_SSS.BackColor = SystemColors.ButtonFace;
            button_Info_SSS.Location = new Point(408, 374);
            button_Info_SSS.Name = "button_Info_SSS";
            button_Info_SSS.Size = new Size(169, 55);
            button_Info_SSS.TabIndex = 4;
            button_Info_SSS.Text = "Справка";
            button_Info_SSS.UseVisualStyleBackColor = false;
            button_Info_SSS.Click += button_Info_SSS_Click;
            // 
            // FormMain_SSS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 450);
            Controls.Add(button_Run_SSS);
            Controls.Add(groupBox_OutputData_SSS);
            Controls.Add(button_Info_SSS);
            Controls.Add(groupBox_InputData_SSS);
            Controls.Add(groupBox_Uslovie_SSS);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain_SSS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 24 | Cизиков С.С.";
            Load += FormMain_Load;
            groupBox_Uslovie_SSS.ResumeLayout(false);
            groupBox_Uslovie_SSS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Uslovie_SSS).EndInit();
            groupBox_InputData_SSS.ResumeLayout(false);
            groupBox_InputData_SSS.PerformLayout();
            groupBox_OutputData_SSS.ResumeLayout(false);
            groupBox_OutputData_SSS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox_Uslovie_SSS;
        private TextBox textBox_Uslovie_SSS;
        private PictureBox pictureBox_Uslovie_SSS;
        private GroupBox groupBox_InputData_SSS;
        private TextBox textBox_InputLineStopValue_SSS;
        private TextBox textBox_InputStopValue_SSS;
        private TextBox textBox_InputLineStartValue_SSS;
        private TextBox textBox_InputStartValue_SSS;
        private GroupBox groupBox_OutputData_SSS;
        private TextBox textBox_OutputBox_SSS;
        private TextBox textBox_Result_SSS;
        private Button button_Run_SSS;
        private Button button_Info_SSS;
    }
}
