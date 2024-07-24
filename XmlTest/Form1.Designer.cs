namespace XmlTest
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
            comboBoxMonth = new ComboBox();
            comboBoxYear = new ComboBox();
            comboBoxDayInMonth = new ComboBox();
            comboBoxDay = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonSowDay = new Button();
            textBoxResult = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "תשרי ", "חשוון", "כסליו", "טבת", "שבט", "אדר", "ניסן", "אייר", "סיוון", "תמוז", "אב", "אלול" });
            comboBoxMonth.Location = new Point(246, 97);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(151, 28);
            comboBoxMonth.TabIndex = 0;
            // 
            // comboBoxYear
            // 
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Items.AddRange(new object[] { "תש\"עט", "תש\"פ", "תשפ\"א", "תשפ\"ב", "תשפ\"ג", "תשפ\"ד", "תשפ\"ה" });
            comboBoxYear.Location = new Point(80, 97);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(151, 28);
            comboBoxYear.TabIndex = 1;
            // 
            // comboBoxDayInMonth
            // 
            comboBoxDayInMonth.FormattingEnabled = true;
            comboBoxDayInMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            comboBoxDayInMonth.Location = new Point(403, 97);
            comboBoxDayInMonth.Name = "comboBoxDayInMonth";
            comboBoxDayInMonth.Size = new Size(151, 28);
            comboBoxDayInMonth.TabIndex = 2;
            // 
            // comboBoxDay
            // 
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי", "שבת" });
            comboBoxDay.Location = new Point(574, 97);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(151, 28);
            comboBoxDay.TabIndex = 3;
            comboBoxDay.SelectedIndexChanged += comboBoxDay_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(610, 58);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 4;
            label1.Text = "יום בשבוע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 54);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "יום בחודש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 54);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 6;
            label3.Text = "חודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 54);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 7;
            label4.Text = "שנה";
            // 
            // buttonSowDay
            // 
            buttonSowDay.Location = new Point(373, 233);
            buttonSowDay.Name = "buttonSowDay";
            buttonSowDay.Size = new Size(165, 73);
            buttonSowDay.TabIndex = 8;
            buttonSowDay.Text = "הצג תאריך";
            buttonSowDay.UseVisualStyleBackColor = true;
            buttonSowDay.Click += OnResultClicked;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(51, 342);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(708, 27);
            textBoxResult.TabIndex = 9;
            textBoxResult.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(699, 301);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 10;
            label5.Text = "התאריך";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBoxResult);
            Controls.Add(buttonSowDay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxDay);
            Controls.Add(comboBoxDayInMonth);
            Controls.Add(comboBoxYear);
            Controls.Add(comboBoxMonth);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMonth;
        private ComboBox comboBoxYear;
        private ComboBox comboBoxDayInMonth;
        private ComboBox comboBoxDay;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonSowDay;
        private TextBox textBoxResult;
        private Label label5;
    }
}
