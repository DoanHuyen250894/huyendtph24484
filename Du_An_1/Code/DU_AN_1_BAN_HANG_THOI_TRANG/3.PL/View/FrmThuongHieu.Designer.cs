namespace _3.PL.View
{
    partial class FrmThuongHieu
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
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.rbtn_NgungCungCap = new System.Windows.Forms.RadioButton();
            this.rbtn_DangCungCap = new System.Windows.Forms.RadioButton();
            this.txt_MoTa = new System.Windows.Forms.RichTextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_ThuongHieu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ThuongHieu)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(495, 153);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(204, 23);
            this.txt_TimKiem.TabIndex = 26;
            this.txt_TimKiem.Text = "Tìm kiếm...";
            this.txt_TimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_TimKiem_MouseClick);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.MouseLeave += new System.EventHandler(this.txt_TimKiem_MouseLeave);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(495, 98);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(203, 44);
            this.btn_xoa.TabIndex = 25;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(494, 49);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(204, 44);
            this.btn_Sua.TabIndex = 24;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(494, 5);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(205, 40);
            this.btn_Them.TabIndex = 23;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // rbtn_NgungCungCap
            // 
            this.rbtn_NgungCungCap.AutoSize = true;
            this.rbtn_NgungCungCap.Location = new System.Drawing.Point(74, 180);
            this.rbtn_NgungCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_NgungCungCap.Name = "rbtn_NgungCungCap";
            this.rbtn_NgungCungCap.Size = new System.Drawing.Size(114, 19);
            this.rbtn_NgungCungCap.TabIndex = 22;
            this.rbtn_NgungCungCap.TabStop = true;
            this.rbtn_NgungCungCap.Text = "Ngừng cung cấp";
            this.rbtn_NgungCungCap.UseVisualStyleBackColor = true;
            // 
            // rbtn_DangCungCap
            // 
            this.rbtn_DangCungCap.AutoSize = true;
            this.rbtn_DangCungCap.Location = new System.Drawing.Point(72, 153);
            this.rbtn_DangCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_DangCungCap.Name = "rbtn_DangCungCap";
            this.rbtn_DangCungCap.Size = new System.Drawing.Size(105, 19);
            this.rbtn_DangCungCap.TabIndex = 21;
            this.rbtn_DangCungCap.TabStop = true;
            this.rbtn_DangCungCap.Text = "Đang cung cấp";
            this.rbtn_DangCungCap.UseVisualStyleBackColor = true;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(72, 99);
            this.txt_MoTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(232, 44);
            this.txt_MoTa.TabIndex = 20;
            this.txt_MoTa.Text = "";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(72, 58);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(232, 23);
            this.txt_Ten.TabIndex = 19;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(74, 12);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(230, 23);
            this.txt_Ma.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã:";
            // 
            // dgrid_ThuongHieu
            // 
            this.dgrid_ThuongHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ThuongHieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_ThuongHieu.Location = new System.Drawing.Point(0, 222);
            this.dgrid_ThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_ThuongHieu.Name = "dgrid_ThuongHieu";
            this.dgrid_ThuongHieu.RowHeadersWidth = 51;
            this.dgrid_ThuongHieu.RowTemplate.Height = 29;
            this.dgrid_ThuongHieu.Size = new System.Drawing.Size(704, 162);
            this.dgrid_ThuongHieu.TabIndex = 27;
            this.dgrid_ThuongHieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_ThuongHieu_CellContentClick_1);
            // 
            // FrmThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 384);
            this.Controls.Add(this.dgrid_ThuongHieu);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.rbtn_NgungCungCap);
            this.Controls.Add(this.rbtn_DangCungCap);
            this.Controls.Add(this.txt_MoTa);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmThuongHieu";
            this.Text = "FrmThuongHieu";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ThuongHieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.RadioButton rbtn_NgungCungCap;
        private System.Windows.Forms.RadioButton rbtn_DangCungCap;
        private System.Windows.Forms.RichTextBox txt_MoTa;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrid_ThuongHieu;
    }
}