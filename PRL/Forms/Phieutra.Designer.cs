﻿namespace PRL.Forms
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
            txttenkh = new TextBox();
            button2 = new Button();
            button3 = new Button();
            txtsach = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label9 = new Label();
            txtcccd = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtid = new TextBox();
            txtsl = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txttrangthai = new TextBox();
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
            HDtraView.AllowUserToAddRows = false;
            HDtraView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HDtraView.Location = new Point(6, 26);
            HDtraView.Name = "HDtraView";
            HDtraView.RowHeadersWidth = 51;
            HDtraView.RowTemplate.Height = 29;
            HDtraView.Size = new Size(577, 299);
            HDtraView.TabIndex = 0;
            HDtraView.CellClick += HDtraView_CellClick;
            HDtraView.CellContentClick += HDtraView_CellContentClick;
            HDtraView.EnabledChanged += txtsl_TextChanged;
            // 
            // HDtraCTview
            // 
            HDtraCTview.AllowUserToAddRows = false;
            HDtraCTview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HDtraCTview.Location = new Point(9, 26);
            HDtraCTview.Name = "HDtraCTview";
            HDtraCTview.RowHeadersWidth = 51;
            HDtraCTview.RowTemplate.Height = 29;
            HDtraCTview.Size = new Size(520, 299);
            HDtraCTview.TabIndex = 1;
            HDtraCTview.CellClick += HDtraCTview_CellClick;
            HDtraCTview.CellContentClick += HDtraCTview_CellContentClick;
            HDtraCTview.EnabledChanged += txtsl_TextChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(HDtraCTview);
            groupBox5.Location = new Point(633, 550);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(535, 331);
            groupBox5.TabIndex = 35;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chi tiết hóa đơn:";
            groupBox5.EnabledChanged += txtsl_TextChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(HDtraView);
            groupBox6.Location = new Point(37, 550);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(589, 331);
            groupBox6.TabIndex = 34;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh sách hóa đơn:";
            groupBox6.EnabledChanged += txtsl_TextChanged;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(651, 87);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 50);
            btnClear.TabIndex = 33;
            btnClear.Text = "Hủy";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.EnabledChanged += txtsl_TextChanged;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(318, 474);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 50);
            btnEdit.TabIndex = 31;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.EnabledChanged += txtsl_TextChanged;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(185, 474);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 50);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.EnabledChanged += txtsl_TextChanged;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(809, 87);
            button1.Name = "button1";
            button1.Size = new Size(126, 50);
            button1.TabIndex = 27;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.EnabledChanged += txtsl_TextChanged;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { phiếuMượnToolStripMenuItem, phiếuTrảToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1219, 28);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.EnabledChanged += txtsl_TextChanged;
            // 
            // phiếuMượnToolStripMenuItem
            // 
            phiếuMượnToolStripMenuItem.Name = "phiếuMượnToolStripMenuItem";
            phiếuMượnToolStripMenuItem.Size = new Size(102, 24);
            phiếuMượnToolStripMenuItem.Text = "Phiếu mượn";
            phiếuMượnToolStripMenuItem.Click += phiếuMượnToolStripMenuItem_Click;
            phiếuMượnToolStripMenuItem.EnabledChanged += txtsl_TextChanged;
            // 
            // phiếuTrảToolStripMenuItem
            // 
            phiếuTrảToolStripMenuItem.Name = "phiếuTrảToolStripMenuItem";
            phiếuTrảToolStripMenuItem.Size = new Size(81, 24);
            phiếuTrảToolStripMenuItem.Text = "Phiếu trả";
            phiếuTrảToolStripMenuItem.Click += phiếuTrảToolStripMenuItem_Click;
            phiếuTrảToolStripMenuItem.EnabledChanged += txtsl_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTK);
            groupBox1.Location = new Point(46, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(580, 77);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            groupBox1.EnabledChanged += txtsl_TextChanged;
            // 
            // btnTK
            // 
            btnTK.Location = new Point(40, 32);
            btnTK.Name = "btnTK";
            btnTK.PlaceholderText = "Nhập thông tin tìm kiếm";
            btnTK.Size = new Size(500, 27);
            btnTK.TabIndex = 0;
            btnTK.EnabledChanged += txtsl_TextChanged;
            btnTK.TextChanged += btnTK_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(SachView);
            groupBox2.Location = new Point(46, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(604, 300);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sách";
            groupBox2.EnabledChanged += txtsl_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 38);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập thông tin sách";
            textBox1.Size = new Size(358, 27);
            textBox1.TabIndex = 1;
            textBox1.EnabledChanged += txtsl_TextChanged;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // SachView
            // 
            SachView.AllowUserToAddRows = false;
            SachView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SachView.Location = new Point(6, 80);
            SachView.Name = "SachView";
            SachView.RowHeadersWidth = 51;
            SachView.RowTemplate.Height = 29;
            SachView.Size = new Size(592, 214);
            SachView.TabIndex = 0;
            SachView.CellClick += SachView_CellClick;
            SachView.EnabledChanged += txtsl_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txttenkh);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(txtsach);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtcccd);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtid);
            groupBox3.Controls.Add(txtsl);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txttrangthai);
            groupBox3.Location = new Point(676, 153);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(492, 391);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thực hiện cho mượn";
            groupBox3.EnabledChanged += txtsl_TextChanged;
            // 
            // txttenkh
            // 
            txttenkh.Location = new Point(111, 87);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(125, 27);
            txttenkh.TabIndex = 34;
            txttenkh.EnabledChanged += txtsl_TextChanged;
            txttenkh.KeyPress += txttenkh_KeyPress;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(64, 321);
            button2.Name = "button2";
            button2.Size = new Size(126, 50);
            button2.TabIndex = 33;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.EnabledChanged += txtsl_TextChanged;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(64, 218);
            button3.Name = "button3";
            button3.Size = new Size(126, 50);
            button3.TabIndex = 32;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.EnabledChanged += txtsl_TextChanged;
            button3.Click += button3_Click;
            // 
            // txtsach
            // 
            txtsach.Location = new Point(341, 38);
            txtsach.Name = "txtsach";
            txtsach.Size = new Size(125, 27);
            txtsach.TabIndex = 26;
            txtsach.EnabledChanged += txtsl_TextChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(341, 198);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(125, 27);
            dateTimePicker2.TabIndex = 25;
            dateTimePicker2.EnabledChanged += txtsl_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Location = new Point(341, 137);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.EnabledChanged += txtsl_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(257, 41);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 22;
            label7.Text = "Mã sách";
            label7.EnabledChanged += txtsl_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 142);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 21;
            label9.Text = "Số CCCD";
            label9.EnabledChanged += txtsl_TextChanged;
            // 
            // txtcccd
            // 
            txtcccd.Location = new Point(111, 135);
            txtcccd.Name = "txtcccd";
            txtcccd.Size = new Size(125, 27);
            txtcccd.TabIndex = 20;
            txtcccd.EnabledChanged += txtsl_TextChanged;
            txtcccd.KeyPress += txtcccd_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 90);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 17;
            label4.Text = "Họ tên KH";
            label4.EnabledChanged += txtsl_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(257, 85);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 14;
            label6.Text = "SL trả";
            label6.EnabledChanged += txtsl_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 41);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 12;
            label8.Text = "Mã phiếu";
            label8.EnabledChanged += txtsl_TextChanged;
            // 
            // txtid
            // 
            txtid.Location = new Point(110, 35);
            txtid.Name = "txtid";
            txtid.Size = new Size(125, 27);
            txtid.TabIndex = 10;
            txtid.EnabledChanged += txtsl_TextChanged;
            // 
            // txtsl
            // 
            txtsl.Location = new Point(341, 82);
            txtsl.Name = "txtsl";
            txtsl.Size = new Size(125, 27);
            txtsl.TabIndex = 9;
            txtsl.EnabledChanged += txtsl_TextChanged;
            txtsl.TextChanged += txtsl_TextChanged;
            txtsl.KeyPress += txtsl_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 258);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "Trạng thái";
            label3.EnabledChanged += txtsl_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 203);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 5;
            label2.Text = "Ngày trả";
            label2.EnabledChanged += txtsl_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 142);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 4;
            label1.Text = "Ngày mượn";
            label1.EnabledChanged += txtsl_TextChanged;
            // 
            // txttrangthai
            // 
            txttrangthai.Location = new Point(341, 255);
            txttrangthai.Name = "txttrangthai";
            txttrangthai.Size = new Size(125, 27);
            txttrangthai.TabIndex = 1;
            txttrangthai.EnabledChanged += txtsl_TextChanged;
            // 
            // Phieutra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 903);
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
            Load += Phieutra_Load;
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
        private Label label6;
        private Label label8;
        private TextBox txtid;
        private TextBox txtsl;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox txttrangthai;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtsach;
        private Button button2;
        private Button button3;
        private TextBox txttenkh;
        private Label label9;
        private TextBox txtcccd;
        private Label label4;
    }
}