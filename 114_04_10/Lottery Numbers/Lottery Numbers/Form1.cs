using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 5; // 陣列的大小
            int[] lotteryNumbers = new int[SIZE]; // 用來儲存樂透號碼的陣列
            Random rand = new Random(); 

            for (int i = 0;i < lotteryNumbers.Length; i++)
            {
                //產生1~42的亂數，確認產生的亂數沒有與陣列中元素重複，在放入陣列中
                int number;
                do
                {
                    number = rand.Next(1, 43); // 產生1~42的亂數
                } while (lotteryNumbers.Contains(number)); // 確認不重複
                lotteryNumbers[i] = number; // 將不重複的亂數放入陣列中
            }

            //將lotteryNumbers 陣列中的數字由小到大排序
            Array.Sort(lotteryNumbers); // 將lotteryNumbers 陣列中的數字顯示在Label上


            //firstLabel.Text = lotteryNumbers[0].ToString();
            //secondLabel.Text = lotteryNumbers[1].ToString();
            //thirdLabel.Text = lotteryNumbers[2].ToString();
            //fourthLabel.Text = lotteryNumbers[3].ToString();
            //fifthLabel.Text = lotteryNumbers[4].ToString();

            // 用迴圈來顯示樂透號碼
            Label[] showLabels = { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };
            for (int i = 0; i < showLabels.Length; i++)
            {
                showLabels[i].Text = lotteryNumbers[i].ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
