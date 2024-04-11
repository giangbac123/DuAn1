namespace PRL.Forms
{
    partial class Sach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sach));
            Giatxt = new TextBox();
            txtid = new TextBox();
            SoTrang_TexBox = new TextBox();
            label9 = new Label();
            groupBox6 = new GroupBox();
            viewCT = new DataGridView();
            groupBox4 = new GroupBox();
            btnSuaCT = new Button();
            btnthemCT = new Button();
            label15 = new Label();
            groupBox5 = new GroupBox();
            Clear_Btn = new Button();
            Thoat_Btn = new Button();
            Them_Btn = new Button();
            Sua_Btn = new Button();
            SoLuong_TexBox = new TextBox();
            lblid = new Label();
            groupBox2 = new GroupBox();
            label16 = new Label();
            TacGia_ComboBox = new ComboBox();
            TheLoai_ComboBox = new ComboBox();
            NXB_ComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TimKiemTen_Texbox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            TrangThai_Textbox = new TextBox();
            label12 = new Label();
            label10 = new Label();
            viewSach = new DataGridView();
            groupBox3 = new GroupBox();
            label1 = new Label();
            TenSach_Texbox = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtMaVach = new TextBox();
            label11 = new Label();
            NgayXuatBan_Date = new DateTimePicker();
            label6 = new Label();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewCT).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewSach).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Giatxt
            // 
            Giatxt.BorderStyle = BorderStyle.FixedSingle;
            Giatxt.Location = new Point(149, 210);
            Giatxt.Name = "Giatxt";
            Giatxt.Size = new Size(204, 27);
            Giatxt.TabIndex = 39;
            Giatxt.Text = "0";
            // 
            // txtid
            // 
            txtid.BorderStyle = BorderStyle.FixedSingle;
            txtid.Location = new Point(150, 78);
            txtid.Name = "txtid";
            txtid.Size = new Size(204, 27);
            txtid.TabIndex = 35;
            // 
            // SoTrang_TexBox
            // 
            SoTrang_TexBox.BorderStyle = BorderStyle.FixedSingle;
            SoTrang_TexBox.Location = new Point(150, 177);
            SoTrang_TexBox.Name = "SoTrang_TexBox";
            SoTrang_TexBox.Size = new Size(204, 27);
            SoTrang_TexBox.TabIndex = 34;
            SoTrang_TexBox.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 179);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 33;
            label9.Text = "Số Trang:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(viewCT);
            groupBox6.Location = new Point(839, 52);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(389, 474);
            groupBox6.TabIndex = 17;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chi Tiết Sách:";
            // 
            // viewCT
            // 
            viewCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewCT.Location = new Point(6, 23);
            viewCT.Name = "viewCT";
            viewCT.RowHeadersWidth = 51;
            viewCT.RowTemplate.Height = 29;
            viewCT.Size = new Size(377, 445);
            viewCT.TabIndex = 0;
            viewCT.CellClick += dataGridView1_CellClick;
            viewCT.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSuaCT);
            groupBox4.Controls.Add(btnthemCT);
            groupBox4.Location = new Point(459, 273);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(374, 134);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Nhập Thông Tin Sách:";
            // 
            // btnSuaCT
            // 
            btnSuaCT.Location = new Point(204, 59);
            btnSuaCT.Name = "btnSuaCT";
            btnSuaCT.Size = new Size(102, 42);
            btnSuaCT.TabIndex = 5;
            btnSuaCT.Text = "Sửa";
            btnSuaCT.UseVisualStyleBackColor = true;
            btnSuaCT.Click += btnSuaCT_Click;
            // 
            // btnthemCT
            // 
            btnthemCT.Location = new Point(59, 57);
            btnthemCT.Name = "btnthemCT";
            btnthemCT.Size = new Size(102, 42);
            btnthemCT.TabIndex = 3;
            btnthemCT.Text = "Thêm";
            btnthemCT.UseVisualStyleBackColor = true;
            btnthemCT.Click += btnthemCT_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 212);
            label15.Name = "label15";
            label15.Size = new Size(34, 20);
            label15.TabIndex = 38;
            label15.Text = "Giá:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(Clear_Btn);
            groupBox5.Controls.Add(Thoat_Btn);
            groupBox5.Controls.Add(Them_Btn);
            groupBox5.Controls.Add(Sua_Btn);
            groupBox5.Location = new Point(79, 430);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(754, 96);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức Năng:";
            // 
            // Clear_Btn
            // 
            Clear_Btn.Location = new Point(584, 35);
            Clear_Btn.Name = "Clear_Btn";
            Clear_Btn.Size = new Size(131, 39);
            Clear_Btn.TabIndex = 13;
            Clear_Btn.Text = "Clear";
            Clear_Btn.UseVisualStyleBackColor = true;
            Clear_Btn.Click += Clear_Btn_Click;
            // 
            // Thoat_Btn
            // 
            Thoat_Btn.Location = new Point(410, 35);
            Thoat_Btn.Name = "Thoat_Btn";
            Thoat_Btn.Size = new Size(131, 39);
            Thoat_Btn.TabIndex = 14;
            Thoat_Btn.Text = "Thoát";
            Thoat_Btn.UseVisualStyleBackColor = true;
            Thoat_Btn.Click += Thoat_Btn_Click;
            // 
            // Them_Btn
            // 
            Them_Btn.Location = new Point(36, 35);
            Them_Btn.Name = "Them_Btn";
            Them_Btn.Size = new Size(131, 39);
            Them_Btn.TabIndex = 10;
            Them_Btn.Text = "Thêm";
            Them_Btn.UseVisualStyleBackColor = true;
            Them_Btn.Click += Them_Btn_Click;
            // 
            // Sua_Btn
            // 
            Sua_Btn.Location = new Point(208, 35);
            Sua_Btn.Name = "Sua_Btn";
            Sua_Btn.Size = new Size(131, 39);
            Sua_Btn.TabIndex = 12;
            Sua_Btn.Text = "Sửa";
            Sua_Btn.UseVisualStyleBackColor = true;
            Sua_Btn.Click += Sua_Btn_Click;
            // 
            // SoLuong_TexBox
            // 
            SoLuong_TexBox.BorderStyle = BorderStyle.FixedSingle;
            SoLuong_TexBox.Location = new Point(149, 144);
            SoLuong_TexBox.Name = "SoLuong_TexBox";
            SoLuong_TexBox.Size = new Size(205, 27);
            SoLuong_TexBox.TabIndex = 32;
            SoLuong_TexBox.Text = "0";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(143, 54);
            lblid.Name = "lblid";
            lblid.Size = new Size(58, 20);
            lblid.TabIndex = 19;
            lblid.Text = "label15";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(lblid);
            groupBox2.Controls.Add(TacGia_ComboBox);
            groupBox2.Controls.Add(TheLoai_ComboBox);
            groupBox2.Controls.Add(NXB_ComboBox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(459, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 215);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Sách:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(31, 54);
            label16.Name = "label16";
            label16.Size = new Size(27, 20);
            label16.TabIndex = 20;
            label16.Text = "ID:";
            // 
            // TacGia_ComboBox
            // 
            TacGia_ComboBox.FormattingEnabled = true;
            TacGia_ComboBox.ImeMode = ImeMode.NoControl;
            TacGia_ComboBox.IntegralHeight = false;
            TacGia_ComboBox.Location = new Point(143, 82);
            TacGia_ComboBox.Name = "TacGia_ComboBox";
            TacGia_ComboBox.Size = new Size(192, 28);
            TacGia_ComboBox.TabIndex = 16;
            // 
            // TheLoai_ComboBox
            // 
            TheLoai_ComboBox.FormattingEnabled = true;
            TheLoai_ComboBox.IntegralHeight = false;
            TheLoai_ComboBox.Location = new Point(143, 116);
            TheLoai_ComboBox.Name = "TheLoai_ComboBox";
            TheLoai_ComboBox.Size = new Size(192, 28);
            TheLoai_ComboBox.TabIndex = 17;
            // 
            // NXB_ComboBox
            // 
            NXB_ComboBox.FormattingEnabled = true;
            NXB_ComboBox.Location = new Point(143, 149);
            NXB_ComboBox.Name = "NXB_ComboBox";
            NXB_ComboBox.Size = new Size(192, 28);
            NXB_ComboBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 85);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 1;
            label3.Text = "Tác Giả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 119);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 2;
            label4.Text = "Thể Loại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 152);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 3;
            label5.Text = "Nhà xuất bản:";
            // 
            // TimKiemTen_Texbox
            // 
            TimKiemTen_Texbox.Location = new Point(87, 16);
            TimKiemTen_Texbox.Name = "TimKiemTen_Texbox";
            TimKiemTen_Texbox.PlaceholderText = "Nhập Tên Muốn Tìm Kiếm";
            TimKiemTen_Texbox.Size = new Size(287, 27);
            TimKiemTen_Texbox.TabIndex = 15;
            TimKiemTen_Texbox.TextChanged += TimKiemTen_Texbox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 20);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 15;
            label8.Text = "Tìm Kiếm:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 146);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 31;
            label7.Text = "Số Lượng:";
            // 
            // TrangThai_Textbox
            // 
            TrangThai_Textbox.BorderStyle = BorderStyle.FixedSingle;
            TrangThai_Textbox.Location = new Point(148, 278);
            TrangThai_Textbox.Name = "TrangThai_Textbox";
            TrangThai_Textbox.Size = new Size(204, 27);
            TrangThai_Textbox.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 280);
            label12.Name = "label12";
            label12.Size = new Size(81, 20);
            label12.TabIndex = 24;
            label12.Text = "Trạng Thái:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 80);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 20;
            label10.Text = "Mã Sách:";
            // 
            // viewSach
            // 
            viewSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewSach.Location = new Point(6, 49);
            viewSach.Name = "viewSach";
            viewSach.RowHeadersWidth = 51;
            viewSach.RowTemplate.Height = 29;
            viewSach.Size = new Size(1137, 270);
            viewSach.TabIndex = 16;
            viewSach.CellClick += view_CellClick;
            viewSach.CellContentClick += view_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(viewSach);
            groupBox3.Controls.Add(TimKiemTen_Texbox);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(79, 532);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1149, 338);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ Liệu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(515, 14);
            label1.Name = "label1";
            label1.Size = new Size(170, 35);
            label1.TabIndex = 14;
            label1.Text = "Quản Lý Sách";
            // 
            // TenSach_Texbox
            // 
            TenSach_Texbox.BorderStyle = BorderStyle.FixedSingle;
            TenSach_Texbox.Location = new Point(150, 111);
            TenSach_Texbox.Name = "TenSach_Texbox";
            TenSach_Texbox.Size = new Size(204, 27);
            TenSach_Texbox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 113);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên Sách:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaVach);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(NgayXuatBan_Date);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Giatxt);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(SoTrang_TexBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(SoLuong_TexBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TrangThai_Textbox);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(TenSach_Texbox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(79, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 355);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Thông Tin";
            // 
            // txtMaVach
            // 
            txtMaVach.BorderStyle = BorderStyle.FixedSingle;
            txtMaVach.Location = new Point(149, 311);
            txtMaVach.Name = "txtMaVach";
            txtMaVach.Size = new Size(204, 27);
            txtMaVach.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 313);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 42;
            label11.Text = "Mã vạch:";
            // 
            // NgayXuatBan_Date
            // 
            NgayXuatBan_Date.CustomFormat = "dd/MM/yyyy";
            NgayXuatBan_Date.Location = new Point(148, 243);
            NgayXuatBan_Date.Name = "NgayXuatBan_Date";
            NgayXuatBan_Date.Size = new Size(205, 27);
            NgayXuatBan_Date.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 248);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 40;
            label6.Text = "Ngày Xuất Bản:";
            // 
            // Sach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 882);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Sach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thông tin sách";
            Load += Sach_Load;
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewCT).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewSach).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Giatxt;
        private TextBox txtid;
        private TextBox SoTrang_TexBox;
        private Label label9;
        private GroupBox groupBox6;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private Button btnSuaCT;
        private Button btnthemCT;
        private Label label15;
        private GroupBox groupBox5;
        private Button Clear_Btn;
        private Button Thoat_Btn;
        private Button Them_Btn;
        private Button Sua_Btn;
        private TextBox SoLuong_TexBox;
        private Label lblid;
        private GroupBox groupBox2;
        private Label label16;
        private ComboBox TacGia_ComboBox;
        private ComboBox TheLoai_ComboBox;
        private ComboBox NXB_ComboBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TimKiemTen_Texbox;
        private Label label8;
        private Label label7;
        private TextBox TrangThai_Textbox;
        private Label label12;
        private Label label10;
        private DataGridView view;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox TenSach_Texbox;
        private Label label2;
        private GroupBox groupBox1;
        private DateTimePicker NgayXuatBan_Date;
        private Label label6;
        private TextBox txtMaVach;
        private Label label11;
        private DataGridView viewCT;
        private DataGridView viewSach;
    }
}