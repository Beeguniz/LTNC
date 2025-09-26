namespace Form_PhepTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Hàm kiểm tra chuỗi có phải số hay không
        private bool IsNumber(string text)
        {
            double temp;
            return double.TryParse(text, out temp);
        }

        private void btnKetQua_click(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtSo1.Text);
                double so2 = double.Parse(txtSo2.Text);
                double ketQua = 0;

                if (radCong.Checked)
                {
                    ketQua = so1 + so2;
                }
                else if (radTru.Checked)
                {
                    ketQua = so1 - so2;
                }
                else if (radNhan.Checked)
                {
                    ketQua = so1 * so2;
                }
                else if (radChia.Checked)
                {
                    if (so2 != 0)
                        ketQua = so1 / so2;
                    else
                        MessageBox.Show("Không thể chia cho 0");
                }

                txtKetQua.Text = ketQua.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
    

