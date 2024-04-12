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
            Giatxt.Location = new Point(186, 262);
            Giatxt.Margin = new Padding(4, 4, 4, 4);
            Giatxt.Name = "Giatxt";
            Giatxt.Size = new Size(254, 31);
            Giatxt.TabIndex = 39;
            Giatxt.Text = "0";
            // 
            // txtid
            // 
            txtid.BorderStyle = BorderStyle.FixedSingle;
            txtid.Location = new Point(188, 98);
            txtid.Margin = new Padding(4, 4, 4, 4);
            txtid.Name = "txtid";
            txtid.Size = new Size(254, 31);
            txtid.TabIndex = 35;
            // 
            // SoTrang_TexBox
            // 
            SoTrang_TexBox.BorderStyle = BorderStyle.FixedSingle;
            SoTrang_TexBox.Location = new Point(188, 221);
            SoTrang_TexBox.Margin = new Padding(4, 4, 4, 4);
            SoTrang_TexBox.Name = "SoTrang_TexBox";
            SoTrang_TexBox.Size = new Size(254, 31);
            SoTrang_TexBox.TabIndex = 34;
            SoTrang_TexBox.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 224);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 25);
            label9.TabIndex = 33;
            label9.Text = "Số Trang:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(viewCT);
            groupBox6.Location = new Point(1049, 65);
            groupBox6.Margin = new Padding(4, 4, 4, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 4, 4, 4);
            groupBox6.Size = new Size(486, 592);
            groupBox6.TabIndex = 17;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chi Tiết Sách:";
            // 
            // viewCT
            // 
            viewCT.BackgroundColor = SystemColors.ButtonHighlight;
            viewCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewCT.Location = new Point(8, 29);
            viewCT.Margin = new Padding(4, 4, 4, 4);
            viewCT.Name = "viewCT";
            viewCT.RowHeadersWidth = 51;
            viewCT.RowTemplate.Height = 29;
            viewCT.Size = new Size(471, 556);
            viewCT.TabIndex = 0;
            viewCT.CellClick += dataGridView1_CellClick;
            viewCT.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSuaCT);
            groupBox4.Controls.Add(btnthemCT);
            groupBox4.Location = new Point(574, 341);
            groupBox4.Margin = new Padding(4, 4, 4, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 4, 4, 4);
            groupBox4.Size = new Size(468, 168);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Nhập Thông Tin Sách:";
            // 
            // btnSuaCT
            // 
            btnSuaCT.BackColor = Color.Lime;
            btnSuaCT.Location = new Point(255, 74);
            btnSuaCT.Margin = new Padding(4, 4, 4, 4);
            btnSuaCT.Name = "btnSuaCT";
            btnSuaCT.Size = new Size(128, 52);
            btnSuaCT.TabIndex = 5;
            btnSuaCT.Text = "Sửa";
            btnSuaCT.UseVisualStyleBackColor = false;
            btnSuaCT.Click += btnSuaCT_Click;
            // 
            // btnthemCT
            // 
            btnthemCT.BackColor = Color.Lime;
            btnthemCT.Location = new Point(74, 71);
            btnthemCT.Margin = new Padding(4, 4, 4, 4);
            btnthemCT.Name = "btnthemCT";
            btnthemCT.Size = new Size(128, 52);
            btnthemCT.TabIndex = 3;
            btnthemCT.Text = "Thêm";
            btnthemCT.UseVisualStyleBackColor = false;
            btnthemCT.Click += btnthemCT_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(14, 265);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(41, 25);
            label15.TabIndex = 38;
            label15.Text = "Giá:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(Clear_Btn);
            groupBox5.Controls.Add(Thoat_Btn);
            groupBox5.Controls.Add(Them_Btn);
            groupBox5.Controls.Add(Sua_Btn);
            groupBox5.Location = new Point(99, 538);
            groupBox5.Margin = new Padding(4, 4, 4, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 4, 4, 4);
            groupBox5.Size = new Size(942, 120);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức Năng:";
            // 
            // Clear_Btn
            // 
            Clear_Btn.BackColor = Color.Lime;
            Clear_Btn.Location = new Point(730, 44);
            Clear_Btn.Margin = new Padding(4, 4, 4, 4);
            Clear_Btn.Name = "Clear_Btn";
            Clear_Btn.Size = new Size(164, 49);
            Clear_Btn.TabIndex = 13;
            Clear_Btn.Text = "Clear";
            Clear_Btn.UseVisualStyleBackColor = false;
            Clear_Btn.Click += Clear_Btn_Click;
            // 
            // Thoat_Btn
            // 
            Thoat_Btn.BackColor = Color.Red;
            Thoat_Btn.Location = new Point(512, 44);
            Thoat_Btn.Margin = new Padding(4, 4, 4, 4);
            Thoat_Btn.Name = "Thoat_Btn";
            Thoat_Btn.Size = new Size(164, 49);
            Thoat_Btn.TabIndex = 14;
            Thoat_Btn.Text = "Thoát";
            Thoat_Btn.UseVisualStyleBackColor = false;
            Thoat_Btn.Click += Thoat_Btn_Click;
            // 
            // Them_Btn
            // 
            Them_Btn.BackColor = Color.Lime;
            Them_Btn.Location = new Point(45, 44);
            Them_Btn.Margin = new Padding(4, 4, 4, 4);
            Them_Btn.Name = "Them_Btn";
            Them_Btn.Size = new Size(164, 49);
            Them_Btn.TabIndex = 10;
            Them_Btn.Text = "Thêm";
            Them_Btn.UseVisualStyleBackColor = false;
            Them_Btn.Click += Them_Btn_Click;
            // 
            // Sua_Btn
            // 
            Sua_Btn.BackColor = Color.Lime;
            Sua_Btn.Location = new Point(260, 44);
            Sua_Btn.Margin = new Padding(4, 4, 4, 4);
            Sua_Btn.Name = "Sua_Btn";
            Sua_Btn.Size = new Size(164, 49);
            Sua_Btn.TabIndex = 12;
            Sua_Btn.Text = "Sửa";
            Sua_Btn.UseVisualStyleBackColor = false;
            Sua_Btn.Click += Sua_Btn_Click;
            // 
            // SoLuong_TexBox
            // 
            SoLuong_TexBox.BorderStyle = BorderStyle.FixedSingle;
            SoLuong_TexBox.Location = new Point(186, 180);
            SoLuong_TexBox.Margin = new Padding(4, 4, 4, 4);
            SoLuong_TexBox.Name = "SoLuong_TexBox";
            SoLuong_TexBox.Size = new Size(256, 31);
            SoLuong_TexBox.TabIndex = 32;
            SoLuong_TexBox.Text = "0";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(179, 68);
            lblid.Margin = new Padding(4, 0, 4, 0);
            lblid.Name = "lblid";
            lblid.Size = new Size(69, 25);
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
            groupBox2.Location = new Point(574, 65);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(468, 269);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Sách:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(39, 68);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(34, 25);
            label16.TabIndex = 20;
            label16.Text = "ID:";
            // 
            // TacGia_ComboBox
            // 
            TacGia_ComboBox.FormattingEnabled = true;
            TacGia_ComboBox.ImeMode = ImeMode.NoControl;
            TacGia_ComboBox.IntegralHeight = false;
            TacGia_ComboBox.Location = new Point(179, 102);
            TacGia_ComboBox.Margin = new Padding(4, 4, 4, 4);
            TacGia_ComboBox.Name = "TacGia_ComboBox";
            TacGia_ComboBox.Size = new Size(239, 33);
            TacGia_ComboBox.TabIndex = 16;
            // 
            // TheLoai_ComboBox
            // 
            TheLoai_ComboBox.FormattingEnabled = true;
            TheLoai_ComboBox.IntegralHeight = false;
            TheLoai_ComboBox.Location = new Point(179, 145);
            TheLoai_ComboBox.Margin = new Padding(4, 4, 4, 4);
            TheLoai_ComboBox.Name = "TheLoai_ComboBox";
            TheLoai_ComboBox.Size = new Size(239, 33);
            TheLoai_ComboBox.TabIndex = 17;
            // 
            // NXB_ComboBox
            // 
            NXB_ComboBox.FormattingEnabled = true;
            NXB_ComboBox.Location = new Point(179, 186);
            NXB_ComboBox.Margin = new Padding(4, 4, 4, 4);
            NXB_ComboBox.Name = "NXB_ComboBox";
            NXB_ComboBox.Size = new Size(239, 33);
            NXB_ComboBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 106);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 1;
            label3.Text = "Tác Giả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 149);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 2;
            label4.Text = "Thể Loại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 190);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 3;
            label5.Text = "Nhà xuất bản:";
            // 
            // TimKiemTen_Texbox
            // 
            TimKiemTen_Texbox.Location = new Point(109, 20);
            TimKiemTen_Texbox.Margin = new Padding(4, 4, 4, 4);
            TimKiemTen_Texbox.Name = "TimKiemTen_Texbox";
            TimKiemTen_Texbox.PlaceholderText = "Nhập Tên Muốn Tìm Kiếm";
            TimKiemTen_Texbox.Size = new Size(358, 31);
            TimKiemTen_Texbox.TabIndex = 15;
            TimKiemTen_Texbox.TextChanged += TimKiemTen_Texbox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 25);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 15;
            label8.Text = "Tìm Kiếm:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 182);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 31;
            label7.Text = "Số Lượng:";
            // 
            // TrangThai_Textbox
            // 
            TrangThai_Textbox.BorderStyle = BorderStyle.FixedSingle;
            TrangThai_Textbox.Location = new Point(185, 348);
            TrangThai_Textbox.Margin = new Padding(4, 4, 4, 4);
            TrangThai_Textbox.Name = "TrangThai_Textbox";
            TrangThai_Textbox.Size = new Size(254, 31);
            TrangThai_Textbox.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 350);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(96, 25);
            label12.TabIndex = 24;
            label12.Text = "Trạng Thái:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 100);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 25);
            label10.TabIndex = 20;
            label10.Text = "Mã Sách:";
            // 
            // viewSach
            // 
            viewSach.BackgroundColor = SystemColors.ButtonHighlight;
            viewSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewSach.Location = new Point(8, 61);
            viewSach.Margin = new Padding(4, 4, 4, 4);
            viewSach.Name = "viewSach";
            viewSach.RowHeadersWidth = 51;
            viewSach.RowTemplate.Height = 29;
            viewSach.Size = new Size(1421, 338);
            viewSach.TabIndex = 16;
            viewSach.CellClick += view_CellClick;
            viewSach.CellContentClick += view_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(viewSach);
            groupBox3.Controls.Add(TimKiemTen_Texbox);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(99, 665);
            groupBox3.Margin = new Padding(4, 4, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 4, 4, 4);
            groupBox3.Size = new Size(1436, 422);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ Liệu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(644, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 41);
            label1.TabIndex = 14;
            label1.Text = "Quản Lý Sách";
            // 
            // TenSach_Texbox
            // 
            TenSach_Texbox.BorderStyle = BorderStyle.FixedSingle;
            TenSach_Texbox.Location = new Point(188, 139);
            TenSach_Texbox.Margin = new Padding(4, 4, 4, 4);
            TenSach_Texbox.Name = "TenSach_Texbox";
            TenSach_Texbox.Size = new Size(254, 31);
            TenSach_Texbox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 141);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
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
            groupBox1.Location = new Point(99, 65);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(468, 444);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Thông Tin";
            // 
            // txtMaVach
            // 
            txtMaVach.BorderStyle = BorderStyle.FixedSingle;
            txtMaVach.Location = new Point(186, 389);
            txtMaVach.Margin = new Padding(4, 4, 4, 4);
            txtMaVach.Name = "txtMaVach";
            txtMaVach.Size = new Size(254, 31);
            txtMaVach.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 391);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(82, 25);
            label11.TabIndex = 42;
            label11.Text = "Mã vạch:";
            // 
            // NgayXuatBan_Date
            // 
            NgayXuatBan_Date.CustomFormat = "dd/MM/yyyy";
            NgayXuatBan_Date.Location = new Point(185, 304);
            NgayXuatBan_Date.Margin = new Padding(4, 4, 4, 4);
            NgayXuatBan_Date.Name = "NgayXuatBan_Date";
            NgayXuatBan_Date.Size = new Size(255, 31);
            NgayXuatBan_Date.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 310);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 25);
            label6.TabIndex = 40;
            label6.Text = "Ngày Xuất Bản:";
            // 
            // Sach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1641, 1050);
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