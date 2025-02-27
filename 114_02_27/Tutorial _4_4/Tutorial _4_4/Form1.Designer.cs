namespace Tutorial__4_4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            distancetextBox = new TextBox();
            gastextBox = new TextBox();
            label4 = new Label();
            calculatebutton = new Button();
            exitbutton = new Button();
            logListBox = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15F);
            label1.Location = new Point(60, 60);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "輸入行駛里程數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15F);
            label2.Location = new Point(60, 159);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 1;
            label2.Text = "消耗油量公升數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15F);
            label3.Location = new Point(80, 249);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 2;
            label3.Text = "您的平均油耗";
            label3.Click += label3_Click;
            // 
            // distancetextBox
            // 
            distancetextBox.Font = new Font("Microsoft JhengHei UI", 15F);
            distancetextBox.Location = new Point(270, 57);
            distancetextBox.Name = "distancetextBox";
            distancetextBox.Size = new Size(126, 33);
            distancetextBox.TabIndex = 3;
            // 
            // gastextBox
            // 
            gastextBox.Font = new Font("Microsoft JhengHei UI", 15F);
            gastextBox.Location = new Point(270, 156);
            gastextBox.Name = "gastextBox";
            gastextBox.Size = new Size(126, 33);
            gastextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Microsoft JhengHei UI", 15F);
            label4.Location = new Point(270, 248);
            label4.Name = "label4";
            label4.Size = new Size(258, 43);
            label4.TabIndex = 5;
            // 
            // calculatebutton
            // 
            calculatebutton.Font = new Font("Microsoft JhengHei UI", 15F);
            calculatebutton.Location = new Point(118, 340);
            calculatebutton.Name = "calculatebutton";
            calculatebutton.Size = new Size(94, 48);
            calculatebutton.TabIndex = 6;
            calculatebutton.Text = "計算";
            calculatebutton.UseVisualStyleBackColor = true;
            calculatebutton.Click += calculatebutton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Font = new Font("Microsoft JhengHei UI", 15F);
            exitbutton.Location = new Point(302, 340);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(94, 48);
            exitbutton.TabIndex = 7;
            exitbutton.Text = "離開";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.TextChanged += exitbutton_Click;
            exitbutton.Click += exitbutton_Click;
            // 
            // logListBox
            // 
            logListBox.FormattingEnabled = true;
            logListBox.ItemHeight = 15;
            logListBox.Location = new Point(534, 57);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(267, 229);
            logListBox.TabIndex = 8;
            logListBox.SelectedIndexChanged += logListBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 15F);
            button1.Location = new Point(571, 340);
            button1.Name = "button1";
            button1.Size = new Size(194, 48);
            button1.TabIndex = 9;
            button1.Text = "總平均油耗";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 450);
            Controls.Add(button1);
            Controls.Add(logListBox);
            Controls.Add(exitbutton);
            Controls.Add(calculatebutton);
            Controls.Add(label4);
            Controls.Add(gastextBox);
            Controls.Add(distancetextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox distancetextBox;
        private TextBox gastextBox;
        private Label label4;
        private Button calculatebutton;
        private Button exitbutton;
        private ListBox logListBox;
        private Button button1;
    }
}
