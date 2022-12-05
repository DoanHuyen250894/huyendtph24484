namespace _3.PL.View
{
    partial class FrmSize
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
            this.rbtn_hetsize = new System.Windows.Forms.RadioButton();
            this.rbtn_consize = new System.Windows.Forms.RadioButton();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgv_size = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_size)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_hetsize
            // 
            this.rbtn_hetsize.AutoSize = true;
            this.rbtn_hetsize.Location = new System.Drawing.Point(89, 69);
            this.rbtn_hetsize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_hetsize.Name = "rbtn_hetsize";
            this.rbtn_hetsize.Size = new System.Drawing.Size(66, 19);
            this.rbtn_hetsize.TabIndex = 19;
            this.rbtn_hetsize.TabStop = true;
            this.rbtn_hetsize.Text = "Hết size";
            this.rbtn_hetsize.UseVisualStyleBackColor = true;
            // 
            // rbtn_consize
            // 
            this.rbtn_consize.AutoSize = true;
            this.rbtn_consize.Location = new System.Drawing.Point(89, 46);
            this.rbtn_consize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_consize.Name = "rbtn_consize";
            this.rbtn_consize.Size = new System.Drawing.Size(69, 19);
            this.rbtn_consize.TabIndex = 20;
            this.rbtn_consize.TabStop = true;
            this.rbtn_consize.Text = "Còn size";
            this.rbtn_consize.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(288, 120);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(82, 22);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(200, 120);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(82, 22);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(112, 120);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(82, 22);
            this.btn_sua.TabIndex = 17;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(24, 120);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(82, 22);
            this.btn_them.TabIndex = 18;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(77, 8);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(110, 23);
            this.txt_ma.TabIndex = 11;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(62, 163);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(110, 23);
            this.txt_timkiem.TabIndex = 12;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(248, 46);
            this.txt_mota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(110, 23);
            this.txt_mota.TabIndex = 13;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(248, 8);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(110, 23);
            this.txt_ten.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên";
            // 
            // dtgv_size
            // 
            this.dtgv_size.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_size.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_size.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_size.Location = new System.Drawing.Point(0, 234);
            this.dtgv_size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_size.Name = "dtgv_size";
            this.dtgv_size.RowHeadersWidth = 51;
            this.dtgv_size.RowTemplate.Height = 29;
            this.dtgv_size.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_size.Size = new System.Drawing.Size(389, 106);
            this.dtgv_size.TabIndex = 5;
            this.dtgv_size.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_size_CellClick);
            this.dtgv_size.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgv_size_RowValidating);
            this.dtgv_size.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgv_size_UserAddedRow);
            // 
            // FrmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 340);
            this.Controls.Add(this.rbtn_hetsize);
            this.Controls.Add(this.rbtn_consize);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgv_size);
            this.Name = "FrmSize";
            this.Text = "FrmSize";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_hetsize;
        private System.Windows.Forms.RadioButton rbtn_consize;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgv_size;
    }
}