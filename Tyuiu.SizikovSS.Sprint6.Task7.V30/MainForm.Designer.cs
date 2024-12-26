namespace Tyuiu.SizikovSS.Sprint6.Task7.V30
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
            dataGridViewIn_SSS = new DataGridView();
            dataGridViewOut_SSS = new DataGridView();
            button_Change_SSS = new Button();
            button_Open_SSS = new Button();
            button_Save_SSS = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SSS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SSS).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewIn_SSS
            // 
            dataGridViewIn_SSS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_SSS.Location = new Point(12, 69);
            dataGridViewIn_SSS.Name = "dataGridViewIn_SSS";
            dataGridViewIn_SSS.RowHeadersWidth = 51;
            dataGridViewIn_SSS.Size = new Size(455, 472);
            dataGridViewIn_SSS.TabIndex = 0;
            // 
            // dataGridViewOut_SSS
            // 
            dataGridViewOut_SSS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_SSS.Location = new Point(495, 69);
            dataGridViewOut_SSS.Name = "dataGridViewOut_SSS";
            dataGridViewOut_SSS.RowHeadersWidth = 51;
            dataGridViewOut_SSS.Size = new Size(455, 472);
            dataGridViewOut_SSS.TabIndex = 1;
            // 
            // button_Change_SSS
            // 
            button_Change_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Change_SSS.Location = new Point(386, 12);
            button_Change_SSS.Name = "button_Change_SSS";
            button_Change_SSS.Size = new Size(193, 51);
            button_Change_SSS.TabIndex = 2;
            button_Change_SSS.Text = "Преобразовать";
            button_Change_SSS.UseVisualStyleBackColor = true;
            button_Change_SSS.Click += ButtonChange_SSS_Click;
            // 
            // button_Open_SSS
            // 
            button_Open_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Open_SSS.Location = new Point(177, 12);
            button_Open_SSS.Name = "button_Open_SSS";
            button_Open_SSS.Size = new Size(193, 51);
            button_Open_SSS.TabIndex = 3;
            button_Open_SSS.Text = "Открыть";
            button_Open_SSS.UseVisualStyleBackColor = true;
            button_Open_SSS.Click += ButtonOpen_SSS_Click;
            // 
            // button_Save_SSS
            // 
            button_Save_SSS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Save_SSS.Location = new Point(595, 12);
            button_Save_SSS.Name = "button_Save_SSS";
            button_Save_SSS.Size = new Size(193, 51);
            button_Save_SSS.TabIndex = 4;
            button_Save_SSS.Text = "Сохранить";
            button_Save_SSS.UseVisualStyleBackColor = true;
            button_Save_SSS.Click += ButtonSave_SSS_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 553);
            Controls.Add(button_Save_SSS);
            Controls.Add(button_Open_SSS);
            Controls.Add(button_Change_SSS);
            Controls.Add(dataGridViewOut_SSS);
            Controls.Add(dataGridViewIn_SSS);
            Name = "MainForm";
            Text = "Спринт 6 | Таск 7 | Вариант 30 | Cизиков С.С.";
            Click += ButtonSave_SSS_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SSS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SSS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewIn_SSS;
        private DataGridView dataGridViewOut_SSS;
        private Button button_Change_SSS;
        private Button button_Open_SSS;
        private Button button_Save_SSS;
    }
}
