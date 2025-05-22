using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    // 定義電話簿條目的結構
    struct PhoneBookEntry
    {
        public string name;  // 姓名
        public string phone; // 電話號碼
    }

    public partial class Form1 : Form
    {
        // 用來儲存所有電話簿條目的清單
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 讀取 PhoneList.txt 檔案內容，並將每一筆資料存入 phoneList 清單
        /// </summary>
        private void ReadFile()
        {
            phoneList.Clear(); // 先清空現有清單
            if (File.Exists("PhoneList.txt"))
            {
                try
                {
                    using (StreamReader inputFile = new StreamReader("PhoneList.txt", Encoding.UTF8))
                    {
                        string line;
                        while ((line = inputFile.ReadLine()) != null)
                        {
                            line = line.Trim();
                            string[] parts = line.Split(',');
                            if (parts.Length == 2)
                            {
                                PhoneBookEntry entry;
                                entry.name = parts[0].Trim();
                                entry.phone = parts[1].Trim();
                                phoneList.Add(entry);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取檔案時發生錯誤:" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 將 phoneList 清單中的所有姓名顯示在 nameListBox 控制項中
        /// </summary>
        private void DisplayNames()
        {
            nameListBox.Items.Clear(); // 先清空列表
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        /// <summary>
        /// 表單載入時自動讀取檔案並顯示姓名清單
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();      // 讀取檔案並存入 phoneList
            DisplayNames();  // 顯示姓名清單
        }

        /// <summary>
        /// 當使用者選擇不同的姓名時，顯示對應的電話號碼
        /// </summary>
        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex;
            if (index != -1 && index < phoneList.Count)
            {
                // 顯示選取的電話號碼
                phoneLabel.Text = phoneList[index].phone;
            }
            else
            {
                // 若未選取任何項目，顯示「無資料」
                phoneLabel.Text = "無資料";
            }
        }

        /// <summary>
        /// 按下「離開」按鈕時，將目前 phoneList 的資料全部寫回 PhoneList.txt 檔案，然後關閉表單。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 將 phoneList 的所有資料寫回 PhoneList.txt（覆蓋舊檔）
                using (StreamWriter sw = new StreamWriter("PhoneList.txt", false, Encoding.UTF8))
                {
                    foreach (var entry in phoneList)
                    {
                        sw.WriteLine($"{entry.name},{entry.phone}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存檔案時發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // 若儲存失敗則不關閉表單
                return;
            }

            // 關閉表單
            this.Close();
        }

        /// <summary>
        /// 當「加入」按鈕被按下時，將輸入的姓名與電話號碼加入 phoneList，
        /// 並立即更新 nameListBox 顯示內容。
        /// 若有任一輸入框未輸入，顯示錯誤訊息。
        /// </summary>
        private void buttonAddEntry_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();

            // 檢查姓名與電話號碼是否皆有輸入
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("請輸入姓名與電話號碼！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 新增到 phoneList
            PhoneBookEntry entry;
            entry.name = name;
            entry.phone = phone;
            phoneList.Add(entry);

            // 清空輸入框
            textBoxName.Text = "";
            textBoxPhone.Text = "";

            // 立即更新 nameListBox 顯示內容
            DisplayNames();

            MessageBox.Show("加入通訊錄成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBoxAddEntry_Enter(object sender, EventArgs e)
        {
            // 此事件可留空或移除
        }
    }
}
