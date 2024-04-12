
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
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            txtTrangthai = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMaSach = new TextBox();
            txtId = new TextBox();
            txtSL = new TextBox();
            txtTien = new TextBox();
            label2 = new Label();
            label1 = new Label();
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
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1528, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // phiếuMượnToolStripMenuItem
            // 
            phiếuMượnToolStripMenuItem.Name = "phiếuMượnToolStripMenuItem";
            phiếuMượnToolStripMenuItem.Size = new Size(124, 29);
            phiếuMượnToolStripMenuItem.Text = "Phiếu mượn";
            // 
            // phiếuTrảToolStripMenuItem
            // 
            phiếuTrảToolStripMenuItem.Name = "phiếuTrảToolStripMenuItem";
            phiếuTrảToolStripMenuItem.Size = new Size(97, 29);
            phiếuTrảToolStripMenuItem.Text = "Phiếu trả";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTK);
            groupBox1.Location = new Point(58, 59);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(725, 96);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // btnTK
            // 
            btnTK.Location = new Point(50, 40);
            btnTK.Margin = new Padding(4, 4, 4, 4);
            btnTK.Name = "btnTK";
            btnTK.PlaceholderText = "Nhập thông tin tìm kiếm";
            btnTK.Size = new Size(624, 31);
            btnTK.TabIndex = 0;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1019, 78);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(119, 68);
            button1.TabIndex = 4;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(ViewSach);
            groupBox2.Location = new Point(58, 162);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(725, 312);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sách";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 48);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập thông tin sách";
            textBox1.Size = new Size(446, 31);
            textBox1.TabIndex = 1;
            // 
            // ViewSach
            // 
            ViewSach.BackgroundColor = SystemColors.ButtonHighlight;
            ViewSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewSach.Location = new Point(8, 100);
            ViewSach.Margin = new Padding(4, 4, 4, 4);
            ViewSach.Name = "ViewSach";
            ViewSach.RowHeadersWidth = 51;
            ViewSach.RowTemplate.Height = 29;
            ViewSach.Size = new Size(710, 205);
            ViewSach.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtTrangthai);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtMaSach);
            groupBox3.Controls.Add(txtId);
            groupBox3.Controls.Add(txtSL);
            groupBox3.Controls.Add(txtTien);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(805, 168);
            groupBox3.Margin = new Padding(4, 4, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 4, 4, 4);
            groupBox3.Size = new Size(651, 420);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thực hiện cho mượn";
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.Lime;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(311, 338);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(158, 62);
            button3.TabIndex = 24;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.Lime;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(146, 338);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(158, 62);
            button4.TabIndex = 23;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 255);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 22;
            label3.Text = "Trạng thái";
            // 
            // txtTrangthai
            // 
            txtTrangthai.Location = new Point(138, 251);
            txtTrangthai.Margin = new Padding(4, 4, 4, 4);
            txtTrangthai.Name = "txtTrangthai";
            txtTrangthai.Size = new Size(155, 31);
            txtTrangthai.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(428, 249);
            dateTimePicker2.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(155, 31);
            dateTimePicker2.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(428, 184);
            dateTimePicker1.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(155, 31);
            dateTimePicker1.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(138, 121);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 33);
            comboBox1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 125);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 17;
            label4.Text = "Nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 125);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 15;
            label5.Text = "Tiền cọc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 60);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 14;
            label6.Text = "SL mượn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 190);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 13;
            label7.Text = "Mã sách";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 60);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 25);
            label8.TabIndex = 12;
            label8.Text = "Mã phiếu";
            // 
            // txtMaSach
            // 
            txtMaSach.Enabled = false;
            txtMaSach.Location = new Point(138, 186);
            txtMaSach.Margin = new Padding(4, 4, 4, 4);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(155, 31);
            txtMaSach.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(138, 56);
            txtId.Margin = new Padding(4, 4, 4, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(155, 31);
            txtId.TabIndex = 10;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(428, 56);
            txtSL.Margin = new Padding(4, 4, 4, 4);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(155, 31);
            txtSL.TabIndex = 9;
            txtSL.Text = "0";
            // 
            // txtTien
            // 
            txtTien.Enabled = false;
            txtTien.Location = new Point(428, 121);
            txtTien.Margin = new Padding(4, 4, 4, 4);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(155, 31);
            txtTien.TabIndex = 8;
            txtTien.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 255);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 5;
            label2.Text = "Ngày trả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 190);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 4;
            label1.Text = "Ngày mượn";
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.Lime;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(179, 505);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 62);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "New";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.BackColor = Color.Lime;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(344, 505);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(158, 62);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.BackColor = Color.Lime;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(841, 78);
            btnClear.Margin = new Padding(4, 4, 4, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 68);
            btnClear.TabIndex = 11;
            btnClear.Text = "Hủy";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(ViewCT);
            groupBox5.Location = new Point(764, 595);
            groupBox5.Margin = new Padding(4, 4, 4, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 4, 4, 4);
            groupBox5.Size = new Size(692, 414);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chi tiết hóa đơn:";
            // 
            // ViewCT
            // 
            ViewCT.BackgroundColor = SystemColors.ButtonHighlight;
            ViewCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewCT.Location = new Point(11, 32);
            ViewCT.Margin = new Padding(4, 4, 4, 4);
            ViewCT.Name = "ViewCT";
            ViewCT.RowHeadersWidth = 51;
            ViewCT.RowTemplate.Height = 29;
            ViewCT.Size = new Size(674, 374);
            ViewCT.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(ViewHD);
            groupBox6.Location = new Point(46, 595);
            groupBox6.Margin = new Padding(4, 4, 4, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 4, 4, 4);
            groupBox6.Size = new Size(710, 414);
            groupBox6.TabIndex = 23;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh sách cho mượn:";
            // 
            // ViewHD
            // 
            ViewHD.BackgroundColor = SystemColors.ButtonHighlight;
            ViewHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewHD.Location = new Point(8, 32);
            ViewHD.Margin = new Padding(4, 4, 4, 4);
            ViewHD.Name = "ViewHD";
            ViewHD.RowHeadersWidth = 51;
            ViewHD.RowTemplate.Height = 29;
            ViewHD.Size = new Size(695, 374);
            ViewHD.TabIndex = 0;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(510, 505);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(158, 62);
            button2.TabIndex = 25;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = false;
            // 
            // Phieumuon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1528, 1050);
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
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMaSach;
        private TextBox txtId;
        private TextBox txtSL;
        private TextBox txtTien;
        private Label label2;
        private Label label1;
        private DataGridView ViewSach;
        private TextBox textBox1;
        private GroupBox groupBox5;
        private DataGridView ViewCT;
        private GroupBox groupBox6;
        private DataGridView ViewHD;
        private ComboBox comboBox1;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox txtTrangthai;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}