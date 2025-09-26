namespace Form_Combobox
{
    partial class Form1
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
            txtSo = new TextBox();
            btnCapNhat = new Button();
            cboSo = new ComboBox();
            groupBox1 = new GroupBox();
            lstTinh = new ListBox();
            btnTong = new Button();
            btnChan = new Button();
            btnNguyenTo = new Button();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtSo
            // 
            txtSo.Location = new Point(35, 57);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(167, 31);
            txtSo.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(223, 54);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(112, 34);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_click;
            // 
            // cboSo
            // 
            cboSo.FormattingEnabled = true;
            cboSo.Location = new Point(35, 127);
            cboSo.Name = "cboSo";
            cboSo.Size = new Size(300, 33);
            cboSo.TabIndex = 2;
            cboSo.SelectedIndexChanged += cboSo_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(cboSo);
            groupBox1.Controls.Add(txtSo);
            groupBox1.Location = new Point(110, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 201);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập số";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lstTinh
            // 
            lstTinh.FormattingEnabled = true;
            lstTinh.HorizontalScrollbar = true;
            lstTinh.ItemHeight = 25;
            lstTinh.Location = new Point(26, 30);
            lstTinh.Name = "lstTinh";
            lstTinh.Size = new Size(300, 154);
            lstTinh.TabIndex = 4;
            lstTinh.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(620, 333);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(300, 41);
            btnTong.TabIndex = 5;
            btnTong.Text = "Tổng các ước số";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_click;
            // 
            // btnChan
            // 
            btnChan.Location = new Point(620, 405);
            btnChan.Name = "btnChan";
            btnChan.Size = new Size(300, 41);
            btnChan.TabIndex = 6;
            btnChan.Text = "Số lượng các ước số chẵn";
            btnChan.UseVisualStyleBackColor = true;
            btnChan.Click += btnChan_click;
            // 
            // btnNguyenTo
            // 
            btnNguyenTo.Location = new Point(620, 473);
            btnNguyenTo.Name = "btnNguyenTo";
            btnNguyenTo.Size = new Size(300, 41);
            btnNguyenTo.TabIndex = 7;
            btnNguyenTo.Text = "Số lượng các ước số nguyên tố";
            btnNguyenTo.UseVisualStyleBackColor = true;
            btnNguyenTo.Click += btnNguyenTo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstTinh);
            groupBox2.Location = new Point(594, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 201);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các ước số";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(364, 473);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 41);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 653);
            Controls.Add(btnThoat);
            Controls.Add(groupBox2);
            Controls.Add(btnNguyenTo);
            Controls.Add(btnChan);
            Controls.Add(btnTong);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSo;
        private Button btnCapNhat;
        private ComboBox cboSo;
        private GroupBox groupBox1;
        private ListBox lstTinh;
        private Button btnTong;
        private Button btnChan;
        private Button btnNguyenTo;
        private GroupBox groupBox2;
        private Button btnThoat;
    }
}
