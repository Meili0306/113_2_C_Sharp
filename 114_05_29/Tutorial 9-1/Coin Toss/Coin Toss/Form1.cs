using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            Coin mycoin = new Coin(); // 創建 Coin 類別的實例
            outputListBox.Items.Clear(); // 清空輸出清單方塊

            // 擲硬幣五次，並將結果添加到 outputListBox 中
            for (int i = 0; i < 5; i++)
            {
                mycoin.Toss(); // 擲硬幣
                outputListBox.Items.Add(mycoin.GetSideUp()); // 將結果添加到清單方塊
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
