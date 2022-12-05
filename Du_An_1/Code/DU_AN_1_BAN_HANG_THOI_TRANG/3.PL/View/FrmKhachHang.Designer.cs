namespace _3.PL.View
{
    partial class FrmKhachHang
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
            this.btn_tk = new System.Windows.Forms.Button();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.cbx_NHD = new System.Windows.Forms.CheckBox();
            this.cbx_HD = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_nu = new System.Windows.Forms.RadioButton();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.date_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_Cmnd = new System.Windows.Forms.TextBox();
            this.txt_quocGia = new System.Windows.Forms.TextBox();
            this.txt_thanhPho = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_Ho = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_Tendem = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_MA = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.btn_SUA = new System.Windows.Forms.Button();
            this.btn_XOA = new System.Windows.Forms.Button();
            this.btn_CLEAR = new System.Windows.Forms.Button();
            this.btn_THEM = new System.Windows.Forms.Button();
            this.Dgrid_KH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tk
            // 
            this.btn_tk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.btn_tk.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_tk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_tk.Location = new System.Drawing.Point(643, 305);
            this.btn_tk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(178, 37);
            this.btn_tk.TabIndex = 90;
            this.btn_tk.Text = "Tìm kiếm";
            this.btn_tk.UseVisualStyleBackColor = false;
            this.btn_tk.Click += new System.EventHandler(this.btn_tk_Click);
            // 
            // txt_TK
            // 
            this.txt_TK.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TK.Location = new System.Drawing.Point(18, 311);
            this.txt_TK.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(595, 32);
            this.txt_TK.TabIndex = 89;
            this.txt_TK.Text = "Tìm kiếm...";
            // 
            // cbx_NHD
            // 
            this.cbx_NHD.AutoSize = true;
            this.cbx_NHD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_NHD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbx_NHD.Location = new System.Drawing.Point(748, 267);
            this.cbx_NHD.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_NHD.Name = "cbx_NHD";
            this.cbx_NHD.Size = new System.Drawing.Size(71, 29);
            this.cbx_NHD.TabIndex = 88;
            this.cbx_NHD.Text = "NHĐ";
            this.cbx_NHD.UseVisualStyleBackColor = true;
            // 
            // cbx_HD
            // 
            this.cbx_HD.AutoSize = true;
            this.cbx_HD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_HD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbx_HD.Location = new System.Drawing.Point(593, 267);
            this.cbx_HD.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_HD.Name = "cbx_HD";
            this.cbx_HD.Size = new System.Drawing.Size(57, 29);
            this.cbx_HD.TabIndex = 87;
            this.cbx_HD.Text = "HĐ";
            this.cbx_HD.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(460, 266);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 86;
            this.label11.Text = "Trạng thái :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 85;
            this.label1.Text = "Giới tính :";
            // 
            // rbtn_nu
            // 
            this.rbtn_nu.AutoSize = true;
            this.rbtn_nu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_nu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtn_nu.Location = new System.Drawing.Point(315, 268);
            this.rbtn_nu.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_nu.Name = "rbtn_nu";
            this.rbtn_nu.Size = new System.Drawing.Size(55, 29);
            this.rbtn_nu.TabIndex = 84;
            this.rbtn_nu.TabStop = true;
            this.rbtn_nu.Text = "Nữ";
            this.rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_Nam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtn_Nam.Location = new System.Drawing.Point(164, 267);
            this.rbtn_Nam.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(70, 29);
            this.rbtn_Nam.TabIndex = 83;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // date_ngaySinh
            // 
            this.date_ngaySinh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_ngaySinh.Location = new System.Drawing.Point(133, 212);
            this.date_ngaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.date_ngaySinh.Name = "date_ngaySinh";
            this.date_ngaySinh.Size = new System.Drawing.Size(294, 32);
            this.date_ngaySinh.TabIndex = 82;
            // 
            // txt_Cmnd
            // 
            this.txt_Cmnd.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Cmnd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Cmnd.Location = new System.Drawing.Point(582, 213);
            this.txt_Cmnd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cmnd.Name = "txt_Cmnd";
            this.txt_Cmnd.Size = new System.Drawing.Size(294, 32);
            this.txt_Cmnd.TabIndex = 81;
            this.txt_Cmnd.UseSystemPasswordChar = true;
            // 
            // txt_quocGia
            // 
            this.txt_quocGia.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_quocGia.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_quocGia.Location = new System.Drawing.Point(582, 165);
            this.txt_quocGia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_quocGia.Name = "txt_quocGia";
            this.txt_quocGia.Size = new System.Drawing.Size(294, 32);
            this.txt_quocGia.TabIndex = 80;
            this.txt_quocGia.Text = "Việt Nam";
            // 
            // txt_thanhPho
            // 
            this.txt_thanhPho.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_thanhPho.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_thanhPho.Location = new System.Drawing.Point(582, 116);
            this.txt_thanhPho.Margin = new System.Windows.Forms.Padding(2);
            this.txt_thanhPho.Name = "txt_thanhPho";
            this.txt_thanhPho.Size = new System.Drawing.Size(294, 32);
            this.txt_thanhPho.TabIndex = 79;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_diaChi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_diaChi.Location = new System.Drawing.Point(582, 68);
            this.txt_diaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(294, 32);
            this.txt_diaChi.TabIndex = 78;
            // 
            // txt_Ho
            // 
            this.txt_Ho.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Ho.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Ho.Location = new System.Drawing.Point(133, 65);
            this.txt_Ho.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(294, 32);
            this.txt_Ho.TabIndex = 77;
            this.txt_Ho.TextChanged += new System.EventHandler(this.txt_Ho_TextChanged);
            this.txt_Ho.Leave += new System.EventHandler(this.txt_Ho_Leave);
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ten.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ten.Location = new System.Drawing.Point(133, 114);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(294, 32);
            this.txt_ten.TabIndex = 76;
            this.txt_ten.TextChanged += new System.EventHandler(this.txt_ten_TextChanged);
            this.txt_ten.Leave += new System.EventHandler(this.txt_ten_Leave);
            // 
            // txt_Tendem
            // 
            this.txt_Tendem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Tendem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Tendem.Location = new System.Drawing.Point(133, 162);
            this.txt_Tendem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Tendem.Name = "txt_Tendem";
            this.txt_Tendem.Size = new System.Drawing.Size(294, 32);
            this.txt_Tendem.TabIndex = 75;
            this.txt_Tendem.TextChanged += new System.EventHandler(this.txt_Tendem_TextChanged);
            this.txt_Tendem.Leave += new System.EventHandler(this.txt_Tendem_Leave);
            // 
            // txt_sdt
            // 
            this.txt_sdt.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_sdt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sdt.Location = new System.Drawing.Point(582, 19);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(294, 32);
            this.txt_sdt.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(460, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 73;
            this.label10.Text = "Địa chỉ :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(460, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 72;
            this.label9.Text = "Thành phố :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(460, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 71;
            this.label8.Text = "Quốc gia : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(460, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 70;
            this.label7.Text = "CMND :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(24, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 69;
            this.label6.Text = "Họ : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(24, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 68;
            this.label5.Text = "Tên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(24, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 67;
            this.label4.Text = "Tên Đệm : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(24, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 66;
            this.label3.Text = "Ngày sinh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(460, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "SĐT :";
            // 
            // lbl_MA
            // 
            this.lbl_MA.AutoSize = true;
            this.lbl_MA.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_MA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_MA.Location = new System.Drawing.Point(24, 21);
            this.lbl_MA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MA.Name = "lbl_MA";
            this.lbl_MA.Size = new System.Drawing.Size(53, 25);
            this.lbl_MA.TabIndex = 64;
            this.lbl_MA.Text = "Mã : ";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Ma.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Ma.Location = new System.Drawing.Point(133, 17);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(294, 32);
            this.txt_Ma.TabIndex = 63;
            // 
            // btn_SUA
            // 
            this.btn_SUA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.btn_SUA.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SUA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_SUA.Location = new System.Drawing.Point(904, 103);
            this.btn_SUA.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SUA.Name = "btn_SUA";
            this.btn_SUA.Size = new System.Drawing.Size(167, 50);
            this.btn_SUA.TabIndex = 62;
            this.btn_SUA.Text = "Sửa";
            this.btn_SUA.UseVisualStyleBackColor = false;
            this.btn_SUA.Click += new System.EventHandler(this.btn_SUA_Click);
            // 
            // btn_XOA
            // 
            this.btn_XOA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.btn_XOA.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_XOA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_XOA.Location = new System.Drawing.Point(904, 187);
            this.btn_XOA.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XOA.Name = "btn_XOA";
            this.btn_XOA.Size = new System.Drawing.Size(167, 50);
            this.btn_XOA.TabIndex = 61;
            this.btn_XOA.Text = "Xóa";
            this.btn_XOA.UseVisualStyleBackColor = false;
            this.btn_XOA.Click += new System.EventHandler(this.btn_XOA_Click);
            // 
            // btn_CLEAR
            // 
            this.btn_CLEAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.btn_CLEAR.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CLEAR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_CLEAR.Location = new System.Drawing.Point(904, 271);
            this.btn_CLEAR.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CLEAR.Name = "btn_CLEAR";
            this.btn_CLEAR.Size = new System.Drawing.Size(167, 50);
            this.btn_CLEAR.TabIndex = 60;
            this.btn_CLEAR.Text = "Clear";
            this.btn_CLEAR.UseVisualStyleBackColor = false;
            this.btn_CLEAR.Click += new System.EventHandler(this.btn_CLEAR_Click);
            // 
            // btn_THEM
            // 
            this.btn_THEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.btn_THEM.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_THEM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_THEM.Location = new System.Drawing.Point(904, 19);
            this.btn_THEM.Margin = new System.Windows.Forms.Padding(2);
            this.btn_THEM.Name = "btn_THEM";
            this.btn_THEM.Size = new System.Drawing.Size(167, 50);
            this.btn_THEM.TabIndex = 59;
            this.btn_THEM.Text = "Thêm";
            this.btn_THEM.UseVisualStyleBackColor = false;
            this.btn_THEM.Click += new System.EventHandler(this.btn_THEM_Click);
            // 
            // Dgrid_KH
            // 
            this.Dgrid_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_KH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgrid_KH.Location = new System.Drawing.Point(0, 347);
            this.Dgrid_KH.Margin = new System.Windows.Forms.Padding(2);
            this.Dgrid_KH.Name = "Dgrid_KH";
            this.Dgrid_KH.RowHeadersWidth = 62;
            this.Dgrid_KH.RowTemplate.Height = 33;
            this.Dgrid_KH.Size = new System.Drawing.Size(1079, 103);
            this.Dgrid_KH.TabIndex = 58;
            this.Dgrid_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_KH_CellClick);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.btn_tk);
            this.Controls.Add(this.txt_TK);
            this.Controls.Add(this.cbx_NHD);
            this.Controls.Add(this.cbx_HD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtn_nu);
            this.Controls.Add(this.rbtn_Nam);
            this.Controls.Add(this.date_ngaySinh);
            this.Controls.Add(this.txt_Cmnd);
            this.Controls.Add(this.txt_quocGia);
            this.Controls.Add(this.txt_thanhPho);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.txt_Ho);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_Tendem);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_MA);
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.btn_SUA);
            this.Controls.Add(this.btn_XOA);
            this.Controls.Add(this.btn_CLEAR);
            this.Controls.Add(this.btn_THEM);
            this.Controls.Add(this.Dgrid_KH);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_KH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tk;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.CheckBox cbx_NHD;
        private System.Windows.Forms.CheckBox cbx_HD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_nu;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.DateTimePicker date_ngaySinh;
        private System.Windows.Forms.TextBox txt_Cmnd;
        private System.Windows.Forms.TextBox txt_quocGia;
        private System.Windows.Forms.TextBox txt_thanhPho;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_Tendem;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MA;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Button btn_SUA;
        private System.Windows.Forms.Button btn_XOA;
        private System.Windows.Forms.Button btn_CLEAR;
        private System.Windows.Forms.Button btn_THEM;
        private System.Windows.Forms.DataGridView Dgrid_KH;
    }
}