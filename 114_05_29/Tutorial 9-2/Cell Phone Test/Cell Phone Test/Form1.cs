using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetPhoneData method accepts a CellPhone object
        // as an argument. It assigns the data entered by the
        // user to the object's properties.
        private void GetPhoneData(CellPhone phone)
        {
            decimal price;

            phone.Brand = brandTextBox.Text; // 取得品牌
            phone.Model = modelTextBox.Text; // 取得型號

            // 嘗試將價格從文字框轉換為十進位數字
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price; // 設定價格
            }
            else
            {
                // 如果轉換失敗，顯示錯誤訊息並清除價格欄位
                MessageBox.Show("請輸入有效的價格。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                priceTextBox.Clear();
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            // 建立一個新的 CellPhone 物件，並將其指派給 myPhone 變數
            CellPhone myPhone = new CellPhone();

            // 呼叫 GetPhoneData 方法，將 myPhone 物件傳遞給它
            GetPhoneData(myPhone);

            // 將 myPhone 的資料顯示在標籤中
            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("C2"); // 格式化為貨幣字串
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
