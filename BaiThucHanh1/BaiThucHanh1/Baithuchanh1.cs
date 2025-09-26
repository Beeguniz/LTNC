namespace BaiThucHanh1
{
    public partial class FrmBai1_1 : Form
    {
        public FrmBai1_1()
        {
            InitializeComponent();
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtUser.Text;
            thongbao += "\n\rMật khẩu là: ";
            thongbao += this.txtPass.Text;
            if (this.bt_nho.Checked == true)
            {
                thongbao += "\n\rBạn có ghi nhớ";
            }
            MessageBox.Show(thongbao, "Thông báo");
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear(); this.txtPass.Clear(); this.txtUser.Focus();
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
