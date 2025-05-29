using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Toss
{
    /// <summary>
    /// Coin 類別用於模擬一枚硬幣，可以執行擲硬幣的動作並取得結果。
    /// </summary>
    internal class Coin
    {
        private string sideUp; // 硬幣正面朝上的一面
        Random rand = new Random(); //隨機亂數產生器

        public Coin()
        {
            sideUp = "正面"; // 預設硬幣正面為 "正面"
        }

        public void Toss()
        {
            
            // 擲硬幣，隨機選擇 "正面" 或 "反面"
            if (rand.Next(2) == 0)
            {
                sideUp = "正面";
            }
            else
            {
                sideUp = "反面";
            }
        }

        public string GetSideUp() 
        {
            // 回傳硬幣正面朝上的一面
            return sideUp;
        }
    }
}
