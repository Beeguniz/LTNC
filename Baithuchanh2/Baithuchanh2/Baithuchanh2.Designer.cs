
namespace Baithuchanh2
{
    partial class Baithuchanh2
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
            label1 = new Label();
            txtHoTen = new TextBox();
            groupBox1 = new GroupBox();
            rad2 = new RadioButton();
            rad1 = new RadioButton();
            bt_delete = new Button();
            btKQ = new Button();
            txtKQ = new TextBox();
            btStop = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 61);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 0;
            label1.Text = "Nhập họ và tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.Location = new Point(277, 61);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(290, 25);
            txtHoTen.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad2);
            groupBox1.Controls.Add(rad1);
            groupBox1.Location = new Point(93, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 99);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn kiểu chữ";
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(13, 63);
            rad2.Name = "rad2";
            rad2.Size = new Size(116, 24);
            rad2.TabIndex = 1;
            rad2.TabStop = true;
            rad2.Text = "CHỮ IN HOA";
            rad2.UseVisualStyleBackColor = true;
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Location = new Point(13, 33);
            rad1.Name = "rad1";
            rad1.Size = new Size(106, 24);
            rad1.TabIndex = 0;
            rad1.TabStop = true;
            rad1.Text = "chữ thường";
            rad1.UseVisualStyleBackColor = true;
            // 
            // bt_delete
            // 
            bt_delete.AutoSize = true;
            bt_delete.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_delete.Location = new Point(656, 179);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(78, 90);
            bt_delete.TabIndex = 3;
            bt_delete.Text = "Xóa";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // btKQ
            // 
            btKQ.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btKQ.Location = new Point(85, 336);
            btKQ.Name = "btKQ";
            btKQ.Size = new Size(94, 29);
            btKQ.TabIndex = 4;
            btKQ.Text = "Kết quả";
            btKQ.UseVisualStyleBackColor = true;
            btKQ.Click += btKQ_Click;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(246, 338);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(378, 27);
            txtKQ.TabIndex = 5;
            // 
            // btStop
            // 
            btStop.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btStop.Location = new Point(667, 338);
            btStop.Name = "btStop";
            btStop.Size = new Size(94, 38);
            btStop.TabIndex = 6;
            btStop.Text = "Dừng";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // Baithuchanh2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btStop);
            Controls.Add(txtKQ);
            Controls.Add(btKQ);
            Controls.Add(bt_delete);
            Controls.Add(groupBox1);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Name = "Baithuchanh2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi kiểu chữ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private GroupBox groupBox1;
        private RadioButton rad1;
        private RadioButton rad2;
        private Button bt_delete;
        private Button btKQ;
        private TextBox txtKQ;
        private Button btStop;

        public EventHandler bt_kq_Click { get; private set; }
    }
}
