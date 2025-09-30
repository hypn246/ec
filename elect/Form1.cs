using Microsoft.VisualBasic;

namespace elect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label9.Text = "";
        }
        //Tính kí điện tổng từ tiền hóa đơn
        public static double moneyTokWh(double amount, int tier = 1)
        {
            double rate = 0, limit = 0;

            switch (tier)
            {
                case 1:
                    rate = 1.984;
                    limit = 50;
                    break;
                case 2:
                    rate = 2.050;
                    limit = 50;
                    break;
                case 3:
                    rate = 2.380;
                    limit = 100;
                    break;
                case 4:
                    rate = 2.998;
                    limit = 100;
                    break;
                case 5:
                    rate = 3.350;
                    limit = 100;
                    break;
                case 6:
                    rate = 3.460;
                    limit = 1000;
                    break;

                default:
                    return 0;
            }

            double usage = Math.Min(amount / rate, limit);
            double remainingAmount = amount - (usage * rate);

            if (remainingAmount > 0 && tier < 4)
            {
                return usage + moneyTokWh(remainingAmount, tier + 1);
            }

            return usage;
        }

        //Tinh kí điện ra tiền
        public static double kWhToMoney(double kWh, int tier = 1)
        {
            if (kWh <= 0) return 0;

            switch (tier)
            {
                case 1: // 0-50
                    double tier1 = Math.Min(kWh, 50);
                    return tier1 * 1.984 + kWhToMoney(kWh - tier1, 2);

                case 2: // 51-100 
                    double tier2 = Math.Min(kWh, 50);
                    return tier2 * 2.050 + kWhToMoney(kWh - tier2, 3);

                case 3: // 101-200
                    double tier3 = Math.Min(kWh, 100);
                    return tier3 * 2.380 + kWhToMoney(kWh - tier3, 4);

                case 4: // 201-300
                    double tier4 = Math.Min(kWh, 100);
                    return tier4 * 2.998 + kWhToMoney(kWh - tier4, 5);

                case 5: // 301-400
                    double tier5 = Math.Min(kWh, 100);
                    return tier5 * 3.350 + kWhToMoney(kWh - tier5, 6);

                case 6: // > 400 
                    return kWh * 3.460;

                default:
                    return 0;
            }
        }

        public void calc()
        {
            try
            {
                double t = double.Parse(textBox1.Text.Trim());     //total money

                double k = moneyTokWh(t / 108 * 100);       //total kwh

                int kThue = int.Parse(textBox2.Text.Trim());       //user kwh
                int kF = Convert.ToInt32(k - kThue);        //family kwh


                //user usage = total - family used(family kwh*scale*1.08)
                double result = t - kWhToMoney(k - kThue) * 1.08;
                MessageBox.Show("Tiền điện khách phải trả là:\n" + result.ToString() + " VNĐ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (FormatException ex)
            {
                MessageBox.Show("Nhập số đi con lợn!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            calc();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                calc();
                e.Handled = true;
            }
        }


        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                button1.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                calc();
                e.Handled = true;
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calc();
            }
        }
        /// <summary>
        /// Tính tiền điện cho thuê và ghi log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double t = double.Parse(tbTien.Text.Trim());     //total money

                double k = moneyTokWh(t / 108 * 100);       //total kwh

                double kOld = double.Parse(tbOld.Text.Trim());
                double kNew = double.Parse(tbNew.Text.Trim());
                int kThue = Convert.ToInt32(kNew - kOld);       //user kwh
                int kF = Convert.ToInt32(k - kThue);        //family kwh


                //user usage = total - family used(family kwh*scale*1.08)
                double result = t - kWhToMoney(k - kThue) * 1.08;
                MessageBox.Show("Tiền điện khách phải trả là:\n" + result.ToString("F3") + " VNĐ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                label8.Text = result.ToString("F3");


            }
            catch (FormatException ex)
            {
                MessageBox.Show("Nhập số đi con lợn!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string money = tbTien.Text.Trim();     //total money

                double kOld = double.Parse(tbOld.Text.Trim());
                double kNew = double.Parse(tbNew.Text.Trim());
                int kThue = Convert.ToInt32(kNew - kOld);       //user kwh
                string result = label8.Text.Trim(); // client bill

                string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Tạo chuỗi JSON thủ công
                string json = $"{{ \"DateTime\": \"{dateTime}\", \"soCu\": {kOld}, \"soMoi\": {kNew}, \"Tien\": {money:F3}}}";


                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string logFilePath = Path.Combine(documentsPath, "log.txt");

                File.AppendAllText(logFilePath, json + Environment.NewLine);

                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTien.Text = "";
                tbOld.Text = "";
                tbNew.Text = "";
                label8.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string money = textBox1.Text.Trim();
                double k = double.Parse(textBox2.Text.Trim());
                string result = label9.Text.Trim(); // client bill

                string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Tạo chuỗi JSON thủ công
                string json = $"{{ \"DateTime\": \"{dateTime}\", \"soKWH\": {k}, \"Tien\": {money:F3}}}";


                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string logFilePath = Path.Combine(documentsPath, "log.txt");

                File.AppendAllText(logFilePath, json + Environment.NewLine);

                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                label9.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                double t = double.Parse(textBox1.Text.Trim());     //total money

                double k = moneyTokWh(t / 108 * 100);       //total kwh

                int kThue = Convert.ToInt32(textBox2.Text.Trim());       //user kwh


                //user usage = total - family used(family kwh*scale*1.08)
                double result = t - kWhToMoney(k - kThue) * 1.08;
                MessageBox.Show("Tiền điện khách phải trả là:\n" + result.ToString("F3") + " VNĐ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                label9.Text = result.ToString("F3");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập số đi con lợn!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
