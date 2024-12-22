namespace Tyuiu.SizikovSS.Sprint6.Task0.V22
{
    partial class MainForm_SSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_SSS));
            groupBox_Uslovie_SSS = new GroupBox();
            pictureBox_Uslovie_SSS = new PictureBox();
            textBox_Uslovie_SSS = new TextBox();
            groupBox1 = new GroupBox();
            textBox_InputLineX_SSS = new TextBox();
            textBox_InputX_SSS = new TextBox();
            groupBox2 = new GroupBox();
            textBox_OutputLineY_SSS = new TextBox();
            textBox_OutputY_SSS = new TextBox();
            button_Run_SSS = new Button();
            button_Info_SSS = new Button();
            groupBox_Uslovie_SSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Uslovie_SSS).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Uslovie_SSS
            // 
            groupBox_Uslovie_SSS.Controls.Add(pictureBox_Uslovie_SSS);
            groupBox_Uslovie_SSS.Controls.Add(textBox_Uslovie_SSS);
            groupBox_Uslovie_SSS.Location = new Point(12, 12);
            groupBox_Uslovie_SSS.Name = "groupBox_Uslovie_SSS";
            groupBox_Uslovie_SSS.Size = new Size(776, 245);
            groupBox_Uslovie_SSS.TabIndex = 0;
            groupBox_Uslovie_SSS.TabStop = false;
            groupBox_Uslovie_SSS.Text = "Условие";
            // 
            // pictureBox_Uslovie_SSS
            // 
            pictureBox_Uslovie_SSS.Image = (Image)resources.GetObject("pictureBox_Uslovie_SSS.Image");
            pictureBox_Uslovie_SSS.Location = new Point(450, 26);
            pictureBox_Uslovie_SSS.Name = "pictureBox_Uslovie_SSS";
            pictureBox_Uslovie_SSS.Size = new Size(320, 96);
            pictureBox_Uslovie_SSS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Uslovie_SSS.TabIndex = 1;
            pictureBox_Uslovie_SSS.TabStop = false;
            // 
            // textBox_Uslovie_SSS
            // 
            textBox_Uslovie_SSS.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Uslovie_SSS.Location = new Point(3, 23);
            textBox_Uslovie_SSS.Multiline = true;
            textBox_Uslovie_SSS.Name = "textBox_Uslovie_SSS";
            textBox_Uslovie_SSS.ReadOnly = true;
            textBox_Uslovie_SSS.Size = new Size(441, 216);
            textBox_Uslovie_SSS.TabIndex = 0;
            textBox_Uslovie_SSS.Text = "Дано выражение вычислить его значение при x = 2, результат вывести в TextBox. Округлить до трёх знаков после запятой. ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_InputLineX_SSS);
            groupBox1.Controls.Add(textBox_InputX_SSS);
            groupBox1.Location = new Point(15, 263);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // textBox_InputLineX_SSS
            // 
            textBox_InputLineX_SSS.Location = new Point(25, 70);
            textBox_InputLineX_SSS.Name = "textBox_InputLineX_SSS";
            textBox_InputLineX_SSS.Size = new Size(125, 27);
            textBox_InputLineX_SSS.TabIndex = 1;
            // 
            // textBox_InputX_SSS
            // 
            textBox_InputX_SSS.BackColor = SystemColors.Control;
            textBox_InputX_SSS.BorderStyle = BorderStyle.None;
            textBox_InputX_SSS.Location = new Point(25, 44);
            textBox_InputX_SSS.Name = "textBox_InputX_SSS";
            textBox_InputX_SSS.ReadOnly = true;
            textBox_InputX_SSS.Size = new Size(125, 20);
            textBox_InputX_SSS.TabIndex = 0;
            textBox_InputX_SSS.Text = "Переменная X:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_OutputLineY_SSS);
            groupBox2.Controls.Add(textBox_OutputY_SSS);
            groupBox2.Location = new Point(542, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(240, 125);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBox_OutputLineY_SSS
            // 
            textBox_OutputLineY_SSS.BackColor = SystemColors.Window;
            textBox_OutputLineY_SSS.Location = new Point(25, 70);
            textBox_OutputLineY_SSS.Name = "textBox_OutputLineY_SSS";
            textBox_OutputLineY_SSS.ReadOnly = true;
            textBox_OutputLineY_SSS.Size = new Size(125, 27);
            textBox_OutputLineY_SSS.TabIndex = 1;
            // 
            // textBox_OutputY_SSS
            // 
            textBox_OutputY_SSS.BackColor = SystemColors.Control;
            textBox_OutputY_SSS.BorderStyle = BorderStyle.None;
            textBox_OutputY_SSS.Location = new Point(25, 44);
            textBox_OutputY_SSS.Name = "textBox_OutputY_SSS";
            textBox_OutputY_SSS.ReadOnly = true;
            textBox_OutputY_SSS.Size = new Size(125, 20);
            textBox_OutputY_SSS.TabIndex = 0;
            textBox_OutputY_SSS.Text = "Переменная Y:";
            // 
            // button_Run_SSS
            // 
            button_Run_SSS.BackColor = SystemColors.ButtonFace;
            button_Run_SSS.Location = new Point(600, 394);
            button_Run_SSS.Name = "button_Run_SSS";
            button_Run_SSS.Size = new Size(182, 44);
            button_Run_SSS.TabIndex = 3;
            button_Run_SSS.Text = "Выполнить";
            button_Run_SSS.UseVisualStyleBackColor = false;
            button_Run_SSS.Click += button_Run_SSS_Click;
            // 
            // button_Info_SSS
            // 
            button_Info_SSS.BackColor = SystemColors.ButtonFace;
            button_Info_SSS.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Info_SSS.Location = new Point(542, 394);
            button_Info_SSS.Name = "button_Info_SSS";
            button_Info_SSS.Size = new Size(52, 44);
            button_Info_SSS.TabIndex = 0;
            button_Info_SSS.Text = "?";
            button_Info_SSS.UseVisualStyleBackColor = false;
            button_Info_SSS.Click += button_Info_SSS_Click;
            // 
            // MainForm_SSS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Info_SSS);
            Controls.Add(button_Run_SSS);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox_Uslovie_SSS);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm_SSS";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 22 | Cизиков С.С.";
            Load += Form1_Load;
            groupBox_Uslovie_SSS.ResumeLayout(false);
            groupBox_Uslovie_SSS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Uslovie_SSS).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Uslovie_SSS;
        private TextBox textBox_Uslovie_SSS;
        private PictureBox pictureBox_Uslovie_SSS;
        private GroupBox groupBox1;
        private TextBox textBox_InputLineX_SSS;
        private TextBox textBox_InputX_SSS;
        private GroupBox groupBox2;
        private TextBox textBox_OutputLineY_SSS;
        private TextBox textBox_OutputY_SSS;
        private Button button_Run_SSS;
        private Button button_Info_SSS;
    }
}
