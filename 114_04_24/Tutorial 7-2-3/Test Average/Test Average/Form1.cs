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

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Average 方法接受一個 List<int> 作為參數
        // 並返回該清單中所有值的平均值。
        private double Average(List<int> scores)
        {
            // 計算總和
            int total = 0;
            foreach (int score in scores)
            {
                total += score;
            }
            // 返回平均值
            return (double)total / scores.Count;
        }

        // Highest 方法接受一個 List<int> 作為參數
        // 並返回該清單中的最大值。
        private int Highest(List<int> scores)
        {
            // 找到最大值
            int highest = scores[0];
            foreach (int score in scores)
            {
                if (score > highest)
                {
                    highest = score;
                }
            }
            // 返回最大值
            return highest;
        }

        // Lowest 方法接受一個 List<int> 作為參數
        // 並返回該清單中的最小值。
        private int Lowest(List<int> scores)
        {
            // 找到最小值
            int lowest = scores[0];
            foreach (int score in scores)
            {
                if (score < lowest)
                {
                    lowest = score;
                }
            }
            // 返回最小值
            return lowest;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            // 這裡可以添加代碼來獲取分數並調用上述方法  
            List<int> testScores = new List<int>();
            int highestScore = 0;
            int lowestScore = 0;
            double averageScore = 0.0;
            StreamReader inputFile;
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    // 開啟檔案  
                    inputFile = File.OpenText(openFile.FileName);
                    // 清空 ListBox  
                    testScoresListBox.Items.Clear();
                    // 讀取檔案中的分數  
                    while (!inputFile.EndOfStream)
                    {
                        int score = Convert.ToInt32(inputFile.ReadLine());
                        testScores.Add(score);
                        // 將分數添加到 ListBox  
                        testScoresListBox.Items.Add(score);
                    }
                    inputFile.Close();
                    // 計算最高分、最低分和平均分  
                    highestScore = Highest(testScores);
                    lowestScore = Lowest(testScores);
                    averageScore = Average(testScores);
                    // 顯示結果  
                    highScoreLabel.Text = "Highest Score: " + highestScore.ToString();
                    lowScoreLabel.Text = "Lowest Score: " + lowestScore.ToString();
                    averageScoreLabel.Text = "Average Score: " + averageScore.ToString("n1");
                }
                else
                {
                    MessageBox.Show("No file selected.", "Error");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
