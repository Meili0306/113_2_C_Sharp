using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        // 用來儲存 CellPhone 物件的清單
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        // GetPhoneData 方法會接收一個 CellPhone 物件作為參數。
        // 此方法會將使用者於表單輸入的資料指派給該物件的屬性。
        private void GetPhoneData(CellPhone phone)
        {
            // 暫存手機價格的變數
            decimal price;

            // 取得手機品牌，並指派給 CellPhone 物件的 Brand 屬性
            phone.Brand = brandTextBox.Text;

            // 取得手機型號，並指派給 CellPhone 物件的 Model 屬性
            phone.Model = modelTextBox.Text;

            // 取得手機價格，並指派給 CellPhone 物件的 Price 屬性
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // 顯示錯誤訊息，提醒使用者輸入的價格格式不正確
                MessageBox.Show("價格格式無效，請輸入正確的數字。");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            // 此事件於使用者點擊「新增手機」按鈕時觸發
            // 根據您的需求，此處不進行任何新增資料的動作
            CellPhone myPhone = new CellPhone(); // 建立新的 CellPhone 物件

            GetPhoneData(myPhone); // 呼叫 GetPhoneData 方法，將表單資料指派給 myPhone 物件

            // 將 myPhone 物件加入到 phoneList 清單中
            phoneList.Add(myPhone);

            //將新增手機的品牌與型號組合成字串，並加入到 ListBox中
            phoneListBox.Items.Add(myPhone.Brand + "" + myPhone.Model);

            // 清空輸入欄位，讓使用者可以繼續輸入下一個手機資料
            brandTextBox.Text = "";
            modelTextBox.Text = "";
            priceTextBox.Text = "";

            // 將焦點設定回品牌輸入欄位，方便使用者繼續輸入
            brandTextBox.Focus();
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 此事件於使用者在手機清單中選取不同項目時觸發
            // 根據您的需求，此處不進行任何資料處理
            int index = phoneListBox.SelectedIndex; // 取得選取的項目索引

            MessageBox.Show(phoneList[index].Price.ToString("C"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式執行
            this.Close();
        }
    }
}
