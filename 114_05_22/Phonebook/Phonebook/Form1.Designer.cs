namespace Phonebook
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// 用於管理表單中的元件。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理正在使用的資源。
        /// 如果需要釋放非託管資源或釋放元件，則應在此處執行。
        /// </summary>
        /// <param name="disposing">如果需要釋放資源，則為 true；否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // 釋放元件資源
            }
            base.Dispose(disposing); // 呼叫基底類別的 Dispose 方法
        }

        #region Windows 表單設計工具產生的程式碼

        /// <summary>
        /// 設計工具支援的必要方法。
        /// 請勿使用程式碼編輯器修改此方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLabel = new System.Windows.Forms.Label();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.selectedPhoneDescriptionLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxAddEntry = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonAddEntry = new System.Windows.Forms.Button();
            this.groupBoxAddEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(44, 11);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(89, 12);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "請選擇一個名字";
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.ItemHeight = 12;
            this.nameListBox.Location = new System.Drawing.Point(22, 26);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(120, 88);
            this.nameListBox.TabIndex = 1;
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);
            // 
            // selectedPhoneDescriptionLabel
            // 
            this.selectedPhoneDescriptionLabel.AutoSize = true;
            this.selectedPhoneDescriptionLabel.Location = new System.Drawing.Point(148, 39);
            this.selectedPhoneDescriptionLabel.Name = "selectedPhoneDescriptionLabel";
            this.selectedPhoneDescriptionLabel.Size = new System.Drawing.Size(53, 12);
            this.selectedPhoneDescriptionLabel.TabIndex = 2;
            this.selectedPhoneDescriptionLabel.Text = "電話號碼";
            // 
            // phoneLabel
            // 
            this.phoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneLabel.Location = new System.Drawing.Point(148, 58);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(130, 21);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(203, 93);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 21);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // groupBoxAddEntry
            // 
            this.groupBoxAddEntry.Controls.Add(this.labelName);
            this.groupBoxAddEntry.Controls.Add(this.textBoxName);
            this.groupBoxAddEntry.Controls.Add(this.labelPhone);
            this.groupBoxAddEntry.Controls.Add(this.textBoxPhone);
            this.groupBoxAddEntry.Controls.Add(this.buttonAddEntry);
            this.groupBoxAddEntry.Location = new System.Drawing.Point(298, 14);
            this.groupBoxAddEntry.Name = "groupBoxAddEntry";
            this.groupBoxAddEntry.Size = new System.Drawing.Size(270, 100);
            this.groupBoxAddEntry.TabIndex = 5;
            this.groupBoxAddEntry.TabStop = false;
            this.groupBoxAddEntry.Text = "新增通訊錄";
            this.groupBoxAddEntry.Enter += new System.EventHandler(this.groupBoxAddEntry_Enter);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "姓名";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(71, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(190, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 53);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(53, 12);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "電話號碼";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(71, 47);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(190, 22);
            this.textBoxPhone.TabIndex = 3;
            // 
            // buttonAddEntry
            // 
            this.buttonAddEntry.Location = new System.Drawing.Point(175, 75);
            this.buttonAddEntry.Name = "buttonAddEntry";
            this.buttonAddEntry.Size = new System.Drawing.Size(75, 21);
            this.buttonAddEntry.TabIndex = 4;
            this.buttonAddEntry.Text = "新增通訊錄";
            this.buttonAddEntry.UseVisualStyleBackColor = true;
            // 
            // buttonAddEntry
            this.buttonAddEntry.Location = new System.Drawing.Point(175, 75);
            this.buttonAddEntry.Name = "buttonAddEntry";
            this.buttonAddEntry.Size = new System.Drawing.Size(75, 21);
            this.buttonAddEntry.TabIndex = 4;
            this.buttonAddEntry.Text = "加入"; // 這裡改為「加入」
            this.buttonAddEntry.UseVisualStyleBackColor = true;
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 131);
            this.Controls.Add(this.groupBoxAddEntry);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.selectedPhoneDescriptionLabel);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            this.Text = "電話簿";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAddEntry.ResumeLayout(false);
            this.groupBoxAddEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 定義表單中的元件
        private System.Windows.Forms.Label promptLabel; // 提示用的標籤
        private System.Windows.Forms.ListBox nameListBox; // 顯示名字列表的清單框
        private System.Windows.Forms.Label selectedPhoneDescriptionLabel; // 顯示電話號碼描述的標籤
        private System.Windows.Forms.Label phoneLabel; // 顯示選擇的電話號碼
        private System.Windows.Forms.Button exitButton; // 離開按鈕
        private System.Windows.Forms.OpenFileDialog openFile;

        // 新增通訊錄相關元件
        private System.Windows.Forms.GroupBox groupBoxAddEntry; // 新增通訊錄群組方塊
        private System.Windows.Forms.Label labelName; // 姓名標籤
        private System.Windows.Forms.TextBox textBoxName; // 姓名輸入框
        private System.Windows.Forms.Label labelPhone; // 電話號碼標籤
        private System.Windows.Forms.TextBox textBoxPhone; // 電話號碼輸入框
        private System.Windows.Forms.Button buttonAddEntry; // 新增通訊錄按鈕
    }
}

