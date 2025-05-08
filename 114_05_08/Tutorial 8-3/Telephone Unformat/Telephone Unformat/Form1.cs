using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // IsValidFormat 方法接受一個字串參數，
        // 用於判斷該字串是否正確地格式化為美國電話號碼的格式：
        // (XXX)XXX-XXXX
        // 如果字串符合上述格式，則方法返回 true；
        // 否則返回 false。
        private bool IsValidFormat(string str)
        {
            // 檢查字串長度是否為 13 並且包含正確的括號和連字符
            if (str.Length == 13 &&
                str[0] == '(' &&
                str[3] == ')' &&
                str[8] == '-')
            {
                // 檢查括號內和其他部分是否為數字
                string areaCode = str.Substring(1, 2);
                string firstPart = str.Substring(4, 4);
                string secondPart = str.Substring(9, 4);

                if (IsAllDigit(areaCode)&&
                    IsAllDigit(firstPart)&&
                    IsAllDigit(secondPart))
                {
                    return true;
                }
                return false;
            }

            return false;
        }

        // IsAllDigit 方法接受一個字串參數，
        // 用於檢查該字串是否全部由數字組成。
        private bool IsAllDigit(string str)
        {
            // 檢查字串中的每個字符是否為數字
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false; // 如果有非數字字符，返回 false
                }
            }
            return true; // 如果全部是數字，返回 true
        }

        // Unformat 方法接受一個字串參數（以引用方式傳遞），
        // 該字串假設包含格式化為 (XX)XXXX-XXXX 的電話號碼。
        // 此方法會移除字串中的括號和連字符，將其轉換為未格式化的電話號碼。
        private void Unformat(ref string str)
        {
            str = str.Remove(0, 1)
                     .Remove(2, 1)
                     .Remove(6, 1); 
        }

        // unformatButton_Click 方法是當使用者按下「去格式化」按鈕時觸發的事件處理程序。
        // 此方法的具體邏輯尚未實作。
        private void unformatButton_Click(object sender, EventArgs e)
        {
            string input = numberTextBox.Text; // 取得使用者輸入的電話號碼

            if (IsValidFormat(input)) // 檢查輸入的格式是否正確
            {
                Unformat(ref input); // 去格式化電話號碼
                MessageBox.Show("去格式化後的電話號碼是：" + input); // 顯示去格式化後的電話號碼
            }
            else
            {
                MessageBox.Show("請輸入正確格式的電話號碼！"); // 提示使用者輸入正確格式
                numberTextBox.Text = "string.Empty"; 
                numberTextBox.Focus(); // 將焦點設置回輸入框
            }
        }

        // exitButton_Click 方法是當使用者按下「離開」按鈕時觸發的事件處理程序。
        // 此方法會關閉目前的表單。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
