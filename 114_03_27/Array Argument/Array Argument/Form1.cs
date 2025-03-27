using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Array_Argument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // goButton 控制項的點擊事件處理程序。
        // 當使用者點擊 goButton 時，會執行此方法。
        private void goButton_Click(object sender, EventArgs e)
        {
            // 建立一個 int 陣列，包含數字 1, 2, 3。
            int[] numbers = { 1, 2, 3 };

            // 在列表框中顯示陣列的原始內容。
            outputListBox.Items.Add("The array's original contents:");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }

            // 將陣列傳遞給 SetToZero 方法，將陣列中的所有元素設置為 0。
            SetToZero(numbers);

            // 再次在列表框中顯示陣列，顯示經過 SetToZero 方法後的內容。
            outputListBox.Items.Add("");
            outputListBox.Items.Add("After calling SetToZero:");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }
        }

        // SetToZero 方法接受一個 int 陣列作為參數，並將其所有元素設置為 0。
        // 這個方法會遍歷陣列中的每個元素，並將其值設置為 0。
        private void SetToZero(int[] iArray)
        {
            for (int index = 0; index < iArray.Length; index++)
            {
                iArray[index] = 0;
            }
        }

        // exitButton 控制項的點擊事件處理程序。
        // 當使用者點擊 exitButton 時，會執行此方法。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束應用程式。
            this.Close();
        }
    }
}
