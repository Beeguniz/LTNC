namespace BaiThucHanh1
{
    partial class FrmBai1_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_nho = new CheckBox();
            bt_login = new Button();
            bt_delete = new Button();
            bt_stop = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // bt_nho
            // 
            bt_nho.AutoSize = true;
            bt_nho.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_nho.Location = new Point(105, 297);
            bt_nho.Name = "bt_nho";
            bt_nho.Size = new Size(110, 30);
            bt_nho.TabIndex = 0;
            bt_nho.Text = "Ghi nhớ";
            bt_nho.UseVisualStyleBackColor = true;
            // 
            // bt_login
            // 
            bt_login.AutoSize = true;
            bt_login.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_login.Location = new Point(132, 352);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(124, 45);
            bt_login.TabIndex = 1;
            bt_login.Text = "Đăng nhập";
            bt_login.UseVisualStyleBackColor = true;
            bt_login.Click += bt_login_Click;
            // 
            // bt_delete
            // 
            bt_delete.AutoSize = true;
            bt_delete.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_delete.Location = new Point(331, 353);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(129, 44);
            bt_delete.TabIndex = 2;
            bt_delete.Text = "Xóa";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_stop
            // 
            bt_stop.AutoSize = true;
            bt_stop.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_stop.Location = new Point(533, 353);
            bt_stop.Name = "bt_stop";
            bt_stop.Size = new Size(124, 44);
            bt_stop.TabIndex = 3;
            bt_stop.Text = "Dừng";
            bt_stop.UseVisualStyleBackColor = true;
            bt_stop.Click += bt_stop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 91);
            label1.Name = "label1";
            label1.Size = new Size(151, 26);
            label1.TabIndex = 4;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 163);
            label2.Name = "label2";
            label2.Size = new Size(99, 26);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(285, 90);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(259, 27);
            txtUser.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(285, 162);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(259, 27);
            txtPass.TabIndex = 7;
            // 
            // FrmBai1_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt_stop);
            Controls.Add(bt_delete);
            Controls.Add(bt_login);
            Controls.Add(bt_nho);
            Name = "FrmBai1_1";
            Text = "Form Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox bt_nho;
        private Button bt_login;
        private Button bt_delete;
        private Button bt_stop;
        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPass;
    }
}
