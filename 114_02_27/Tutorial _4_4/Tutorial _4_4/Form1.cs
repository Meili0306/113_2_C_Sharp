namespace Tutorial__4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            double distance, gas, average;

            if (double.TryParse(distancetextBox.Text, out distance))
            {
                if (double.TryParse(gastextBox.Text, out gas))
                {
                    average = distance / gas;
                    label4.Text = "平均油耗：" + average.ToString("f2") + "公里/公升";
                    logListBox.Items.Add(average.ToString("f2") + "公里/公升");
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
                distancetextBox.Focus();
                distancetextBox.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
            logListBox.Items.Add("平均油耗紀錄:");
        }

        private void logListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (logListBox.Items.Count > 1)
            {
                for (int i = 1; i < logListBox.Items.Count; i++)
                {
                    sum += double.Parse(logListBox.Items[i].ToString().Replace("公里/公升", ""));
                }
                logListBox.Items.Add("平均油耗：" + (sum / (logListBox.Items.Count - 1)).ToString("f2") + "公里/公升");
            }
            else
            {
                MessageBox.Show("沒有紀錄");
            }
        }
    }
}
