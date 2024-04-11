
namespace PRL.Forms
{
    partial class Phieumuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phieumuon));
            menuStrip1 = new MenuStrip();
            phiếuMượnToolStripMenuItem = new ToolStripMenuItem();
            phiếuTrảToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnTK = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            ViewSach = new DataGridView();
            groupBox3 = new GroupBox();
            txttien = new TextBox();
            label5 = new Label();
            txttenkh = new TextBox();
            txtid = new TextBox();
            button3 = new Button();
            txttrangthai = new TextBox();
            button4 = new Button();
            label1 = new Label();
            txtsach = new TextBox();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtsl = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            txtcccd = new TextBox();
            label4 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnClear = new Button();
            groupBox5 = new GroupBox();
            ViewCT = new DataGridView();
            groupBox6 = new GroupBox();
            ViewHD = new DataGridView();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewSach).BeginInit();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewCT).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewHD).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { phiếuMượnToolStripMenuItem, phiếuTrảToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1222, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // phiếuMượnToolStripMenuItem
            // 
            phiếuMượnToolStripMenuItem.Name = "phiếuMượnToolStripMenuItem";
            phiếuMượnToolStripMenuItem.Size = new Size(102, 24);
            phiếuMượnToolStripMenuItem.Text = "Phiếu mượn";
            // 
            // phiếuTrảToolStripMenuItem
            // 
            phiếuTrảToolStripMenuItem.Name = "phiếuTrảToolStripMenuItem";
            phiếuTrảToolStripMenuItem.Size = new Size(81, 24);
            phiếuTrảToolStripMenuItem.Text = "Phiếu trả";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTK);
            groupBox1.Location = new Point(46, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 77);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // btnTK
            // 
            btnTK.Location = new Point(40, 32);
            btnTK.Name = "btnTK";
            btnTK.PlaceholderText = "Nhập thông tin tìm kiếm";
            btnTK.Size = new Size(500, 27);
            btnTK.TabIndex = 0;
            btnTK.TextChanged += btnTK_TextChanged;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(815, 62);
            button1.Name = "button1";
            button1.Size = new Size(95, 54);
            button1.TabIndex = 4;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(ViewSach);
            groupBox2.Location = new Point(46, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(580, 250);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sách";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 38);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập thông tin sách";
            textBox1.Size = new Size(358, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ViewSach
            // 
            ViewSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewSach.Location = new Point(6, 80);
            ViewSach.Name = "ViewSach";
            ViewSach.RowHeadersWidth = 51;
            ViewSach.RowTemplate.Height = 29;
            ViewSach.Size = new Size(568, 164);
            ViewSach.TabIndex = 0;
            ViewSach.CellClick += ViewSach_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txttien);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txttenkh);
            groupBox3.Controls.Add(txtid);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(txttrangthai);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtsach);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(txtsl);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtcccd);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(644, 134);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(521, 336);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thực hiện cho mượn";
            // 
            // txttien
            // 
            txttien.Enabled = false;
            txttien.Location = new Point(338, 134);
            txttien.Name = "txttien";
            txttien.Size = new Size(125, 27);
            txttien.TabIndex = 53;
            txttien.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 137);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 54;
            label5.Text = "Tiền phí";
            // 
            // txttenkh
            // 
            txttenkh.Location = new Point(108, 86);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(125, 27);
            txttenkh.TabIndex = 52;
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(107, 34);
            txtid.Name = "txtid";
            txtid.Size = new Size(125, 27);
            txtid.TabIndex = 40;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(61, 270);
            button3.Name = "button3";
            button3.Size = new Size(126, 50);
            button3.TabIndex = 51;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txttrangthai
            // 
            txttrangthai.Location = new Point(338, 283);
            txttrangthai.Name = "txttrangthai";
            txttrangthai.Size = new Size(125, 27);
            txttrangthai.TabIndex = 35;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(61, 184);
            button4.Name = "button4";
            button4.Size = new Size(126, 50);
            button4.TabIndex = 50;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 189);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 36;
            label1.Text = "Ngày mượn";
            // 
            // txtsach
            // 
            txtsach.Enabled = false;
            txtsach.Location = new Point(338, 37);
            txtsach.Name = "txtsach";
            txtsach.Size = new Size(125, 27);
            txtsach.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 238);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 37;
            label2.Text = "Ngày trả";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(338, 233);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(125, 27);
            dateTimePicker2.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 286);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 38;
            label3.Text = "Trạng thái";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Location = new Point(338, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 47;
            // 
            // txtsl
            // 
            txtsl.Location = new Point(338, 81);
            txtsl.Name = "txtsl";
            txtsl.Size = new Size(125, 27);
            txtsl.TabIndex = 39;
            txtsl.Text = "0";
            txtsl.TextChanged += txtsl_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 40);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 46;
            label7.Text = "Mã sách";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 40);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 41;
            label8.Text = "Mã phiếu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 141);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 45;
            label9.Text = "Số CCCD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 89);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 42;
            label6.Text = "SL trả";
            // 
            // txtcccd
            // 
            txtcccd.Location = new Point(108, 134);
            txtcccd.Name = "txtcccd";
            txtcccd.Size = new Size(125, 27);
            txtcccd.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 89);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 43;
            label4.Text = "Họ tên KH";
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(143, 404);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 50);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(275, 404);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 50);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(673, 62);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 54);
            btnClear.TabIndex = 11;
            btnClear.Text = "Hủy";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(ViewCT);
            groupBox5.Location = new Point(611, 476);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(554, 331);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chi tiết hóa đơn:";
            // 
            // ViewCT
            // 
            ViewCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewCT.Location = new Point(9, 26);
            ViewCT.Name = "ViewCT";
            ViewCT.RowHeadersWidth = 51;
            ViewCT.RowTemplate.Height = 29;
            ViewCT.Size = new Size(539, 299);
            ViewCT.TabIndex = 1;
            ViewCT.CellClick += ViewCT_CellClick;
            ViewCT.CellContentClick += ViewCT_CellContentClick;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(ViewHD);
            groupBox6.Location = new Point(37, 476);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(568, 331);
            groupBox6.TabIndex = 23;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh sách cho mượn:";
            // 
            // ViewHD
            // 
            ViewHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewHD.Location = new Point(6, 26);
            ViewHD.Name = "ViewHD";
            ViewHD.RowHeadersWidth = 51;
            ViewHD.RowTemplate.Height = 29;
            ViewHD.Size = new Size(556, 299);
            ViewHD.TabIndex = 0;
            ViewHD.CellClick += ViewHD_CellClick;
            ViewHD.CellContentClick += ViewHD_CellContentClick;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(408, 404);
            button2.Name = "button2";
            button2.Size = new Size(126, 50);
            button2.TabIndex = 25;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = true;
            // 
            // Phieumuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 853);
            Controls.Add(button2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Controls.Add(btnClear);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Phieumuon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn mượn";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewSach).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ViewCT).EndInit();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ViewHD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnxoa;
        private Button TimKiemTen_Btn;
        private Button btnxoact;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem phiếuMượnToolStripMenuItem;
        private ToolStripMenuItem phiếuTrảToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox btnTK;
        private Button button1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnClear;
        private DataGridView ViewSach;
        private TextBox textBox1;
        private GroupBox groupBox5;
        private DataGridView ViewCT;
        private GroupBox groupBox6;
        private DataGridView ViewHD;
        private Button button2;
        private TextBox txttenkh;
        private TextBox txtid;
        private Button button3;
        private TextBox txttrangthai;
        private Button button4;
        private Label label1;
        private TextBox txtsach;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox txtsl;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label6;
        private TextBox txtcccd;
        private Label label4;
        private TextBox txttien;
        private Label label5;
    }
}