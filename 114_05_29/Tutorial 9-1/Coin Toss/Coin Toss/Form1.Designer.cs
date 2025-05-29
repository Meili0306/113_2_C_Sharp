namespace Coin_Toss
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 釋放正在使用的資源。
        /// </summary>
        /// <param name="disposing">
        /// 如果為 true，則釋放所有受控資源；否則僅釋放非受控資源。
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此方法為設計工具所需，請勿以程式碼編輯器修改其內容。
        /// 用於初始化表單上的所有控制項與其屬性設定。
        /// </summary>
        private void InitializeComponent()
        {
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.tossButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            // outputListBox 控制項用於顯示擲硬幣的結果，每次擲硬幣後會將結果新增至此清單方塊中。
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(50, 12);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(120, 95);
            this.outputListBox.TabIndex = 0;
            // 
            // tossButton
            // 
            // tossButton 控制項為一個按鈕，按下後會執行擲五次硬幣的動作，並將結果顯示於 outputListBox。
            this.tossButton.Location = new System.Drawing.Point(32, 113);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(75, 39);
            this.tossButton.TabIndex = 1;
            this.tossButton.Text = "擲五次硬幣";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // exitButton
            // 
            // exitButton 控制項為一個按鈕，按下後會關閉應用程式。
            this.exitButton.Location = new System.Drawing.Point(113, 113);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 39);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // Form1 為主視窗，包含顯示擲硬幣結果的清單方塊及兩個按鈕（擲硬幣與離開）。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 164);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.outputListBox);
            this.Name = "Form1";
            this.Text = "擲硬幣";
            this.ResumeLayout(false);

        }

        #endregion

        // outputListBox 控制項用於顯示每次擲硬幣的結果。
        private System.Windows.Forms.ListBox outputListBox;
        // tossButton 控制項為執行擲五次硬幣動作的按鈕。
        private System.Windows.Forms.Button tossButton;
        // exitButton 控制項為結束應用程式的按鈕。
        private System.Windows.Forms.Button exitButton;
    }
}

