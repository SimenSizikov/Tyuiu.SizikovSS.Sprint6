namespace Tyuiu.SizikovSS.Sprint6.Task6.V26
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
            textBoxIn = new TextBox();
            textBoxOut = new TextBox();
            button_Open_SSS = new Button();
            button_Conver = new Button();
            openFileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // textBoxIn
            // 
            textBoxIn.BackColor = SystemColors.ControlLight;
            textBoxIn.Location = new Point(12, 99);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ScrollBars = ScrollBars.Vertical;
            textBoxIn.Size = new Size(385, 339);
            textBoxIn.TabIndex = 0;
            // 
            // textBoxOut
            // 
            textBoxOut.BackColor = SystemColors.ControlLight;
            textBoxOut.Location = new Point(419, 99);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ScrollBars = ScrollBars.Vertical;
            textBoxOut.Size = new Size(377, 339);
            textBoxOut.TabIndex = 1;
            // 
            // button_Open_SSS
            // 
            button_Open_SSS.BackColor = SystemColors.ControlDark;
            button_Open_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Open_SSS.Location = new Point(209, 15);
            button_Open_SSS.Name = "button_Open_SSS";
            button_Open_SSS.Size = new Size(188, 68);
            button_Open_SSS.TabIndex = 2;
            button_Open_SSS.Text = "Открыть";
            button_Open_SSS.UseVisualStyleBackColor = false;
            button_Open_SSS.Click += button_Open_SSS_Click;
            // 
            // button_Conver
            // 
            button_Conver.BackColor = SystemColors.ControlDark;
            button_Conver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Conver.Location = new Point(419, 12);
            button_Conver.Name = "button_Conver";
            button_Conver.Size = new Size(188, 71);
            button_Conver.TabIndex = 3;
            button_Conver.Text = "Преобразовать\r\n";
            button_Conver.UseVisualStyleBackColor = false;
            button_Conver.Click += button_Conver_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.FileOk += openFileDialog_FileOk;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Conver);
            Controls.Add(button_Open_SSS);
            Controls.Add(textBoxOut);
            Controls.Add(textBoxIn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Спринт 6 | Таск 6 | Вариант 26 | Cизиков С.С.";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIn;
        private TextBox textBoxOut;
        private Button button_Open_SSS;
        private Button button_Conver;
        private OpenFileDialog openFileDialog;
    }
}
