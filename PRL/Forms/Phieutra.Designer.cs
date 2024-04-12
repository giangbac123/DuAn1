namespace PRL.Forms
{
    partial class Phieutra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phieutra));
            HDtraView = new DataGridView();
            HDtraCTview = new DataGridView();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            btnClear = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            phiếuMượnToolStripMenuItem = new ToolStripMenuItem();
            phiếuTrảToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnTK = new TextBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            SachView = new DataGridView();
            groupBox3 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label9 = new Label();
            txtmamuon = new TextBox();
            comboboxnv = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtid = new TextBox();
            txtsl = new TextBox();
            txttien = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txttrangthai = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)HDtraView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HDtraCTview).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SachView).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // HDtraView
            // 
            HDtraView.BackgroundColor = SystemColors.ButtonHighlight;
            HDtraView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HDtraView.Location = new Point(8, 32);
            HDtraView.Margin = new Padding(4, 4, 4, 4);
            HDtraView.Name = "HDtraView";
            HDtraView.RowHeadersWidth = 51;
            HDtraView.RowTemplate.Height = 29;
            HDtraView.Size = new Size(721, 374);
            HDtraView.TabIndex = 0;
            // 
            // HDtraCTview
            // 
            HDtraCTview.BackgroundColor = SystemColors.ButtonHighlight;
            HDtraCTview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HDtraCTview.Location = new Point(11, 32);
            HDtraCTview.Margin = new Padding(4, 4, 4, 4);
            HDtraCTview.Name = "HDtraCTview";
            HDtraCTview.RowHeadersWidth = 51;
            HDtraCTview.RowTemplate.Height = 29;
            HDtraCTview.Size = new Size(650, 374);
            HDtraCTview.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(HDtraCTview);
            groupBox5.Location = new Point(791, 688);
            groupBox5.Margin = new Padding(4, 4, 4, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 4, 4, 4);
            groupBox5.Size = new Size(669, 414);
            groupBox5.TabIndex = 35;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chi tiết hóa đơn:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(HDtraView);
            groupBox6.Location = new Point(46, 688);
            groupBox6.Margin = new Padding(4, 4, 4, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 4, 4, 4);
            groupBox6.Size = new Size(736, 414);
            groupBox6.TabIndex = 34;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh sách hóa đơn:";
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.BackColor = Color.Lime;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(814, 109);
            btnClear.Margin = new Padding(4, 4, 4, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(158, 62);
            btnClear.TabIndex = 33;
            btnClear.Text = "Hủy";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.BackColor = Color.Lime;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(398, 592);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(158, 62);
            btnEdit.TabIndex = 31;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.Lime;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(231, 592);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 62);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "New";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1011, 109);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(158, 62);
            button1.TabIndex = 27;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { phiếuMượnToolStripMenuItem, phiếuTrảToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1524, 33);
            menuStrip1.TabIndex = 25;
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
            groupBox1.Location = new Point(58, 88);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(725, 96);
            groupBox1.TabIndex = 26;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(SachView);
            groupBox2.Location = new Point(58, 191);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(755, 375);
            groupBox2.TabIndex = 28;
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
            // SachView
            // 
            SachView.BackgroundColor = SystemColors.ButtonHighlight;
            SachView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SachView.Location = new Point(8, 100);
            SachView.Margin = new Padding(4, 4, 4, 4);
            SachView.Name = "SachView";
            SachView.RowHeadersWidth = 51;
            SachView.RowTemplate.Height = 29;
            SachView.Size = new Size(740, 268);
            SachView.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtmamuon);
            groupBox3.Controls.Add(comboboxnv);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtid);
            groupBox3.Controls.Add(txtsl);
            groupBox3.Controls.Add(txttien);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txttrangthai);
            groupBox3.Location = new Point(845, 191);
            groupBox3.Margin = new Padding(4, 4, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 4, 4, 4);
            groupBox3.Size = new Size(615, 489);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thực hiện cho mượn";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(319, 401);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(158, 62);
            button2.TabIndex = 33;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.Lime;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(134, 401);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(158, 62);
            button3.TabIndex = 32;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(138, 250);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 31);
            textBox2.TabIndex = 26;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(425, 184);
            dateTimePicker2.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(155, 31);
            dateTimePicker2.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Location = new Point(425, 119);
            dateTimePicker1.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(155, 31);
            dateTimePicker1.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 250);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 22;
            label7.Text = "Mã sách";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 190);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(90, 25);
            label9.TabIndex = 21;
            label9.Text = "Mã mượn";
            // 
            // txtmamuon
            // 
            txtmamuon.Location = new Point(138, 186);
            txtmamuon.Margin = new Padding(4, 4, 4, 4);
            txtmamuon.Name = "txtmamuon";
            txtmamuon.Size = new Size(155, 31);
            txtmamuon.TabIndex = 20;
            // 
            // comboboxnv
            // 
            comboboxnv.FormattingEnabled = true;
            comboboxnv.Location = new Point(138, 121);
            comboboxnv.Margin = new Padding(4, 4, 4, 4);
            comboboxnv.Name = "comboboxnv";
            comboboxnv.Size = new Size(155, 33);
            comboboxnv.TabIndex = 18;
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
            label5.Location = new Point(319, 60);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 15;
            label5.Text = "Tiền cọc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 309);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 14;
            label6.Text = "SL trả";
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
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(138, 56);
            txtid.Margin = new Padding(4, 4, 4, 4);
            txtid.Name = "txtid";
            txtid.Size = new Size(155, 31);
            txtid.TabIndex = 10;
            // 
            // txtsl
            // 
            txtsl.Location = new Point(138, 305);
            txtsl.Margin = new Padding(4, 4, 4, 4);
            txtsl.Name = "txtsl";
            txtsl.Size = new Size(155, 31);
            txtsl.TabIndex = 9;
            txtsl.Text = "0";
            // 
            // txttien
            // 
            txttien.Enabled = false;
            txttien.Location = new Point(425, 56);
            txttien.Margin = new Padding(4, 4, 4, 4);
            txttien.Name = "txttien";
            txttien.Size = new Size(155, 31);
            txttien.TabIndex = 8;
            txttien.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 250);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 6;
            label3.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 190);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 5;
            label2.Text = "Ngày trả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 125);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 4;
            label1.Text = "Ngày mượn";
            // 
            // txttrangthai
            // 
            txttrangthai.Location = new Point(425, 246);
            txttrangthai.Margin = new Padding(4, 4, 4, 4);
            txttrangthai.Name = "txttrangthai";
            txttrangthai.Size = new Size(155, 31);
            txttrangthai.TabIndex = 1;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.Lime;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(562, 592);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(158, 62);
            button4.TabIndex = 36;
            button4.Text = "Pay";
            button4.UseVisualStyleBackColor = false;
            // 
            // Phieutra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1524, 1050);
            Controls.Add(button4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Controls.Add(btnClear);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Phieutra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn trả";
            ((System.ComponentModel.ISupportInitialize)HDtraView).EndInit();
            ((System.ComponentModel.ISupportInitialize)HDtraCTview).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SachView).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView HDtraView;
        private DataGridView HDtraCTview;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Button btnClear;
        private Button btnEdit;
        private Button btnAdd;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem phiếuMượnToolStripMenuItem;
        private ToolStripMenuItem phiếuTrảToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox btnTK;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private DataGridView SachView;
        private GroupBox groupBox3;
        private ComboBox comboboxnv;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox txtid;
        private TextBox txtsl;
        private TextBox txttien;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox txttrangthai;
        private Label label9;
        private TextBox txtmamuon;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}