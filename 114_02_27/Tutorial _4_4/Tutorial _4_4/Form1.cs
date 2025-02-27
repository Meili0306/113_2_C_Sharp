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
                    label4.Text = "�����o�ӡG" + average.ToString("f2") + "����/����";
                    logListBox.Items.Add(average.ToString("f2") + "����/����");
                }
            }
            else
            {
                MessageBox.Show("�п�J�Ʀr");
                distancetextBox.Focus();
                distancetextBox.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
            logListBox.Items.Add("�����o�Ӭ���:");
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
                    sum += double.Parse(logListBox.Items[i].ToString().Replace("����/����", ""));
                }
                logListBox.Items.Add("�����o�ӡG" + (sum / (logListBox.Items.Count - 1)).ToString("f2") + "����/����");
            }
            else
            {
                MessageBox.Show("�S������");
            }
        }
    }
}
