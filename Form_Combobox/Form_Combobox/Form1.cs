namespace Form_Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSo.Clear();
            cboSo.Items.Clear();
            lstTinh.Items.Clear();
            txtSo.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSo.Text, out int so))
            {
                cboSo.Items.Add(so);
                txtSo.Clear();
                txtSo.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!");
                txtSo.Focus();
            }
        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTinh.Items.Clear();
            int so = int.Parse(cboSo.SelectedItem.ToString());
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    lstTinh.Items.Add(i);
                }
            }
        }

        private void btnTong_click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                tong += int.Parse(lstTinh.Items[i].ToString());
            }
            MessageBox.Show("Tổng các ước số là: " + tong);
        }

        private void btnChan_click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                int x = int.Parse(lstTinh.Items[i].ToString());
                if (x % 2 == 0) dem++;
            }
            MessageBox.Show("Số lượng các ước số chẵn là: " + dem);
        }
        private bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        private void btnNguyenTo_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                int x = int.Parse(lstTinh.Items[i].ToString());
                if (LaSoNguyenTo(x)) dem++;
            }
            MessageBox.Show("Số lượng các ước số nguyên tố là: " + dem);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
