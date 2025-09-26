namespace Baithuchanh2
{
    public partial class Baithuchanh2 : Form
    {
        public Baithuchanh2()
        {
            InitializeComponent();
        }
        private void btKQ_Click(object sender, EventArgs e)
        {
            string hoten = this.txtHoTen.Text.Trim();
            if (this.rad1.Checked == true)
                txtKQ.Text = hoten.ToLower();
            if (this.rad2.Checked == true)
                txtKQ.Text = hoten.ToUpper();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear();
            this.txtKQ.Clear();
            this.rad1.Checked = true;
            this.txtHoTen.Focus();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
