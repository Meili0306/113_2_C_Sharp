﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Program7_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 使用 List<string> 來存放球隊與冠軍資料
        List<string> teamList = new List<string>();
        List<string> winnerList = new List<string>();

        // 儲存使用者選擇的檔案路徑
        string teamsFilePath = "";
        string winnerFilePath = "";

        /// <summary>
        /// 表單載入事件，初始化並讀取球隊與冠軍資料
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // 提示使用者選擇 Teams.txt 檔案
            MessageBox.Show("請選擇球隊檔案", "選擇檔案", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog openTeamsDialog = new OpenFileDialog();
            openTeamsDialog.Title = "請選擇球隊檔案 (Teams.txt)";
            openTeamsDialog.Filter = "文字檔案 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            openTeamsDialog.FileName = "Teams.txt";

            if (openTeamsDialog.ShowDialog() == DialogResult.OK)
            {
                teamsFilePath = openTeamsDialog.FileName;
            }
            else
            {
                MessageBox.Show("未選擇球隊檔案，程式即將結束。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // 提示使用者選擇 WorldSeries.txt 檔案
            MessageBox.Show("請選擇世界大賽冠軍檔案", "選擇檔案", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog openWinnerDialog = new OpenFileDialog();
            openWinnerDialog.Title = "請選擇世界大賽冠軍檔案 (WorldSeries.txt)";
            openWinnerDialog.Filter = "文字檔案 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            openWinnerDialog.FileName = "WorldSeries.txt";

            if (openWinnerDialog.ShowDialog() == DialogResult.OK)
            {
                winnerFilePath = openWinnerDialog.FileName;
            }
            else
            {
                MessageBox.Show("未選擇世界大賽冠軍檔案，程式即將結束。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            readTeams();
            readWinner();
        }

        /// <summary>
        /// 讀取 Teams.txt 檔案，將所有球隊名稱加入 listBox1，並存入 teamList
        /// </summary>
        private void readTeams()
        {
            try
            {
                // 清空 teamList 及 listBox1，避免重複加入
                teamList.Clear();
                listBox1.Items.Clear();

                using (StreamReader inputFile = File.OpenText(teamsFilePath))
                {
                    string line;
                    // 逐行讀取 Teams.txt，將每一行加入 teamList 及 listBox1
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        teamList.Add(line);
                        listBox1.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                // 若檔案讀取失敗，顯示錯誤訊息（繁體中文）
                MessageBox.Show("讀取球隊檔案時發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 讀取 WorldSeries.txt 檔案，將每一年的冠軍球隊名稱存入 winnerList
        /// </summary>
        private void readWinner()
        {
            try
            {
                // 清空 winnerList，避免重複加入
                winnerList.Clear();

                using (StreamReader inputFile = File.OpenText(winnerFilePath))
                {
                    string line;
                    // 逐行讀取 WorldSeries.txt，將每一行加入 winnerList
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        winnerList.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                // 若檔案讀取失敗，顯示錯誤訊息（繁體中文）
                MessageBox.Show("讀取世界大賽冠軍檔案時發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 當使用者在 listBox1 選取球隊時，計算該球隊奪冠次數並顯示於 label1，並列出奪冠年份
        /// </summary>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            int numWin = 0;
            List<int> winYears = new List<int>();
            int startYear = 1903;
            int year = startYear;

            // MLB 世界大賽 1904 與 1994 年未舉辦，需跳過
            HashSet<int> skipYears = new HashSet<int> { 1904, 1994 };

            for (int i = 0; i < winnerList.Count; i++)
            {
                // 跳過未舉辦的年份
                while (skipYears.Contains(year))
                {
                    year++;
                }
                if (str == winnerList[i])
                {
                    numWin++;
                    winYears.Add(year);
                }
                year++;
            }

            // 組合奪冠年份字串
            string yearsText = winYears.Count > 0
                ? "\n奪冠年份：" + string.Join("、", winYears)
                : "\n無奪冠紀錄。";

            // 顯示該球隊自 1903 年至 2009 年奪冠次數及年份（繁體中文）
            label1.Text = str + " 自 1903 年至 2009 年共獲得世界大賽冠軍 " + numWin + " 次。" + yearsText;
        }
    }
}
