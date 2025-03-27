using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace American_Colonies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "美國殖民地"; // 修改表單標題
            okButton.Text = "確定"; // 修改確定按鈕的文字
            exitButton.Text = "退出"; // 修改退出按鈕的文字
        }

        // SequentialSearch 方法在字串陣列中搜尋指定的值。
        // 如果找到該值，則返回其位置。否則，返回 -1。
        private int SequentialSearch(string[] sArray, string value)
        {
            bool found = false;  // 標誌表示搜尋結果
            int index = 0;       // 用於遍歷陣列的索引
            int position = -1;   // 如果找到值，則記錄其位置

            // 搜尋陣列。
            while (!found && index < sArray.Length)
            {
                if (sArray[index] == value)
                {
                    found = true;
                    position = index;
                }

                index++;
            }

            // 返回位置
            return position;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string selection;   // 用於保存使用者的選擇

            // 建立一個包含殖民地名稱的陣列。
            string[] colonies = {  "德拉瓦", "賓夕法尼亞", "新澤西",
                                            "喬治亞", "康乃狄克", "麻薩諸塞",
                                            "馬里蘭", "南卡羅來納", "新罕布夏",
                                            "維吉尼亞", "紐約", "北卡羅來納",
                                            "羅德島" };

            if (selectionListBox.SelectedIndex != -1)
            {
                // 獲取選中的項目。
                selection = selectionListBox.SelectedItem.ToString();

                // 判斷該項目是否在陣列中。
                if (SequentialSearch(colonies, selection) != -1)
                {
                    MessageBox.Show("是的，那是其中一個殖民地。");
                }
                else
                {
                    MessageBox.Show("不，那不是其中一個殖民地。");
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
