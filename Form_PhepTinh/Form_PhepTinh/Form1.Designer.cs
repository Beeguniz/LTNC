namespace Form_PhepTinh
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
            label1 = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            label2 = new Label();
            radCong = new RadioButton();
            radTru = new RadioButton();
            radNhan = new RadioButton();
            radChia = new RadioButton();
            groupBox1 = new GroupBox();
            txtKetQua = new TextBox();
            btnKetQua = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 89);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "Số 1:";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(207, 86);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(446, 31);
            txtSo1.TabIndex = 1;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(207, 163);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(446, 31);
            txtSo2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 166);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 2;
            label2.Text = "Số 2:";
            // 
            // radCong
            // 
            radCong.AutoSize = true;
            radCong.Location = new Point(26, 58);
            radCong.Name = "radCong";
            radCong.Size = new Size(80, 29);
            radCong.TabIndex = 4;
            radCong.TabStop = true;
            radCong.Text = "Cộng";
            radCong.UseVisualStyleBackColor = true;
            // 
            // radTru
            // 
            radTru.AutoSize = true;
            radTru.Location = new Point(154, 58);
            radTru.Name = "radTru";
            radTru.Size = new Size(61, 29);
            radTru.TabIndex = 5;
            radTru.TabStop = true;
            radTru.Text = "Trừ";
            radTru.UseVisualStyleBackColor = true;
            radTru.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radNhan
            // 
            radNhan.AutoSize = true;
            radNhan.Location = new Point(290, 58);
            radNhan.Name = "radNhan";
            radNhan.Size = new Size(79, 29);
            radNhan.TabIndex = 6;
            radNhan.TabStop = true;
            radNhan.Text = "Nhân";
            radNhan.UseVisualStyleBackColor = true;
            // 
            // radChia
            // 
            radChia.AutoSize = true;
            radChia.Location = new Point(428, 58);
            radChia.Name = "radChia";
            radChia.Size = new Size(71, 29);
            radChia.TabIndex = 7;
            radChia.TabStop = true;
            radChia.Text = "Chia";
            radChia.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radNhan);
            groupBox1.Controls.Add(radChia);
            groupBox1.Controls.Add(radCong);
            groupBox1.Controls.Add(radTru);
            groupBox1.Location = new Point(128, 241);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 130);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phép tính";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(263, 418);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(390, 31);
            txtKetQua.TabIndex = 10;
            txtKetQua.TextChanged += textBox1_TextChanged;
            // 
            // btnKetQua
            // 
            btnKetQua.Location = new Point(128, 418);
            btnKetQua.Name = "btnKetQua";
            btnKetQua.Size = new Size(106, 31);
            btnKetQua.TabIndex = 11;
            btnKetQua.Text = "Kết quả";
            btnKetQua.UseVisualStyleBackColor = true;
            btnKetQua.Click += btnKetQua_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 480);
            Controls.Add(btnKetQua);
            Controls.Add(txtKetQua);
            Controls.Add(groupBox1);
            Controls.Add(txtSo2);
            Controls.Add(label2);
            Controls.Add(txtSo1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private Label label2;
        private RadioButton radCong;
        private RadioButton radTru;
        private RadioButton radNhan;
        private RadioButton radChia;
        private GroupBox groupBox1;
        private TextBox txtKetQua;
        private Button btnKetQua;
    }
}
