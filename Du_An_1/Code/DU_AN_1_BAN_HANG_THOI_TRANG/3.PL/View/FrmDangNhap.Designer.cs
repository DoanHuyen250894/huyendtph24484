namespace _3.PL.View
{
    partial class FrmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_nmk = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_quenmatkhau = new System.Windows.Forms.Label();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_nmk
            // 
            this.cb_nmk.AutoSize = true;
            this.cb_nmk.Location = new System.Drawing.Point(259, 369);
            this.cb_nmk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_nmk.Name = "cb_nmk";
            this.cb_nmk.Size = new System.Drawing.Size(152, 24);
            this.cb_nmk.TabIndex = 24;
            this.cb_nmk.Text = "Ghi Nhớ Mật Khẩu";
            this.cb_nmk.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(254, 226);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(259, 301);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 51);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(254, 352);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 4);
            this.panel2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3.PL.Properties.Resources.login__1_;
            this.pictureBox1.Location = new System.Drawing.Point(347, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 179);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(254, 289);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 4);
            this.panel1.TabIndex = 19;
            // 
            // lb_quenmatkhau
            // 
            this.lb_quenmatkhau.AutoSize = true;
            this.lb_quenmatkhau.ForeColor = System.Drawing.Color.Black;
            this.lb_quenmatkhau.Location = new System.Drawing.Point(403, 414);
            this.lb_quenmatkhau.Name = "lb_quenmatkhau";
            this.lb_quenmatkhau.Size = new System.Drawing.Size(109, 20);
            this.lb_quenmatkhau.TabIndex = 18;
            this.lb_quenmatkhau.Text = "Quên mật khẩu";
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(503, 364);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(126, 44);
            this.btn_dangnhap.TabIndex = 17;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.BackColor = System.Drawing.Color.White;
            this.tb_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_matkhau.Location = new System.Drawing.Point(307, 322);
            this.tb_matkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '*';
            this.tb_matkhau.PlaceholderText = "PassWord";
            this.tb_matkhau.Size = new System.Drawing.Size(322, 20);
            this.tb_matkhau.TabIndex = 16;
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.BackColor = System.Drawing.Color.White;
            this.tb_taikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_taikhoan.ForeColor = System.Drawing.Color.Black;
            this.tb_taikhoan.Location = new System.Drawing.Point(307, 260);
            this.tb_taikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.PlaceholderText = "UserName";
            this.tb_taikhoan.Size = new System.Drawing.Size(322, 20);
            this.tb_taikhoan.TabIndex = 15;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(883, 472);
            this.Controls.Add(this.cb_nmk);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_quenmatkhau);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.tb_taikhoan);
            this.Name = "FrmDangNhap";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_nmk;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_quenmatkhau;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.TextBox tb_taikhoan;
    }
}